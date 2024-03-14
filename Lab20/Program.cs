namespace Lab20



{ internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(GetLenth);
            myDelegate += GetVolume;
            myDelegate += GetSquare;
            myDelegate(5);
            Console.ReadKey();
        }

        static double GetLenth(double r) 
        {
        Console.WriteLine("Длина окружности {0}", 2 * Math.PI * r);
        return 2*Math.PI*r;
        }
    static double GetSquare(double r)
    {
        Console.WriteLine("Площадь окружности {0}", Math.PI * r*r);
        return  Math.PI * r*r;
    }

    static double GetVolume(double r)
    {
        Console.WriteLine("Объем шара {0}", (double)(4 / 3) * Math.PI * r * r * r);
        return (double)(4/3)* Math.PI * r * r*r;
    }
}
}
