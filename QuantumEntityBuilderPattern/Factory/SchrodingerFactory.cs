using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Factory;

/// <summary>
/// Factory for creating quantum entities using a builder.
/// </summary>
public class SchrodingerFactory
{
    private readonly ISchrodingerBuilder _builder;

    /// <summary>
    /// Initializes a new instance of the <see cref="SchrodingerFactory"/> class.
    /// </summary>
    /// <param name="builder">The builder to use for entity creation.</param>
    public SchrodingerFactory(ISchrodingerBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Creates a quantum entity, optionally configuring its state functionally.
    /// </summary>
    /// <param name="stateConfigurator">
    /// Optional function to configure the entity's state.
    /// </param>
    /// <returns>The created <see cref="SchrodingerEntity"/>.</returns>
    public SchrodingerEntity CreateEntity(Func<bool?>? stateConfigurator = null)
    {
        _builder.BuildState(stateConfigurator);
        return _builder.GetEntity();
    }
}
