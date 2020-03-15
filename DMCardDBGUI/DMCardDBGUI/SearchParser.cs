using System;
using System.Collections.Generic;
using System.Linq;

namespace DMCardDBGUI
{
    public interface IClause
    {
        bool EvaluateOn(string cardText);
    }

    public class Clause : IClause
    {
        public IClause Left { get; }
        public IClause Right { get; }
        public Operator Operator { get; }

        public Clause(IClause left, Operator op, IClause right)
        {
            Left = left;
            Operator = op;
            Right = right;
        }

        public bool EvaluateOn(string cardText)
        {
            switch (Operator)
            {
                case Operator.AND:
                    return Left.EvaluateOn(cardText) && Right.EvaluateOn(cardText);
                case Operator.OR:
                    return Left.EvaluateOn(cardText) || Right.EvaluateOn(cardText);
                case Operator.NOT:
                    return !Right.EvaluateOn(cardText);
            }
            throw new NotImplementedException("Operator type not implemented.");
        }
    }

    public class Primitive : IClause
    {
        public string Value { get; }

        public Primitive(string value)
        {
            Value = value;
        }

        public bool EvaluateOn(string cardText)
        {
            return cardText != null ? cardText.Contains(Value) : false;
        }
    }

    public static class SearchParser
    {
        private static IClause BuildClause(IEnumerable<string> splits)
        {
            var len = splits.Count();

            if (len == 1)
            {
                return new Primitive(splits.First());
            }
            else if (len > 1)
            {
                var prim = new Primitive(splits.First());
                var next = splits.ElementAt(1);
                Clause clause;
                IClause right;
                switch (next)
                {
                    case "or":
                    case "|":
                    case "||":
                        right = BuildClause(splits.Skip(2));
                        return clause = new Clause(prim, Operator.OR, right);
                    case "not":
                    case "!":
                        right = BuildClause(splits.Skip(2));
                        return clause = new Clause(prim, Operator.NOT, right);
                    case "and":
                    case "&":
                    case "&&":
                    case "AND":
                        right = BuildClause(splits.Skip(2));
                        return clause = new Clause(prim, Operator.AND, right);
                    default:
                        if(next.First() == '!')
                        {
                            right = BuildClause(splits.Skip(1));
                            var notted = new Clause(null, Operator.NOT, next.Remove(1));
                            return clause = new Clause(prim, Operator.NOT, null);
                        }
                        right = BuildClause(splits.Skip(1));
                        return clause = new Clause(prim, Operator.AND, right);
                }
            }
            throw new NotSupportedException("Löl something bad went down :D");
        }

        public static IClause Parse(string searchString)
        {
            if (searchString.Trim().Length < 2) return null;

            var splits = searchString.ToLower().Split(' ').ToList();

            return BuildClause(splits);
        }
    }
}
