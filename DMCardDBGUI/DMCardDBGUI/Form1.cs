using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DMCardDBGUI
{
    public partial class Form1 : Form
    {
        private Parser Parser;
        private IEnumerable<Card> Cards;
        private IEnumerable<Card> AllCards;

        private IClause filterClause = null;

        public Form1()
        {
            InitializeComponent();
            Parser = new Parser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllCards = Parser.Parse();
            Cards = AllCards;

            UpdateCardDisplay();
        }

        private void UpdateSearch(object sender, EventArgs e)
        {
            Cards = AllCards;
            if (ColorChecked())
            {
                var colors = SelectedColors();
                Cards = Cards.Where(x =>
                    colors.Contains(x.Color.PrimaryColor) || colors.Contains(x.Color.SecondaryColor));
            }
            var types = SelectedTypes();
                Cards = Cards.Where(x => types.Contains(x.Type));
            
            Cards = Cards.Where(x => x.Cost >= MinCost.Value);
            Cards = Cards.Where(x => x.Cost <= MaxCost.Value);

            Cards = Cards.Where(x => x.Power >= MinPower.Value * 1000 || x.Type == Type.Spell);
            Cards = Cards.Where(x => x.Power <= MaxPower.Value * 1000 || x.Type == Type.Spell);

            if(filterClause != null)
            {
                Cards = Cards.Where(x => filterClause.EvaluateOn(x.Text));
            }

            UpdateCardDisplay();
        }

        private void UpdateCardDisplay()
        {
            var stringcards = Cards.Select(x => FilterCardText(x.ToString()));
            CardDisplay.Lines = stringcards.ToArray();

            Count.Text = "Matches: " + Cards.Count();

            MinPowerLabel.Text = (MinPower.Value *1000).ToString();
            MaxPowerLabel.Text = (MaxPower.Value * 1000).ToString();
            MinCostLabel.Text = MinCost.Value.ToString();
            MaxCostLabel.Text = MaxCost.Value.ToString();
        }

        private bool ColorChecked()
        {
            return Light.Checked || Water.Checked || Darkness.Checked || Fire.Checked || Nature.Checked;
        }

        private IEnumerable<EColor> SelectedColors()
        {
            EColor[] SelectedColors = {
                Light.Checked ? EColor.Light : EColor.Null,
                Water.Checked ? EColor.Water : EColor.Null,
                Darkness.Checked ? EColor.Darkness : EColor.Null,
                Fire.Checked ? EColor.Fire : EColor.Null,
                Nature.Checked ? EColor.Nature : EColor.Null
            };
            return SelectedColors.Distinct().Where(x=> x!= EColor.Null);
        }

        private IEnumerable<Type> SelectedTypes()
        {
            Type[] SelectedTypes = {
                Creatures.Checked ? Type.Creature : Type.Null,
                Spells.Checked ? Type.Spell : Type.Null,
                Evolutions.Checked ? Type.Evolution : Type.Null
            };
            return SelectedTypes.Distinct().Where(x => x != Type.Null);
        }

        private string FilterCardText(string cardText)
        {
            var text = cardText;
            if (FilterReminder.Checked)
            {
                text = Loop(text, '(', ')');
            text = Loop(text, '[', ']');
            }
            return text;
        }

        private string Loop(string text, char s, char e)
        {
            var next = FilterPiece(text, s, e);
            while (next != null)
            {
                text = next;
                next = FilterPiece(text, s, e);
            }
            return text;
        }

        private string FilterPiece(string snippet, char s, char e)
        {
            var start = snippet.IndexOf(s);
            var end = snippet.IndexOf(e);
            if (start < 0) return null;
            snippet = snippet.Remove(start, end - start +1);
            return snippet;
        }

        private void RuleSearch_TextChanged(object sender, EventArgs e)
        {
            filterClause = SearchParser.Parse(RuleSearch.Text);

            UpdateSearch(sender, e);
        }
    }
}
