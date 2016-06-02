﻿using klukule.GLFW3;
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
    public class BlockPicker : IScript
    {
        private int ltimer = 0;
        private int rtimer = 0;
        public override void Update()
        {
            base.Update();
            if (Mouse.IsCursorHidden)
            {
                Vector3 origin = ScreenToWorld(new Vector3(Program.WIN_WIDTH / 2f, Program.WIN_HEIGHT / 2f, 0), Game.GetInstance().GetCamera().ViewMatrix, Game.GetInstance().ProjectionMatrix, new int[] { 0, 0, Program.WIN_WIDTH, Program.WIN_HEIGHT });
                Vector3 camPos = Game.GetInstance().GetCamera().GetParent().GetComponent<TransformComponent>().Position;
                Ray ray = new Ray(camPos, (origin - camPos).Normalize());

                List<VoxelChunk> chunks = Game.GetInstance().GetComponents<VoxelChunk>();
                List<Vector3> outputs = new List<Vector3> { };
                List<VoxelChunk> chunkPass = new List<VoxelChunk> { };
                foreach (VoxelChunk chunk in chunks)
                {
                    FrustumComponent bb = chunk.GetComponent<FrustumComponent>();
                    if (bb.BoundingBox != null)
                    {
                        if (ray.Intersects(bb.BoundingBox))
                        {
                            Vector3 block = chunk.Pick(ray);
                            chunkPass.Add(chunk);
                            outputs.Add(block);
                        }
                    }
                }
                Vector3 output = -Vector3.Identity;
                VoxelChunk outputChunk = null;
                float distance = 0;
                int i = 0;
                foreach (Vector3 block in outputs)
                {
                    float dist = MathHelper.Distance(camPos, block);
                    if (distance == 0 || dist <= distance)
                    {
                        distance = dist;
                        output = block;
                        outputChunk = chunkPass[i];
                    }
                    i++;
                }
                HilightBlock hb = Game.GetInstance().GetComponent<HilightBlock>();
                if (output == -Vector3.Identity)
                {
                    hb.IsEnabled = false;
                }
                else
                {
                    hb.SetPosition(output);
                    hb.IsEnabled = true;
                }
                Face face = CheckFace(output, output + Vector3.Identity, camPos, ray);
                if(Mouse.MouseState(MouseButton.LeftButton) == KeyAction.Release)
                {
                    ltimer = 0;
                }
                if (Mouse.MouseState(MouseButton.RightButton) == KeyAction.Release)
                {
                    rtimer = 0;
                }
                if (Mouse.MouseDown(MouseButton.LeftButton) && ltimer == 0)
                {
                    if (outputChunk != null)
                    {
                        outputChunk.RemoveBlock(output);
                        ltimer = 20;
                    }
                }

                if (Mouse.MouseDown(MouseButton.RightButton) && rtimer == 0)
                {
                    if (outputChunk != null)
                    {

                        switch (face)
                        {
                            case Face.XN:
                                outputChunk.SetBlock(output + Vector3.Left);
                                break;
                            case Face.XP:
                                outputChunk.SetBlock(output + Vector3.Right);
                                break;
                            case Face.YN:
                                outputChunk.SetBlock(output + Vector3.Down);
                                break;
                            case Face.YP:
                                outputChunk.SetBlock(output + Vector3.Up);
                                break;
                            case Face.ZN:
                                outputChunk.SetBlock(output + Vector3.Backward);
                                break;
                            case Face.ZP:
                                outputChunk.SetBlock(output + Vector3.Forward);
                                break;
                        }
                        rtimer = 20;
                    }
                }
                if(ltimer > 0)
                {
                    ltimer--;
                }

                if(rtimer > 0)
                {
                    rtimer--;
                }

            }
        }

        private Vector3 ScreenToWorld(Vector3 screen, Matrix4 viewMatrix, Matrix4 projectionMatrix, int[] viewPort)
        {
            Matrix4 m = (viewMatrix * projectionMatrix).Inverse();

            Vector4 input;
            input.x = (screen.x - (float)viewPort[0]) / (float)viewPort[2] * 2.0f - 1.0f;
            input.y = (screen.y - (float)viewPort[1]) / (float)viewPort[3] * 2.0f - 1.0f;
            input.z = 2.0f * screen.z - 1.0f;
            input.w = 1.0f;

            Vector4 output = input * m;
            if (output[3] == 0.0) return Vector3.Zero;

            float scale = 1.0f / output.w;

            return new Vector3(output.x * scale, output.y * scale, output.z * scale);
        }

        private Face CheckFace(Vector3 Min, Vector3 Max, Vector3 cameraPosition, Ray ray)
        {
            double[] x = new double[] { Min.x, Max.x, Min.x, Max.x, Min.x, Max.x, Min.x, Max.x, Min.x, Min.x, Max.x, Max.x };
            double[] y = new double[] { Min.y, Max.y, Min.y, Max.y, Min.y, Min.y, Max.y, Max.y, Min.y, Max.y, Min.y, Max.y };
            double[] z = new double[] { Min.z, Min.z, Max.z, Max.z, Min.z, Max.z, Min.z, Max.z, Min.z, Max.z, Min.z, Max.z };
            Face[] faces = new Face[] { Face.ZP, Face.ZN, Face.YN, Face.YP, Face.XN, Face.XP };

            Face face = Face.None;
            double distance = double.MaxValue;

            for (int i = 0; i < 6; i++)
            {
                AxisAlignedBoundingBox check = new AxisAlignedBoundingBox(new Vector3(x[i * 2], y[i * 2], z[i * 2]), new Vector3(x[i * 2 + 1], y[i * 2 + 1], z[i * 2 + 1]));
                double d = (check.Center - cameraPosition).Length;
                if (ray.Intersects(check) && d < distance)
                {
                    face = faces[i];
                    distance = d;
                }
            }

            return face;
        }

        private enum Face
        {
            None,
            ZP,
            ZN,
            YN,
            YP,
            XN,
            XP
        }
    }
}
