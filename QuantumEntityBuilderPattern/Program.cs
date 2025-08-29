using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Extensions;
using QuantumEntityBuilderPattern.Factory;
using QuantumEntityBuilderPattern.Quantum;

/// <summary>
/// Tells a quantum story: a butterfly in your hand, illustrating superposition and observation.
/// Demonstrates use of extension methods and the QuantumState monad for quantum state analysis.
/// </summary>
var butterflyFactory = new SchrodingerFactory(new ButterflyBuilder());

// The butterfly starts in superposition
var butterfly = butterflyFactory.CreateEntity();

Console.WriteLine("Suppose you have a butterfly in your hand.");
Console.WriteLine("You close your hand and squash it.");
Console.WriteLine("But you will never know the state of the butterfly until you open your hand.");
Console.WriteLine();

Console.WriteLine("Current quantum state (before observation):");
Console.WriteLine(butterfly.Describe());
Console.WriteLine($"Butterfly status: {butterfly.State.ToQuantumString()}");

butterfly.State.IfSuperposition(() =>
{
    Console.WriteLine("The butterfly's fate is undetermined until you look.");
});

Console.WriteLine();
Console.WriteLine("Now, suppose you open your hand and observe the butterfly...");

// Simulate observation: collapse the state (for demonstration, randomly alive or dead)
var random = new Random();
bool observedState = random.Next(2) == 0;
butterfly.SetState(QuantumState<bool>.Observed(observedState));

Console.WriteLine(butterfly.Describe());
Console.WriteLine($"Butterfly status: {butterfly.State.ToQuantumString()}");

butterfly.State.IfObserved(val =>
{
    Console.WriteLine(val ? "You see the butterfly flutter away!" : "You see the butterfly is still.");
});

Console.ReadKey();
