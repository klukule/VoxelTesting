using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;
using VoxelTesting.Components;

namespace VoxelTesting.Prefabs
{
    class HilightBlock : GameObject
    {
        private bool ScaleSet = false;

        public void SetPosition(Vector3 position)
        {
            GetTransform().Position = position;
            GetTransform().Position += new Vector3(-0.01, -0.01, -0.01);
        }

        public override void Init()
        {
            base.Init();
            MeshComponent mesh = (MeshComponent)AddComponent(new MeshComponent());
            MeshRendererComponent renderer = (MeshRendererComponent)AddComponent(new MeshRendererComponent());
            renderer.Shader = "Testing/noLight";
            renderer.MeshToRender = mesh;
            List<Vector3> vertex = new List<Vector3> { };
            vertex.Add(new Vector3(0, 0, 0));
            vertex.Add(new Vector3(1, 0, 0));
            vertex.Add(new Vector3(1, 0, 1));
            vertex.Add(new Vector3(0, 0, 1));
            vertex.Add(new Vector3(0, 1, 0));
            vertex.Add(new Vector3(1, 1, 0));
            vertex.Add(new Vector3(1, 1, 1));
            vertex.Add(new Vector3(0, 1, 1));
            List<int> element = new List<int> { };
            element.Add(0);
            element.Add(1);
            element.Add(1);
            element.Add(2);
            element.Add(2);
            element.Add(3);
            element.Add(3);
            element.Add(0);
            element.Add(0);
            element.Add(4);
            element.Add(1);
            element.Add(5);
            element.Add(2);
            element.Add(6);
            element.Add(3);
            element.Add(7);
            element.Add(4);
            element.Add(5);
            element.Add(5);
            element.Add(6);
            element.Add(6);
            element.Add(7);
            element.Add(7);
            element.Add(4);
            List<Vector3> normal = Geometry.CalculateNormals(vertex.ToArray(), element.ToArray()).ToList();
            mesh.SetNormal(new Vector3MeshData().SetData(normal));
            mesh.SetVertex(new Vector3MeshData().SetData(vertex));
            mesh.SetElement(new IntMeshData().SetData(element));
            mesh.Regenerate();
            mesh.MeshVAO.DrawMode = BeginMode.Lines;


        }
        public override void Update()
        {
            base.Update();
            if (!ScaleSet)
            {
                GetTransform().Scale = new Vector3(1.02, 1.02, 1.02);
                SetPosition(new Vector3(0, 1, 0));
                ScaleSet = true;
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
