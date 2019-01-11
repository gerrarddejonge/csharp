/*
 * File:      test3.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Testing integer calculations
 */
 
 using System;

class test3 {
	static void Main() {

		int a = 18;
		int b = 5;
		int c = a + b;
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("b = {0}", b);
		Console.WriteLine("a + b = {0}", c);
		
		Console.WriteLine("a - b = {0}", a - b);
		Console.WriteLine("a * b = {0}", a * b);
		Console.WriteLine("a / b = {0}", a / b);
	}
}
