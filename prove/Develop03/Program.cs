using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();



        Reference reference1 = new Reference();
        Console.WriteLine(reference1.GetDisplayText());

        Reference reference2 = new Reference("John", 3, 16);
        Console.WriteLine(reference2.GetDisplayText());

        Reference reference3 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(reference3.GetDisplayText());

        Word word1 = new Word("Hola, MUCHO GUSTO");
        word1.Hide();
        Console.WriteLine(word1.GetDisplayText());
        Console.WriteLine(word1.IsHidden());

        Word word2 = new Word("Hola, MUCHO GUSTO");
        word2.Show();
        Console.WriteLine(word2.GetDisplayText());
        Console.WriteLine(word2.IsHidden());

        Scripture scripture = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");


        Random number = new Random();
        int numberToHide = number.Next(1, 4);
        
        scripture.GetDisplayText();

    }
}