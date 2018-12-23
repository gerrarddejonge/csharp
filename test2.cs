/*
 * File:      test2.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 */
 
 using System;

class test2 {
	static void Main() {
		string songLyrics = "You say goodbye, and I say hello";
		Console.WriteLine(songLyrics.StartsWith("You"));
		Console.WriteLine(songLyrics.StartsWith("goodbye"));

		Console.WriteLine(songLyrics.EndsWith("hello"));
		Console.WriteLine(songLyrics.EndsWith("goodbye"));
	}
}


