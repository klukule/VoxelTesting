using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Components;

namespace VoxelTesting.Chunks
{
    class VoxelChunk : GameObject
    {
        public override void Init()
        {
            AddComponent(new GreedyComponent());
        }

        public override void Update()
        {
        }

        public override void Draw()
        {
        }

        public override void Dispose()
        {
        }
    }
}
