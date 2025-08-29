using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Extensions;
/// <summary>
/// Extension methods for SchrodingerEntity and its derived types.
/// </summary>
public static class SchrodingerEntityExtensions
{
    /// <summary>
    /// Returns true if the entity is in a superposition of states.
    /// </summary>
    public static bool IsInSuperposition(this SchrodingerEntity entity) =>
        entity.IsAlive is null;

    /// <summary>
    /// Returns true if the entity is alive.
    /// </summary>
    public static bool IsAliveState(this SchrodingerEntity entity) =>
        entity.IsAlive == true;

    /// <summary>
    /// Returns true if the entity is dead.
    /// </summary>
    public static bool IsDeadState(this SchrodingerEntity entity) =>
        entity.IsAlive == false;

    /// <summary>
    /// Returns a short status string for the entity.
    /// </summary>
    public static string GetStatus(this SchrodingerEntity entity) =>
        entity.IsAlive is null ? "Superposition"
        : entity.IsAlive == true ? "Alive"
        : "Dead";
}
