using System;

class Exercicio2 {
    static void Main() {
        double valor1 = double.Parse(Console.ReadLine());
        double valor2;
        do {
            valor2 = double.Parse(Console.ReadLine());
        } while (valor2 <= valor1);
    }
}
