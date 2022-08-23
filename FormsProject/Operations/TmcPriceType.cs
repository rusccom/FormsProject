using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Operations
{
    public enum TmcPriceType
    {
        price = 1,
        price1 = 2,
        price2 = 3,
        price3 = 4
    }

    public static class TmcPriceHandling
    {
        public static Dictionary<TmcPriceType, string> GetTmcPriceType()
        {
            Dictionary<TmcPriceType, string> result = new Dictionary<TmcPriceType, string>();

            result.Add(TmcPriceType.price, GetPriceName(TmcPriceType.price));
            result.Add(TmcPriceType.price1, GetPriceName(TmcPriceType.price1));
            result.Add(TmcPriceType.price2, GetPriceName(TmcPriceType.price2));
            result.Add(TmcPriceType.price3, GetPriceName(TmcPriceType.price3));

            return result;
        }

        public static void PopulateComboBox(ComboBox control)
        {
            Dictionary<TmcPriceType, string> priceType = GetTmcPriceType();

            control.DataSource = new BindingSource(priceType, null);
            control.ValueMember = "Key";
            control.DisplayMember = "Value";
        }

        private static string GetPriceName(TmcPriceType tmcPriceType)
        {
            string result = string.Empty;

            switch(tmcPriceType)
            {
                case TmcPriceType.price:
                    result = "Закупочная";
                    break;
                case TmcPriceType.price1:
                    result = "Цена 1";
                    break;
                case TmcPriceType.price2:
                    result = "Цена 2";
                    break;
                case TmcPriceType.price3:
                    result = "Цена 3";
                    break;
            }

            return result;
        }
    }
}
