using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Components;

namespace VoxelTesting.Base
{
    public class ShaderFactory
    {
        private static Dictionary<string, ShaderProgram> shaders = new Dictionary<string, ShaderProgram> { };

        public static ShaderProgram LoadShader(string name)
        {
            if (!shaders.ContainsKey(name))
            {
                shaders.Add(name, new ShaderProgram(File.ReadAllText("shaders/" + name + ".vs"), File.ReadAllText("shaders/" + name + ".fs")));
            }
            return shaders[name];
        }

        public static ShaderProgram GetShader(string name)
        {
            if (!shaders.ContainsKey(name))
            {
                throw new ShaderNotFoundEception(name);
            }
            return shaders[name];
        }

        public static void DisposeShader(string name)
        {
            if (!shaders.ContainsKey(name))
            {
                throw new ShaderNotFoundEception(name);
            }
            shaders[name].DisposeChildren = true;
            shaders[name].Dispose();
            shaders.Remove(name);
        }

        public static void Update()
        {
            CameraComponent cam = Game.GetInstance().GetCamera();
            foreach (ShaderProgram program in shaders.Values)
            {
                program["view_matrix"].SetValue(cam.ViewMatrix);
                program["projection_matrix"].SetValue(Game.GetInstance().ProjectionMatrix);
            }
        }

        public static void Dispose()
        {
            foreach (ShaderProgram program in shaders.Values)
            {
                program.DisposeChildren = true;
                program.Dispose();
            }
        }
    }

    public class ShaderNotFoundEception : Exception
    {
        public ShaderNotFoundEception(string name)
        {
            Console.WriteLine("Shader " + name + "not found");
        }
    }
}
