/*
 * File:      test1.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description:
 *            Testing positional specifiers for WriteLine
 */
 
using System;  
class Test  
{  
   static void Main() {  
      int intValue = 123;  
      long longValue = intValue + 1;  
      Console.WriteLine("{1}, {0}", intValue, longValue);  
   }  
}
