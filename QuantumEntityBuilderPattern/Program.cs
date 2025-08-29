using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Extensions; // Import extension methods
using QuantumEntityBuilderPattern.Factory;

/// <summary>
/// Tells a quantum story: a cat in a box and a butterfly in a hand.
/// Demonstrates use of extension methods for quantum state analysis.
/// </summary>
var catFactory = new SchrodingerFactory(new CatBuilder());
var butterflyFactory = new SchrodingerFactory(new ButterflyBuilder());

// Both start in superposition
var cat = catFactory.CreateEntity();
var butterfly = butterflyFactory.CreateEntity();

Console.WriteLine("Suppose you put a cat in a box...");
Console.WriteLine(cat.Describe());
Console.WriteLine($"Cat status: {cat.GetStatus()} (Superposition? {cat.IsInSuperposition()})");
Console.WriteLine();

Console.WriteLine("Suppose you put a butterfly in your hand...");
Console.WriteLine(butterfly.Describe());
Console.WriteLine($"Butterfly status: {butterfly.GetStatus()} (Superposition? {butterfly.IsInSuperposition()})");

Console.ReadKey();
