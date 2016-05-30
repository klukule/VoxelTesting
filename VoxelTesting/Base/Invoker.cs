using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelTesting.Base
{
    public enum Priority
    {
        LOW = 0,
        NORMAL = 1,
        HIGH = 2
    }

    public static class Invoker
    {
        private static List<Tuple<Action, Priority>> actions = new List<Tuple<Action, Priority>> { };
        public static void AddToQueue(Action action, Priority priority)
        {
            actions.Add(new Tuple<Action, Priority>(action, priority));
        }

        public static void Update()
        {
            var queue = actions.ToList();
            var filtered = new List<Tuple<Action, Priority>> { };
            foreach (var item in actions)
            {

                if(item != null)
                {
                    filtered.Add(item);
                }
            }
            queue = filtered.OrderBy(item => item.Item2).ToList();
            //actions.RemoveRange(0, Math.Min(50, queue.Count));

            Parallel.For(0, Math.Min(50, queue.Count), (index) => {
                Parallel.Invoke(() =>
                {
                    queue[index].Item1.Invoke();
                });
                actions.Remove(queue[index]);
            });
        }
    }
}
