using System;

class Exercicio7 {
    static void Main() {
        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.ReadKey();
        }
    }
}
