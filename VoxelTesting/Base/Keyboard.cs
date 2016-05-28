using klukule.GLFW3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Base
{

    public static class Keyboard
    {
        public static Dictionary<Key, bool> keys = new Dictionary<Key, bool> { };

        public static bool IsKeyPressed(Key key)
        {
            if (keys.ContainsKey(key) && keys[key] == true)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
