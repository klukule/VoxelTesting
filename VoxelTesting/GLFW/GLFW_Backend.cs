using System;
using klukule.OpenGL;
using klukule.GLFW3;
using System.Diagnostics;

namespace VoxelTesting.GLFW
{
    public class GLFW_Backend
    {
        public delegate void KeyDelegate(GlfwWindowPtr wnd, Key key, int scanCode, KeyModifiers mods);
        public delegate void MouseMoveDelegate(GlfwWindowPtr wnd, double x, double y);
        public delegate void MouseClickDelegate(GlfwWindowPtr wnd, MouseButton btn, KeyAction action);

        public event KeyDelegate OnKeyPress;
        public event KeyDelegate OnKeyRelease;
        public event KeyDelegate OnKeyRepeat;
        public event MouseMoveDelegate OnMouseMove;
        public event MouseClickDelegate OnMouseClick;
        GlfwWindowPtr window;
        private static int winW, winH;
        private static Stopwatch timer;

        /// <summary>
        /// Gets the height of the window.
        /// </summary>
        /// <returns>The window height.</returns>
        public static int getWindowHeight()
        {
            return winH;
        }

        public GlfwWindowPtr GetWindow()
        {
            return window;
        }


        /// <summary>
        /// Gets the width of the window.
        /// </summary>
        /// <returns>The window width.</returns>
        public static int getWindowWidth()
        {
            return winW;
        }

        /// <summary>
        /// Init GLFW window with specified width, height and title.
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        /// <param name="title">Title.</param>
        public void Init(int width, int height, string title)
        {
            Glfw.Init();
            window = Glfw.CreateWindow(width, height, title, GlfwMonitorPtr.Null, GlfwWindowPtr.Null);
            Glfw.MakeContextCurrent(window);

            Glfw.SetMouseButtonCallback(window, new GlfwMouseButtonFun(onClick));
            Glfw.SetKeyCallback(window, new GlfwKeyFun(onKey));
            Glfw.SetCursorPosCallback(window, new GlfwCursorPosFun(onMove));
            winH = height;
            winW = width;
            timer = Stopwatch.StartNew();
        }

        private void onMove(GlfwWindowPtr wnd, double x, double y)
        {
            if (OnMouseMove != null)
                OnMouseMove(wnd, x, y);
        }

        private void onKey(GlfwWindowPtr wnd, Key key, int scanCode, KeyAction action, KeyModifiers mods)
        {
            if(action == KeyAction.Press && OnKeyPress != null)
            {
                OnKeyPress(wnd, key, scanCode, mods);
            }
            else if(action == KeyAction.Release && OnKeyRelease != null)
            {
                OnKeyRelease(wnd, key, scanCode, mods);
            }
            else if(action == KeyAction.Repeat && OnKeyRepeat != null)
            {
                OnKeyRepeat(wnd, key, scanCode, mods);
            }
        }

        private void onClick(GlfwWindowPtr wnd, MouseButton btn, KeyAction action)
        {
            if(OnMouseClick != null)
                OnMouseClick(wnd, btn, action);
        }

        /// <summary>
        /// Render the specified renderLoop. PollEvents and SwapBuffers done automaticaly
        /// </summary>
        /// <param name="renderLoop">Render loop.</param>
        public void Render(Action<GlfwWindowPtr,float> renderLoop)
        {
            while (!Glfw.WindowShouldClose(window))
            {
                timer.Stop();
                float deltaTime = (float)timer.ElapsedTicks / System.Diagnostics.Stopwatch.Frequency;
                timer.Restart();

                Glfw.PollEvents();
                renderLoop(window, deltaTime);
                Glfw.SwapBuffers(window);
            }
        }

        /// <summary>
        /// Terminate this instance.
        /// </summary>
        public void Terminate()
        {
            Glfw.Terminate();
        }
    }
}