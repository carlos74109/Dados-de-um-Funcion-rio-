using Exercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Seu salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            //func.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + func.nome + ", salário atual: R$"  + func.AumentarSalario(porcentagem));

            

            
        }
    }
}
