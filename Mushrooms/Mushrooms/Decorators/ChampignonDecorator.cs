using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Decorators
{
    public abstract class ChampignonDecorator : IChampignon
    {
        protected IChampignon champignon;

        public ChampignonDecorator(IChampignon champignon)
        {
            this.champignon = champignon;
        }

        public virtual string Spore()
        {
            return champignon.Spore();
        }
    }

}
