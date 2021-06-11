using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomanos
{
    public class ConversorRomanosArabicos
    {
        DicionarioArabicoRomano dicionario;
        public ConversorRomanosArabicos()
        {
            dicionario = new DicionarioArabicoRomano();
        }

        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }




        public int Converter(string numeroRomano)
        {
            numeroRomano = dicionario.Normalizar(numeroRomano);
            char[] valoresParaConversao = numeroRomano.ToCharArray();
            int saida = 0;

            for (int i = 0; i < valoresParaConversao.Length; i++)
            {
                string valor = valoresParaConversao[i].ToString();
                int valorASerAdicionado = 0;
                VerificaAvancoDePosicao(valoresParaConversao, ref i, valor, ref valorASerAdicionado);

                if (valorASerAdicionado == 0)
                {
                    valorASerAdicionado = dicionario.conversaoRomanoArabico[valor];
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

                if (dicionario.valoresQuePodemDiminuir.Contains(valor) && ProximoValorEhMaiorQueOAtual(valor, proximoValor))
                {
                    valorASerAdicionado = dicionario.conversaoRomanoArabico[proximoValor] - 
                        dicionario.conversaoRomanoArabico[valor];
                    i++;
                }

            }
        }

        private bool ProximoValorEhMaiorQueOAtual(string valor, string proximoValor)
        {
            return dicionario.conversaoRomanoArabico[proximoValor] > dicionario.conversaoRomanoArabico[valor];
        }

        private static bool AvancarMais(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }
    }
}