using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double a, b;
            
            Console.Write("Введіть дійсне число " + "\n" + "Реальна частина - ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Уявна частина - ");
            b = Convert.ToDouble(Console.ReadLine());

            MyComplex A = new MyComplex("A", a, b);
            A.OutputComNumb();

            Console.Write("Введіть дійсне число " + "\n" + "Реальна частина - ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Уявна частина - ");
            b = Convert.ToDouble(Console.ReadLine());

            MyComplex B = new MyComplex("B", a, b);
            B.OutputComNumb();

            MyComplex C = new MyComplex("C");
            C = A * B;
            Console.WriteLine("C = A * B");
            C.OutputComNumb();

            MyComplex D = new MyComplex("D");
            D = C * 15;
            Console.WriteLine("D = C * 15");
            D.OutputComNumb();

            MyComplex E = new MyComplex("E");
            E = 13 * D;
            Console.WriteLine("E = 13 * D");
            E.OutputComNumb();
        }
    }

    class MyComplex
    {
        private double re;
        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        private double im;
        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public MyComplex(string n = " ", double a = 0, double b = 0) { name = n; re = a; im = b; }

        public void OutputComNumb()
        {
            Console.WriteLine($"{name} = {re}+{im}*i");
            Console.WriteLine();
        }
        
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex { re = a.re * b.re, im = a.im * b.im, name = "Result"};
        }
        public static MyComplex operator *(MyComplex a, double b)
        {
            return new MyComplex { re = a.re * b, im = a.im * b, name = "Result" };
        }
        public static MyComplex operator *(double b, MyComplex a)
        {
            return new MyComplex { re = a.re * b, im = a.im * b, name = "Result" };
        }
    }
}
