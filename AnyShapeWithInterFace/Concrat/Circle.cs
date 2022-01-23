using AnyShapeWithInterFace.Contract;
using AnyShapeWithInterFace.Enum;

namespace AnyShapeWithInterFace.Concrat
{
    /// <summary>
    /// Class Shape Circle
    /// </summary>
    public class Circle : IAnyShape
    {
        public Circle(float _radius)
        {
            Radius = _radius;
        }
        string IAnyShape.TypeName
        { 
            get {return EnShaps.Circle.ToString() ; } 
        }
        /// <summary>
        /// Radius
        /// </summary>
        public float Radius { get; set; }
        /// <summary>
        /// ratio of the circumference of a circle to its diameter 
        /// </summary>
        private float p = 3.14F;
        float IAnyShape.Area()
        {
            return Radius * Radius * p;
        }

        float IAnyShape.Enviroment()
        {
            return 2 * Radius * p;
        }
    }
}
