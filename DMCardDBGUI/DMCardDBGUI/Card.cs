using System;

namespace DMCardDBGUI
{
    public class Card
    {
        public string Name;
        public CardColor Color;
        public int Cost;
        public string Text;
        public string Flavor;
        public Type Type;
        public string Race;
        public int Power;

        public void SetColor(string colorText)
        {
            var split = colorText.Split('/');
            if (split.Length == 2)
            {
                var parsed1 = (EColor)Enum.Parse(typeof(EColor), split[0]);
                var parsed2 = (EColor)Enum.Parse(typeof(EColor), split[1]);
                Color = new CardColor(parsed1, parsed2);
            }
            else
            {
                var parsed = (EColor)Enum.Parse(typeof(EColor), colorText);
                Color = new CardColor(parsed);
            };
        }

        public void SetType(string type)
        {
            if (type == "Evolution Creature")
            {
                Type = Type.Evolution;
            }
            else
            {
                Type = (Type)Enum.Parse(typeof(Type), type);
            }
        }

        public void SetText(string text)
        {
            var final = "";
            var splits = text.Split('\n');
            foreach (var split in splits)
            {
                final = final + "        " + split + "\n";
            }
            Text = final;
        }

        public override string ToString()
        {
            return "Name: " + Name
                    + (Type == Type.Creature || Type == Type.Evolution ? 
                        "\n    Race: " + Race
                        : "")
                    + "\n    Color: " + Color
                    + "\n    Type: " + Type
                    + "\n    Cost: " + Cost
                    + (Type == Type.Creature || Type == Type.Evolution
                        ? "\n    Power: " + Power
                        : "" )
                    + "\n    Rules Text: " 
                    + "\n" + Text
                    //+ "\n    Flavor Text: " + Flavor
                    + "\n\n";
        }
    }

    public class CardColor
    {
        public EColor PrimaryColor { get; }
        public EColor SecondaryColor { get; }

        public CardColor(EColor eColor)
        {
            PrimaryColor = eColor;
        }

        public CardColor(EColor color1, EColor color2)
        {
            PrimaryColor = color1;
            SecondaryColor = color2;
        }

        public override string ToString()
        {
            return PrimaryColor + (SecondaryColor == EColor.Null ? "" : SecondaryColor.ToString());
        }
    }
}
