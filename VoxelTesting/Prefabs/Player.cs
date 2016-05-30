using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Components;
using VoxelTesting.Scripts;

namespace VoxelTesting.Prefabs
{
    class Player : GameObject
    {
        public Player()
        {
            Name = "Player";
            AddComponent(new CameraComponent());
            AddComponent(new PlayerControler());
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
