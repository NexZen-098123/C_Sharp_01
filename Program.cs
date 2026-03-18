using System;

class Program
{
    static void Main()
    {
        Console.Write("Wpisz PESEL: ");
        string pesel = Console.ReadLine();

        if (pesel.Length != 11)
        {
            Console.WriteLine("PESEL musi mieć 11 cyfr!");
            return;
        }

        
        int dziesiataCyfra = int.Parse(pesel[9].ToString());
        if (dziesiataCyfra % 2 == 0)
            Console.WriteLine("Płeć: kobieta");
        else
            Console.WriteLine("Płeć: mężczyzna");

        
        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += int.Parse(pesel[i].ToString()) * wagi[i];
        }

        int modulo = suma % 10;
        int kontrolna = 0;
        if (modulo != 0)
            kontrolna = 10 - modulo;

        if (kontrolna == int.Parse(pesel[10].ToString()))
            Console.WriteLine("PESEL jest poprawny");
        else
            Console.WriteLine("PESEL jest niepoprawny");
    }
}