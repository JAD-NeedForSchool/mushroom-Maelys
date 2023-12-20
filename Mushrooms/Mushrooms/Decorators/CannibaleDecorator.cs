using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Decorators
{
    public class CannibaleDecorator : ChampignonDecorator
    {
        public CannibaleDecorator(IChampignon champignon) : base(champignon) { }

        protected string SporeDecorated()
        {
            return "MIAM ! ";
        }
    }
}
