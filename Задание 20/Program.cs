using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        delegate double MyDelegate(double Radius);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double R = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate1 = new MyDelegate(LengthCircle);
            MyDelegate myDelegate2 = new MyDelegate(AreaCircle);
            MyDelegate myDelegate3 = new MyDelegate(VolumeCircle);

            
            Console.WriteLine($"Длина окружности: {myDelegate1?.Invoke(R):f2}");
            Console.WriteLine($"Площадь круга: {myDelegate2?.Invoke(R):f2}");
            Console.WriteLine($"Объем шара: {myDelegate3?.Invoke(R):f2}");

            Console.ReadKey();
        }
        static double LengthCircle(double Radius)
        {
            return 2 * Math.PI * Radius;
        }
        static double AreaCircle(double Radius)
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        static double VolumeCircle(double Radius)
        {
            return (4 * Math.PI * Math.Pow(Radius, 3))/3;
        }
    }
}
