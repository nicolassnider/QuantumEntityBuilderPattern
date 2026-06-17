using System;
using System.Collections.Generic;
using QuantumEntityBuilderPattern.Factory;
using QuantumEntityBuilderPattern.Story;

/// <summary>
/// Entry point for the QuantumEntityBuilderPattern demonstration.
///
/// This program narrates a quantum-inspired story using the Abstract Factory and Strategy design patterns.
/// It creates quantum entities (like a cat and a butterfly) and their corresponding narrative scenarios,
/// reflecting the famous Schrödinger's thought experiments.
///
/// Key features demonstrated:
/// - Use of Abstract Factory pattern to create related families of objects (Entities and Scenarios).
/// - Use of Strategy pattern to dynamically select how an entity's story is told.
/// - Clean architecture adhering to SOLID (Open/Closed Principle) and DRY principles.
/// </summary>

Console.WriteLine("--- Quantum Entity Narrative Simulator ---\n");

var experimentFactories = new List<IQuantumExperimentFactory>
{
    new CatExperimentFactory(),
    new ButterflyExperimentFactory()
};

var story = QuantumStoryFactory.Create(experimentFactories);

foreach (var line in story.RenderStory())
{
    Console.WriteLine(line);
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
