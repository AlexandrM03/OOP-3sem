using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace OOP_Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection images = new MyCollection();
            images.Add(new Image("JPG"));
            images.Add(new Image("PNG"));
            images.Add(new Image("JPEG"));
            images.Show();
            images.Remove(new Image("JPG"));
            images.Show();

            Console.WriteLine();
            //////////////////////////////////////////
            Console.WriteLine();

            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                linkedList.AddLast(i);
            }
            linkedList.Show();

            for (int i = 3; i <= 6; i++)
            {
                linkedList.Remove(i);
            }
            linkedList.Show();

            linkedList.AddFirst(10);
            linkedList.AddLast(20);
            linkedList.Show();

            Stack<int> stack = new Stack<int>();
            Console.Write("Stack: ");
            foreach (int i in linkedList)
            {
                stack.Push(i);
                Console.Write(stack.Peek() + " ");
            }

            Console.WriteLine();
            //////////////////////////////////////////
            Console.WriteLine();

            ObservableCollection<Image> obs = new ObservableCollection<Image>();
            obs.CollectionChanged += Notify;
            Image im1 = new Image("JPG");
            Image im2 = new Image("PNG");
            Image im3 = new Image("JPEG");
            obs.Add(im1);
            obs.Add(im2);
            obs.Add(im3);
            obs.Remove(im1);

            Console.Write("Observable collection:   ");
            foreach (Image i in obs)
            {
                Console.Write(i.Type + "   ");
            }

        }

        private static void Notify (object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("|Add comlete|");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("|Remove complete|");
            }
        }
    }
}
