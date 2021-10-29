using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChuck;

            randomChuck = GetRandomFromFile("chuck.txt");

            Console.WriteLine(randomChuck);
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length); //viimane number on viimane elemendi väärtus + 1

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName) //vaatab mis faili ma pakkun lahti teha 
        {
            string filePath = $@"C:\Users\Laptop\samples\{fileName}"; //teeb faili lahti
            string[] dataFromFile = File.ReadAllLines(filePath); //loeb failide sisu ja salvestab massiivi dataFromFile. 1 rida = 1 element
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)]; //loob vahemälus uus muutuja randomElement ja salvestab sinna ühe juhusliku elemendi massiivist

            return randomElement;
        }
    }
}
