using System.Collections.Generic;
using QuantumEntityBuilderPattern.Factory;

namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Provides factory methods for constructing quantum stories involving quantum-inspired entities.
/// It uses a collection of <see cref="IQuantumExperimentFactory"/> to dynamically generate the story
/// by creating entities and appending their respective scenarios, adhering to OCP and DRY principles.
/// </summary>
public static class QuantumStoryFactory
{
    public static QuantumStory<IQuantumStoryElement> Create(IEnumerable<IQuantumExperimentFactory> experimentFactories)
    {
        var story = new QuantumStory<IQuantumStoryElement>();

        foreach (var factory in experimentFactories)
        {
            var entity = factory.CreateEntity();
            var scenario = factory.CreateScenario();
            
            scenario.AppendToStory(story, entity);
        }

        return story;
    }
}
