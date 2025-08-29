using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Story;
public static class QuantumStoryFactory
{
    public static QuantumStory<IQuantumStoryElement> Create(SchrodingerEntity cat, SchrodingerEntity butterfly)
    {
        var story = new QuantumStory<IQuantumStoryElement>();

        // Cat story
        story.AddElement(new NarrativeLine("Suppose you put a cat in a box..."));
        story.AddElement(new NarrativeLine("Inside the box, there is a mechanism that may or may not release a poisonous gas."));
        story.AddElement(new NarrativeLine("Until you open the box, you do not know whether the gas has been released, or if the cat is alive or dead."));
        story.AddElement(new NarrativeLine($"Cat status: {cat.State.GetStatus()} (Superposition? {cat.State.IsInSuperposition()})"));
        story.AddElement(new ActionLine("You open the box to observe the cat's fate."));

        // Collapse the cat's state and add the outcome line
        bool catOutcome = new Random().Next(2) == 0;
        cat.SetState(QuantumState<bool>.Observed(catOutcome));
        if (catOutcome)
        {
            story.AddElement(new NarrativeLine("When you open the box, you see the cat is alive!"));
        }
        else
        {
            story.AddElement(new NarrativeLine("When you open the box, you see the cat is dead."));
            story.AddElement(new ActionLine("Shame on you."));
        }
        story.AddElement(new NarrativeLine($"Cat status: {cat.State.GetStatus()} (Superposition? {cat.State.IsInSuperposition()})"));
        story.AddElement(new NarrativeLine(""));

        // Butterfly story
        story.AddElement(new NarrativeLine("Suppose you put a butterfly in your hand..."));
        story.AddElement(new NarrativeLine($"Butterfly status: {butterfly.State.GetStatus()} (Superposition? {butterfly.State.IsInSuperposition()})"));
        story.AddElement(new ActionLine("You crush your hand."));
        bool butterflyOutcome = new Random().Next(2) == 0;
        butterfly.SetState(QuantumState<bool>.Observed(butterflyOutcome));
        if (butterflyOutcome)
        {
            story.AddElement(new NarrativeLine("When you open your hand, the butterfly is alive and flies away!"));
        }
        else
        {
            story.AddElement(new NarrativeLine("When you open your hand, the butterfly is dead."));
            story.AddElement(new ActionLine("Shame on you."));
        }
        story.AddElement(new NarrativeLine($"Butterfly status: {butterfly.State.GetStatus()} (Superposition? {butterfly.State.IsInSuperposition()})"));

        return story;
    }
}
