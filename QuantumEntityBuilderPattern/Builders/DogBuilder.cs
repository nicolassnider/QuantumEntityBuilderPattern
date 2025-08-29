using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Builders;
public class DogBuilder : ISchrodingerBuilder
{
    private SchrodingerDog _dog = new SchrodingerDog();
    public void BuildState()
    {
        _dog.SetState(null); // Dog starts in superposition
    }

    public SchrodingerEntity GetEntity()
    {
        return _dog;
    }
}
