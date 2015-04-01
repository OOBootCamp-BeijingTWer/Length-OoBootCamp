using System;

namespace LengthOoDemo
{
    public enum Unit
    {
        km=3,
        m=0,
        dm=-1,
        cm=-2,
        mm=-3,
    }
    public class Length
    {
        private double value;

        public Length(double value, Unit unit)
        {
            this.value = value*Math.Pow(10, (int)unit);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var length = (Length) obj;
            return Math.Abs(length.value - value) < 0.0001;
        }
    }
}
