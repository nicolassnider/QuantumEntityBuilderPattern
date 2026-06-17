using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Story;

namespace QuantumEntityBuilderPattern.Factory;

public class CatExperimentFactory : IQuantumExperimentFactory
{
    public SchrodingerEntity CreateEntity() => new SchrodingerCat();
    public IStoryScenario CreateScenario() => new BoxScenario();
}
