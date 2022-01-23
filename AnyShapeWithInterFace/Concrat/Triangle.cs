using AnyShapeWithInterFace.Contract;
using AnyShapeWithInterFace.Enum;

namespace AnyShapeWithInterFace.Concrat
{
    public class Triangle : IAnyShape
    {
        public Triangle(float _hight, float _base)
        {
            Hight = _hight;
            Base = _base;
        }
        string IAnyShape.TypeName
        {
            get { return EnShaps.Triangle.ToString(); }
        }
        public float Hight { get; set; }
        public float Base { get; set; }

        float IAnyShape.Area()
        {
            return Hight * Base / 2;
        }

        float IAnyShape.Enviroment()
        {
           return 3 * Base;
        }
    }
}
