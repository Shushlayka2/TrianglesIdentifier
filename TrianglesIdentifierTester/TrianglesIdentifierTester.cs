using TrIdentifier;
using Xunit;

namespace TrIdentifierTester
{
    public class TrianglesIdentifierTesterk
    {
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetAcuteTriangles), MemberType = typeof(TestDataGenerator))]
        public void AcuteTrianglesTestCase(float a, float b, float c)
        {
            var triangleType = new TrianglesIdentifier().IdentifyBySides(a, b, c);
            Assert.Equal(TrianglesTypes.Acute, triangleType);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetObtuseTriangles), MemberType = typeof(TestDataGenerator))]
        public void ObtuseTrianglesTestCase(float a, float b, float c)
        {
            var triangleType = new TrianglesIdentifier().IdentifyBySides(a, b, c);
            Assert.Equal(TrianglesTypes.Obtuse, triangleType);
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetRightTriangles), MemberType = typeof(TestDataGenerator))]
        public void RightTrianglesTestCase(float a, float b, float c)
        {
            var triangleType = new TrianglesIdentifier().IdentifyBySides(a, b, c);
            Assert.Equal(TrianglesTypes.Right, triangleType);
        }
    }
}
