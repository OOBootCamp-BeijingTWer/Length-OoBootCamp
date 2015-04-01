using Xunit;

namespace LengthOoDemo
{
    public class LengthTest
    {
        [Fact]
        public void should_equal_given_same_value_and_unit()
        {
            Assert.Equal(new Length(10, "m"), new Length(10, "m"));
        }

        [Fact]
        public void should_not_equal_given_same_value_and_different_unit()
        {
            Assert.NotEqual(new Length(10, "cm"), new Length(10, "m"));
        }

        [Fact]
        public void should_equal_given_same_length_with_different_unit()
        {
            Assert.Equal(new Length(100, "cm"), new Length(1, "m"));
        }
    }
}
