namespace QuantumEntityBuilderPattern.Story;
/// <summary>
/// Represents an action in the quantum story.
/// </summary>
public class ActionLine : IQuantumStoryElement
{
    public string ActionText { get; }

    public ActionLine(string actionText) => ActionText = actionText;

    public string Render() => $"[Action] {ActionText}";
}
