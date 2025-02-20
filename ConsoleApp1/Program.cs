using System;
using System.Globalization;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Juntar metodo na main 
            // VerificarMedias();
            //ConcatenarPalavras();
            //VerificarAulaEtec();
            DetalharData();
            CalcularInss();
        }


        public static void VerificarMedias()
        {
            Console.WriteLine("Digite a primeira nota :");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");


            if (media > 7)
                Console.WriteLine("Aprovado");

            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperação");

            else
                Console.WriteLine("Reprovado");

        }

        //Criar metodo
        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje nao tem aula! Revisarei exercicios");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora para a ETEC!!!!");
            }
        }


        //Criar metodo

        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $" Óla {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine(" ");

            Console.WriteLine("Quanto custa o dolar em reais");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dddd}, o dolar está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);


            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} = {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            //traduz para portugues
            Console.WriteLine($"Dia da semana {data.ToString("dddd", new CultureInfo("pt-BR"))} ");
            Console.WriteLine($"Mes do ano {data.ToString("MMMM", new CultureInfo("pt-BR"))}");

            if (data.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine($"Hoje é domingo, a hora atual é {DateTime.Now:HH:mm:ss}");
        }


        public static void CalcularInss()
        {
            Console.WriteLine("Digite o seu salario para calcular o desconto do Inss: ");
            double Salario = double.Parse(Console.ReadLine());
            double DescontoInss = 0;
            if (Salario <= 1212)
            {
                DescontoInss = Salario * 0.075;
            }
            else if (Salario > 1212.01 && Salario <= 2427.35)
            {
                DescontoInss = Salario * 0.09;
            }
            else if (Salario > 2427.36 && Salario <= 3641.03)
            {
                DescontoInss = Salario * 0.12;
            }
            else if (Salario > 3641.04 && Salario <= 7087.22)
            {
                DescontoInss = Salario * 0.14;
            }

            double SalarioLiquido = Salario - DescontoInss;

            Console.WriteLine($"O valor do Inss a ser pago é de {DescontoInss:F2}"); //F2 para que saia com 2 casas decimais 
            Console.WriteLine($"O salario liquido ficou $: {SalarioLiquido:F2}");
        }
    }
}