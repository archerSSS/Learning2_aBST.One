using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class aBST
    {
        public int?[] Tree;

        public aBST(int depth)
        {
            depth = 1 << (depth);
            int tree_size = depth | (depth - 1);
            if (tree_size < 0) tree_size = 0; 
            Tree = new int?[tree_size];
            for (int i = 0; i < tree_size; i++) Tree[i] = null;
        }

        public int? FindKeyIndex(int key)
        {
            int index = 0;
            while (index < Tree.Length)
            {
                if (Tree[index] == null) return -index; 
                if (Tree[index] == key) return index;
                else if (Tree[index] > key) index = index * 2 + 1;
                else index = index * 2 + 2;
            }
            // ищем в массиве индекс ключа
            return null; // не найден
        }

        public int AddKey(int key)
        {
            int index = 0;
            while (index < Tree.Length)
            {
                if (Tree[index] == null)
                {
                    Tree[index] = key;
                    return index;
                }
                if (Tree[index] == key)
                    return index;
                else if (Tree[index] > key)
                    index = index * 2 + 1;
                else index = index * 2 + 2;
            }
            // добавляем ключ в массив
            return -1;
            // индекс добавленного/существующего ключа или -1 если не удалось
        }
    }
}