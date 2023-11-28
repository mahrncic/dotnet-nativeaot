using System.Diagnostics;

var num = 100_000_000;

var stopWatch = Stopwatch.StartNew();
var result = CalculatePi(num);
Console.WriteLine($"Calculated result: {result} in {stopWatch.ElapsedMilliseconds}ms");
stopWatch.Stop();

Console.ReadKey();

static double CalculatePi(int numberOfSamples)
{
    var random = new Random();
    var insideCircle = 0;

    for (var i = 0; i < numberOfSamples; i++)
    {
        var x = random.NextDouble() * 2 - 1;
        var y = random.NextDouble() * 2 - 1;

        if (x * x + y * y <= 1)
        {
            insideCircle++;
        }
    }

    return (double)insideCircle / numberOfSamples * 4;
}