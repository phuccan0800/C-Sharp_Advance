using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4
{
    internal class Problem9
    {
        public void Run()
        {
            string[] elements = Console.ReadLine().Split(' ');
            int removeCount = int.Parse(Console.ReadLine());
            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();
            List<int> addCollectionResults = new List<int>();
            List<int> addRemoveCollectionResults = new List<int>();
            List<int> myListResults = new List<int>();
            List<string> addRemoveCollectionRemoveResults = new List<string>();
            List<string> myListRemoveResults = new List<string>();
            foreach (string element in elements)
            {
                addCollectionResults.Add(addCollection.Add(element));
                addRemoveCollectionResults.Add(addRemoveCollection.Add(element));
                myListResults.Add(myList.Add(element));
            }
            for (int i = 0; i < removeCount; i++)
            {
                addRemoveCollectionRemoveResults.Add(addRemoveCollection.Remove());
                myListRemoveResults.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", addCollectionResults));
            Console.WriteLine(string.Join(" ", addRemoveCollectionResults));
            Console.WriteLine(string.Join(" ", myListResults));
            Console.WriteLine(string.Join(" ", addRemoveCollectionRemoveResults));
            Console.WriteLine(string.Join(" ", myListRemoveResults));
        }
    }
    public interface IAddCollection
    {
        int Add(string item);
    }
    public interface IAddRemoveCollection : IAddCollection
    {
        string Remove();
    }
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
    public class AddCollection : IAddCollection
    {
        private List<string> collection;
        public AddCollection()
        {
            collection = new List<string>();
        }
        public int Add(string item)
        {
            collection.Add(item);
            return collection.Count - 1;
        }
    }
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> collection;
        public AddRemoveCollection()
        {
            collection = new List<string>();
        }
        public int Add(string item)
        {
            collection.Insert(0, item);
            return 0;
        }
        public string Remove()
        {
            string removedItem = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            return removedItem;
        }
    }
    public class MyList : IMyList
    {
        private List<string> collection;
        public MyList()
        {
            collection = new List<string>();
        }
        public int Add(string item)
        {
            collection.Insert(0, item);
            return 0;
        }
        public string Remove()
        {
            string removedItem = collection[0];
            collection.RemoveAt(0);
            return removedItem;
        }
        public int Used => collection.Count;
    }
}
