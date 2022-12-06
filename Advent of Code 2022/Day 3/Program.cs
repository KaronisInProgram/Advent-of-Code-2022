using Cocona;
using Day_3.Backpack;
using System;

CoconaLiteApp.Run(([Argument(Description = "Path to the Input File", Name = nameof(inputFile))] string inputFile) =>
{
    var listWithBackpacks = BackpackListCreator.Create(inputFile);

    var priority = listWithBackpacks.Sum(backpack => Backpack.CalculateItemPriority(backpack.DuplicateInComponents));
    var badgePriority = listWithBackpacks
        .Chunk(3)
        .Select(backpack => backpack[0].Items.Distinct().Single(item => backpack[1].Items.Contains(item) && backpack[2].Items.Contains(item)))
        .Select(Backpack.CalculateItemPriority)
        .Sum();

    Console.WriteLine($"Complete Score (Part 1) of all item priorities is {priority}");
    Console.WriteLine($"Complete Score (Part 2) of all elfen groups (badge priority) is {badgePriority}");
});