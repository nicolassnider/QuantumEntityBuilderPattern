using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Story;

public interface IStoryScenario
{
    void AppendToStory(QuantumStory<IQuantumStoryElement> story, SchrodingerEntity entity);
}
