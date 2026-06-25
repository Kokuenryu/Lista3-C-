using System;

class Exercicio10 {
    static void Main() {
        double maior = 0, soma = 0, valor;
        
        Console.WriteLine("--- Análise de 10 Valores Positivos ---");
        
        for (int i = 0; i < 10; i++) {
            do {
                Console.Write($"Digite o {i + 1}º valor (apenas positivos): ");
                valor = double.Parse(Console.ReadLine());
                if (valor <= 0) {
                    Console.WriteLine("Erro: O valor deve ser maior que zero. Tente novamente.");
                }
            } while (valor <= 0);

            if (i == 0 || valor > maior) maior = valor;
            soma += valor;
        }
        
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Maior valor digitado: {maior}");
        Console.WriteLine($"Soma dos valores: {soma}");
        Console.WriteLine($"Média aritmética: {soma / 10.0}");
    }
}
