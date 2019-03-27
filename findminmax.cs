/*
 * File:      findmaxmin.cs
 * Copyright: (c) 2019 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description:
 *            Find the largest and the smallest value from a given amount
 *            of numbers
 *
 * Implementation:
 *            We use a List<int> to collect the numbers
 *            then use sort() to sort smallest to largest
 *            and print the first number(smallest)
 *            and the last number(largest)
 *
 * Comments:
 *            There is no error handling so input illegal values
 *            will crash the program
 *
 */


using System;
using System.Collections.Generic;


class Program{
	static void Main() {
		int loop;
		List<int> numbers = new List<int>();

		loop = GetGetal("Enter amount of numbers");
		for (int i = 1; i <= loop; i++) {
			numbers.Add(GetGetal($"Enter number {i}"));
		}

		numbers.Sort();

		Console.WriteLine($"The smallest number is {numbers[0]}");
		Console.WriteLine($"The largest number is {numbers[numbers.Count-1]}");
	}

	static int GetGetal(string msg) {
		Console.Write($"{msg} : ");
		return int.Parse(Console.ReadLine());
	}
}
