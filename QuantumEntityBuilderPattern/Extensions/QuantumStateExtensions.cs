namespace QuantumEntityBuilderPattern.Quantum;

/// <summary>
/// Extension methods for QuantumState monad.
/// </summary>
public static class QuantumStateExtensions
{
    public static string GetStatus(this QuantumState<bool> state) =>
        !state.IsObserved ? "Superposition"
        : state.Value ? "Alive"
        : "Dead";

    public static bool IsInSuperposition(this QuantumState<bool> state) =>
        !state.IsObserved;
}
