using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;

namespace VoxelTesting.Components
{
    class FrustumComponent : IComponent
    {
        public AxisAlignedBoundingBox BoundingBox;
        private Vector3 size;
        public MeshRendererComponent Target;
        public FrustumComponent(Vector3 size): base()
        {
            this.size = size;
        }
        public override void Update()
        {
            base.Update();
            if(BoundingBox == null)
            {
                UpdateBoundingBox(size);
            }
            if (Game.GetInstance().GetCamera() != null)
            {
                if (Game.GetInstance().GetCamera().Frustum.Intersects(BoundingBox))
                {
                    Target.IsEnabled = true;
                }
                else
                {
                    Target.IsEnabled = false;
                }
            }
        }

        public void UpdateBoundingBox(Vector3 size)
        {
            BoundingBox = new AxisAlignedBoundingBox(GetParent().GetComponent<TransformComponent>().Position, GetParent().GetComponent<TransformComponent>().Position + size);
        }
    }
}
