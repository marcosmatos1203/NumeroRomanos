using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomanos
{
    public class ConversorRomanosArabicos
    {

        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private static string Normalizar(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "i");
            str = str.Replace("V̄", "v");
            str = str.Replace("X̄", "x");

            return str;
        }

        private Dictionary<string, int> dicionarioConversao = new Dictionary<string, int>()
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

        private List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "I",
            "X",
            "C",
            "i",
            "x",
            "c"
        };


        public int Converter(string numeroRomano)
        {
            numeroRomano = Normalizar(numeroRomano);
            char[] valoresParaConversao = numeroRomano.ToCharArray();
            int saida = 0;

            for (int i = 0; i < valoresParaConversao.Length; i++)
            {
                string valor = valoresParaConversao[i].ToString();
                int valorASerAdicionado = 0;
                VerificaAvancoDePosicao(valoresParaConversao, ref i, valor, ref valorASerAdicionado);

                if (valorASerAdicionado == 0)
                {
                    valorASerAdicionado = dicionarioConversao[valor];
                }

                saida += valorASerAdicionado;
            }

            return saida;
        }

        private void VerificaAvancoDePosicao(char[] valoresParaConversao, ref int i, string valor, ref int valorASerAdicionado)
        {
            if (AvancarMais(valoresParaConversao, i))
            {
                string proximoValor = valoresParaConversao[i + 1].ToString();

                if (valoresQuePodemDiminuir.Contains(valor) && ProximoValorEhMaiorQueOAtual(valor, proximoValor))
                {
                    valorASerAdicionado = dicionarioConversao[proximoValor] - dicionarioConversao[valor];
                    i++;
                }

            }
        }

        private bool ProximoValorEhMaiorQueOAtual(string valor, string proximoValor)
        {
            return dicionarioConversao[proximoValor] > dicionarioConversao[valor];
        }

        private static bool AvancarMais(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }
    }
}