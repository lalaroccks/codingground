using System.IO;
using System;

class Program
{
    static void Main()
    {
            int value = 635;
			int voltage = value / 4096 * 10;
			double temp = ((voltage - 1.8639) / -.01177) - 1.5;
			double tempInF = (temp * (9 / 5)) + 32;
			Console.Write(tempInF);
    }
}
