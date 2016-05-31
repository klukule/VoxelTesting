using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;

namespace VoxelTesting.Components
{
    public interface IMeshData { }
    
    public class IntMeshData : IMeshData
    {
        List<int> data;
        public IntMeshData SetData(List<int> data)
        {
            this.data = data;
            return this;
        }

        public List<int> GetData()
        {
            return data;
        }

        public int[] GetDataArray()
        {
            return data.ToArray();
        }
    }
    public class Vector2MeshData : IMeshData
    {
        List<Vector2> data;
        public Vector2MeshData SetData(List<Vector2> data)
        {
            this.data = data;
            return this;
        }

        public List<Vector2> GetData()
        {
            return data;
        }

        public Vector2[] GetDataArray()
        {
            return data.ToArray();
        }
    }
    public class Vector3MeshData : IMeshData
    {
        List<Vector3> data;
        public Vector3MeshData SetData(List<Vector3> data)
        {
            this.data = data;
            return this;
        }

        public List<Vector3> GetData()
        {
            return data;
        }

        public Vector3[] GetDataArray()
        {
            return data.ToArray();
        }
    }
    public class Vector4MeshData : IMeshData
    {
        List<Vector4> data;
        public Vector4MeshData SetData(List<Vector4> data)
        {
            this.data = data;
            return this;
        }

        public List<Vector4> GetData()
        {
            return data;
        }

        public Vector4[] GetDataArray()
        {
            return data.ToArray();
        }
    }

    public class MeshComponent : IComponent
    {
        public VAO MeshVAO;
        private Dictionary<string, IMeshData> meshData = new Dictionary<string, IMeshData> {};
        private BeginMode mode = BeginMode.Triangles;
        public void SetData(string name, IMeshData data)
        {
            meshData[name] = data;
        }
        public IMeshData GetData(string name)
        {
            IMeshData data;
            if(meshData.TryGetValue(name,out data)){
                return data;
            }
            return null;
        }
        public void SetVertex(Vector3MeshData data)
        {
            meshData["position"] = data;
        }
        public void SetNormal(Vector3MeshData data)
        {
            meshData["normal"] = data;
        }
        public void SetElement(IntMeshData data)
        {
            meshData["element"] = data;
        }

        public override void Init()
        {
            base.Init();
            meshData.Add("position", new Vector3MeshData());
            meshData.Add("normal", new Vector3MeshData());
            meshData.Add("element", new IntMeshData());
        }
        public void SetMode(BeginMode mode)
        {
            this.mode = mode;
        }
        public void Regenerate()
        {
            if (MeshVAO != null)
            {
                MeshVAO.DisposeChildren = true;
                MeshVAO.Dispose();
            }
            Vector3[] vertex = ((Vector3MeshData)meshData["position"]).GetDataArray();

            int[] element = ((IntMeshData)meshData["element"]).GetDataArray();
            Vector3[] normals = Geometry.CalculateNormals(vertex, element);
            MeshVAO = new VAO(ShaderFactory.GetShader("Testing/basic"), new VBO<Vector3>(vertex), new VBO<Vector3>(normals), new VBO<int>(element, BufferTarget.ElementArrayBuffer, BufferUsageHint.StaticRead));
            if(MeshVAO != null)
            {
                MeshVAO.DrawMode = mode;
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            if (MeshVAO != null)
            {
                MeshVAO.DisposeChildren = true;
                MeshVAO.Dispose();
            }
        }


    }
}
