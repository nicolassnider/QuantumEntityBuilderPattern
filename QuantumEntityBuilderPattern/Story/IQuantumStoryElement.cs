namespace QuantumEntityBuilderPattern.Story;
/// <summary>
/// Defines a contract for elements that compose a quantum story.
/// Implementing types must provide a string representation of the element
/// via the <see cref="Render"/> method, enabling consistent rendering of
/// various story components such as actions, events, or narrative lines.
/// </summary>
public interface IQuantumStoryElement
{

    string Render();
}
