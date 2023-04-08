/*Copyright (C) 2023 Huzieva Iyliia*/
/*Створити абстрактний базовий клас Pair з віртуальними арифметичними операціями. 
 * Створити похідні класи Fuzzynumber (нечіткі числа) і Complex (комплексні числа). 
 * Реалізувати базові операції над цими числами.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huzeva_Lab17
{
 


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComplexAdd_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtReal1.Text), double.Parse(txtImaginary1.Text));
            Complex c2 = new Complex(double.Parse(txtReal2.Text), double.Parse(txtImaginary2.Text));
            Complex result = (Complex)c1.Add(c2);
            lblComplexAddResult.Text = result.ToString();
        }

        private void btnComplexSubtract_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtReal1.Text), double.Parse(txtImaginary1.Text));
            Complex c2 = new Complex(double.Parse(txtReal2.Text), double.Parse(txtImaginary2.Text));
            Complex result = (Complex)c1.Subtract(c2);
            lblComplexSubtractResult.Text = result.ToString();
        }

        private void btnComplexMultiply_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtReal1.Text), double.Parse(txtImaginary1.Text));
            Complex c2 = new Complex(double.Parse(txtReal2.Text), double.Parse(txtImaginary2.Text));
            Complex result = (Complex)c1.Multiply(c2);
            lblComplexMultiplyResult.Text = result.ToString();
        }

        private void btnComplexDivide_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtReal1.Text), double.Parse(txtImaginary1.Text));
            Complex c2 = new Complex(double.Parse(txtReal2.Text), double.Parse(txtImaginary2.Text));
            Complex result = (Complex)c1.Divide(c2);
            lblComplexDivideResult.Text = result.ToString();
        }

        private void btnFuzzyAdd_Click(object sender, EventArgs e)
        {
            FuzzyNumber f1 = new FuzzyNumber(double.Parse(txtCenter1.Text), double.Parse(txtWidth1.Text));
            FuzzyNumber f2 = new FuzzyNumber(double.Parse(txtCenter2.Text), double.Parse(txtWidth2.Text));
            FuzzyNumber result = (FuzzyNumber)f1.Add(f2);
            lblFuzzyAddResult.Text = result.ToString();
        }

        private void btnFuzzySubtract_Click(object sender, EventArgs e)
        {
            FuzzyNumber f1 = new FuzzyNumber(double.Parse(txtCenter1.Text), double.Parse(txtWidth1.Text));
            FuzzyNumber f2 = new FuzzyNumber(double.Parse(txtCenter2.Text), double.Parse(txtWidth2.Text));
            FuzzyNumber result = (FuzzyNumber)f1.Subtract(f2);
            lblFuzzySubtractResult.Text = result.ToString();
        }

        private void btnFuzzyMultiply_Click(object sender, EventArgs e)
        {
            FuzzyNumber f1 = new FuzzyNumber(double.Parse(txtCenter1.Text), double.Parse(txtWidth1.Text));
            FuzzyNumber f2 = new FuzzyNumber(double.Parse(txtCenter2.Text), double.Parse(txtWidth2.Text));
            FuzzyNumber result = (FuzzyNumber)f1.Multiply(f2);
            lblFuzzyMultiplyResult.Text = result.ToString();
        }

        private void btnFuzzyDivide_Click(object sender, EventArgs e)
        {
            FuzzyNumber f1 = new FuzzyNumber(double.Parse(txtCenter1.Text), double.Parse(txtWidth1.Text));
            FuzzyNumber f2 = new FuzzyNumber(double.Parse(txtCenter2.Text), double.Parse(txtWidth2.Text));
            FuzzyNumber result = (FuzzyNumber)f1.Divide(f2);
            lblFuzzyDivideResult.Text = result.ToString();
        }
    }
}
