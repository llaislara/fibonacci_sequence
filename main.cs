using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para informar um número
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Inicializa os dois primeiros números da sequência de Fibonacci
        int anterior = 0;
        int atual = 1;

        // Verifica se o número informado é igual a um dos números iniciais da sequência
        if (numero == 0 || numero == 1)
        {
            Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
            return;
        }

        // Calcula a sequência de Fibonacci até ultrapassar o número informado
        while (atual <= numero)
        {
            int proximo = anterior + atual;
            // Se o próximo número da sequência for igual ao número informado, o número pertence à sequência
            if (proximo == numero)
            {
                Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
                return;
            }
            // Atualiza os valores para o próximo cálculo
            anterior = atual;
            atual = proximo;
        }

        // Se o número informado não foi encontrado na sequência, exibe uma mensagem informando
        Console.WriteLine("O número informado não pertence à sequência de Fibonacci.");
    }
}
