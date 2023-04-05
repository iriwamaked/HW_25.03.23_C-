using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_25._03._23
{
    internal class Fraction
    {
        private int _num;
        private int _denom;

        public Fraction(int num, int denom)
        {
            _num = num;
            if (denom == 0) { throw new DivideByZeroException("Знаменатель не может быть равен 0!"); }
            _denom = denom;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a._num * b._denom + b._num * a._denom, a._denom * b._denom);
        }

        public static Fraction operator +(Fraction a, double b)
        {
            int int1 = (int)b; //выделяем целую часть
            double double1 = b - int1;//выделяем дробную часть
            Fraction tmp=new Fraction((int)(double1*a._denom), a._denom);//новый объект с числителем, равным дробная*знаменатель а и знаменатель=знаменателю а
            return a + tmp + new Fraction(int1, 1);//возвращаем сумму исходной дроби, дробной части и новой дроби, полученной из целой части
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a._num * b._denom - b._num * a._denom, a._denom * b._denom);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a._num * b._num, a._denom * b._denom);
        }

        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a._num * b, a._denom);
        }

        public static Fraction operator*(int a, Fraction b)
        {
            return b * a;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a._num * b._denom, a._denom * b._num);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            if (ReferenceEquals(a, null)&&ReferenceEquals(b,null)) return true;//проверка, существуют ли объекты
            if (ReferenceEquals(a, null)||ReferenceEquals(b,null)) return false;//проверка, если один объект не существует
            return a._num * b._denom == b._num * a._denom;
        }

        public static bool operator !=(Fraction a, Fraction b) { return !(a == b); }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (ReferenceEquals(obj, null)) return false;
            if (GetType() != obj.GetType()) return false;
            Fraction tmp=(Fraction) obj;
            return _num== tmp._num &&_denom== tmp._denom;
        }

        //Метод для получения целочисленного значения хеш-кода объекта (если не выполнить перегрузку - предупреждение)
        public override int GetHashCode()
        {
            return _num.GetHashCode()^_denom.GetHashCode();
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a._num * b._denom < b._num * a._denom;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return a._num * b._denom > b._num * a._denom;
        }

        public static bool operator true(Fraction obj)
        {
            return obj._num < obj._denom;
        }

        public static bool operator false(Fraction obj)
        {
            return obj._num >= obj._denom;
        }

        public override string ToString()
        {
            return $"{_num}/{_denom}";
        }


    }
}
