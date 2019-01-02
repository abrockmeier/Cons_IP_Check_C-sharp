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
<<<<<<< HEAD
			string eingabeIP;
			
			Console.WriteLine("Bitte IP Adresse eingeben: ");
			eingabeIP = Console.ReadLine ();
			
			//	Zahl > 3 abfangen!... buchstaben abfangen, sonstige zeichen statt punkt abfangen..
			char zeichen = '.';
			int zahl = eingabeIP.IndexOf(zeichen);
			int zahlP = zahl;
			
			for (int i = 0; 3 >= i; i++)
			{			
				//int zahl = eingabeIP.IndexOf(zeichen);
				eingabeIP = eingabeIP.Substring(zahl);
					// String in Teilstrings zerlegen und diese überprüfen ggf Array of Strings.
				CipValidate.TeilIP = Convert.ToInt32(eingabeIP);
			
				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", CipValidate.TeilIP, zahl, zeichen);

			}

			CipValidate.CipValidator(CipValidate.TeilIP);
			Console.WriteLine("teilIP {0}, zeichen {1}", CipValidate.TeilIP,  zeichen);
			


			
			
			
=======
			public CIPAdresse IP = new CIPAdresse();

			if (IP.SetIP("12.111.222.123") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");
>>>>>>> b313862452071b3ab449e50c14e0df387625c187

			if (IP.SetIP("..0.000") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");

<<<<<<< HEAD
				Console.WriteLine("Die Eingegebene IP ist gültig!");
			}

			
=======
			if (IP.SetIP("012.1.10.000") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");

			if (IP.SetIP("123.12.0.") == true)
				Console.WriteLine("IP-Adresse ist OK!");
			else Console.WriteLine("IP Adresse ist nicht OK!");
>>>>>>> b313862452071b3ab449e50c14e0df387625c187
		}
	}
}	
			//Console.WriteLine("Bitte IP Adresse eingeben: ");
			//eingabeIP = Console.ReadLine ();

<<<<<<< HEAD
	class CipValidate
	{
		public static int TeilIP { get => TeilIP; set => TeilIP = value; }
		//public static bool IPvalid { get => IPvalid; set => IPvalid = value; }

		public static bool CipValidator(int TeilIP) //(string teilIP)
		{
			if (TeilIP > 0 && 256 > TeilIP) return true;

			else
			{
			Console.WriteLine("Die eingegebene IP ist ungültig");
			return false;
			
			}
		}
	
	}

}
			//CipValidate IP = new CipValidate (eingabeIP);
			//CipValidate IP2 = new CipValidate ("192.168.1.1");
=======
			//CipValidate IP = new CipValidate (eingabeIP);
			//CipValidate IP2 = new CipValidate ("192.168.1.1");
			
			

			//if ( ) == true)
			

				//Console.WriteLine("Die Eingegebene IP ist gültig!");
				//else Console.WriteLine("Die eingegebene IP ist ungültig");
			

	

	


>>>>>>> b313862452071b3ab449e50c14e0df387625c187
