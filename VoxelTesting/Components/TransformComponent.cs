using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Components
{
    public class TransformComponent : IComponent
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Scale = Vector3.Identity;
        public Quaternion Orientation = Quaternion.Identity;
    }
}
