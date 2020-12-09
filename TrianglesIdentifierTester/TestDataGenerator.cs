using System.Collections.Generic;

namespace TrIdentifierTester
{
    public static class TestDataGenerator
    {
        public static IEnumerable<object[]> GetAcuteTriangles()
        {
            yield return new object[] { 7, 9, 10 };    
        }

        public static IEnumerable<object[]> GetObtuseTriangles()
        {
            yield return new object[] { 5, 12, 9 };
            yield return new object[] { 15, 6, 13 };
        }

        public static IEnumerable<object[]> GetRightTriangles()
        {
            yield return new object[] { 15, 8, 17 };
            yield return new object[] { 5, 3, 4 };
        }

        public static IEnumerable<object[]> GetInvaidTriangles()
        {
            yield return new object[] { 1, 2, 3 };
        }
    }
}
