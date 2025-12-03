using System.Text.RegularExpressions;

var watch = System.Diagnostics.Stopwatch.StartNew();
// parse data
var lines = File.ReadAllLines("data/day2.txt");
// split products
var products = lines[0].Split(',',StringSplitOptions.TrimEntries).ToArray();
long invalidIDsTotal = 0;
string pattern = @"^(\d+)\1+$";
foreach (var item in products)
{
    var parts = item.Split('-');
    for (long i = long.Parse(parts[0]); i <= long.Parse(parts[1]); i++)
    {
        if (Regex.IsMatch(i.ToString(), pattern))
            invalidIDsTotal += i;
    }
}
watch.Stop();
// output total of all invalid IDs
Console.WriteLine($"Invalid product IDs total: {invalidIDsTotal}. Execution Time: {watch.Elapsed.Milliseconds} ms");