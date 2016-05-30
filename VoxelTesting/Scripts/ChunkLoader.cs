using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Prefabs;

namespace VoxelTesting.Scripts
{
    public class ChunkLoader : IScript
    {
        public static VoxelFace[,,] LoadChunk(Vector2 position,Vector2 size)
        {
            if (File.Exists("chunks/" + position.x + "_" + position.y + ".chunk"))
            {
                return new VoxelFace[,,] { };
            }
            else
            {
                return ChunkGenerator.GenerateChunk(position,size);
            }
        }
    }
}
