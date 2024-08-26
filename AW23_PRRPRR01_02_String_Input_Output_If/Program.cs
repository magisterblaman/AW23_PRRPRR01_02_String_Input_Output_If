using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_02_String_Input_Output_If {
	internal class Program {
		static void Main(string[] args) {

			Console.WriteLine("Gillar du glass?");

			string reply = Console.ReadLine().ToLower();

			if (reply == "ja") {
				Console.WriteLine("Kul(a)");
			} else if (reply == "kanske") {
				Console.WriteLine("Vad kan jag göra för att övertyga dig?");
			} else {
				Console.WriteLine("Synd");
			}



		}
	}
}
