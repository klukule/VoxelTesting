using klukule.GLFW3;
using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Components;

namespace VoxelTesting.Scripts
{
    public class PlayerControler : IScript
    {
        public override void Update()
        {
            base.Update();
            TransformComponent transform = ((GameObject)GetParent()).GetTransform();

            if (Keyboard.IsKeyPressed(Key.S)) transform.Position += transform.Orientation * (Vector3.UnitZ * Timers.DeltaTime * 5);
            if (Keyboard.IsKeyPressed(Key.W)) transform.Position += transform.Orientation * (-Vector3.UnitZ * Timers.DeltaTime * 5);
            if (Keyboard.IsKeyPressed(Key.A)) transform.Position += transform.Orientation * (-Vector3.UnitX * Timers.DeltaTime * 5);
            if (Keyboard.IsKeyPressed(Key.D)) transform.Position += transform.Orientation * (Vector3.UnitX * Timers.DeltaTime * 5);
            if (Keyboard.IsKeyPressed(Key.Space)) transform.Position += transform.Orientation * (Vector3.Up * Timers.DeltaTime * 3);

            if (Mouse.MouseDown(MouseButton.RightButton))
            {
                Mouse.HideCursor();
            }else
            {
                Mouse.ShowCursor();
            }

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
