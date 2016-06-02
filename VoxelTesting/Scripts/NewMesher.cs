using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Scripts
{
    public class NewMesher
    {
        public enum FaceOrientation
        {
            XZ,
            XY,
            YZ
        }
        public List<Vector3> vertex = new List<Vector3> { };
        public List<int> elems = new List<int> { };
        public void Tester()
        {
            int[] pole = new int[32 * 128 * 32];
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 128; y++)
                {
                    for (int z = 0; z < 32; z++)
                    {
                        pole[x + 128 * y + 32 * 32 * z] = 1;
                    }
                }
            }
                        FaceOrientation or = FaceOrientation.XY;
            int imax = 32;
            int jmax = 128;
            int lay = 1;
            OptimizeFaces(pole, or, imax, jmax, lay);
        }

        public void OptimizeFaces(int[] mask, FaceOrientation orientation, int imax, int jmax, int layer)
        {
            Vector3 v1 = Vector3.Zero, v2 = Vector3.Zero, v3 = Vector3.Zero, v4 = Vector3.Zero;

            // optimize the voxels by first looking for a long strip, and then a rectangle or strip in the other direction
            // this new optimizer is about 3x faster than the old one, and reduces vertex count by approximately 10%
            for (int i = 0; i < imax; i++)
            {
                for (int j = 0; j < jmax; j++)
                {
                    int data = mask[i + j * imax];
                    if (data == 0) continue;
                     
                    bool possible = true;
                    int sizei, sizej;
 
                    for (sizei = 2; sizei < imax; sizei++)
                    {
                        if ((i + sizei) >= (imax + 1)) break;
 
                        for (int ii = i; ii < i + sizei; ii++)
                        {
                            if (mask[ii + j * imax] != data)
                            {
                                possible = false;
                                break;
                            }
                        }
 
                        if (!possible) break;
                    }
                    sizei--;
 
                    possible = true;
                    for (sizej = 2; sizej < jmax; sizej++)
                    {
                        if ((j + sizej) >= (jmax + 1)) break;
 
                        for (int ii = i; ii < i + sizei; ii++)
                        {
                            int jj = sizej + j - 1;
 
                            if (mask[ii + jj * imax] != data)
                            {
                                possible = false;
                                break;
                            }
                        }
 
                        if (!possible) break;
                    }
                    sizej--;
 
                    if (sizei > 1 || sizej > 1)
                    {
                        int x = (orientation == FaceOrientation.XZ || orientation == FaceOrientation.XY ? i : layer);
                        int y = (orientation == FaceOrientation.XY ? j : (orientation == FaceOrientation.YZ ? i : layer));
                        int z = (orientation == FaceOrientation.XZ || orientation == FaceOrientation.YZ ? j : layer);
 
                        v1 = new Vector3(x, y, z);
                        v2 = (orientation == FaceOrientation.YZ ? new Vector3(x, y + sizei, z) : new Vector3(x + sizei, y, z));
                        v3 = (orientation == FaceOrientation.YZ ? new Vector3(x, y + sizei, z + sizej) : (orientation == FaceOrientation.XZ ? new Vector3(x + sizei, y, z + sizej) : new Vector3(x + sizei, y + sizej, z)));
                        v4 = (orientation == FaceOrientation.XY ? new Vector3(x, y + sizej, z) : new Vector3(x, y, z + sizej));
 
                        AddOptimizedFace(v1, v2, v3, v4, orientation, data, 1);
 
                        for (int ii = i; ii < i + sizei; ii++)
                            for (int jj = j; jj < j + sizej; jj++) mask[ii + jj * imax] = 0;
                    }
                }
            }

            // add any of the left over faces
            for (int i = 0; i < imax; i++)
            {
                for (int j = 0; j < jmax; j++)
                {
                    int data = mask[i + j * imax];
                    if (data == 0) continue;

                    int x = (orientation == FaceOrientation.XZ || orientation == FaceOrientation.XY ? i : layer);
                    int y = (orientation == FaceOrientation.XY ? j : (orientation == FaceOrientation.YZ ? i : layer));
                    int z = (orientation == FaceOrientation.XZ || orientation == FaceOrientation.YZ ? j : layer);

                    v1 = new Vector3(x, y, z);
                    v2 = (orientation == FaceOrientation.YZ ? new Vector3(x, y + 1, z) : new Vector3(x + 1, y, z));
                    v3 = (orientation == FaceOrientation.YZ ? new Vector3(x, y + 1, z + 1) : (orientation == FaceOrientation.XZ ? new Vector3(x + 1, y, z + 1) : new Vector3(x + 1, y + 1, z)));
                    v4 = (orientation == FaceOrientation.XY ? new Vector3(x, y + 1, z) : new Vector3(x, y, z + 1));

                    AddOptimizedFace(v1, v2, v3, v4, orientation, data, 1);
                }
            }
        }

        private void AddOptimizedFace(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4, FaceOrientation orientation, int data, int v)
        {
            int offset = vertex.Count;
            vertex.Add(v1);
            vertex.Add(v2);
            vertex.Add(v3);
            vertex.Add(v4);
            int[] indexes = new int[] { 0 + offset, 1 + offset, 2 + offset, 0 + offset, 2 + offset, 3 + offset };
            elems.AddRange(indexes);
            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", v1, v2, v3, v4, orientation, data, v);
        }
    }
}
