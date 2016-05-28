using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;

namespace VoxelTesting.Components
{
    public class CameraComponent : IComponent
    {
        public Matrix4 ViewMatrix = Matrix4.Identity;
        public override void Init()
        {
        }

        public override void Update()
        {
            base.Update();
            TransformComponent transform = ((GameObject)GetParent()).GetTransform();
            ViewMatrix = Matrix4.CreateTranslation(-transform.Position) * transform.Orientation.Matrix4;
        }
    }
}
