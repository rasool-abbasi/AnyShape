using AnyShapeWithAbstract.Enum;

namespace AnyShapeWithAbstract.Concrat
{
    /// <summary>
    /// Class Calculate Area and Enviroment of a Triangle by Inheriting from the Class Abstract
    /// </summary>
    public class Triangle : Shaps
    {
        public Triangle(float _hight, float _base)
        {
            Hight = _hight;
            Base = _base;
        }
        public float Hight { get; set; }
        public float Base { get; set; }
        public override string Name => EnShaps.Triangle.ToString();

        public override float Area()
        {
            return Hight * Base / 2;
        }

        public override float Enviroment()
        {
            return 3 * Base;
        }
    }
}
