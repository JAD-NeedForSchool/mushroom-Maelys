using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Decorators
{
    public class RadioactifDecorator : ChampignonDecorator
    {
        public RadioactifDecorator(IChampignon champignon) : base(champignon) { }

        public override string Spore()
        {
            return "BEURK " + base.Spore();
        }
    }
}
