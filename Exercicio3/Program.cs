using System;

class Exercicio3 {
    static void Main() {
        string sexo;
        do {
            sexo = Console.ReadLine().ToUpper();
        } while (sexo != "F" && sexo != "M");
    }
}
