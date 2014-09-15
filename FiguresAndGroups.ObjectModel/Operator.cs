using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAndGroups.ObjectModel
{
    public abstract class Operator : IMeasure
    {
        protected ICollection<IMeasurable> elemsCollection;

        public Operator(ICollection<IMeasurable> elems)
        {
            elemsCollection = elems;
        }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
