namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a customizable quantum story composed of elements.
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
