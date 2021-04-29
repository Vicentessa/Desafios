using System;

namespace Desafios
{
    class Program
    {
        static string opcao = null;
        static void Main(string[] args)
        {
         
            do
            {
                Console.WriteLine("Quantos testes? ");
                Desafio05();
                Console.WriteLine("X - Para sair ou pressione uma tecla p/continuar...");
                opcao = Console.ReadLine();
            }
            while (opcao.ToUpper() != "X");
            
        }

        private static void Desafio05()
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[0]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
           

            int transformaSegundosInicio = ();
            int transformaSegundosTermino = ();

            int somaTotalSegundos = (            );
            int W =  / ();
          

            Console.WriteLine("{0} dia(s)", W);
        }

        private static void Desafio04()
        {
            try
            {
                int qtdTeste = int.Parse(Console.ReadLine());
                string v1, v2;
                for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
                {
                    string[] valores = Console.ReadLine().Split();
                    v1 = valores[0];
                    v2 = valores[1];
                    if ((v1 == "tesoura" && v2 == "papel") || (v1 == "papel" && v2 == "pedra") ||
                        (v1 == "pedra" && v2 == "lagarto") || (v1 == "lagarto" && v2 == "Spock") ||
                        (v1 == "Spock" && v2 == "tesoura") || (v1 == "tesoura" && v2 == "lagarto") ||
                        (v1 == "lagarto" && v2 == "papel") || (v1 == "papel" && v2 == "Spock") ||
                        (v1 == "Spock" && v2 == "pedra") || (v1 == "pedra" && v2 == "tesoura"))
                        Console.WriteLine("Caso #{0}: Bazinga!", i);                
                    else if ( v1 == v2   )   //complete a solucao
                        Console.WriteLine("Caso #{0}: De novo!", i);
                    else
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                }               
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        private static void Desafio03()
        {
            try
            {
                double a, b;
                Console.WriteLine("Informe o valor de A: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o valor de B: ");
                b = Convert.ToDouble(Console.ReadLine());
                
                //complete com as variaveis

                Console.WriteLine("MEDIA = {0}", ((( a * 3.5) + ( b * 7.5)) / 11).ToString("0.00000"));
                Console.WriteLine("Pressione uma tecla para sair...");
                opcao = Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message.ToString());
                return;
            }

            
        }

        private static void Desafio02()
        {
            double salario = 0.00, reajuste = 0.00, novoSalario = 0.00, percentual = 0.00;

            while (salario < 9000.00) {

                Console.WriteLine("Informe o Salário: ");
                try
                {
                    salario = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Salário inválido! " + ex.Message);
                    return;
                }
                
                //insira os valores corretos de acordo com o enunciado
                if (salario < 0.00)
                {
                    return;
                }
                else if (salario <= 400.00)
                {
                    reajuste = salario * 0.15; 
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) /salario;
                }
                else if (salario <= 800.00)
                {
                    reajuste = salario * 0.12;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                }
                else if (salario <= 1200.00)
                {
                    reajuste = salario * 0.10;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                }
                else if (salario <= 2000.00)
                {
                    reajuste = salario * 0.07;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                }
                else if (salario > 2000.01)
                {
                    //complete o codigo
                    reajuste = salario * 0.04;
                    novoSalario = salario + reajuste;
                    percentual = ((novoSalario - salario) * 100) / salario;
                }

                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);

            }
        }

        private static void Desafio01()
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Informe a distancia total percorrida: ");
            distancia = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o total de combustível consumido: ");
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio =  distancia / combustivelGasto; //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio);
        }
    }
}
