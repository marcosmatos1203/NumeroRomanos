using NumeroRomanos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConversorArabicosRomanos
{
    public class NumerosArabicosParaRomanos
    {
        DicionarioArabicoRomano dicionario;
        public NumerosArabicosParaRomanos()
        {
            dicionario = new DicionarioArabicoRomano();
        }

        public string ConverterArabicoParaRomano(int valorArabico)
        {
            String resultado = "";

            foreach (int valor in dicionario.conversaoArabicoRomano.Keys)
            {
                while (valorArabico >= valor)
                {
                    resultado += dicionario.conversaoArabicoRomano[valor];
                    valorArabico -= valor;
                }
            }
            return resultado;
        }
    }
}
