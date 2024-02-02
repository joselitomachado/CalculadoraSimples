namespace Calculadora.Models
{
    public class Calculo
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public void Soma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine($"\nO resultado da soma: {numero1} + {numero2} = {resultado}");
        }

        public void Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            Console.WriteLine($"\nO resultado da subtração: {numero1} - {numero2} = {resultado}");
        }

        public void Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            Console.WriteLine($"\nO resultado da Multiplicação: {numero1} x {numero2} = {resultado}");
        }

        public void Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            Console.WriteLine($"\nO resultado da Divisão: {numero1} / {numero2} = {resultado}");
        }
    }
}
