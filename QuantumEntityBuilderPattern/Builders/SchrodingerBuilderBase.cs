using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Builders;

/// <summary>
/// Generic base class for Schrodinger entity builders.
/// </summary>
public abstract class SchrodingerBuilderBase<T> : ISchrodingerBuilder where T : SchrodingerEntity, new()
{
    private T _entity = new();

    public void BuildState(Func<bool?>? stateConfigurator = null)
    {
        _entity.SetState(stateConfigurator?.Invoke() ?? null);
    }

    public SchrodingerEntity GetEntity()
    {
        var result = _entity;
        _entity = new T();
        return result;
    }
}
