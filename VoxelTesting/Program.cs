using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using klukule.GLFW3;
using klukule.OpenGL;

using VoxelTesting.GLFW;
using VoxelTesting.Components;
using VoxelTesting.Base;

namespace VoxelTesting
{
    public class Program
    {
        public const int WIN_WIDTH = 1280;
        public const int WIN_HEIGHT = 720;

        public static GLFW_Backend Backend;
        private static GameHandler game;


        static void Main(string[] args)
        {
            Backend = new GLFW_Backend();
            Backend.Init(WIN_WIDTH, WIN_HEIGHT, "Testing window");

            game = Game.GetInstance();
            game.Init();

            Gl.Enable(EnableCap.DepthTest);
            Gl.Enable(EnableCap.CullFace);

            Backend.OnKeyPress += Backend_OnKeyPress;

            Prefabs.Player player = new Prefabs.Player();
            player.GetTransform().Position = new Vector3(-30, 20, -30);
            player.GetTransform().Orientation = Quaternion.FromRotationMatrix(Matrix4.LookAt(player.GetTransform().Position, new Vector3(16, 0, 16), Vector3.Up));
            game.AddComponent(player);
            for(int x = 0; x < 30; x++)
            {
                for(int z = 0; z < 30; z++)
                {
                    Prefabs.VoxelChunk chunk = new Prefabs.VoxelChunk(new Vector2(x * 16, z * 16));
                    game.AddComponent(chunk);
                }
            }

            ShaderFactory.LoadShader("Testing/basic");

            //Init render
            Backend.Render(new Action<GlfwWindowPtr,float>(renderLoop));

            //Terminate everyting
            game.Dispose();
            //Terminate window
            Backend.Terminate();
            ShaderFactory.Dispose();
        }

        private static void Backend_OnKeyPress(GlfwWindowPtr wnd, Key key, int scanCode, KeyModifiers mods)
        {
            /*if(key == Key.Escape)
            {
                Glfw.SetWindowShouldClose(wnd, true);
            }*/
        }

        private static void renderLoop(GlfwWindowPtr window,float deltaTime)
        {
            Timers.DeltaTime = deltaTime;
            Gl.Viewport(0, 0, WIN_WIDTH, WIN_HEIGHT);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            game.Update();
            game.Draw();
        }
    }
}
