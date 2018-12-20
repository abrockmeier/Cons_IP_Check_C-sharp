using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_IP_Check_C_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
			public CIPAdresse IP = new CIPAdresse();

			if (IP.SetIP("12.111.222.123") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");

			if (IP.SetIP("..0.000") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");

			if (IP.SetIP("012.1.10.000") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");

			if (IP.SetIP("123.12.0.") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");
		}
	}
}	
			//Console.WriteLine("Bitte IP Adresse eingeben: ");
			//eingabeIP = Console.ReadLine ();

			//CipValidate IP = new CipValidate (eingabeIP);
			//CipValidate IP2 = new CipValidate ("192.168.1.1");
			
			

			//if ( ) == true)
			

				//Console.WriteLine("Die Eingegebene IP ist gültig!");
				//else Console.WriteLine("Die eingegebene IP ist ungültig");
			

	

	


