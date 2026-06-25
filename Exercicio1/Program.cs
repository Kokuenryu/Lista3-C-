using System;

class Exercicio1 {
    static void Main() {
        double valor;
        do {
            valor = double.Parse(Console.ReadLine());
        } while (valor <= 0);
    }
}
