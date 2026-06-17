using System;
using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Story;

public class HandScenario : IStoryScenario
{
    public void AppendToStory(QuantumStory<IQuantumStoryElement> story, SchrodingerEntity entity)
    {
        string name = entity.EntityName;
        string capitalizedName = char.ToUpper(name[0]) + name.Substring(1);

        story.AddElement(new NarrativeLine($"Suppose you put a {name} in your hand..."));
        story.AddElement(new NarrativeLine($"{capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})"));
        story.AddElement(new ActionLine("You crush your hand."));

        bool outcome = new Random().Next(2) == 0;
        entity.Observe(outcome);

        if (outcome)
        {
            story.AddElement(new NarrativeLine($"When you open your hand, the {name} is alive and flies away!"));
        }
        else
        {
            story.AddElement(new NarrativeLine($"When you open your hand, the {name} is dead."));
            story.AddElement(new ActionLine("Shame on you."));
        }
        
        story.AddElement(new NarrativeLine($"{capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})"));
        story.AddElement(new NarrativeLine(""));
    }
}
