using Xunit;

namespace LengthOoDemo
{
    public class LengthTest
    {
        [Fact]
        public void should_equal_given_same_value_and_unit()
        {
            Assert.Equal(new Length(10, Unit.m), new Length(10, Unit.m));
        }

        [Fact]
        public void should_not_equal_given_same_value_and_different_unit()
        {
            Assert.NotEqual(new Length(10, Unit.cm), new Length(10, Unit.m));
        }

        [Fact]
        public void should_not_equal_given_different_length_with_same_unit()
        {
            Assert.NotEqual(new Length(100, Unit.m), new Length(1, Unit.m));
        }

        [Fact]
        public void should_equal_given_same_length_with_different_unit()
        {
            Assert.Equal(new Length(100, Unit.cm), new Length(1, Unit.m));
        }

        [Fact]
        public void should_not_equal_when_given_only_one_length()
        {
            Assert.NotEqual(new Length(100, Unit.cm), null);
        }
    }
}
