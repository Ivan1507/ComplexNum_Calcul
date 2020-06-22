using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public class ComplexNum
    {
        private double real;
        private double image;

        public ComplexNum()
        {
            real = 1;
            image = 1;
        }
        public ComplexNum(double re)
        {
            real = re;
            image = 0;
        }
        public ComplexNum(double re, double im)
        {
            real = re;
            image = im;
        }

        public void setReal(double re)
        {
            real = re;
        }
        public void setImage(double im)
        {
            image = im;
        }
        public double getReal()
        {
            return real;
        }
        public double getImage()
        {
            return image;
        }

        static public ComplexNum operator +(ComplexNum left, ComplexNum right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left.getReal() + right.getReal());
            complexNum.setImage(left.getImage() + right.getImage());
            return complexNum;
        }
        static public ComplexNum operator -(ComplexNum left, ComplexNum right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left.getReal() - right.getReal());
            complexNum.setImage(left.getImage() - right.getImage());
            return complexNum;
        }
        static public ComplexNum operator *(ComplexNum left, ComplexNum right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left.getReal() * right.getReal() - left.getImage() * right.getImage());
            complexNum.setImage(left.getReal() * right.getImage() + left.getImage() * right.getReal());
            return complexNum;
        }
        static public ComplexNum operator *(ComplexNum left, double right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left.getReal() * right);
            complexNum.setImage(left.getImage() * right);
            return complexNum;
        }
        static public ComplexNum operator *(double left, ComplexNum right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left * right.getReal());
            complexNum.setImage(left * right.getImage());
            return complexNum;
        }
        static public ComplexNum operator /(ComplexNum left, ComplexNum right)
        {
            ComplexNum complexNum = new ComplexNum();
            double r1 = left.getReal();
            double r2 = right.getReal();
            double im1 = left.getImage();
            double im2 = right.getImage();
            double r = (r1 * r2 + im1 * im2) / (r2 * r2 + im2 * im2);
            double im = (r2 * im1 - r1 * im2) / (r2 * r2 + im2 * im2);
            complexNum.setReal(r);
            complexNum.setImage(im);
            return complexNum;
        }
        static public ComplexNum operator /(ComplexNum left, double right)
        {
            ComplexNum complexNum = new ComplexNum();
            complexNum.setReal(left.getReal() / right);
            complexNum.setImage(left.getImage() / right);
            return complexNum;
        }
        public void Convert(String str)
        {
            String buf1 = "", buf2 = "";
            int i = 0;

            for (; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-') break;
                else buf1 += str[i];
            }
            if(str[i]=='+') i += 1;

            for (; i < str.Length; i++)
            {
                if (str[i] == 'i') break;
                else buf2 += str[i];
            }

            this.setReal(Double.Parse(buf1));
            this.setImage(Double.Parse(buf2));
        }
       public String BackConvert()
        {
            if (this.getImage() >= 0)
            {
                return this.getReal().ToString() + '+' + this.getImage().ToString() + 'i';
            }
            else
            {
                return this.getReal().ToString() + '-' + (this.getImage()).ToString() + 'i';
            }
        }
    }
}
