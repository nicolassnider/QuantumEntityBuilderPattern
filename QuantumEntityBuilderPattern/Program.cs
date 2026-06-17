using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

var factoryTypes = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(IQuantumExperimentFactory).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
    .ToList();

var experimentFactories = factoryTypes
    .Select(t => (IQuantumExperimentFactory)Activator.CreateInstance(t)!)
    .ToList();

while (true)
{
    Console.WriteLine("Available Experiments:");
    for (int i = 0; i < experimentFactories.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {experimentFactories[i].GetType().Name.Replace("ExperimentFactory", "")}");
    }
    Console.WriteLine($"{experimentFactories.Count + 1}. Run All Experiments");
    Console.WriteLine("q. Quit");
    Console.Write("\nSelect an option: ");
    
    var input = Console.ReadLine();
    if (input?.ToLower() == "q")
    {
        break;
    }
    
    if (int.TryParse(input, out int choice))
    {
        Console.Clear();
        if (choice >= 1 && choice <= experimentFactories.Count)
        {
            Console.WriteLine($"--- Running {experimentFactories[choice - 1].GetType().Name.Replace("ExperimentFactory", "")} Experiment ---\n");
            
            var selectedFactory = new List<IQuantumExperimentFactory> { experimentFactories[choice - 1] };
            var story = QuantumStoryFactory.Create(selectedFactory);
            
            foreach (var line in story.RenderStory())
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\n--------------------------------------------------\n");
        }
        else if (choice == experimentFactories.Count + 1)
        {
            Console.WriteLine($"--- Running All Experiments ---\n");
            var story = QuantumStoryFactory.Create(experimentFactories);
            
            foreach (var line in story.RenderStory())
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\n--------------------------------------------------\n");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.\n");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.\n");
    }
}
