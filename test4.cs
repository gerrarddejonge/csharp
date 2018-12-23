/*
 * File:      test4.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 */
 
 using System;  
class Test  
{  
	static void Main() {  
		int[] arr = new int[5];  
		for (int i = 0; i < arr.Length; i++) { 
			arr[i] = i * i;  
		}
		for (int i = 0; i < arr.Length; i++)  
			Console.WriteLine("arr[{0}] = {1}", i, arr[i]);  
   }  
}
