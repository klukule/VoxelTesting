using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Prefabs;

namespace VoxelTesting.Scripts
{
    public struct GreedyData
    {
        public List<Vector3> Vertices;
        public List<Vector3> Normals;
        public List<int> Elements;
        public List<Vector4> Colors;
    }
    public class GreedyMeshing : IScript
    {
        private GreedyData data = new GreedyData();
        public GreedyData Generate(VoxelFace[,,] voxelData, Vector2 size)
        {
            data = new GreedyData();
            data.Vertices = new List<Vector3> { };
            data.Elements = new List<int> { };
            data.Normals = new List<Vector3> { };
            data.Colors = new List<Vector4> { };
            int CHUNK_WIDTH = (int)size.x;
            int CHUNK_HEIGHT = (int)size.y;
            /*NewMesher mesher = new NewMesher();
            int[] pole = new int[16 * 16];
            for (int i = 0; i < pole.Length; i++) pole[i] = 1;
            mesher.OptimizeFaces(pole, NewMesher.FaceOrientation.XY, 16, 16, 16);
            data.Vertices = mesher.vertex;
            data.Elements = mesher.elems;
            data.Normals = Geometry.CalculateNormals(data.Vertices.ToArray(), data.Elements.ToArray()).ToList();*/
            int i, j, k, l, w, h, u, v, n = 0;
            VoxelSide side = VoxelSide.NONE;

            int[] x = new int[] { 0, 0, 0 };
            int[] q = new int[] { 0, 0, 0 };
            int[] du = new int[] { 0, 0, 0 };
            int[] dv = new int[] { 0, 0, 0 };

            VoxelFace[] mask = new VoxelFace[CHUNK_WIDTH * CHUNK_HEIGHT];

            VoxelFace voxelFace, voxelFace1;

            for (bool backFace = true, b = false; b != backFace; backFace = backFace && b, b = !b)
            {
                for (int d = 0; d < 3; d++)
                {

                    u = (d + 1) % 3;
                    v = (d + 2) % 3;

                    x[0] = 0;
                    x[1] = 0;
                    x[2] = 0;

                    q[0] = 0;
                    q[1] = 0;
                    q[2] = 0;
                    q[d] = 1;

                    if (d == 0) { side = backFace ? VoxelSide.WEST : VoxelSide.EAST; }
                    else if (d == 1) { side = backFace ? VoxelSide.BOTTOM : VoxelSide.TOP; }
                    else if (d == 2) { side = backFace ? VoxelSide.SOUTH : VoxelSide.NORTH; }

                    for (x[d] = -1; x[d] < CHUNK_WIDTH;)
                    {
                        n = 0;

                        for (x[v] = 0; x[v] < CHUNK_HEIGHT; x[v]++)
                        {

                            for (x[u] = 0; x[u] < CHUNK_WIDTH; x[u]++)
                            {

                                voxelFace = (x[d] >= 0) ? GetVoxelFace(x[0], x[1], x[2], side, ref voxelData) : null;
                                voxelFace1 = (x[d] < CHUNK_WIDTH - 1) ? GetVoxelFace(x[0] + q[0], x[1] + q[1], x[2] + q[2], side, ref voxelData) : null;


                                mask[n++] = ((voxelFace != null && voxelFace1 != null && voxelFace.equals(voxelFace1)))
                                            ? null
                                            : backFace ? voxelFace1 : voxelFace;
                            }
                        }

                        x[d]++;
                        n = 0;

                        for (j = 0; j < CHUNK_HEIGHT; j++)
                        {

                            for (i = 0; i < CHUNK_WIDTH;)
                            {

                                if (mask[n] != null)
                                {

                                    for (w = 1; i + w < CHUNK_WIDTH && mask[n + w] != null && mask[n + w].equals(mask[n]); w++) { }

                                    bool done = false;

                                    for (h = 1; j + h < CHUNK_HEIGHT; h++)
                                    {

                                        for (k = 0; k < w; k++)
                                        {

                                            if (mask[n + k + h * CHUNK_WIDTH] == null || !mask[n + k + h * CHUNK_WIDTH].equals(mask[n])) { done = true; break; }
                                        }

                                        if (done) { break; }
                                    }

                                    if (!mask[n].transparent)
                                    {
                                        x[u] = i;
                                        x[v] = j;

                                        du[0] = 0;
                                        du[1] = 0;
                                        du[2] = 0;
                                        du[u] = w;

                                        dv[0] = 0;
                                        dv[1] = 0;
                                        dv[2] = 0;
                                        dv[v] = h;

                                        Quad(new Vector3(x[0], x[1], x[2]),
                                             new Vector3(x[0] + du[0], x[1] + du[1], x[2] + du[2]),
                                             new Vector3(x[0] + du[0] + dv[0], x[1] + du[1] + dv[1], x[2] + du[2] + dv[2]),
                                             new Vector3(x[0] + dv[0], x[1] + dv[1], x[2] + dv[2]),
                                             w,
                                             h,
                                             mask[n],
                                             backFace);
                                    }

                                    for (l = 0; l < h; ++l)
                                    {

                                        for (k = 0; k < w; ++k) { mask[n + k + l * CHUNK_WIDTH] = null; }
                                    }

                                    i += w;
                                    n += w;

                                }
                                else
                                {

                                    i++;
                                    n++;
                                }
                            }
                        }
                    }
                }
            }
            return data;
        }
        private void Quad(Vector3 bottomLeft,
              Vector3 topLeft,
              Vector3 topRight,
              Vector3 bottomRight,
              int width,
              int height,
              VoxelFace voxel,
              bool backFace)
        {
            int VOXEL_SIZE = 1;
            int offset = data.Vertices.Count;

            Vector3[] verts = new Vector3[4];

            verts[2] = topLeft * VOXEL_SIZE;
            verts[3] = topRight * VOXEL_SIZE;
            verts[0] = bottomLeft * VOXEL_SIZE;
            verts[1] = bottomRight * VOXEL_SIZE;
            data.Vertices.AddRange(verts);

            int[] indexes = backFace ? new int[] { 2 + offset, 0 + offset, 1 + offset, 1 + offset, 3 + offset, 2 + offset } : new int[] { 2 + offset, 3 + offset, 1 + offset, 1 + offset, 0 + offset, 2 + offset };

            data.Elements.AddRange(indexes);

            Vector2[] colorArray = new Vector2[4];
            if (voxel.side == VoxelSide.BOTTOM)
            {
                colorArray[1] = new Vector2(1 * (verts[2].z - verts[0].z), -1 * (verts[3].x - verts[2].x));
                colorArray[3] = new Vector2(0 * (verts[2].z - verts[0].z), -1 * (verts[3].x - verts[2].x));
                colorArray[0] = new Vector2(1 * (verts[2].z - verts[0].z), 0 * (verts[3].x - verts[2].x));
                colorArray[2] = new Vector2(0 * (verts[2].z - verts[0].z), 0 * (verts[3].x - verts[2].x));
            }
            if (voxel.side == VoxelSide.TOP)
            {
                colorArray[3] = new Vector2(-1 * (verts[2].z - verts[0].z), 1 * (verts[3].x - verts[2].x));
                colorArray[1] = new Vector2(0 * (verts[2].z - verts[0].z), 1 * (verts[3].x - verts[2].x));
                colorArray[2] = new Vector2(-1 * (verts[2].z - verts[0].z), 0 * (verts[3].x - verts[2].x));
                colorArray[0] = new Vector2(0 * (verts[2].z - verts[0].z), 0 * (verts[3].x - verts[2].x));
            }
            if (voxel.side == VoxelSide.NORTH)
            {

                colorArray[3] = new Vector2(1 * (verts[2].x - verts[0].x), -1 * (verts[1].y - verts[0].y));
                colorArray[1] = new Vector2(0 * (verts[2].x - verts[0].x), -1 * (verts[1].y - verts[0].y));
                colorArray[2] = new Vector2(1 * (verts[2].x - verts[0].x), 0 * (verts[1].y - verts[0].y));
                colorArray[0] = new Vector2(0 * (verts[2].x - verts[0].x), 0 * (verts[1].y - verts[0].y));
            }
            if (voxel.side == VoxelSide.SOUTH)
            {
                colorArray[1] = new Vector2(1 * (verts[2].x - verts[0].x), -1 * (verts[1].y - verts[0].y));
                colorArray[3] = new Vector2(0 * (verts[2].x - verts[0].x), -1 * (verts[1].y - verts[0].y));
                colorArray[0] = new Vector2(1 * (verts[2].x - verts[0].x), 0 * (verts[1].y - verts[0].y));
                colorArray[2] = new Vector2(0 * (verts[2].x - verts[0].x), 0 * (verts[1].y - verts[0].y));
            }
            if (voxel.side == VoxelSide.EAST)
            {


                colorArray[2] = new Vector2(1 * (verts[1].z - verts[0].z), 1 * (verts[1].y - verts[2].y));
                colorArray[3] = new Vector2(0 * (verts[1].z - verts[0].z), 1 * (verts[1].y - verts[2].y));
                colorArray[0] = new Vector2(1 * (verts[1].z - verts[0].z), 0 * (verts[1].y - verts[2].y));
                colorArray[1] = new Vector2(0 * (verts[1].z - verts[0].z), 0 * (verts[1].y - verts[2].y));
            }
            if (voxel.side == VoxelSide.WEST)
            {
                colorArray[3] = new Vector2(1 * (verts[1].z - verts[0].z), 1 * (verts[1].y - verts[2].y));
                colorArray[2] = new Vector2(0 * (verts[1].z - verts[0].z), 1 * (verts[1].y - verts[2].y));
                colorArray[1] = new Vector2(1 * (verts[1].z - verts[0].z), 0 * (verts[1].y - verts[2].y));
                colorArray[0] = new Vector2(0 * (verts[1].z - verts[0].z), 0 * (verts[1].y - verts[2].y));
            }

            //uvs.AddRange(colorArray);
        }

        VoxelFace GetVoxelFace(int x, int y, int z, VoxelSide side, ref VoxelFace[,,] voxels)
        {
            VoxelFace voxelFace = voxels[x, y, z];
            voxelFace.side = side;
            return voxelFace;
        }
    }
}
