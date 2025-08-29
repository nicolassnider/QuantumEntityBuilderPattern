using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Quantum;

namespace QuantumEntityBuilderPattern.Builders;


/// <summary>
/// Generic base class for Schrodinger entity builders.
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
