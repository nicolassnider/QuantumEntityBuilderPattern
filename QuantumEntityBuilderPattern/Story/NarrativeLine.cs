namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a simple narrative line in the story.
/// </summary>
public class NarrativeLine : IQuantumStoryElement
{
    public string Text { get; }

    public NarrativeLine(string text) => Text = text;

    public string Render() => Text;
}
