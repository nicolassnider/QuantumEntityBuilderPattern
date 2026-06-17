using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Story;

namespace QuantumEntityBuilderPattern.Factory;

public class ButterflyExperimentFactory : IQuantumExperimentFactory
{
    public SchrodingerEntity CreateEntity() => new SchrodingerButterfly();
    public IStoryScenario CreateScenario() => new HandScenario();
}
