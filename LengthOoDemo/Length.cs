using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOoDemo
{
    class Length
    {
        private string unit;
        private long value;

        public Length(long value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Length length = (Length) obj;
            return length.value == value && unit == length.unit;
        }
    }
}
