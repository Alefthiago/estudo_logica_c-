using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class OperadoresTipoVariaveis
    {
        public static void ImprimirPerimetroTrianguloEquilatero (double aresta) {
            Console.WriteLine($"Perímetro do triângulo equilátero: {aresta * 3}");
        }

        public static void ImprimirPerimetroQuadro (double aresta)
        {
            Console.WriteLine($"Perímetro do quadrado: {(aresta * 4).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ImprimirPerimetroRetangulo(double aresta1, double aresta2, double aresta3, double aresta4)
        {
            Console.WriteLine($"Perímetro de um retângulo: {(aresta1 + aresta2 + aresta3 + aresta4).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ImprimirPerimetroPentagono(double aresta1, double aresta2, double aresta3, double aresta4, double aresta5)
        {
            Console.WriteLine($"Perímetro de um pentágono: {(aresta1 + aresta2 + aresta3 + aresta4 + aresta5).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ImprimirPerimetroHexagono(double aresta1, double aresta2, double aresta3, double aresta4, double aresta5, double aresta6)
        {
            Console.WriteLine($"Perímetro de um hexágono: {(aresta1 + aresta2 + aresta3 + aresta4 + aresta5 + aresta6).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ConverterSegundoEmHoras(double segundos)
        {
            double horas = segundos / 3600.0;
            Console.WriteLine($"Segundos: {segundos}\nHoras: {horas}");
        }

        public static void equacao1(double X)
        {
            double resultado = (Math.Pow(X, 2.0)) + (2.0 * X) - 3.0;
            Console.WriteLine($"Resultado da equação: f(x) = x² + 2x – 3 \nResultado: {resultado}");
        }

        public static void equacao2(double X)
        {
            double resultado = (Math.Pow(X, 3.0)) + (Math.Pow(X, 2.0)) + (3.0 * X) - 25;
            Console.WriteLine($"Resultado da equação: f(x) = x³ + x² + 3x - 25\nResultado : {resultado}");
        }

        public static void ImprimirMediaSeisNumeros(double numero1, double numero2, double numero3, double numero4, double numero5, double numero6)
        {
            double media = (numero1 + numero2 + numero3 + numero4 + numero5 + numero6) / 6.0;

            Console.WriteLine($"Media dos numeros: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ImprimirMediaPonderadaQuatroNumero(double numero1, double numero2, double numero3, double numero4)
        {
            int peso1 = 3, peso2 = 1, peso3 = 4, peso4 = 2;
            double media = ((numero1 * peso1) + (numero2 * peso2) + (numero3 * peso3) + (numero4 * peso4)) / (double) (peso1 + peso2 + peso3 + peso4);

            Console.WriteLine($"Media dos numero: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ImprimirIndiceDeMassaCorporal(double peso, double altura)
        {
            double massaCorporal = peso / (Math.Pow(altura, 2));

            Console.WriteLine($"Massa corporal: {massaCorporal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
