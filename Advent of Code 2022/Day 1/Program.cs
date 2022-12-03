using Cocona;
using Day_1.Elf;

CoconaLiteApp.Run(([Argument(Description = "Path to the Input File", Name = nameof(inputFile))] string inputFile) =>
{
    var listCreator = new ElfListCreator();
    var elfen = listCreator.CreateList(inputFile);
    var topThreeCarriers = elfen.Select(elf => elf.OwnedValue()).OrderDescending().Take(3);

    foreach (var topCarrier in topThreeCarriers)
    {
        Console.WriteLine($"Most calories carried was {topCarrier}");
    }

    Console.WriteLine($"Total top-three-carrier valeu {topThreeCarriers.Sum()}");
});