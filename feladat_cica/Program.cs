using System.Numerics;

namespace feladat_cica
{
    internal class Program
    {
        static Random r = new Random();
        static int[,] eredmeny;
        static string[] macskaknevei(int szam)
        {
            string[] nevek = { "Anna", "Bence", "Csaba", "Dóra", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márk", "Nóra", "Orsolya", "Péter", "Réka", "Sándor", "Tamás", "Viktória", "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid", "Emese", "Flóra", "György", "Levente", "Mihály" };
            string[] macskak = new string[szam];
            for (int i = 0; i < szam; i++)
            {
                macskak[i] = nevek[r.Next(0, nevek.Length)];
            }
            return macskak;
        }
        static int[,] feltolt(int szam)
        {
            int[,] pontok = new int[szam, 3];
            for (int i = 0; i < pontok.GetLength(0); i++)
            {

                for (int j = 0; j < pontok.GetLength(1); j++)
                {
                    pontok[i, j] = r.Next(1, 11);
                }

            }

            return pontok;
        }
        static void kiiras(int[,] matrix, string[] nevek)
        {
            for (int i = 0; i < nevek.GetLength(0); i++)
            {
                Console.Write(nevek[i] + ":  ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],8}");
                }
                Console.WriteLine();
            }
            int[] legnagy = new int[3];
            string[] gyoztes = new string[3];

            for (int i = 0; i < nevek.GetLength(0); i++)
            {
                if (matrix[i, 0] > legnagy[0])
                {
                    legnagy[0]=matrix[i, 0];
                    gyoztes[0] = nevek[i];
                }
                else if (matrix[i, 1] > legnagy[1])
                {
                    legnagy[1]= matrix[i, 1];
                    gyoztes[1] = nevek[i];
                }
                else if (matrix[i, 2] > legnagy[2])
                {
                    legnagy[2] = matrix[i, 2];
                    gyoztes[2] = nevek[i];
                }
            }
            
            Console.WriteLine($"A leglustább:{gyoztes[0]}");
            Console.WriteLine($"A legjátékosabb:{gyoztes[1]}");
            Console.WriteLine($"A legéhesebb:{gyoztes[2]}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi macska van: ");
            int szama = Convert.ToInt32(Console.ReadLine());
            string[] macskak = macskaknevei(szama);
            eredmeny = feltolt(szama);
            kiiras(eredmeny, macskak);
        }
    }
}
