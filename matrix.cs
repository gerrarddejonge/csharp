using System;

public class Matrix
{
	public int rows { get; set;}
	public int cols { get; set;}
	
	public void GetEntries() {
		Console.Write("Enter number of rows: ");
		rows = UInt16.Parse(Console.ReadLine());
		Console.Write("Enter number of columns: ");
		cols = UInt16.Parse(Console.ReadLine());
	}
		
	public void PrintColumns(String s) {
		for (var i = 0; i < cols; i++) {
			Console.Write($"{s}");
		}
		Console.WriteLine(s[0]);
	}
		
	public void PrintMatrix() {
		Console.WriteLine("");
		for (var i = 0; i < rows; i++) {
			PrintColumns("+--");
			PrintColumns("|  ");
		}
		PrintColumns("+--");		
	}
}


class test {
	static void Main() {
	
		var matrix = new Matrix();
		
		matrix.GetEntries();
		matrix.PrintMatrix();
	}
}



