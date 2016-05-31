using klukule.GLFW3;
using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Components;

namespace VoxelTesting.Base
{
    public class GameHandler : IComponent
    {
        public Matrix4 ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(0.45f, (float)Program.WIN_WIDTH / Program.WIN_HEIGHT, 0.1f, 1000f);
        private CameraComponent ActiveCamera;
        public GameHandler()
        {
            this.Parent = null;
            this.Name = "Game";
        }

        public override void Init()
        {
            Program.Backend.OnKeyPress += Backend_OnKeyPress;
            Program.Backend.OnKeyRelease += Backend_OnKeyRelease;

            Program.Backend.OnMouseClick += Backend_OnMouseClick;
        }

        private void Backend_OnMouseClick(klukule.GLFW3.GlfwWindowPtr wnd, klukule.GLFW3.MouseButton btn, klukule.GLFW3.KeyAction action)
        {
            if (!Mouse.state.ContainsKey(btn))
            {
                Mouse.state.Add(btn, action);
            }
            else
            {
                Mouse.state[btn] = action;
                Console.WriteLine(Mouse.state[btn]);
            }
            if (action == klukule.GLFW3.KeyAction.Release)
            {
                if (!Mouse.bnts.ContainsKey(btn))
                {
                    Mouse.bnts.Add(btn, false);
                }
                else
                {
                    Mouse.bnts[btn] = false;
                }
               
            }
            else if(action == klukule.GLFW3.KeyAction.Press)
            {
                if (!Mouse.bnts.ContainsKey(btn))
                {
                    Mouse.bnts.Add(btn, true);
                }
                else
                {
                    Mouse.bnts[btn] = true;
                }
            }
        }

        private void Backend_OnKeyRelease(klukule.GLFW3.GlfwWindowPtr wnd, klukule.GLFW3.Key key, int scanCode, klukule.GLFW3.KeyModifiers mods)
        {
            if (!Keyboard.keys.ContainsKey(key))
            {
                Keyboard.keys.Add(key, false);
            }
            else
            {
                Keyboard.keys[key] = false;
            }
        }

        private void Backend_OnKeyPress(klukule.GLFW3.GlfwWindowPtr wnd, klukule.GLFW3.Key key, int scanCode, klukule.GLFW3.KeyModifiers mods)
        {
            if (!Keyboard.keys.ContainsKey(key))
            {
                Keyboard.keys.Add(key, true);
            }else
            {
                Keyboard.keys[key] = true;
            }
        }


        public override void Draw()
        {
            for(int i = 0; i < Components.Count; i++)
            {
                if (Components[i].IsEnabled)
                {
                    Components[i].Draw();
                }
            }
        }

        public override void Update()
        {
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].IsEnabled)
                {
                    Components[i].Update();
                }
            }
            if(ActiveCamera == null || !ActiveCamera.IsEnabled)
            {
                ActiveCamera = GetComponentRecursive<CameraComponent>();
            }
            ShaderFactory.Update();
            Invoker.Update();
        }

        public CameraComponent GetCamera()
        {
            return ActiveCamera;
        }

        public override void Dispose()
        {
            for (int i = 0; i < Components.Count; i++)
            {
                Components[i].Dispose();
            }
        }
    }

    public static class Game
    {
        private static GameHandler Handler = new GameHandler();

        public static GameHandler GetInstance()
        {
            return Handler;
        }


    }
}
