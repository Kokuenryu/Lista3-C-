using System;

class Exercicio6 {
    static void Main() {
        double x;
        do {
            x = double.Parse(Console.ReadLine());
        } while (x <= 0);

        int a = int.Parse(Console.ReadLine());
        int b;
        do {
            b = int.Parse(Console.ReadLine());
        } while (b <= a);

        for (int i = b; i >= a; i--) {
            Console.WriteLine($"{x} x {i} = {x * i}");
        }
    }
}
