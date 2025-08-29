namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a story element that renders a random outcome as part of a quantum story.
/// When rendered, selects between two possible text outputs based on a random boolean value.
/// Optionally executes a callback with the outcome and allows injection of a custom randomization function
/// for deterministic or testable behavior.
/// </summary>
public class RandomOutcomeLine : IQuantumStoryElement
{
    private readonly string _ifTrue;
    private readonly string _ifFalse;
    private readonly Action<bool>? _onOutcome;
    private readonly Func<bool> _randomFunc;

    public RandomOutcomeLine(string ifTrue, string ifFalse, Action<bool>? onOutcome = null, Func<bool>? randomFunc = null)
    {
        _ifTrue = ifTrue;
        _ifFalse = ifFalse;
        _onOutcome = onOutcome;
        _randomFunc = randomFunc ?? (() => new Random().Next(2) == 0);
    }

    public string Render()
    {
        bool outcome = _randomFunc();
        _onOutcome?.Invoke(outcome);
        return outcome ? _ifTrue : _ifFalse;
    }
}
