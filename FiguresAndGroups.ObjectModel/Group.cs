using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAndGroups.ObjectModel
{
    public abstract class Group : IMeasurable
    {
        protected ICollection<IMeasurable> group;
        public IMeasure Measure {get;set;}

        public virtual void Add(IMeasurable item)
        {
            group.Add(item);
        }

        public void Delete(IMeasurable item)
        {
            group.Remove(item);
        }

        public virtual double GetMeasure()
        {
            return Measure.GetResult();
        }
    }
}
