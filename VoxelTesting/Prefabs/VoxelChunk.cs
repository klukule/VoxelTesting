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
        private FrustumComponent frustum;
        private VoxelFace[,,] voxelData;
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
        public Vector3 Pick(Ray ray)
        {
            AxisAlignedBoundingBox bb = new AxisAlignedBoundingBox();
            Vector3 v3pos = new Vector3(position.x, 0, position.y);
            List<Vector3> colliding = new List<Vector3> { };
            for(int x = 0; x <16; x++)
            {
                for (int y = 15; y >= 0; y--)
                {
                    for (int z = 0; z < 16; z++)
                    {

                        if(voxelData[x,y,z].transparent == false)
                        {
                            bb.Min = new Vector3(x, y, z) + v3pos;
                            bb.Max = bb.Min + Vector3.Identity + v3pos;
                            if (ray.Intersects(bb))
                            {
                                colliding.Add(bb.Center);
                            }
                        }
                    }
                }
            }
            float distance = 0;
            Vector3 output = -Vector3.Identity;
            Vector3 camPos = Game.GetInstance().GetCamera().GetParent().GetComponent<TransformComponent>().Position;
            foreach(Vector3 bbpos in colliding)
            {
                float dist = MathHelper.Distance(camPos, bbpos);
                if (dist <= 20)
                {
                    if (distance == 0 || Math.Abs(dist) <= distance)
                    {
                        distance = Math.Abs(dist);
                        output = bbpos - (Vector3.Identity / 2f);
                    }
                }
            }
            return output;
        }
        public override void Init()
        {
            Name = "VoxelChunk";
            mesh = (MeshComponent)AddComponent(new MeshComponent());
            renderer = (MeshRendererComponent)AddComponent(new MeshRendererComponent());
            renderer.Shader = "Testing/basic";
            renderer.MeshToRender = mesh;
            frustum = (FrustumComponent)AddComponent(new FrustumComponent(new Vector3(16, 16, 16)));
            frustum.Target = renderer;
            Invoker.AddToQueue(() =>
            {
                voxelData = ChunkLoader.LoadChunk(position, new Vector2(16, 16));
                RequestGreedy = true;
            },Priority.HIGH);
        }
        public override void Update()
        {
            base.Update();
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
