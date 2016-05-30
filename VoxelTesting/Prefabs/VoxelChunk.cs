using klukule.GLFW3;
using klukule.OpenGL;
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
    public class VoxelFace
    {
        public bool transparent;
        public int type;
        public VoxelSide side;

        public bool equals(VoxelFace face) { return face.transparent == this.transparent && face.type == this.type; }
    }

    public enum VoxelSide
    {
        NONE,
        WEST,
        EAST,
        BOTTOM,
        SOUTH,
        NORTH,
        TOP
    }

    class VoxelChunk : GameObject
    {
        private GreedyMeshing greedy = new GreedyMeshing();
        private bool RequestRegen = false;
        private bool RequestGreedy = true;
        private bool Wireframe = false;
        private int timeout = 0;
        private Vector2 position = Vector2.Zero;
        private MeshComponent mesh;
        private MeshRendererComponent renderer;
        private VoxelFace[,,] voxelData;

        public Vector2 GetPosition()
        {
            return position;
        }

        public VoxelChunk(Vector2 position) : base()
        {
            this.position = position;
            GetTransform().Position = new Vector3(position.x, 0, position.y);
            Parallel.Invoke(() =>
            {
                voxelData = ChunkLoader.LoadChunk(position, new Vector2(16, 16));
                RequestGreedy = true;
            });

        }

        public override void Init()
        {
            Name = "VoxelChunk";
            mesh = (MeshComponent)AddComponent(new MeshComponent());
            renderer = (MeshRendererComponent)AddComponent(new MeshRendererComponent());
            renderer.Shader = "Testing/basic";
            renderer.MeshToRender = mesh;
            Invoker.AddToQueue(() =>
            {
                voxelData = ChunkLoader.LoadChunk(position, new Vector2(16, 16));
                RequestGreedy = true;
            },Priority.HIGH);
        }
        public override void Update()
        {
            if (RequestGreedy)
            {
                RequestGreedy = false;
                Invoker.AddToQueue(() => {
                    GreedyData data = greedy.Generate(voxelData, new Vector2(16, 16));
                    mesh.SetVertex(new Vector3MeshData().SetData(data.Vertices));
                    mesh.SetNormal(new Vector3MeshData().SetData(data.Normals));
                    mesh.SetElement(new IntMeshData().SetData(data.Elements));
                    mesh.SetData("color", new Vector4MeshData().SetData(data.Colors));
                    RequestRegen = true;
                },Priority.HIGH);
            }
            if (RequestRegen)
            {
                RequestRegen = false;
                mesh.Regenerate();
            }
            if(timeout > 0)
            {
                timeout--;
            }

            if (Keyboard.IsKeyPressed(Key.Q))
            {
                if (timeout <= 0)
                {
                    if (!Wireframe)
                    {
                        renderer.RenderMode = RenderMode.Wireframe;
                        Wireframe = true;
                        timeout = 30;
                    }
                    else
                    {
                        renderer.RenderMode = RenderMode.Solid;
                        Wireframe = false;
                        timeout = 30;
                    }
                }
            }
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
