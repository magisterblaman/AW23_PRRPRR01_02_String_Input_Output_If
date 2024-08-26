using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_02_String_Input_Output_If {
	internal class Program {
		static void Main(string[] args) {

			Console.WriteLine("Vad heter din katt?");

			string input = Console.ReadLine();

			Console.WriteLine("Din katt heter: " + input);

		}
	}
}
