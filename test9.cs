/*
 * File:      test9.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Testing the List class
 */

using System;
using System.Collections.Generic;

class test {
	static void Main() {
		var names = new List<string> { "Gerrard", "Ana", "Felipe" };
		
		Console.WriteLine();
		names.Add("Maria");
		names.Add("Bill");
		names.Remove("Ana");
		
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
		
		Console.WriteLine($"The list has {names.Count} people in it");
		
		var index = names.IndexOf("Felipe");
		if (index != -1)
			Console.WriteLine($"The name {names[index]} is at index {index}");

		var notFound = names.IndexOf("Not Found");
		Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
		
		names.Sort();
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
	}
}
