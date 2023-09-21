using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kL_2023_09_21
{
    public class MyClass
    {
        public int A { get; set; }
        public MyClass(int a) {  A = a; }

        public int this[int index]
        {
            get {
                var ln = A.ToString().Length;
                if (index >= 0 && index < ln) return A.ToString()[ln-index-1]-'0';
                return 0;
            }
        }

        public MyClass Append(MyClass c)
        {
            return new MyClass(int.Parse($"{this.A}{c.A}"));
        }

        public static MyClass operator +(MyClass c1, MyClass c2)
        {
            return new MyClass(int.Parse($"{c1.A}{c2.A}"));
        }

        public static implicit operator MyClass(int value)
        {
            return new MyClass(value);
        }

        public static explicit operator int(MyClass value) => value.A;
        public static explicit operator string(MyClass value) => value.A.ToString();

        public static MyClass operator -(MyClass c)
        {
            return new MyClass(-c.A);
        }

        public static MyClass operator +(MyClass c)
        {
            return new MyClass(Math.Abs(c.A));
        }

        public static bool operator ==(MyClass c1, MyClass c2) => c1.A == c2.A;
        public static bool operator !=(MyClass c1, MyClass c2) => !(c1 == c2);

        public override string ToString() => $"[{A}]";
    }
}
