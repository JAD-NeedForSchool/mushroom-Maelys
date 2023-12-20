using Mushrooms.Decorators;
using Mushrooms;

public class RampantDecorator : ChampignonDecorator
{
    public RampantDecorator(IChampignon champignon) : base(champignon) { }

    public override string Spore()
    {
        return "SLURP ! " + base.Spore();
    }
}