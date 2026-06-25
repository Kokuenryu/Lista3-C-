using System;

class Exercicio5 {
    static void Main() {
        double valor;
        do {
            valor = double.Parse(Console.ReadLine());
        } while (valor <= 0);

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{valor} x {i} = {valor * i}");
        }
    }
}
