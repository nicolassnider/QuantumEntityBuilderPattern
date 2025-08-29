namespace QuantumEntityBuilderPattern.Entities;
public abstract class SchrodingerEntity
{
    public bool? IsAlive { get; protected set; }

    public void SetState(bool? isAlive)
    {
        IsAlive = isAlive;
    }

    public abstract string Describe();
}
