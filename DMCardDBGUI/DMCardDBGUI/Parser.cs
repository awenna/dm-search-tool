using System;
using System.Collections.Generic;
using System.Xml;
using MoreLinq;

namespace DMCardDBGUI
{
    public class Parser
    {
        private const String defaultFilename = "DM Card DB.xml";

        public IEnumerable<Card> Parse()
        {
            Console.WriteLine("Reading begins..");

            List<Card> cards = new List<Card>();
            XmlNodeReader reader = null;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(defaultFilename);
                reader = new XmlNodeReader(doc);

                var card = new Card();
                var rules = true;
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "rules_text") rules = true;
                            if (reader.Name == "flavor_text") rules = false;
                            if (reader.HasAttributes)
                            {
                                card.Name = reader.GetAttribute("name");
                                card.SetColor(reader.GetAttribute("civilization"));
                                var type = reader.GetAttribute("type");
                                card.SetType(type);
                                card.Cost = Int32.Parse(reader.GetAttribute("cost"));
                                if (type == "Creature" || type == "Evolution Creature")
                                {
                                    card.Power = Int32.Parse(reader.GetAttribute("power"));
                                }
                                card.Race = reader.GetAttribute("race");
                            }
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.LocalName == "card")
                            {
                                cards.Add(card);
                                card = new Card();
                            }
                            break;
                        case XmlNodeType.Text:
                            if (rules)
                            {
                                card.SetText(reader.Value);
                            }
                            else
                                card.Flavor = reader.Value;
                            break;
                        case XmlNodeType.CDATA:
                            break;
                        case XmlNodeType.Attribute:
                            break;
                    }
                    
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            var distinct = cards.DistinctBy(c => c.Name);

            return distinct;
        }
    }
}
