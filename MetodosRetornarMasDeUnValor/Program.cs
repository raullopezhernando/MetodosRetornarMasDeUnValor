using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosRetornarMasDeUnValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primera Forma de Imprimir ambos Datos
            int cociente = 0;
            int residuo = 0;

            (cociente,residuo) = Dividir(50, 25);

            Console.WriteLine(cociente);
            Console.WriteLine(residuo);

            // Segunda Forma de Imprimir ambos Datos

            (int cociente, int residuo) datos = Dividir(50, 25);

            Console.ReadLine();
            Console.WriteLine(datos.cociente);
            Console.ReadLine();
            Console.WriteLine(datos.residuo);
            Console.ReadLine();

        }

        static (int,int) Dividir(int numero1,int numero2) 

        {
            int cociente = numero1 / numero2;
            int residuo = numero1 % numero2;
            return (cociente,residuo);
        }
    }
}
