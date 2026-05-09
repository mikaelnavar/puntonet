string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

//Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

string[] pallets2 = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets2[0].ToLower()}");
Array.Clear(pallets2, 0, 2);
Console.WriteLine($"After: {pallets2[0].ToLower()}");

Console.WriteLine($"Clearing 2...count: {pallets2.Length}");
foreach (var pallet in pallets2)
{
    Console.WriteLine($"--{pallet}");
}

