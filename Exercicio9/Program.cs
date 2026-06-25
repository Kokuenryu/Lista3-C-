using System;

class Exercicio9 {
    static void Main() {
        long a = 1, b = 1, c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 3; i <= 30; i++) {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}
