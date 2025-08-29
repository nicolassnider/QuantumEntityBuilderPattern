using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Entities;

/// <summary>
/// Abstract base class for quantum-inspired entities that can exist in a superposition of states
/// (unknown, unobserved) or in a collapsed, observed state (e.g., alive or dead).
/// 
/// <para>
/// Each <see cref="SchrodingerEntity"/> maintains a <see cref="QuantumState{bool}"/> representing its quantum state,
/// and exposes a descriptive interface for derived types (such as cat, dog, or butterfly) to specify their identity.
/// </para>
/// 
/// <para>
/// This class provides core functionality for setting and describing the entity's quantum state, modeling the
/// quantum measurement process where the state remains indeterminate until observed. It is intended to be
/// subclassed for specific quantum entities in scenarios that demonstrate quantum concepts and design patterns.
/// </para>
/// </summary>
/// 
public abstract class SchrodingerEntity
{
    public QuantumState<bool> State { get; protected set; } = QuantumState<bool>.Superposition();

    protected abstract string EntityName { get; }

    public void SetState(QuantumState<bool> state) => State = state;

    public virtual string Describe() =>
        !State.IsObserved ? $"The {EntityName} is in a superposition of states."
        : State.Value ? $"The {EntityName} is alive."
        : $"The {EntityName} is dead.";
}
