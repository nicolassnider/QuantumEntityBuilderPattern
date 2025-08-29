using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Builders;


/// <summary>
/// Generic abstract base class for quantum entity builders, implementing the <see cref="ISchrodingerBuilder"/> interface.
/// <para>
/// <see cref="SchrodingerBuilderBase{T}"/> provides reusable logic for constructing quantum-inspired entities
/// (such as cats, dogs, or butterflies) that inherit from <see cref="SchrodingerEntity"/>.
/// </para>
/// <para>
/// It encapsulates the process of initializing the entity's quantum state using a functional configuration delegate,
/// supporting scenarios such as superposition, alive, or dead states. The builder pattern enables flexible,
/// extensible, and testable creation of quantum entities by decoupling construction logic from entity representation.
/// </para>
/// </summary>
public abstract class SchrodingerBuilderBase<T> : ISchrodingerBuilder where T : SchrodingerEntity, new()
{
    private T _entity = new();

    public void BuildState(Func<bool?>? stateConfigurator = null)
    {
        bool? state = stateConfigurator?.Invoke();
        QuantumState<bool> quantumState = state switch
        {
            null => QuantumState<bool>.Superposition(),
            bool value => QuantumState<bool>.Observed(value)
        };
        _entity.SetState(quantumState);
    }

    public SchrodingerEntity GetEntity()
    {
        var result = _entity;
        _entity = new T();
        return result;
    }
}
