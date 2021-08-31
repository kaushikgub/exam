using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Show example use case of ItemBox
            var obj = new ItemBox<Box>();

            var box = new Box();
            box.Size = 20;
            obj.Add(box);

            var box2 = new Box();
            box2.Size = 40;
            obj.Add(box2);

            obj.Remove(box);

            Console.WriteLine(obj.Get(0).Size);
            Console.WriteLine(obj.Count);
        }
    }

    public class Box
    {
        private int size; // field
        public int Size   // property
        {
            get { return size; }
            set { size = value; }
        }
    }
}
