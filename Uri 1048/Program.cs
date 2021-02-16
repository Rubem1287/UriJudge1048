using System;
using System.Globalization;
namespace Uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, porcentagem;
            int valorPorcentagem;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400 )
            {
                porcentagem = 15.0 / 100.0;

                valorPorcentagem = (int) (porcentagem * salario);

                salario += +valorPorcentagem;
                Console.WriteLine();
                Console.WriteLine("Novo salário : " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho : "+valorPorcentagem);
                Console.WriteLine("Em percentual : 15 %");


            }
            else if(salario>=400.01&&salario<=800)
            {
                porcentagem = 12.0 / 100.0;

                valorPorcentagem = (int)(porcentagem * salario);

                salario += +valorPorcentagem;
                Console.WriteLine();
                Console.WriteLine("Novo salário : " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho : " + valorPorcentagem);
                Console.WriteLine("Em percentual : 12 %");
            }

            else if(salario>=800.01&&salario<=1200)
            {

                porcentagem = 10.0 / 100.0;

                valorPorcentagem = (int)(porcentagem * salario);

                salario += +valorPorcentagem;
                Console.WriteLine();
                Console.WriteLine("Novo salário : " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho : " + valorPorcentagem);
                Console.WriteLine("Em percentual : 10 %");

            }

            else if (salario >= 1200.01 && salario <= 2000)
            {

                porcentagem = 7.0 / 100.0;

                valorPorcentagem = (int)(porcentagem * salario);

                salario += +valorPorcentagem;
                Console.WriteLine();
                Console.WriteLine("Novo salário : " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho : " + valorPorcentagem);
                Console.WriteLine("Em percentual : 7 %");

            }

            else if (salario >= 2000)
            {

                porcentagem = 4.0 / 100.0;

                valorPorcentagem = (int)(porcentagem * salario);

                salario += +valorPorcentagem;
                Console.WriteLine();
                Console.WriteLine("Novo salário : " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho : " + valorPorcentagem);
                Console.WriteLine("Em percentual : 4 %");

            }


            
        }
    }
}
