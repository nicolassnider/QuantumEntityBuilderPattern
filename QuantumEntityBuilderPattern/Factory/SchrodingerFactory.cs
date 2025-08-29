using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Factory;
public class SchrodingerFactory
{
    private ISchrodingerBuilder _builder;
    public SchrodingerFactory(ISchrodingerBuilder builder)
    {
        _builder = builder;
    }

    public SchrodingerEntity CreateEntity()
    {
        _builder.BuildState();
        return _builder.GetEntity();
    }
}
