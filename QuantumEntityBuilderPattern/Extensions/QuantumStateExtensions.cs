using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Extensions;

/// <summary>
/// Extension methods for QuantumState monad.
/// </summary>
public static class QuantumStateExtensions
{
    /// <summary>
    /// Returns a string representation of the quantum state.
    /// </summary>
    public static string ToQuantumString<T>(this QuantumState<T> state)
    {
        return state.IsObserved
            ? $"Observed: {state.Value}"
            : "Superposition (unknown)";
    }

    /// <summary>
    /// Executes an action if the state is observed.
    /// </summary>
    public static void IfObserved<T>(this QuantumState<T> state, Action<T> action)
    {
        if (state.IsObserved)
            action(state.Value);
    }

    /// <summary>
    /// Executes an action if the state is in superposition.
    /// </summary>
    public static void IfSuperposition<T>(this QuantumState<T> state, Action action)
    {
        if (!state.IsObserved)
            action();
    }
}
