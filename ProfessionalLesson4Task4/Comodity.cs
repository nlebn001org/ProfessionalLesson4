using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson4Task4
{
    class Commodity
    {
        string name;
        int price;
        DateTime date;

        public Commodity(string name, int price, DateTime date)
        {
            this.name = name;
            this.price = price;
            this.date = date;
        }

        public override string ToString()
        {
            return $"Нименование продукта:\n{name}\nЦена:\n{price} {new RegionInfo("cz").ISOCurrencySymbol}\nДата:\n{date}\n\n" +
                    $"Product name:\n{name}\nPrice:\n{price / 22} {new RegionInfo("us").ISOCurrencySymbol}\nDate:\n{date}\n\n";
        }
    }
}
