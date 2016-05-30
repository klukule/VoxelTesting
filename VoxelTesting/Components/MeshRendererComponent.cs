using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxelTesting.Base;

namespace VoxelTesting.Components
{
    public enum RenderMode
    {
        Solid,
        Wireframe
    }
    public class MeshRendererComponent : Renderer
    {
        public IComponent MeshToRender;
        public string Shader = "";
        public RenderMode RenderMode = RenderMode.Solid;

        public override void Draw()
        {
            MeshComponent component = (MeshComponent)MeshToRender;
            ShaderProgram shader = ShaderFactory.GetShader(Shader);
            shader.Use();
            if (component.MeshVAO != null)
            {
                TransformComponent transform = ((GameObject)GetParent()).GetTransform();
                shader["model_matrix"].SetValue(transform.Orientation.Matrix4 * Matrix4.CreateTranslation(transform.Position));
                if(RenderMode == RenderMode.Wireframe)
                {
                    Gl.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                }
                component.MeshVAO.Draw();
                if (RenderMode == RenderMode.Wireframe)
                {
                    Gl.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                }
            }
        }
    }
}
