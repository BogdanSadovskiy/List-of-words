namespace Myspace;
class program
{
    static void Main(string[] args)
    {
        ListOfWords listOfWords = new ListOfWords();

        Console.WriteLine("Input words:");
        string str = Console.ReadLine();
        listOfWords.addWord(str);

        Console.WriteLine(listOfWords.ToString());
        listOfWords.checkIfSameWords();
        Console.WriteLine(listOfWords.ToString());

    }
}

