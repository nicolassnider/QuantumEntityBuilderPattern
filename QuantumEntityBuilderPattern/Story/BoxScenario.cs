using System;
using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Story;

public class BoxScenario : IStoryScenario
{
    public void AppendToStory(QuantumStory<IQuantumStoryElement> story, SchrodingerEntity entity)
    {
        string name = entity.EntityName;
        string capitalizedName = char.ToUpper(name[0]) + name.Substring(1);

        story.AddElement(new NarrativeLine($"Suppose you put a {name} in a box..."));
        story.AddElement(new NarrativeLine("Inside the box, there is a mechanism that may or may not release a poisonous gas."));
        story.AddElement(new NarrativeLine($"Until you open the box, you do not know whether the gas has been released, or if the {name} is alive or dead."));
        story.AddElement(new NarrativeLine($"{capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})"));
        story.AddElement(new UserDecisionLine(
            $"Do you open the box to observe the {name}'s fate?",
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
                    return $"You decided to leave the box closed. {capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})\n";
                }
                
                string outcomeText = entity.State.GetStatus() == "Alive" 
                    ? $"When you open the box, you see the {name} is alive!" 
                    : $"When you open the box, you see the {name} is dead.\n*Shame on you.*";
                
                return $"{outcomeText}\n{capitalizedName} status: {entity.State.GetStatus()} (Superposition? {entity.State.IsInSuperposition()})\n";
            }
        ));
    }
}
