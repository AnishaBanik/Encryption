using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("enter messege");
		String msg = Console.ReadLine();
		int i, asc, k, j = 6;
		//string ss="";
		char c;
		int[] ascar = new int[7];
		for (i = 0; i < msg.Length; i++)
		{
			j = 6;
			c = msg[i];
			asc = (int)c;
			while (asc > 0)
			{
				k = asc % 2;
				ascar[j] = k;
				asc = asc / 2;
				j--;
			}

			Console.WriteLine();
			encrypt(ascar);
			Console.WriteLine();
		}


	}
	public static void encrypt(int[] arr)
	{
		int i, j, k, diff;
		for (i = 0; i < arr.Length;)
		{

			k = arr[i];
			for (j = i + 1; j < arr.Length; j++)
			{
				if (arr[j] != k)
					break;


			}
			if (k == 1)
				Console.Write("0 ");
			else
				Console.Write("00 ");
			diff = j - i;
			while (diff > 0)
			{
				Console.Write("0");
				diff--;
			}
			i = j;
			Console.Write(" ");
		}
	}

}
