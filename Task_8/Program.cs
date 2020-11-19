using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            MyComplex A = new MyComplex();
            A.InputComplexNumber(A);
            Console.WriteLine(A);
            Console.WriteLine();

            MyComplex B = new MyComplex();
            B.InputComplexNumber(B);
            Console.WriteLine(B);
            Console.WriteLine();

            MyComplex C = new MyComplex("C");
            C = A * B;
            Console.WriteLine($"C = {A.Name} * {B.Name}");
            Console.WriteLine(C);

            MyComplex D = new MyComplex("D");
            D = C * 15;
            Console.WriteLine("D = C * 15");
            Console.WriteLine(D);

            MyComplex E = new MyComplex("E");
            E = 13 * D;
            Console.WriteLine("E = 13 * D");
            Console.WriteLine(E);

            MyComplex F = new MyComplex("F");
            F = -E;
            Console.WriteLine("F = -E");
            Console.WriteLine(F);
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

        private string InputName()
        {
            Console.Write("Введіть назву змінної:");
            name = Console.ReadLine();

            return name;
        }
        private double InputRe()
        {
            bool flag = false;
            do
            {
                Console.Write("Введіть реальну частину: ");
                string a = Console.ReadLine();
                flag = double.TryParse(a, out re);
                if (flag)
                    break;
                else
                {
                    Console.WriteLine("Невірно введені данні!!!!");
                    flag = true;
                }

            } while (flag);

            return re;
        }
        private double InputIm()
        {
            bool flag = false;
            do
            {
                Console.Write("Уявна частина - ");
                string a = Console.ReadLine();
                flag = double.TryParse(a, out im);
                if (flag)
                    break;
                else
                {
                    Console.WriteLine("Невірно введені данні!!!!");
                    flag = true;
                }

            } while (flag);

            return im;
        }
        public void InputComplexNumber(MyComplex a)
        {
            a.InputName();
            a.InputRe();
            a.InputIm();
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
        public static MyComplex operator -(MyComplex a)
        {
            return new MyComplex { Re = -1 * a.Re, Im = -1 * a.Im, Name = "Result" };
        }
        public override string ToString()
        {
            if (Im < 0)
                return Name + "=" + Re + Im + "*i";
            else
                return Name + "=" + Re + "+" + Im + "*i";
        }
    }
}
