namespace QuantumEntityBuilderPattern.Entities;

/// <summary>
/// Abstract base class for quantum entities that can be alive, dead, or in superposition.
/// </summary>
public abstract class SchrodingerEntity
{
    /// <summary>
    /// Gets the quantum state: true (alive), false (dead), or null (superposition).
    /// </summary>
    public bool? IsAlive { get; protected set; }

    /// <summary>
    /// The display name of the entity (e.g., "cat", "dog", "butterfly").
    /// </summary>
    protected abstract string EntityName { get; }

    /// <summary>
    /// Sets the quantum state.
    /// </summary>
    /// <param name="isAlive">The state to set: true, false, or null.</param>
    public void SetState(bool? isAlive)
    {
        IsAlive = isAlive;
    }

    /// <summary>
    /// Describes the current quantum state.
    /// </summary>
    /// <returns>A string description of the state.</returns>
    public virtual string Describe() =>
        IsAlive == null ? $"The {EntityName} is in a superposition of states."
        : IsAlive == true ? $"The {EntityName} is alive."
        : $"The {EntityName} is dead.";
}
