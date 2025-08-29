namespace QuantumEntityBuilderPattern.Quantum;

/// <summary>
/// Represents a quantum state: superposition (unknown) or observed (known value).
/// </summary>
public sealed class QuantumState<T>
{
    private readonly T? _value;
    private readonly bool _isObserved;

    private QuantumState(T? value, bool isObserved)
    {
        _value = value;
        _isObserved = isObserved;
    }

    public static QuantumState<T> Superposition() => new(default, false);
    public static QuantumState<T> Observed(T value) => new(value, true);

    public bool IsObserved => _isObserved;
    public T Value => _isObserved
        ? _value!
        : throw new InvalidOperationException("State is in superposition.");

    // Monad Bind
    public QuantumState<TResult> Bind<TResult>(Func<T, QuantumState<TResult>> func) =>
        _isObserved ? func(_value!) : QuantumState<TResult>.Superposition();

    // Functor Map
    public QuantumState<TResult> Map<TResult>(Func<T, TResult> func) =>
        _isObserved ? QuantumState<TResult>.Observed(func(_value!)) : QuantumState<TResult>.Superposition();
}
