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
			string eingabeIP;

			Console.WriteLine("Bitte IP Adresse eingeben: ");
			eingabeIP = Console.ReadLine();

			//	Zahl > 3 abfangen!... buchstaben abfangen, sonstige zeichen statt punkt abfangen..
			char zeichen = '.';
			int zahl = eingabeIP.IndexOf(zeichen);
			int zahlL = eingabeIP.Length;


			// Hier wird der String bestenfalls geschnippelt 
			if (zahl > 3)
				Console.WriteLine("Falsches Eingabeformat x.x.x.x (255 > x > 0)");
			else
				Console.WriteLine("Bereit für die weitere Verarbeitung!");
			Console.WriteLine(" {0} <|Zahl|,  {1} <|ZahlL|", zahl, zahlL);

			/*
			for (int i = 0; 3 >= i; i++)
			{
				//int zahl = eingabeIP.IndexOf(zeichen);
				eingabeIP = Convert.ToString(eingabeIP.Substring(zahl));
				// String in Teilstrings zerlegen und diese überprüfen ggf Array of Strings.
				CipValidate.TeilIP = Convert.ToInt32(eingabeIP);

				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", CipValidate.TeilIP, zahl, zeichen);

			}

			CipValidate.CipValidator(CipValidate.TeilIP);
			Console.WriteLine("teilIP {0}, zeichen {1}", CipValidate.TeilIP, zeichen);

			*/
		}
	}






	/*

	
		if (IP.SetIP("12.111.222.123") == true)
			Console.WriteLine("IP-Adresse ist OK!");
		else Console.WriteLine("IP Adresse ist nicht OK!");

		if (IP.SetIP("..0.000") == true)
			Console.WriteLine("IP-Adresse ist OK!");
		else Console.WriteLine("IP Adresse ist nicht OK!");
	
		Console.WriteLine("Die Eingegebene IP ist gültig!");
			

			
	if (IP.SetIP("012.1.10.000") == true)
		Console.WriteLine("IP-Adresse ist OK!");
	else Console.WriteLine("IP Adresse ist nicht OK!");
	
	if (IP.SetIP("123.12.0.") == true)
		Console.WriteLine("IP-Adresse ist OK!");
	else Console.WriteLine("IP Adresse ist nicht OK!");
	
	
	
			//Console.WriteLine("Bitte IP Adresse eingeben: ");
			//eingabeIP = Console.ReadLine ();
	*/

	class CIPAdresse
	{
		

		//string teilIP;
		
		//public string IP { get => IP; set => IP = value; }
		//public bool IPvalid { get => IPvalid; set => IPvalid = value; }
		//public string TeilIP3 { get => teilIP3; set => teilIP3 = value; }
		//public string TeilIP4 { get => teilIP4; set => teilIP4 = value; }

		//public CIPAdresse()
		//{
		//}
		/*
		public CIPAdresse(string a,int b, int c,int d)
		{
		IP = Convert.ToString(a);
		}*/
		
		public string CIPAdressenCutter(string s)
		{
				
				// "cut-off bei kurzen ip´s zu hoch,..."
				char zeichen = '.';
				int Teilstelle = s.IndexOf(zeichen);
				string st = s.Substring(Teilstelle + 1);

				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", st, Teilstelle, zeichen);
				if (Convert.ToInt32(st) > 0 && 256 > Convert.ToInt32(st))
				return st;
				else return("");
		}

		// methode mit Substring()
		// methode mit IndexOf()...
			
				
				
	}
	
	class CipValidate
	{
		public static int TeilIP { get => TeilIP; set => TeilIP = value; }
		//public static bool IPvalid { get => IPvalid; set => IPvalid = value; }

		public static bool CipValidator(int TeilIP) //(string teilIP)
		{
			return true;
		}
	}
}


