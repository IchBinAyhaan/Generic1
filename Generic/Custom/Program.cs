using System;

class Program
{
    static void Main(string[] args)
    {
       
        CustomList<int> myList = new CustomList<int>();

        
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

       
        Console.WriteLine("Is 20 in the list? " + myList.Contains(20)); 
        Console.WriteLine("Is 40 in the list? " + myList.Contains(40)); 

       
        Console.WriteLine("Is the list empty? " + (myList.Any(x => true) ? "No" : "Yes")); 

      
        Console.WriteLine("First element of the list: " + myList.FirstOrDefault());

       
        Console.WriteLine("Last element of the list: " + myList.LastOrDefault()); 

        
        Console.WriteLine("Element at index 1: " + myList.ElementAtOrDefault(1));
        Console.WriteLine("Element at index 5: " + myList.ElementAtOrDefault(5));

      
        myList.Clear();

        
        Console.WriteLine("Is the list empty now? " + (myList.Any(x => true) ? "No" : "Yes")); 
    }
}
