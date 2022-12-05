using Cocona;
using Day_2.Guide;

CoconaLiteApp.Run(([Argument(Description = "Path to the Input File", Name = nameof(inputFile))] string inputFile) =>
{
    var guide = GuideCreator.Create(inputFile);

    Console.WriteLine($"Complete Score (Part 1) after all Matches is {guide.ScoreFromPart1}");
    Console.WriteLine($"Complete Score (Part 2) after all Matches is {guide.ScoreFromPart2}");
});