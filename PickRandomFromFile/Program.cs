using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length); //viimane number on viimane elemendi väärtus + 1

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName) //vaatab mis faili ma pakkun lahti teha 
        {
            string filePath = $@"C:\Users\...\samples\{fileName}"; //teeb faili lahti
            string[] dataFromFile = File.ReadAllLines(filePath); //loeb failide sisu ja salvestab massiivi dataFromFile. 1 rida = 1 element
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)]; //loob vahemälus uus muutuja randomElement ja salvestab sinna ühe juhusliku elemendi massiivist

            return randomElement;
        }


    }
}
