// Скрипников Сергей 22-ИСП-2/1 Вариант 17
class Program
{
    static void Main(string[] args)
    {
        try
        {
            StraightLine line1 = new StraightLine(1, 2, 3);
            StraightLine line2 = new StraightLine(4, 5, 6);
            bool result = CheckParallelLines(line1, line2);
            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static bool CheckParallelLines(StraightLine line1, StraightLine line2)
    {
        if (line1 == null || line2 == null)
            throw new ArgumentNullException("Одна или обе строки равны нулю");

        double d = line1.A * line2.B - line2.A * line1.B;

        if (d == 0)
            throw new ArgumentException("Линии параллельны");

        return true;
    }

    class StraightLine
    {
        private double a;
        private double b;
        private double c;

        public StraightLine(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }
    }
}