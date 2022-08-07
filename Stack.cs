using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{   public class Stack
    {   List<object> listOfData;
        Stack(List<object> list)
        {
            this.listOfData = list;
        }
        public  void PushData(object value)
        {
            listOfData.Add(value);
        }
        public object PopData()
        {   try
            {
                object data = listOfData.ElementAt(listOfData.Count - 1);
                listOfData.RemoveAt(listOfData.Count - 1);
                return data;
            }
            catch (Exception)
            {
                return "The List Is Empty ";
           }
        }

        public  void PrintData()
        {
            try
            {
                List<object> data = listOfData.Select(s => s).ToList();
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
            }
            catch(Exception ) { 
            
                Console.WriteLine("The List Is Empty Nothing To Print");
            }
        }
        public void PeakValue()
        {
            try
            {
                Console.WriteLine("Peak Value is: "+listOfData.ElementAt(listOfData.Count - 1));
            }
            catch(Exception )
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
            Stack stack1 = new Stack(new List<object>());
            stack1.PushData(5);
            stack1.PushData("data");
            stack1.PushData(3.5);
            Console.WriteLine(stack1.PopData());
            ///stack1.PrintData();
            stack1.PeakValue();
            stack1.ClearList();
            stack1.PeakValue();
        }

    


    }
}
