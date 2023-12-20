using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushrooms.Champignons
{
    public class AbstractChampignon : IChampignon

    {
        private string _spore;
        public AbstractChampignon(string spore) {
            this._spore = spore;
        }

        public string Spore()
        {
            return this._spore;
        }
    }
}
