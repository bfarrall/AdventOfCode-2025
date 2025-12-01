// read contents of data/day1.txt into array
var lines = File.ReadAllLines("data/day1.txt");
// dial starts at 50
int dial = 50;
// for each line, if its starts with L move left, if R move right
// wrap around if going below 0 or above 99
// keep track of how many times we stop at 0
int zeroCount = 0;
foreach (var line in lines)
{
    var direction = line[0];
    var steps = int.Parse(line[1..].Trim());
    switch (direction)
    {
        case 'L':
            dial = (dial - steps + 100) % 100;
            break;
        case 'R':
            dial = (dial + steps) % 100;
            break;
    }
    if (dial == 0)
        zeroCount++;
}
// output the number of times hitting 0
Console.WriteLine($"Hit 0 a total of {zeroCount} times.");
