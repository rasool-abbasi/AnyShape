using AnyShapeWithInterFace.Contract;
using AnyShapeWithInterFace.Enum;

namespace AnyShapeWithInterFace.Concrat
{
    public class Square : IAnyShape
    {
        public Square(float _base)
        {
            Base = _base;
        }
        public float Base { get; set; }
        string IAnyShape.TypeName
        {
            get { return EnShaps.Square.ToString(); }
        }

        float IAnyShape.Area()
        {
            return Base * Base;
        }

        float IAnyShape.Enviroment()
        {
            return 4 * Base;
        }
    }
}
