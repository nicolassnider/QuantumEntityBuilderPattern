namespace QuantumEntityBuilderPattern.Entities;
public class SchrodingerDog : SchrodingerEntity
{
    public override string Describe() =>
        IsAlive == null ? "The dog is in a superposition of states." :
        IsAlive == true ? "The dog is alive." :
        "The dog is dead.";
}
