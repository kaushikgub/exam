using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ItemBox<T> : IStorage<T> where T : class, new()
    {
        // Write your code here
        List<T> list = new List<T>();
        public int Count { get; set; }

        public void Add(T box){
            list.Add(box);
        }

        public void Remove(T box){
            list.Remove(box);
        }

        public T Get(int index)
        {
            return list[index];
        }
    }
}
