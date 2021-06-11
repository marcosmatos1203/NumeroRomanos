using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomanos
{
    public class DicionarioArabicoRomano
    {
        public Dictionary<int, string> conversaoArabicoRomano = new Dictionary<int, string>()
        {
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 8000, "V̄ĪĪĪ" },
            { 7000, "V̄ĪĪ" },
            { 6000, "V̄Ī" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 1, "I"},
        };
        public Dictionary<string, int> conversaoRomanoArabico = new Dictionary<string, int>()
        {
            { "x", 10000 },
            { "v", 5000 },
            { "i", 1000 },
            { "M", 1000 },
            { "D", 500 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10},
            { "V", 5},
            { "I", 1},
        };
        public string Normalizar(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "i");
            str = str.Replace("V̄", "v");
            str = str.Replace("X̄", "x");

            return str;
        }

        public List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "I",
            "X",
            "C",
            "i",
            "x",
            "c"
        };
    }
}
