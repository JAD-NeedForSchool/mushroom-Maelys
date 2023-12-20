using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Decorators
{
    public class ParlantDecorator : ChampignonDecorator
    {
        public ParlantDecorator(IChampignon champignon) : base(champignon) { }

        public override string Spore()
        {
            return "OUAH ! " + base.Spore();
        }
    }
}
