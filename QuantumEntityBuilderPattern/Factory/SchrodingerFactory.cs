using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Factory;

/// <summary>
/// Implements the Factory design pattern to create quantum entities using a provided builder.
/// The <see cref="SchrodingerFactory"/> decouples the construction process from the entity representation,
/// allowing flexible creation of different quantum entities (such as cats, dogs, or butterflies) in a quantum-inspired state.
///
/// The factory leverages an <see cref="ISchrodingerBuilder"/> to encapsulate the construction logic,
/// and supports functional configuration of the entity's quantum state via an optional delegate.
/// This enables scenarios such as superposition, alive, or dead states, and allows for extensible, testable, and maintainable code.
/// </summary>
/// 
public class SchrodingerFactory
{
    private readonly ISchrodingerBuilder _builder;

    /// <summary>
    /// Implements the Factory design pattern for quantum entities, enabling flexible and decoupled creation
    /// of quantum-inspired objects (such as cats, dogs, or butterflies) in various quantum states.
    /// 
    /// <para>
    /// The <see cref="SchrodingerFactory"/> uses an <see cref="ISchrodingerBuilder"/> to encapsulate the construction
    /// logic for each entity type. It supports functional configuration of the entity's quantum state via an optional
    /// delegate, allowing scenarios such as superposition, alive, or dead states.
    /// </para>
    /// 
    /// <para>
    /// This approach promotes extensibility, testability, and maintainability by separating the entity creation process
    /// from its representation and state management. The factory is suitable for demonstrating quantum concepts and
    /// design patterns in a clear and reusable manner.
    /// </para>
    /// </summary>
    public SchrodingerFactory(ISchrodingerBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Creates a new quantum entity using the configured builder, with optional functional state configuration.
    /// This method delegates the construction process to the underlying <see cref="ISchrodingerBuilder"/>,
    /// allowing the caller to specify a <paramref name="stateConfigurator"/> delegate to determine the entity's
    /// initial quantum state (e.g., superposition, alive, or dead).
    ///
    /// The resulting <see cref="SchrodingerEntity"/> will have its state set according to the provided configuration,
    /// supporting scenarios that require dynamic or randomized quantum state assignment.
    /// </summary>
    /// <param name="stateConfigurator">
    /// Optional function to configure the entity's quantum state in a functional style.
    /// If not provided, the entity will be initialized in a default superposition state.
    /// </param>
    /// <returns>
    /// The constructed <see cref="SchrodingerEntity"/> instance with its quantum state set.
    /// </returns>
    public SchrodingerEntity CreateEntity(Func<bool?>? stateConfigurator = null)
    {
        _builder.BuildState(stateConfigurator);
        return _builder.GetEntity();
    }
}
