using System.Collections.Generic;

namespace TrIdentifierTester
{
    public static class TestDataGenerator
    {
        public static IEnumerable<object[]> GetAcuteTriangles()
        {
            yield return new object[] { 7, 4, 6 };
            yield return new object[] { 7, 9, 10 };
            yield return new object[] { 12, 6, 12 };
            yield return new object[] { 12, 12, 12 };
        }

        public static IEnumerable<object[]> GetObtuseTriangles()
        {
            yield return new object[] { 5, 12, 9 };
            yield return new object[] { 15, 6, 13 };
            yield return new object[] { 6, 9, 4 };
        }

        public static IEnumerable<object[]> GetRightTriangles()
        {
            yield return new object[] { 15, 8, 17 };
            yield return new object[] { 5, 3, 4 };
            yield return new object[] { 5, 3, 5.8309519f };
            yield return new object[] { 13, 17.691806f, 12 };
            yield return new object[] { 8, 10, 6 };
        }

        public static IEnumerable<object[]> GetInvaidTriangles()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 12.5, 2, 18.3 };
            yield return new object[] { 100, 45, 510 };
            yield return new object[] { 0, 0, 0 };
            yield return new object[] { 5, -3, 4 };
            yield return new object[] { -5, -3, -4 };
        }
    }
}
