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
    public class ChunkManager : IScript
    {
        private int ViewDistance = 10;
        public override void Update()
        {
            if (Game.GetInstance().GetCamera() != null)
            {
                Vector3 camPos = Game.GetInstance().GetCamera().GetParent().GetComponent<TransformComponent>().Position;
                Vector3 chunkInIndex = new Vector3((int)camPos.x / 16, (int)camPos.y / 16, (int)camPos.z / 16);
                chunkInIndex.y = 0;
                Vector3 currentChunkPos = chunkInIndex * 16;
                List<VoxelChunk> chunks = Game.GetInstance().GetComponents<VoxelChunk>();
                VoxelChunk[][] grid = new VoxelChunk[2* ViewDistance + 1][];
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i] = new VoxelChunk[2 * ViewDistance + 1];
                }
                foreach(VoxelChunk chunk in chunks)
                {
                    Vector3 pos = chunk.GetTransform().Position;
                    Vector3 chi = new Vector3((int)pos.x / 16, (int)pos.y / 16, (int)pos.z / 16) - chunkInIndex;
                    Vector3 tf = chi + ViewDistance;
                    if (Math.Abs(chi.x) <= ViewDistance && Math.Abs(chi.z) <= ViewDistance)
                    {
                        grid[(int)tf.x][(int)tf.z] = chunk;
                    }
                    else {

                        Parallel.Invoke(() => { Game.GetInstance().RemoveComponent(chunk); });
                    }
                }
                
                for(int x = 0;x < grid.Length; x++)
                {
                    for(int z = 0; z < grid[x].Length; z++)
                    {
                        if(grid[x][z] == null)
                        {
                            int realX = (x - ViewDistance) * 16;
                            int realZ = (z - ViewDistance) * 16;
                            Vector2 RealPos = new Vector2(currentChunkPos.x + realX, currentChunkPos.z + realZ);
                            Parallel.Invoke(() => { Game.GetInstance().AddComponent(new VoxelChunk(RealPos)); });
                        }
                    }
                }
            }
        }
    }
}
