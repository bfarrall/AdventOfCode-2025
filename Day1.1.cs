// read contents of data/day1.txt into array
var lines = File.ReadAllLines("data/day1.txt");
// dial starts at 50
int dial = 50;
// for each line, if its starts with L move left, if R move right
// wrap around if going below 0 or above 99
// keep track of how many times we go past 0
int zeroCount = 0;
foreach (var line in lines)
{
    var direction = line[0];
    var steps = int.Parse(line[1..].Trim());
    switch (direction)
    {
        case 'L':
            for (int i = 0; i < steps; i++)
            {
                dial = (dial - 1 + 100) % 100;
                if (dial == 0)
                    zeroCount++;
            }
            break;
        case 'R':
            for (int i = 0; i < steps; i++)
            {
                dial = (dial + 1) % 100;
                if (dial == 0)
                    zeroCount++;
            }
            break;
    }
}
// output the number of times hitting 0
Console.WriteLine($"Hit 0 a total of {zeroCount} times.");
