global using ClientLibrary;

internal class Program
{
    private static void Main()
    {
        string[] text = {"Все было так, как он говорил, только вот слова его не имели смысла.","Но как же можно было не верить этому человеку, который смотрел на нее такими искренними глазами? Как","же можно было не верить ему? Ведь он был единственным свидетелем ее жизни." };

        static List<string> GetWords(string[] textArray, int n)=> textArray.SelectMany(text => text.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries))
                .Where(word => word.Length >= n)
                .Select(word => word.ToLower())
                .Distinct()
                .OrderBy(word => word)
                .ToList();

        foreach (string word in GetWords(text,5))
            Console.WriteLine(word);

        static void GetMaxDurationYear(List<Record> clients)
        {
            var maxDurationYear = clients.GroupBy(client => client.Year)
                .Select(group => new { Year = group.Key, TotalDuration = group.Sum(client => client.Duration) })
                .OrderByDescending(group => group.TotalDuration)
                .ThenBy(group => group.Year)
                .First();

            Console.WriteLine($"Год: {maxDurationYear.Year}, продолжительность: {maxDurationYear.TotalDuration}");
        }

        var andrew = new Record(1, 2022, 4, 20);
        var andrew1 = new Record(1, 2022, 5, 20);
        var dima = new Record(2, 2021, 8, 50);
        var katya = new Record(3, 2022, 6, 30);
        var alex = new Record(3, 2021, 1, 10);
        var clients_test1 = new List<Record>() {andrew, andrew1, dima, katya, alex};
        GetMaxDurationYear(clients_test1);

        alex.Duration = 20;
        var clients_test2 = new List<Record>() { andrew, andrew1, dima, katya, alex };
        GetMaxDurationYear(clients_test2);
    }
}