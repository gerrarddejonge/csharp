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


