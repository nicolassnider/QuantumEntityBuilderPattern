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
    void BuildState();

    /// <summary>
    /// Gets the constructed entity.
    /// </summary>
    SchrodingerEntity GetEntity();
}
