using System;

class Exercicio13 {
    static void Main() {
        string resp;
        
        Console.WriteLine("--- Calculadora de Fatorial ---");
        
        do {
            int n;
            do {
                Console.Write("\nDigite um número inteiro positivo para calcular o seu fatorial: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0) {
                    Console.WriteLine("Erro: Não é possível calcular o fatorial de um número negativo. Tente novamente.");
                }
            } while (n < 0);

            long fatorial = 1;
            for (int i = n; i > 1; i--) {
                fatorial *= i;
            }
            
            Console.WriteLine($"\nResultado: {n}! = {fatorial}");

            do {
                Console.Write("\nDeseja fazer um novo cálculo? (S/N): ");
                resp = Console.ReadLine().ToUpper();
                if (resp != "S" && resp != "N") {
                    Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.");
                }
            } while (resp != "S" && resp != "N");

        } while (resp == "S");
        
        Console.WriteLine("Programa encerrado. Até logo!");
    }
}
