/*
 * File:      test10.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 */
 
using System;
using System.Collections.Generic;

class test {
	static void Main() {

		var fibonacciNumbers = new List<int> {1, 1};

		for (int i = 0; i < 18; i++) 
		{
			var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
			var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

			fibonacciNumbers.Add(previous + previous2);
		}

		foreach(var item in fibonacciNumbers)
			Console.WriteLine(item);

		
	}
}
