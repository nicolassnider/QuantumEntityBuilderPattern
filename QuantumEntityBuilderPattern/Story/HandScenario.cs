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
        story.AddElement(new UserDecisionLine(
            $"Do you crush your hand?",
            decision => 
            {
                if (decision)
                {
                    bool outcome = new Random().Next(2) == 0;
                    entity.Observe(outcome);
                }
            },
            decision => 
            {
                if (!decision)
                {
                    return $"You decided to spare the {name}. {capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})\n";
                }
                
                string outcomeText = entity.State.GetStatus() == "Alive" 
                    ? $"When you open your hand, the {name} is alive and flies away!" 
                    : $"When you open your hand, the {name} is dead.\n*Shame on you.*";
                
                return $"{outcomeText}\n{capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})\n";
            }
        ));
    }
}
