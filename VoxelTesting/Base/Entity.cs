using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Components;

namespace VoxelTesting.Base
{
    public class GameObject : IComponent
    {
        public GameObject()
        {
            AddComponent(new TransformComponent());
        }

        public TransformComponent GetTransform()
        {
            return GetComponent<TransformComponent>();
        }
    }
}
