namespace QuantumEntityBuilderPattern.Story;
/// <summary>
/// Represents a single action within a quantum story sequence.
/// Implements <see cref="IQuantumStoryElement"/> to allow rendering as part of a story.
/// Encapsulates the action's descriptive text and provides a formatted string representation
/// for inclusion in story outputs or logs.
/// </summary>
public class ActionLine : IQuantumStoryElement
{
    public string ActionText { get; }

    public ActionLine(string actionText) => ActionText = actionText;

    public string Render() => $"[Action] {ActionText}";
}
