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
        var len = id.Length;
        for (int n = len -1; n >= 2; n--)
        {
            if (len % n == 0)
            {
                bool isInvalid = true;

                var segment = id.Substring(0, len / n);
                for (int j = 1; j < n; j++)
                {
                    if (id.Substring(j * (len / n), len / n) != segment)
                    {
                        isInvalid = false;
                        break;
                    }
                }
                if (isInvalid)
                {
                    invalidIDsTotal += i;
                    break;
                }
            }
        }
    }
}
watch.Stop();
// output total of all invalid IDs
Console.WriteLine($"Invalid product IDs total: {invalidIDsTotal}. Execution Time: {watch.ElapsedMilliseconds} ms");