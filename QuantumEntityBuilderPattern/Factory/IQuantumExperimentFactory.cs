using QuantumEntityBuilderPattern.Entities;
using QuantumEntityBuilderPattern.Story;

namespace QuantumEntityBuilderPattern.Factory;

public interface IQuantumExperimentFactory
{
    SchrodingerEntity CreateEntity();
    IStoryScenario CreateScenario();
}
