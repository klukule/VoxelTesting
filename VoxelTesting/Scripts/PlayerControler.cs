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
        public override void Init()
        {
            base.Init();
            AddComponent(new BlockPicker());
        }
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

                Console.Clear();
            if (Mouse.IsCursorHidden)
            {
                float yaw = (Mouse.GetOldPosition().x - (int)Mouse.GetPosition().x) * 0.002f;
                float pitch = (Mouse.GetOldPosition().y - (int)Mouse.GetPosition().y) * 0.002f;

                transform.Orientation = Quaternion.FromAngleAxis(yaw, Vector3.Up) * transform.Orientation;

                Vector3 axis = transform.Orientation * Vector3.UnitX;

                transform.Orientation = Quaternion.FromAngleAxis(pitch, axis) * transform.Orientation;
            }
            
        }
    }
}
