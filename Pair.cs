using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzeva_Lab17
{
    public abstract class Pair
    {

        public abstract Pair Add(Pair p);
        public abstract Pair Subtract(Pair p);
        public abstract Pair Multiply(Pair p);
        public abstract Pair Divide(Pair p);
        public abstract void Print();
    }
    public class FuzzyNumber : Pair
    {
        private double _center;
        private double _width;
        public override string ToString()
        {
            return $"{_center} ± {_width}";
        }
        public FuzzyNumber(double center, double width)
        {
            _center = center;
            _width = width;
        }
        //Операція додавання.
        public override Pair Add(Pair p)
        {
            FuzzyNumber f = (FuzzyNumber)p;
            return new FuzzyNumber(_center + f._center, _width + f._width);
        }
        //Операція віднімання.
        public override Pair Subtract(Pair p)
        {
            FuzzyNumber f = (FuzzyNumber)p;
            return new FuzzyNumber(_center - f._center, _width + f._width);
        }
        //Операція множення.
        public override Pair Multiply(Pair p)
        {
            FuzzyNumber f = (FuzzyNumber)p;
            return new FuzzyNumber(_center * f._center, _width + f._width);
        }
        //Операція ділення.
        public override Pair Divide(Pair p)
        {
            FuzzyNumber f = (FuzzyNumber)p;
            return new FuzzyNumber(_center / f._center, _width + f._width);
        }

        public override void Print()
        {
            Console.WriteLine("Fuzzy Number: Center = {0}, Width = {1}", _center, _width);
        }
    }

    public class Complex : Pair
    {
        private double _real;
        private double _imaginary;
        public override string ToString()
        {
            return $"{_real} ± {_imaginary}";
        }
        public Complex(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }
        public static Complex ParseComplexNumber(string input)
        {
            string[] parts = input.Split('±');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Input string does not contain a valid complex number.");
            }

            double real = double.Parse(parts[0].Trim());
            double imaginary = double.Parse(parts[1].Trim());

            return new Complex(real, imaginary);
        }
        //Операція додавання.
        public override Pair Add(Pair p)
        {
            Complex c = (Complex)p;
            return new Complex(_real + c._real, _imaginary + c._imaginary);
        }
        //Операція віднімання.
        public override Pair Subtract(Pair p)
        {
            Complex c = (Complex)p;
            return new Complex(_real - c._real, _imaginary - c._imaginary);
        }
        //Операція множення.
        public override Pair Multiply(Pair p)
        {
            Complex c = (Complex)p;
            double realPart = _real * c._real - _imaginary * c._imaginary;
            double imaginaryPart = _real * c._imaginary + _imaginary * c._real;
            return new Complex(realPart, imaginaryPart);
        }
        //Операція ділення.
        public override Pair Divide(Pair p)
        {
            Complex c = (Complex)p;
            double denominator = c._real * c._real + c._imaginary * c._imaginary;
            double realPart = (_real * c._real + _imaginary * c._imaginary) / denominator;
            double imaginaryPart = (_imaginary * c._real - _real * c._imaginary) / denominator;
            return new Complex(realPart, imaginaryPart);
        }

        public override void Print()
        {
            Console.WriteLine("Complex Number: {0} + {1}i", _real, _imaginary);
        }
    }
}
