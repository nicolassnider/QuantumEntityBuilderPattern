namespace QuantumEntityBuilderPattern.Quantum;

/// <summary>
/// Represents a quantum state that can be either in superposition (unknown, unobserved)
/// or collapsed to an observed value. This class models the quantum concept of measurement,
/// where the state remains indeterminate until observed, at which point it becomes a known value.
///
/// Provides monadic operations (Bind and Map) for functional composition, allowing safe and
/// expressive manipulation of quantum states in a type-safe manner.
///
/// Typical usage includes representing the state of quantum-inspired entities (e.g., alive/dead/superposition)
/// and simulating the process of quantum observation and state collapse.
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
