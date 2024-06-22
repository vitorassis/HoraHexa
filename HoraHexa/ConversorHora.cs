using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraHexa
{

    public class ConversorHora
    {

        private static string ConverterParaHexa(int dec)
        {
            int dezenas = dec / 6;
            int unidades = 0;
            dec = dec - (dezenas * 6);

            while(dec >= 6)
            {
                dec -= 6;
                dezenas++;
            }
            int centenas = 0;
            while(dezenas >= 6)
            {
                centenas++;
                dezenas -= 6;
            }
            unidades = dec;


            return (centenas != 0 ? centenas : "")+(dezenas + "") + unidades;
        }

        // Método para converter hora decimal para hora hexa
        public static string ConverterHoraHexa(int horaDecimal)
        {
            if (horaDecimal < 0 || horaDecimal > 23)
            {
                throw new ArgumentOutOfRangeException("horaDecimal", "Valor da hora deve estar entre 0 e 23.");
            }

            string horaHexa = ConverterParaHexa(horaDecimal);
            return horaHexa;
        }

        // Método para converter minuto decimal para minuto hexa
        public static string ConverterMinutoHexa(int minutoDecimal)
        {
            if (minutoDecimal < 0 || minutoDecimal > 59)
            {
                throw new ArgumentOutOfRangeException("minutoDecimal", "Valor do minuto deve estar entre 0 e 59.");
            }

            string minutoHexa = ConverterParaHexa(minutoDecimal);
            return minutoHexa;
        }

        // Método para obter a hora hexa atual
        public static string GetHoraHexaAtual()
        {
            return GetHoraHexa(DateTime.Now);
        }

        public static string GetHoraHexa(DateTime time)
        {
            int horaDecimal = time.Hour;
            int minutoDecimal = time.Minute;

            string horaHexa = ConverterHoraHexa(horaDecimal);
            string minutoHexa = ConverterMinutoHexa(minutoDecimal);

            return horaHexa + ":" + minutoHexa;
        }
    }
}
