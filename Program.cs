using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crie um programa que solicite o valor de um produto. Após isso deve ser solicitado a porcentagem de desconto para o produto.
// Deve ser mostrado o valor com desconto ao final do processo.

//Regras:
//A taxa de desconto não pode ser maior que 50%
//A taxa de desconto não pode ser menor que 0%
//A taxa de desconto não pode ser maior que 10% caso o valor do produto seja menor que 100 reais.
//A taxa de desconto não pode ser maior que 20% caso o valor do produto seja menor que 200 reais.

namespace Descontao
{


    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Qual é o valor do produto?");
            float valorProduto = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Qual é a porcentagem de desconto?");
            float porcentagemDesconto = float.Parse(Console.ReadLine());

            
            if (porcentagemDesconto > 50)
            {
                Console.WriteLine("A porcentagem de desconto não pode ser maior que 50%.");
            }
            if (porcentagemDesconto < 0)
            {
                Console.WriteLine("A porcentagem de desconto não pode ser menor que 0%.");
            }
            if (valorProduto < 100 && porcentagemDesconto > 10)
            {
                Console.WriteLine("A porcentagem de desconto não pode ser maior que 10% para produtos com valor menor que 100 reais.");
            }
            if (valorProduto < 200 && porcentagemDesconto > 20)
            {
                Console.WriteLine("A porcentagem de desconto não pode ser maior que 20% para produtos com valor menor que 200 reais.");
            }

            
            float valorDesconto = valorProduto * porcentagemDesconto / 100;
            float valorFinal = valorProduto - valorDesconto;

            
            Console.WriteLine("O valor final do produto é de {0:C}", valorFinal);

            Console.ReadLine();
        }

    }


}

