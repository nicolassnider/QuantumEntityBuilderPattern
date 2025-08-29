using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Builders;
public interface ISchrodingerBuilder
{
    void BuildState();

    SchrodingerEntity GetEntity();

}
