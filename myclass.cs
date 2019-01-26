using System.Collections.Generic;
using System;


class MainClass
{
    public static void Main(string[] args)
    {

        List<MyClass> list = new List<MyClass>();

        list.Add(new MyClass());

        MyClass ass2 = list[0];

        Console.WriteLine("\nFound in list: {0}", ass2);
    }
}
class MyClass {
    
   public override string ToString(){
    
      return "my class";
   }
    
}
