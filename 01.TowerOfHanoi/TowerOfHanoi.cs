namespace _01.TowerOfHanoi
{
    using System.Collections.Generic;
    using System.Linq;

    class TowerOfHanoi
    {
        static Stack<int> source = new Stack<int>(Enumerable.Range(1,3).Reverse());
        static Stack<int> spare = new Stack<int>(); 
        static Stack<int> destination = new Stack<int>();

        static void Main()
        {

        }

        static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                destination.Push(source.Pop());
            }
            else
            {
                // TODO
                destination.Push(source.Pop());
                // TODO
            }
        }
    }
}
