namespace QuantumEntityBuilderPattern.Entities;
public class SchrodingerCat : SchrodingerEntity
{
    public override string Describe() =>
        IsAlive == null ? "The cat is in a superposition of states." :
        IsAlive == true ? "The cat is alive." :
        "The cat is dead.";
}
