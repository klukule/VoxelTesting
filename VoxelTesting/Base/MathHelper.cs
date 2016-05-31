using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Base
{
    public static class MathHelper
    {
        public static float Lerp(float value1, float value2, float amount)
        {
            return value1 + (value2 - value1) * amount;
        }

        public static float Distance(Vector3 v1, Vector3 v2)
        {
            Vector3 difference = new Vector3(
                v1.x - v2.x,
                v1.y - v2.y,
                v1.z - v2.z);
            float distance = (float) Math.Sqrt(
                Math.Pow(difference.x, 2f) +
                Math.Pow(difference.y, 2f) +
                Math.Pow(difference.z, 2f));
            return distance;
        }
    }
}
