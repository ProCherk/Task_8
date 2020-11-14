using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex A = new MyComplex(2, 5);
            A.OutputComNumb(A);
            MyComplex B = new MyComplex(7, 8);

            MyComplex C = new MyComplex();
            C = A * B;
            C.OutputComNumb(C);

            MyComplex D = new MyComplex();
            D = C * 15;
            D.OutputComNumb(D);

            MyComplex E = new MyComplex();
            E = 13 * D;
            E.OutputComNumb(E);


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

        public MyComplex(double a = 0, double b = 0 ) { re = a; im = b; }

        public void OutputComNumb(object MyComplex)
        {
            Console.WriteLine($"{MyComplex} = {re}+{im}*i");
            Console.WriteLine();
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex { re = a.re * b.re, im = a.im * b.im };
        }
        public static MyComplex operator *(MyComplex a, double b)
        {
            return new MyComplex { re = a.re * b, im = a.im * b };
        }
        public static MyComplex operator *(double b, MyComplex a)
        {
            return new MyComplex { re = a.re * b, im = a.im * b };
        }


    }
}
