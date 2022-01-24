using AnyShapeWithAbstract.Concrat;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Flag End of The Bet
            //
            bool flag = false;
            //
            //Shap Number
            //
            int _count = 1;
            //
            //List for storing shapes
            //
            var Shapes = new List<Shaps>();
            //
            //Help
            //
            Console.WriteLine("Exit=0 Type=> Circle:1  Triangle:2    Square:3 ");
            while (!flag)
            {
                Console.WriteLine($"Shape Namber {_count} ");
                Console.Write("type:");
                byte _type = Convert.ToByte(Console.ReadLine());
                switch (_type)
                {
                    case 0:
                        flag = true;
                        break;
                    case 1:
                        Console.Write("radius:");
                        float radius = float.Parse(Console.ReadLine());
                        Shapes.Add(new Circle(radius));
                        break;
                    case 2:
                        Console.Write("Hight:");
                        float hight = float.Parse(Console.ReadLine());
                        Console.Write("Base:");
                        float _base = float.Parse(Console.ReadLine());
                        Shapes.Add(new Triangle(hight, _base));
                        break;
                    case 3:
                        Console.Write("Base:");
                        float _base_ = float.Parse(Console.ReadLine());
                        Shapes.Add(new Square(_base_));
                        break;
                    default:
                        Console.WriteLine("The number entered is out of range");
                        _count--;
                        break;
                }
                _count++;
            }
            if (_count == 1)
                Console.WriteLine("You did not enter any Shap");
            else
            {
                Console.WriteLine("\n**************Result*****************\n");
                for (int i = 0; i < Shapes.Count; i++)
                {
                    Console.WriteLine($"Type:{Shapes[i].Name}   " +
                                      $"Area : {Shapes[i].Area()}   " +
                                      $"Enviromnt : {Shapes[i].Enviroment()}   ");
                }
                Console.WriteLine("\n*************************************");
            }

        }
    }
}