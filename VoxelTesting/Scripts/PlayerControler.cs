using klukule.GLFW3;
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
    public class PlayerControler : IScript
    {
        public override void Update()
        {
            base.Update();
            TransformComponent transform = ((GameObject)GetParent()).GetTransform();
            float multiplier = 1;
            if (Keyboard.IsKeyPressed(Key.LeftShift)) multiplier = 4;
            if (Keyboard.IsKeyPressed(Key.S)) transform.Position += transform.Orientation * (Vector3.UnitZ * Timers.DeltaTime * 5 * multiplier);
            if (Keyboard.IsKeyPressed(Key.W)) transform.Position += transform.Orientation * (-Vector3.UnitZ * Timers.DeltaTime * 5 * multiplier);
            if (Keyboard.IsKeyPressed(Key.A)) transform.Position += transform.Orientation * (-Vector3.UnitX * Timers.DeltaTime * 5 * multiplier);
            if (Keyboard.IsKeyPressed(Key.D)) transform.Position += transform.Orientation * (Vector3.UnitX * Timers.DeltaTime * 5 * multiplier);
            if (Keyboard.IsKeyPressed(Key.Space)) transform.Position += transform.Orientation * (Vector3.Up * Timers.DeltaTime * 3 * multiplier);
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                Mouse.ShowCursor();
            }
            if (Mouse.MouseDown(MouseButton.RightButton))
            {
                Mouse.HideCursor();
            }

            if (Mouse.IsCursorHidden)
            {
                float yaw = (Mouse.GetOldPosition().x - (int)Mouse.GetPosition().x) * 0.002f;
                float pitch = (Mouse.GetOldPosition().y - (int)Mouse.GetPosition().y) * 0.002f;

                transform.Orientation = Quaternion.FromAngleAxis(yaw, Vector3.Up) * transform.Orientation;

                Vector3 axis = transform.Orientation * Vector3.UnitX;

                transform.Orientation = Quaternion.FromAngleAxis(pitch, axis) * transform.Orientation;

                Vector3 origin = ScreenToWorld(new Vector3(Program.WIN_WIDTH/2f,Program.WIN_HEIGHT/2f, 0),Game.GetInstance().GetCamera().ViewMatrix,Game.GetInstance().ProjectionMatrix,new int[] {0,0,Program.WIN_WIDTH,Program.WIN_HEIGHT});
                Vector3 camPos = Game.GetInstance().GetCamera().GetParent().GetComponent<TransformComponent>().Position;
                Ray ray = new Ray(camPos, (origin - camPos).Normalize());
                
                List<VoxelChunk> chunks = Game.GetInstance().GetComponents<VoxelChunk>();
                Console.Clear();
                Vector3 output = -Vector3.Identity;
                foreach(VoxelChunk chunk in chunks)
                {
                    FrustumComponent bb = chunk.GetComponent<FrustumComponent>();
                    if (ray.Intersects(bb.BoundingBox))
                    { 
                    Console.WriteLine(chunk.GetTransform().Position);
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
            // compute the inverse of the view and projection matrix
            Matrix4 m = (viewMatrix * projectionMatrix).Inverse();

            // transform the screen space co-ordinates into values normalized between -1 and +1
            Vector4 input;
            input.x = (screen.x - (float)viewPort[0]) / (float)viewPort[2] * 2.0f - 1.0f;
            input.y = (screen.y - (float)viewPort[1]) / (float)viewPort[3] * 2.0f - 1.0f;
            input.z = 2.0f * screen.z - 1.0f;
            input.w = 1.0f;

            // return the object co-ordinates
            Vector4 output = input * m;
            if (output[3] == 0.0) return Vector3.Zero;

            float scale = 1.0f / output.w;

            return new Vector3(output.x * scale, output.y * scale, output.z * scale);
        }
    }
}
