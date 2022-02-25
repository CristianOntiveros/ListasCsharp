using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCsharp.ArrayList
{
    public class ArrayList
    {
        private static int DEFAULT_SIZE = 2;
        private string[] array;
        private int size;

        public ArrayList()
        {
            array = new string[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new string[size];
        }

        public void addAtTail(string data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }
            array[size] = data;
            size++;
        }

        public void addAtFront(string data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0) Array.Copy(array, 0, array, 1, size);
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public void setAt(int index, string data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        /**
         * @param index 0-index
         * @return element at position index
         */
        public string? getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null;
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            string[] newArray = new string[array.Length * 2];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

    }
}
