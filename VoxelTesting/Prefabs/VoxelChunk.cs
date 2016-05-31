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
            Invoker.AddToQueue(() =>
            {
                voxelData = ChunkLoader.LoadChunk(position, new Vector2(16, 16));
                RequestGreedy = true;
            }, Priority.HIGH);

        }

        public void SetBlock(Vector3 pos)
        {
            pos = pos - new Vector3(position.x, 0, position.y);
            if (pos.x > 15 || pos.y > 15 || pos.z > 15 || pos.x < 0 || pos.y < 0 || pos.z < 0)
            {
                List<VoxelChunk> chunks = Game.GetInstance().GetComponents<VoxelChunk>();
                SetBlockNextChunk(chunks, pos);
                return;
            }
            voxelData[(int)pos.x, (int)pos.y, (int)pos.z].transparent = false;
            RequestGreedy = true;
        }

        public void RemoveBlock(Vector3 pos)
        {
            pos = pos - new Vector3(position.x, 0, position.y);
            if (pos.x > 15 || pos.y > 15 || pos.z > 15 || pos.x < 0 || pos.y < 0 || pos.z < 0)
            {
                //Should not realy happen :D

                return;
            }
            voxelData[(int)pos.x, (int)pos.y, (int)pos.z].transparent = true;
            RequestGreedy = true;
        }

        private void SetBlockNextChunk(List<VoxelChunk> chunks, Vector3 position)
        {
            Vector3 chunkPos = new Vector3(this.position.x,0,this.position.y);
            VoxelChunk XPos = null;
            VoxelChunk XNeg = null;
            VoxelChunk ZPos = null;
            VoxelChunk ZNeg = null;
            foreach (VoxelChunk chunk in chunks)
            {
                Vector3 nchp = chunk.GetTransform().Position;
                if (nchp == chunkPos + Vector3.Right * 16)
                {
                    XPos = chunk;
                    continue;
                }
                if (nchp == chunkPos + Vector3.Left * 16)
                {
                    XNeg = chunk;
                    continue;
                }
                if (nchp == chunkPos + Vector3.Backward * 16)
                {
                    ZPos = chunk;
                    continue;
                }
                if (nchp == chunkPos + Vector3.Forward * 16)
                {
                    ZNeg = chunk;
                    continue;
                }
            }
            if (position.x > 15 && XPos != null)
            {
                Vector3 pos = new Vector3(position.x + chunkPos.x, position.y, position.z);
                XPos.SetBlock(pos);
            }
            if (position.x < 0 && XNeg != null)
            {
                Vector3 pos = new Vector3(position.x - chunkPos.x, position.y, position.z);
                XNeg.SetBlock(pos);
            }
            if (position.z > 15 && ZPos != null)
            {
                Vector3 pos = new Vector3(position.x, position.y, position.z + chunkPos.z);
                ZPos.SetBlock(pos);
            }
            if (position.z < 0 && ZNeg != null)
            {
                Vector3 pos = new Vector3(position.x, position.y, position.z - chunkPos.z);
                ZNeg.SetBlock(pos);
            }
        }

        public Vector3 Pick(Ray ray)
        {
            AxisAlignedBoundingBox bb = new AxisAlignedBoundingBox();
            Vector3 v3pos = new Vector3(position.x, 0, position.y);
            List<Vector3> colliding = new List<Vector3> { };
            for(int x = 0; x <16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    for (int z = 0; z < 16; z++)
                    {

                        if(voxelData[x,y,z].transparent == false)
                        {
                            bb.Min = new Vector3(x, y, z) + v3pos;
                            bb.Max = new Vector3(x, y, z) + v3pos + Vector3.Identity;
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
                    if (distance == 0 || dist <= distance)
                    {
                        distance = dist;
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
