using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAndGroups.ObjectModel
{
    public interface IMeasure
    {
        double GetResult();
    }

    public interface IMeasurable
    {
        IMeasure Measure { get; set; }
        double GetMeasure();
    }
}
