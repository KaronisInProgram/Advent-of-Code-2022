using Cocona;
using Day_1.Elf;

CoconaLiteApp.Run(([Argument(Description = "Path to the Input File", Name = nameof(inputFile))] string inputFile) =>
{
    var topThreeCarriers = CarrierListCreator.Create(inputFile).Select(elf => elf.Values.Sum(element => element)).OrderDescending().Take(3);

    foreach (var topCarrier in topThreeCarriers)
    {
        Console.WriteLine($"Most calories carried by an elf was {topCarrier}");
    }

    Console.WriteLine($"Total top-three-carrier value {topThreeCarriers.Sum()}");
});