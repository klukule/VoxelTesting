using klukule.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting
{
    public class IComponent
    {
        public IComponent Parent;
        public string Name = "Component";

        public bool IsEnabled = true;

        public IComponent()
        {
            Init();
        }

        public List<IComponent> Components = new List<IComponent> { };
        
        public IComponent AddComponent(IComponent component)
        {
            component.Parent = this;
            Components.Add(component);
            return component;
        }

        public T GetComponent<T>() where T : IComponent
        {
            for(int i = 0; i < Components.Count; i++)
            {
                if(Components[i].GetType() == typeof(T))
                {
                    return (T)Components[i];
                }
            }
            return null;
        }

        public T GetComponentRecursive<T>() where T : IComponent
        {
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].GetType() == typeof(T))
                {
                    return (T)Components[i];
                }else
                {
                    IComponent comp = Components[i].GetComponentRecursive<T>();
                    if (comp != null)
                        return (T)comp;
                }
            }
            return null;
        }

        public List<T> GetComponents<T> () where T : IComponent
        {
            List<T> array = new List<T> { };
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].GetType() == typeof(T))
                {
                    array.Add((T)Components[i]);
                }
            }
            return array;
        }

        public List<T> GetComponentsRecursive<T>() where T : IComponent
        {
            List<T> array = new List<T> { };
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].GetType() == typeof(T))
                {
                    array.Add((T)Components[i]);
                }else
                {
                    array.AddRange(Components[i].GetComponentsRecursive<T>());
                }
            }
            return array;
        }

        public void RemoveComponent(IComponent component)
        {
            if(Components.Contains(component)){
                component.Dispose();
                Components.Remove(component);
            }
        }

        public IComponent GetParent()
        {
            return this.Parent;
        }


        public virtual void Init() {
        }
        public virtual void Update() {
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].IsEnabled)
                {
                    Components[i].Update();
                }
            }
        }
        public virtual void Draw() {
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i].IsEnabled)
                {
                    Components[i].Draw();
                }
            }
        }
        public virtual void Dispose() {
            for (int i = 0; i < Components.Count; i++)
            {
                Components[i].Dispose();
            }
        }
    }
}
