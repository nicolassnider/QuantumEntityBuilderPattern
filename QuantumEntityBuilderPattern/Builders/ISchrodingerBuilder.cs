using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Builders;

/// <summary>
/// Builder interface for creating Schrodinger entities.
/// </summary>
public interface ISchrodingerBuilder
{
    /// <summary>
    /// Builds the quantum state of the entity.
    /// </summary>
    /// <param name="stateConfigurator">
    /// Optional function to configure the entity's state in a functional style.
    /// </param>
    void BuildState(Func<bool?>? stateConfigurator = null);

    /// <summary>
    /// Gets the constructed entity.
    /// </summary>
    /// <returns>The built <see cref="SchrodingerEntity"/>.</returns>
    SchrodingerEntity GetEntity();
}
