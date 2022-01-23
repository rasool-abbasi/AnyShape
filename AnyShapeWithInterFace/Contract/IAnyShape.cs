using AnyShapeWithInterFace.Enum;

namespace AnyShapeWithInterFace.Contract
{
     interface IAnyShape
    {
        public string TypeName { get; }
        float Area();
        float Enviroment();
    }
}
