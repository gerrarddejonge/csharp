/*
 * File:      test8.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Testing class construction
 */
 
using System;

public class Vegetable
{
	public Vegetable(string name) {
		Name = name;
	}

	public string Name { get; }

	public override string ToString() => Name; 
}

public enum Unit { item, kilogram, gram, dozen };


class test {
	static void Main() {
	
		var item = new Vegetable("eggplant");
		var date = DateTime.Now;
		var price = 1.99m;
		var unit = Unit.item;
		Console.WriteLine($"On {date:d}, the price of {item} was {price:c2} per {unit}.");
	}
}



