using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Models
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.imposto = imposto;
            this.salarioBruto = salarioBruto;
        }

        public double salarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            double mediaPortcentagem = salarioLiquido() + (porcentagem / 100) * salarioBruto;
            return mediaPortcentagem;
        }

        public override string ToString()
        {
            return nome + ", " + " salario: $" + salarioLiquido();
        }
    }
}
