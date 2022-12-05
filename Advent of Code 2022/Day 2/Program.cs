using Cocona;
using Day_2.Guide;

CoconaLiteApp.Run(([Argument(Description = "Path to the Input File", Name = nameof(inputFile))] string inputFile) =>
{
    var guide = GuideCreator.Create(inputFile);

    Console.WriteLine($"Complete Score after all Matches is {guide.Score}");
});