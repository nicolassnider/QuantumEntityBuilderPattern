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
        var result = _dog;
        _dog = new SchrodingerDog(); // Reset for next build
        return result;
    }
}
