using ModelsLayer;

namespace ServicesLayer
{
    public class Sumar: ISumar
    {
        Suma s = new Suma();

        public int Sum()
        {
            s.A = 5001;
            s.B = 639;

            return s.A + s.B;
        }

        public int Mult()
        {
            int _Area = 60;
            s.A = 5001;
            s.B = 639;
            int Result = (s.A + s.B) * _Area;

            return Result;
        }

        public int ScaleEnd()
        {
            int Result = Sum() + Mult() * 10;
            return Result;
        }
    }
}