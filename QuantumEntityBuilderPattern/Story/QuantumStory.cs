namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a customizable quantum story composed of elements that implement <see cref="IQuantumStoryElement"/>.
/// Maintains an ordered collection of story elements, allowing dynamic construction of a story sequence.
/// Provides methods to add new elements and to render the entire story as a sequence of formatted strings,
/// enabling flexible composition and output of various story components such as actions or narrative lines.
/// </summary>
public class QuantumStory<TElement> where TElement : IQuantumStoryElement
{
    private readonly List<TElement> _elements = new();

    public void AddElement(TElement element) => _elements.Add(element);

    public IEnumerable<string> RenderStory()
    {
        foreach (var element in _elements)
            yield return element.Render();
    }
}
