using AnyShapeWithAbstract.Enum;

namespace AnyShapeWithAbstract.Concrat
{
    /// <summary>
    /// Class Calculate Area and Enviroment of a Circle by Inheriting from the Class Abstract
    /// </summary>
    public class Circle : Shaps
    {
        public Circle(float _radius)
        {
         Radius = _radius;
        }
        public float Radius { get; set; }
        public float p = 3.14F;
        public override string Name => EnShaps.Circle.ToString();

        public override float Area()
        {
           return Radius * Radius * p;
        }

        public override float Enviroment()
        {
            return 2 * Radius * p;
        }
    }
}
