using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  public class StackClass<T>
    {   List<T> listOfData;
        StackClass()
        {
            listOfData = new List<T>();
        }
        public  void PushData(T value)
        {
            listOfData.Add(value);
        }
        public T? PopData()
        {
            if (listOfData.Count > 0)
            {
                T data = listOfData.ElementAt(listOfData.Count - 1);
                listOfData.RemoveAt(listOfData.Count - 1);
                return data;
            }
            return default(T);
        }

        public  void PrintData()
        {
            try
            {
                List<T> data = listOfData.Select(s => s).ToList();
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("The List Is Empty Nothing To Print ");
            }
        }
        public void PeakValue()
        {
            try
            {
                Console.WriteLine("Peak Value is: " + listOfData.ElementAt(listOfData.Count - 1));
            }
            catch (Exception)
            {
                Console.WriteLine("Empty List Nothing To Print");
            }
        }
        public void ClearList()
        {
            listOfData.Clear();
            Console.WriteLine("List is Cleared");

        }
    public static void Main(string[] args)
    {
        StackClass<string> stack1 = new StackClass<string>();
        stack1.PushData("data1");
        /*     
                  Console.WriteLine(stack1.PopData());
                  ///stack1.PrintData();
                  stack1.PeakValue();
                  stack1.ClearList();
                  stack1.PeakValue();*/
    }
}

