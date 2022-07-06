using System;

namespace FirstTask
{
    class Test
    {
        static void Main(string[] args)
        {
            CircleTest();
            TriangleTest();
            return;
        }
        static void CircleTest()
        {
            double Area = SurfaceArea.SurfaceLib.CircleSurface(1);
            if (Area == Math.PI)
                Console.WriteLine("Тест функции определения площади окружнеости пройден успешно");
            else
                Console.WriteLine("Тест функции определения площади окружнеости пройден c ошибками");
        }
        static void TriangleTest()
        {
            double AreaSquare = SurfaceArea.SurfaceLib.TriangleSurface(3,4,5);
            double Area = SurfaceArea.SurfaceLib.TriangleSurface(13,14,15);
            if (AreaSquare == 6&&Area == 84 )
                Console.WriteLine("Тест функции определения площади треугольника пройден успешно");
            else
                Console.WriteLine("Тест функции определения площади треугольника пройден c ошибками");
        }
    }
}
