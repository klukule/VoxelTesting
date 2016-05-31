using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Components;
using VoxelTesting.Prefabs;

namespace VoxelTesting.Scripts
{
    public class BlockPicker : IScript
    {
        public override void Update()
        {
            base.Update();
            if (Mouse.IsCursorHidden)
            {
                Vector3 origin = ScreenToWorld(new Vector3(Program.WIN_WIDTH / 2f, Program.WIN_HEIGHT / 2f, 0), Game.GetInstance().GetCamera().ViewMatrix, Game.GetInstance().ProjectionMatrix, new int[] { 0, 0, Program.WIN_WIDTH, Program.WIN_HEIGHT });
                Vector3 camPos = Game.GetInstance().GetCamera().GetParent().GetComponent<TransformComponent>().Position;
                Ray ray = new Ray(camPos, (origin - camPos).Normalize());

                List<VoxelChunk> chunks = Game.GetInstance().GetComponents<VoxelChunk>();
                Vector3 output = -Vector3.Identity;
                foreach (VoxelChunk chunk in chunks)
                {
                    FrustumComponent bb = chunk.GetComponent<FrustumComponent>();
                    if (ray.Intersects(bb.BoundingBox))
                    {
                        Console.WriteLine("hi");
                        Vector3 block = chunk.Pick(ray);
                        if (output == -Vector3.Identity)
                        {
                            output = block;
                        }
                    }
                }
                HilightBlock hb = Game.GetInstance().GetComponent<HilightBlock>();
                if (output == -Vector3.Identity)
                {
                    hb.IsEnabled = false;
                }
                else
                {
                    hb.SetPosition(output);
                    hb.IsEnabled = true;
                }
            }
        }

        private Vector3 ScreenToWorld(Vector3 screen, Matrix4 viewMatrix, Matrix4 projectionMatrix, int[] viewPort)
        {
            Matrix4 m = (viewMatrix * projectionMatrix).Inverse();

            Vector4 input;
            input.x = (screen.x - (float)viewPort[0]) / (float)viewPort[2] * 2.0f - 1.0f;
            input.y = (screen.y - (float)viewPort[1]) / (float)viewPort[3] * 2.0f - 1.0f;
            input.z = 2.0f * screen.z - 1.0f;
            input.w = 1.0f;

            Vector4 output = input * m;
            if (output[3] == 0.0) return Vector3.Zero;

            float scale = 1.0f / output.w;

            return new Vector3(output.x * scale, output.y * scale, output.z * scale);
        }
    }
}
