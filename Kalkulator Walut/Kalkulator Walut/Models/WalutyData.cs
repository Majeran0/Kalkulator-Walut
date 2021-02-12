using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_Walut
{
    public static class WalutyData
{
        public static IList<Waluta> Waluty { get; private set; }

        static WalutyData()
        {
            Waluty = new List<Waluta>
            {
                new Waluta
                {
                    currency = "bat (Tajlandia)",
                    code = "THB",
                    mid = 0.1219
                },
                new Waluta
                {
                    currency = "dolar amerykański",
                    code = "USD",
                    mid = 3.6765
                },
                new Waluta
                {
                    currency = "dolar australijski",
                    code = "AUD",
                    mid = 0.4743
                },
                new Waluta
                {
                    currency = "dolar kanadyjski",
                    code = "CAD",
                    mid = 2.8596
                },
                new Waluta
                {
                    currency = "dolar nowozelandzki",
                    code = "NZD",
                    mid = 2.5928
                },
                new Waluta
                {
                    currency = "dolar singapurski",
                    code = "SGD",
                    mid = 2.7600
                },
                new Waluta
                {
                    currency = "euro",
                    code = "EUR",
                    mid = 4.4732
                },
                new Waluta
                {
                    currency = "forint (Węgry)",
                    code = "HUF",
                    mid = 0.012474
                },
                new Waluta
                {
                    currency = "frank szwajcarski",
                    code = "CHF",
                    mid = 4.1241
                },
                new Waluta
                {
                    currency = "funt szterling",
                    code = "GBP",
                    mid = 4.9565
                },
                new Waluta
                {
                    currency = "hrywna (Ukraina)",
                    code = "UAH",
                    mid = 0.1300
                },
                new Waluta
                {
                    currency = "jen (Japonia)",
                    code = "JPY",
                    mid = 0.035367
                },
                new Waluta
                {
                    currency = "korona czeska",
                    code = "CZK",
                    mid = 0.1689
                },
                new Waluta
                {
                    currency = "korona duńska",
                    code = "DKK",
                    mid = 0.6009
                },
                new Waluta
                {
                    currency = "korona islandzka",
                    code = "ISK",
                    mid = 0.029294
                },
                new Waluta
                {
                    currency = "korona norweska",
                    code = "NOK",
                    mid = 0.4198
                },
                new Waluta
                {
                    currency = "korona szwedzka",
                    code = "SEK",
                    mid = 0.4356
                },
                new Waluta
                {
                    currency = "kuna (Chorwacja)",
                    code = "HRK",
                    mid = 0.5928
                },
                new Waluta
                {
                    currency = "lej rumuński",
                    code = "RON",
                    mid = 0.9179
                },
                new Waluta
                {
                    currency = "lew (Bułgaria)",
                    code = "BGN",
                    mid = 2.2871
                },
                new Waluta
                {
                    currency = "lira turecka",
                    code = "TRY",
                    mid = 0.4734
                },
                new Waluta
                {
                    currency = "nowy izraelski szekel",
                    code = "ILS",
                    mid = 1.1257
                },
                new Waluta
                {
                    currency = "peso chilijskie",
                    code = "CLP",
                    mid = 0.004898
                },
                new Waluta
                {
                    currency = "peso filipińskie",
                    code = "PHP",
                    mid = 0.0765
                },
                new Waluta
                {
                    currency = "peso meksykańskie",
                    code = "MXN",
                    mid = 0.1851
                },
                new Waluta
                {
                    currency = "rand (Republika Południowej Afryki)",
                    code = "ZAR",
                    mid = 0.2420
                },
                new Waluta
                {
                    currency = "real (Brazylia)",
                    code = "BRL",
                    mid = 0.7136
                },
                new Waluta
                {
                    currency = "ringgit (Malezja)",
                    code = "MYR",
                    mid = 0.9055
                },
                new Waluta
                {
                    currency = "rubel rosyjski",
                    code = "RUB",
                    mid = 0.0495
                },
                new Waluta
                {
                    currency = "rupia indonezyjska",
                    code = "IDR",
                    mid = 0.00026065
                },
                new Waluta
                {
                    currency = "rupia indyjska",
                    code = "INR",
                    mid = 0.049835
                },
                new Waluta
                {
                    currency = "won południowokoreański",
                    code = "KRW",
                    mid = 0.003392
                },
                new Waluta
                {
                    currency = "yuan renminbi (Chiny)",
                    code = "CNY",
                    mid = 0.5630
                },
                new Waluta
                {
                    currency = "SDR (MFW)",
                    code = "XDR",
                    mid = 5.2891
                }
            };
        }
}
}
