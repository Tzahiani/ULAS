using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNum1
{
    class CardClass
    {
        private FunctionClass ff = new FunctionClass();

        public string name { get; set; }
        public string set { get; set; }
        public string setName { get; set; }
        public double cardPriceD;
        public string cardPrice { get; set; }
        public string colors { get; set; }
        public string cardType { get; set; }
        public string rarity { get; set; }

        public CardClass(string CardName)
        {
            name = ff.getDataFromJSON(CardName, "name");
            set = ff.getDataFromJSON(CardName, "set");
            setName = ff.getDataFromJSON(CardName, "setName");
            colors = ff.getColorFromJSON(CardName, "colors");
            cardType = ff.getDataFromJSON(CardName, "type");
            rarity = ff.getDataFromJSON(CardName, "rarity");
            ff.TryParseDouble(ff.getPriceFromJSON(CardName, set), out cardPriceD);
            cardPrice = (cardPriceD + (cardPriceD * 0.1)).ToString();
        }
    }
}
