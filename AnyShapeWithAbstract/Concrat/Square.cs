using AnyShapeWithAbstract.Enum;

namespace AnyShapeWithAbstract.Concrat
{
    /// <summary>
    /// Class Calculate Area and Enviroment of a Square by Inheriting from the Class Abstract
    /// </summary>
    public class Square : Shaps
    {
        public Square(float _base)
        {
            Base = _base;
        }
        public float Base { get; set; }
        public override string Name => EnShaps.Square.ToString();

        public override float Area()
        {
            return Base*Base;
        }

        public override float Enviroment()
        {
            return 4*Base;
        }
    }
}
