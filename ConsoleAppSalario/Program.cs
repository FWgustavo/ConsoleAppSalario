using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o Valor do seu Sálario bruto: ");
            double sb = double.Parse(Console.ReadLine());
            Console.Write("Valor do Vale Alimentação: ");
            double valea = double.Parse(Console.ReadLine());
            Console.Write("Números de filhos: ");
            int filho = int.Parse(Console.ReadLine());
            Console.Write("Valor por filho: ");
            double vfilho = double.Parse(Console.ReadLine());
            Console.Write("Número de horas extras: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora extra: ");
            double vhora = double.Parse(Console.ReadLine());
            Console.Write("Valor de desconto do INSS: ");
            double inss = double.Parse(Console.ReadLine());
            Console.Write("Valor de desconto do IRPF: ");
            double irpf = double.Parse(Console.ReadLine());
            
            double totalf = filho * vfilho;
            double totalh = horas * vhora;
            double sl = sb + valea + totalf + totalh - inss - irpf;

            Console.WriteLine("O seu sálario líquido é: " + sl);
            Console.ReadKey();
        }
    }
}
