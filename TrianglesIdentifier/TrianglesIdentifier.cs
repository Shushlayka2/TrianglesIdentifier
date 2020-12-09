using System;
using System.Linq;

namespace TrIdentifier
{
    public class TrianglesIdentifier
    {
        protected const float Epsilon = 0.0001f;

        /// <summary>
        /// Identifies the type of triangle
        /// </summary>
        /// <param name="a">Triangle's first side</param>
        /// <param name="b">Triangle's second side</param>
        /// <param name="c">Triangle's third side</param>
        /// <returns></returns>
        public TrianglesTypes IdentifyBySides(float a, float b, float c)
        {
            var sides = new float[] { a, b, c };

            if (!VerifyTriangle(sides))
                return TrianglesTypes.NonTriangle;

            sides = sides.OrderByDescending(side => side).ToArray();
            var squaredLargestSide = Math.Pow(sides[0], 2);
            var squaredSidesSum = (from side in sides.Skip(1)
                                   select Math.Pow(side, 2)).Sum();

            if (Math.Abs(squaredLargestSide - squaredSidesSum) < Epsilon)
                return TrianglesTypes.Right;
            else if (squaredLargestSide > squaredSidesSum)
                return TrianglesTypes.Obtuse;
            else
                return TrianglesTypes.Acute;
        }

        /// <summary>
        /// Verifies whether triangle correctly determined
        /// </summary>
        /// <param name="sides">Triangle's sides</param>
        /// <returns></returns>
        private bool VerifyTriangle(float[] sides)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((sides[i] + sides[(i + 1) % 3] <= sides[(i + 2) % 3])
                    || (Math.Abs(sides[i] - sides[(i + 1) % 3]) >= sides[(i + 2) % 3]))
                    return false;
            }
            return true;
        }
    }
}
