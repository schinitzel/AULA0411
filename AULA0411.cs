using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("SELECIONE UMA ATIVIDADE:");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            double gasolina, etanol, total;
            if (opcao == 1)
            {
                Console.WriteLine("Insira o Valor da Gasolina");
                gasolina = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();
                
                Console.WriteLine("Insira o Valor do etanol");
                etanol = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();

                total = gasolina / etanol;
                Console.WriteLine("o total é:" + total);
                Console.ReadKey();

                if (total > 0.7)
                {
                    Console.WriteLine("Use Gasolina");
                    Console.ReadKey();
                }
                else if(total < 0.7){
                    Console.WriteLine("Use Etanol");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ambos Combustiveis são equivalentes");
                    Console.ReadKey();
                }

            }
            else if(opcao == 2)
            {
                double numero = 0, valor, quantidade = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Insira um numero:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    numero = numero + valor;
                    quantidade = quantidade + 1;
                  

                } while (quantidade < 50);
                numero = numero / 50;
                Console.WriteLine("a média é:" + numero);
                Console.ReadKey();

            }

            else if(opcao == 3){
                double a1, b1, resultado, area;
                Console.Clear();
                Console.WriteLine("insira o cateto 1");
                a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("insira o cateto 2");
                b1 = Convert.ToDouble(Console.ReadLine());


                resultado = a1 * a1 + b1 * b1;
                area = a1 + b1/2;
                Console.WriteLine("a hipotenusa é:" + resultado);
                Console.WriteLine("a area é:" + area);

                Console.ReadKey();

            }
            else if(opcao == 4)
            {
                double imc, p, a1;
                Console.WriteLine("Insira seu peso");
                p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira sua altura");
                a1 = Convert.ToDouble(Console.ReadLine());

                imc = p / a1 * a1;

                if (imc < 18.5)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está abaixo do peso");
                }
                else if (imc > 18.5 && imc <= 24.9)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está no peso ideal (parabéns)");
                }

                else if (imc >= 25.5 && imc <= 29.9)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está acima do peso (sobrepeso)");
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está em estágio de obesidade I)");
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está em estágio de obesidade II (severa))");
                }
                else if (imc > 40)
                {
                    Console.WriteLine("Seu IMC é de {imc}. Você está em estágio de obesidade III(móbita))");
                }
            }

            else if (opcao == 5)
            {
                double fim = 0;
                double b1, m1, seminario, media, maiorm, maiorb, maiors;
                string aluno;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Insira um aluno:");
                    Console.ReadLine();
                    Console.WriteLine("Insira a nota mensal");
                    m1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira a nota bimestral:");
                    b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira a nota de seminário");
                    seminario = Convert.ToDouble(Console.ReadLine());
                    fim = fim++;
                    media = m1 + b1 + seminario / 3;
                    Console.ReadKey();
                } while (fim < 20);

                if(m1){
                    Console.WriteLine(maiorm);
                }

            }
        }
        
    }
}
