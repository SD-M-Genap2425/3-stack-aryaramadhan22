using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        var history = new HistoryManager();

        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine("Halaman saat ini: " + history.LihatHalamanSaatIni());

        Console.WriteLine("Kembali ke halaman sebelumnya...");
        history.Kembali();
        Console.WriteLine("Halaman saat ini: " + history.LihatHalamanSaatIni());

        history.TampilkanHistory();



        // Bracket validator
        var bracketValidator = new BracketValidator();
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {bracketValidator.ValidasiEkspresi(ekspresiInvalid)}");


        //Palindrome Checker
        string[] testStrings = { "Kasur ini rusak", "Ibu Ratna antar ubi", "Hello World" };

        foreach (var test in testStrings)
        {
            bool isPalindrome = PalindromeChecker.CekPalindrom(test);
            Console.WriteLine($"{isPalindrome}");
        }


    }
}
