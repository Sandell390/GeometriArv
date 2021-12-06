using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriArv
{
    public abstract class Figur
    {

        private double omkreds;      

        public double Omkreds
        {
            get { return omkreds; }
            set { omkreds = value; }
        }

        private double areal;

        public double Areal
        {
            get { return areal; }
            set { areal = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void SetOmkreds();

        public abstract void SetAreal();


    }


    public class Parallelogram : Figur 
    {
        private double a;

        public double A
        {
            get { return a; }
        }

        private double b;

        public double B
        {
            get { return b; }
        }

        private double v;

        public double V
        {
            get { return v; }
        }


        public Parallelogram(double _a, double _b, double _v, string _name) 
        {
            a = _a;

            b = _b;

            v = _v;

            Name = _name;
        }

        public override void SetOmkreds()
        {
            Omkreds = (2 * a) + (2 * b);
        }

        public override void SetAreal()
        {
            Areal = a * b * Math.Sin(v);
        }

    }

    public class Trapezen : Figur 
    {
        private double a;

        public double A
        {
            get { return a; }
        }

        private double b;

        public double B
        {
            get { return b; }
        }

        private double c;

        public double C
        {
            get { return c; }
        }


        private double d;

        public double D
        {
            get { return d; }
        }

        public Trapezen(double _a, double _b, double _c, double _d, string _name)
        {
            a = _a;

            b = _b;

            c = _c;

            d = _d;

            Name = _name;
        }

        public override void SetOmkreds()
        {
            Omkreds = a + b + c + d;
        }

        public override void SetAreal()
        {
            double s = (a + b - c + d) / 2;

            double h = (2 / (a - c)) * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));

            Areal = 0.5 * (a + c) * h;
        }
    }

    public class Trekant : Figur 
    {
        private double a;

        public double A
        {
            get { return a; }
        }

        private double b;

        public double B
        {
            get { return b; }
        }

        private double c;

        public double C
        {
            get { return c; }
        }

        public Trekant(double _a, double _b, double _c, string _name)
        {
            a = _a;

            b = _b;

            c = _c;

            Name = _name;
        }

        public override void SetOmkreds()
        {
            Omkreds = a + b + c;
        }

        public override void SetAreal()
        {
            Areal = 0.5 * a * b;
        }
    }
}
