using klukule.GLFW3;
using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Base
{
    public static class Mouse
    {
        public static bool IsCursorHidden = false;
        public static Dictionary<MouseButton, bool> bnts = new Dictionary<MouseButton, bool> { };

        private static Vector2 MousePosCap = Vector2.Zero;
        private static Vector2 MousePos = Vector2.Zero;
        private static Vector2 MousePosPrev = Vector2.Zero;
        public static bool MouseDown(MouseButton btn)
        {
            if (bnts.ContainsKey(btn) && bnts[btn] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowCursor()
        {
            if (IsCursorHidden)
            {
                Glfw.SetInputMode(Program.Backend.GetWindow(), InputMode.CursorMode, CursorMode.CursorNormal);
                Glfw.SetCursorPos(Program.Backend.GetWindow(), MousePosCap.x, MousePosCap.y);
                IsCursorHidden = false;
            }
        }

        public static void HideCursor()
        {
            if (!IsCursorHidden)
            {
                Glfw.SetInputMode(Program.Backend.GetWindow(), InputMode.CursorMode, CursorMode.CursorCaptured);
                double x, y;
                Glfw.GetCursorPos(Program.Backend.GetWindow(), out x, out y);
                MousePosCap = new Vector2(x, y);
                MousePosPrev = MousePosCap;
                MousePos = MousePosCap;
                IsCursorHidden = true;
            }
        }

        public static Vector2 GetPosition()
        {
            MousePosPrev = MousePos;
            double x, y;
            Glfw.GetCursorPos(Program.Backend.GetWindow(), out x, out y);
            MousePos = new Vector2(x, y);
            return MousePos;
        }

        public static Vector2 GetOldPosition()
        {
            return MousePosPrev;
        }
    }
}
