// time how long the code takes to run
var watch = System.Diagnostics.Stopwatch.StartNew();
// parse data
var lines = File.ReadAllLines("data/day2.txt");
// split lines by -
var products = lines[0].Split(',').ToArray();
long invalidIDsTotal = 0;
var id = "";
foreach (var item in products)
{
    var parts = item.Split('-');
    for (long i = long.Parse(parts[0]); i <= long.Parse(parts[1]); i++)  {
        id = i.ToString();
        if(id.Length % 2 != 0) // ignore odd length IDs
            continue;
        if (id[..(id.Length / 2)] == id[(id.Length / 2)..]) // check if first half matches second half
            invalidIDsTotal += i;
    }
}
watch.Stop();
// output total of all invalid IDs
Console.WriteLine($"Invalid product IDs total: {invalidIDsTotal}. Execution Time: {watch.ElapsedMilliseconds} ms");