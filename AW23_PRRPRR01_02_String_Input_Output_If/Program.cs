using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_02_String_Input_Output_If {
	internal class Program {
		static void Main(string[] args) {
			string myText = "Hejsan svejsan";

			Console.WriteLine(myText);

			myText = "Hejdå";

			Console.WriteLine(myText);

			string firstName = "Hannes";

			string lastName = "Blåman";

			string fullName = firstName + " " + lastName;

			Console.WriteLine(fullName);

			// Console.Write("Hejsan");
			// Console.WriteLine("SIODHuisdhad");
		}
	}
}
