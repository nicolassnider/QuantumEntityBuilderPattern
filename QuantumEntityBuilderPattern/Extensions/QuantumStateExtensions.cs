namespace QuantumEntityBuilderPattern.Quantum;

/// <summary>
/// Provides extension methods for the <see cref="QuantumState{T}"/> monad, specifically for <see cref="QuantumState{bool}"/>.
/// These methods offer convenient, domain-specific operations for interpreting and displaying the quantum state
/// of entities, such as determining if the state is in superposition or observed, and generating a user-friendly status string.
///
/// Typical usage includes rendering the state of quantum-inspired entities (e.g., alive, dead, or superposition)
/// in a readable format for storytelling, diagnostics, or UI purposes.
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
