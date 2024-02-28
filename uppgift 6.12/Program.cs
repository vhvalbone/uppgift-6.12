using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ange höjden på triangeln:");
        int hojd = Convert.ToInt32(Console.ReadLine());

        RitaTriangel(hojd);
    }

    public static void RitaTriangel(int hojd)
    {
        for (int rad = 1; rad <= hojd; rad++)
        {

            int antal_stjarnor = 2 * rad - 1;
            int antal_mellanslag = hojd - rad;


            for (int i = 0; i < antal_mellanslag; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < antal_stjarnor; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
