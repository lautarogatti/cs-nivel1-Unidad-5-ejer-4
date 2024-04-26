using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo*//

            int n, resto, con = 0;
            Console.WriteLine("Por favor ingrese el número que desea saber si es primo");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                resto = n % i;
                if(resto == 0){
                    con++;
                }
            }
            if(con == 2) {
                Console.WriteLine(n + " es primo");
            } else {
                Console.WriteLine(n + " no es primo");
            }
        }
    }
}
