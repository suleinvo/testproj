using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAndGroups.ObjectModel
{
    public abstract class Figure : IMeasurable
    {
        public IMeasure Measure { get; set; }

        public virtual double GetMeasure()
        {
            return Measure.GetResult();
        }
    }
}
