using System;
namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Input nilai a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input nilai b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input nilai c : ");
            c = int.Parse(Console.ReadLine());

            classNum Nilai = new classNum();
            Nilai.cariNilaiMin(a, b, c);
            Nilai.cariNilaiMax(a, b, c);
            Console.ReadKey();
        }
    }
}