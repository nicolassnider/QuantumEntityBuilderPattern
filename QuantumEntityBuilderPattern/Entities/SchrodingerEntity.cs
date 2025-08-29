using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Entities;

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
