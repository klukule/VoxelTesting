using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using klukule.GLFW3;
using klukule.OpenGL;

using VoxelTesting.GLFW;
using VoxelTesting.Components;
using VoxelTesting.Chunks;
using VoxelTesting.Base;

namespace VoxelTesting
{
    public class Program
    {
        public const int WIN_WIDTH = 1280;
        public const int WIN_HEIGHT = 720;

        public static GLFW_Backend Backend;
        private static GameHandler game;

        private static VAO CubeTest;

        static void Main(string[] args)
        {
            Backend = new GLFW_Backend();
            Backend.Init(WIN_WIDTH, WIN_HEIGHT, "Testing window");

            game = Game.GetInstance();
            game.Init();

            Gl.Enable(EnableCap.DepthTest);
            Gl.Enable(EnableCap.CullFace);

            Backend.OnKeyPress += Backend_OnKeyPress;

            game.AddComponent(new Prefabs.Player());
            CubeTest = Geometry.CreateCubeWithNormals(ShaderFactory.LoadShader("Testing/basic"), new Vector3(0,0,1), new Vector3(2,2,2));

            //Init render
            Backend.Render(new Action<GlfwWindowPtr,float>(renderLoop));

            //Terminate everyting
            game.Dispose();
            CubeTest.DisposeChildren = true;
            CubeTest.Dispose();
            //Terminate window
            Backend.Terminate();
            ShaderFactory.Dispose();
        }

        private static void Backend_OnKeyPress(GlfwWindowPtr wnd, Key key, int scanCode, KeyModifiers mods)
        {
            if(key == Key.Escape)
            {
                Glfw.SetWindowShouldClose(wnd, true);
            }
        }

        private static void renderLoop(GlfwWindowPtr window,float deltaTime)
        {
            Timers.DeltaTime = deltaTime;
            Gl.Viewport(0, 0, WIN_WIDTH, WIN_HEIGHT);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            game.Update();
            game.Draw();
            CubeTest.Program.Use();
            CubeTest.Program["model_matrix"].SetValue(Matrix4.CreateTranslation(Vector3.Zero));
            CubeTest.Draw();
        }
    }
}
