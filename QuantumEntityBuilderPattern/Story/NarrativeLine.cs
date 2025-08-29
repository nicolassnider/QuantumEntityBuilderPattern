namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a simple narrative line within a quantum story.
/// Implements <see cref="IQuantumStoryElement"/> to provide a consistent interface
/// for rendering narrative text as part of the story sequence.
/// Encapsulates the narrative content and returns it directly when rendered.
/// </summary>
public class NarrativeLine : IQuantumStoryElement
{
    public string Text { get; }

    public NarrativeLine(string text) => Text = text;

    public string Render() => Text;
}
