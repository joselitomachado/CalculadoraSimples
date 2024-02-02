namespace Calculadora.Models
{
    public class Layout
    {
        public static void TelaPrincipal()
        {
            try
            {
                int opcao;
                Calculo calculo = new();

                do
                {
                    ChamarMenu();

                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (opcao >= 1 && opcao <= 4)
                    {
                        Console.WriteLine("\nDigite o primeiro número: ");
                        calculo.Numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite o segundo número: ");
                        calculo.Numero2 = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                calculo.Soma(calculo.Numero1, calculo.Numero2);
                                break;

                            case 2:
                                calculo.Subtracao(calculo.Numero1, calculo.Numero2);
                                break;

                            case 3:
                                calculo.Multiplicacao(calculo.Numero1, calculo.Numero2);
                                break;

                            case 4:
                                calculo.Divisao(calculo.Numero1, calculo.Numero2);
                                break;

                            default:
                                break;
                        }

                        Console.WriteLine("\nOperação finalizada com sucesso!\n");
                    }

                    else if (opcao == 0)
                    {
                        Console.WriteLine("\nVocê saiu do sistema!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Digite uma opção válida!\n");
                    }

                } while (true);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Ocorreu um erro na sua aplicação: {ex.Message}");
            }
        }
        public static void ChamarMenu()
        {
            Console.WriteLine("========================[ Calculadora ]========================\n");

            Console.WriteLine("Qual a operação deseja fazer: \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair\n");
        }
    }
}