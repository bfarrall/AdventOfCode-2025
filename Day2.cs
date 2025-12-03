// time how long the code takes to run
var watch = System.Diagnostics.Stopwatch.StartNew();
// parse data
var lines = File.ReadAllLines("data/day2.txt");
// split lines by -
var products = lines[0].Split(',').ToArray();
long invalidIDsTotal = 0;
foreach (var item in products)
{
    var parts = item.Split('-');
    for (long i = long.Parse(parts[0]); i <= long.Parse(parts[1]); i++)  {
        var id = i.ToString();
        if(id.Length % 2 != 0) // ignroe odd length IDs
            continue;
        if (id.Substring(0, id.Length / 2) == id.Substring(id.Length / 2))
            invalidIDsTotal += i;
    }
}
watch.Stop();
// output total of all invalid IDs
Console.WriteLine($"Invalid product IDs total: {invalidIDsTotal}. Execution Time: {watch.ElapsedMilliseconds} ms");