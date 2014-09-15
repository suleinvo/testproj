using FiguresAndGroups.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAndGroups.UserModelExample
{
    //Определяем меры
    public class PerimeterCircle : IMeasure
    {
        private double _radius;

        public PerimeterCircle(double radius)
        {
            _radius = radius;
        }

        public double GetResult()
        {
            return _radius * _radius * Math.PI;
        }
    }

    public class Perimeter : IMeasure
    {
        private ICollection<double> _params;

        public Perimeter(ICollection<double> param)
        {
            _params = param;
        }

        public double GetResult()
        {
            if (_params != null)
            {
                double result = 0;
                foreach (var p in _params)
                {
                    result += p;
                }
                return result;
            }
            throw new ArgumentException();
        }
    }

    //Пользователь создаёт фигуры

    public class Square : Figure
    {
        private List<double> _sides;

        public Square(List<double> sides)
        {
            if (sides != null) _sides = sides;
            this.Measure = new Perimeter(_sides);
        }
    }
    
    public class Tryangle : Figure
    {
        private List<double> _sides;

        public Tryangle(List<double> sides)
        {
            if (sides != null) _sides = sides;
            this.Measure = new Perimeter(_sides);
        }
    }

    public class Circle : Figure
    {
        private double _radius = 2;

        public Circle(double radius)
        {
            _radius = radius;
            this.Measure = new PerimeterCircle(_radius);
        }
    }

    //Оператор
    public class MyOperator : Operator
    { 
         public MyOperator(ICollection<IMeasurable> elems) : base(elems)
         {

         }

         public override double GetResult()
         {
             double result = 0;

             foreach (var elem in elemsCollection)
             {
                 result += elem.GetMeasure();
             }
              
             return result;
         }
         
    }

    //Создаём группу

    public class MyGroup : Group
    {
        //К примеру 
        public string GroupId = Guid.NewGuid().ToString();

        public MyGroup()
        {
            group = new List<IMeasurable>();
            Measure = new MyOperator(this.group);
        }
    }
}
