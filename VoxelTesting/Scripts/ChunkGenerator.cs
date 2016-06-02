using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klukule.OpenGL;
using VoxelTesting.Base;
using VoxelTesting.Prefabs;

namespace VoxelTesting.Scripts
{
    public class ChunkGenerator : IScript
    {
        public static VoxelFace[,,] GenerateChunk(Vector2 position, Vector2 size)
        {
            VoxelFace[,,] chunkData = new VoxelFace[(int)size.x,(int)size.y,(int)size.x];
            VoxelFace face;

            for (var i = 0; i < size.x; i++)
            {
                for (var j = 0; j < size.x; j++)
                {
                    float h = SimplexNoise.Generate(Math.Abs((position.x + i + 50) / 32f), Math.Abs((position.y + j + 50) / 45f));
                    h = (float)Math.Round(h * 8) + 3;
                    for (var k = 0; k < size.y; k++)
                    {
                        face = new VoxelFace();
                        face.type = 1;
                        
                        if(k >= h && k > 0)
                        {
                            face.transparent = true;
                        }
                        chunkData[i, k, j] = face;
                    }
                }
            }

            return chunkData;
        }
    }
}
