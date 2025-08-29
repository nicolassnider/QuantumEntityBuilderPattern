using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Factory;
using QuantumEntityBuilderPattern.Story;

/// <summary>
/// Entry point for the QuantumEntityBuilderPattern demonstration.
///
/// This program narrates a quantum-inspired story using the Builder and Factory design patterns.
/// It creates quantum entities (a cat and a butterfly) that exist in a superposition of states
/// until observed, reflecting the famous Schrödinger's Cat thought experiment.
///
/// The story logic is encapsulated in the QuantumStoryFactory, which builds a customizable
/// sequence of narrative and action elements. The quantum state of each entity is randomly
/// determined upon "observation," and the story output reflects the result, including humorous
/// or moral commentary for certain outcomes.
///
/// Key features demonstrated:
/// - Use of Builder and Factory patterns for flexible entity creation.
/// - Modular, extensible story construction using generic and interface-based elements.
/// - Simulation of quantum superposition and state collapse upon observation.
/// - Clear separation of story logic from program orchestration for maintainability.
/// </summary>

var catFactory = new SchrodingerFactory(new CatBuilder());
var butterflyFactory = new SchrodingerFactory(new ButterflyBuilder());

var cat = catFactory.CreateEntity();
var butterfly = butterflyFactory.CreateEntity();

var story = QuantumStoryFactory.Create(cat, butterfly);

foreach (var line in story.RenderStory())
    Console.WriteLine(line);

Console.ReadKey();
