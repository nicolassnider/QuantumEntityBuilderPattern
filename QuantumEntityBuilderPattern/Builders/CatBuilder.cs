using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Builders;
public class CatBuilder : ISchrodingerBuilder
{
    private SchrodingerCat _cat = new SchrodingerCat();
    public void BuildState()
    {
        _cat.SetState(null); // Cat starts in superposition
    }

    public SchrodingerEntity GetEntity()
    {
        return _cat;
    }
}
