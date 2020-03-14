using System;
using System.Collections.Generic;
using System.Text;

namespace ListTemplate
{
    class MyList
    {
        // Узел списка
        private class Node
        {
            // Хранимые данные
            public MyPerson data;
            // Следующий элемент списка
            public Node next;
            // Предыдущий элемент списка
            public Node prev;
        }

        Node first = null;
        Node last = null;

        // Добавление в конец списка
        public void Append(MyPerson item)
        {
            Node node = new Node();
            node.data = item;
            node.prev = last;
            last.next = node;
            last = node;
        }

        // Добавление в начало списка
        public void Prepend(MyPerson item)
        {
            Node node = new Node();
            node.data = item;
            if (last == null || first == null)
            {
                first = node;
                last = node;
                return;
            }
            else
            {
                node.next = first;
                first.prev = node;
                first = node;
            }
        }

        // Добавляет элемент на указанную позицию
        public void Insert(MyPerson item, int postion)
        {

        }

        // Удаляет элемент по указаннмоу ключу
        private void Remove(string keyValue)
        {

        }

        public MyPerson[] ToArray()
        {
            return new MyPerson[0];
        }

        // Ищет элемент списка по указанному ключу (имени)
        public MyPerson Find(string keyValue)
        {
            return new MyPerson();
        }

        // Поиск узла
        private Node FindNode(string keyValue)
        {
            return null;
        }


    }
}
