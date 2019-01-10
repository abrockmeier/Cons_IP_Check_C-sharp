using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cons_IP_Check_C_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
			CIPAdresse IP = new CIPAdresse();
			//CIPAdresse.Dot = '.'; //Stack overflow wtf...

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
			
			//	Todo: eingabe von IP´s...
			Console.ReadKey();
		}
	}

	class CIPAdresse
	{
		private string IP;
		
		public CIPAdresse()
		{
			
		}
		
		public CIPAdresse(int a, int b, int c, int d)
		{
			SetIP(a,b,c,d);
		}
				
		public CIPAdresse(string s)
		{
			SetIP(s);
		}

		public bool SetIP(int a, int b, int c, int d)
		{
			IP = String.Concat(a, ".", b, ".", c, ".", d);
			return false;
			// return true or false denpending on result of IP validation...
		}

		public bool SetIP(string s)
		{
			IP = s;
			if (ValidateIP(s))
				return true;
			else
			{
				Console.WriteLine( "0.0.0.0" );
				return false;
			}
			// return true or false denpending on result of IP validation...
		}

		public string GetIP()
		{
			return IP;
		}

		//public static int TeilIP { get => TeilIP; set => TeilIP = value; }
		
		//public static bool ValidIP { get => ValidIP; set => ValidIP = value; }

		//public static char Dot { get => Dot; set => Dot = value;}

		public static void ValidateIP()
		{
			// methode überflüssig?
		}

		/*
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
		*/

		public static bool ValidateIP(string s)
		{
			// cuttof
			//int dotAT = s.IndexOf(CIPAdresse.Dot);
			string[] tsArray = Regex.Split(s, @"(?<=[.])");
			for (int i = 0; i < 4; i++)
			{
				//	Hier die '.'e aus den Teilstrings 1-3 entfernen. 
				//	(in tsArray[3] sollte kein . drin sein sonst: return false... )
				//	dann noch die Teilstrings mittels Boxing auf Wertebereich überprüfen...
				// wenn alles okay return true ...

				Console.WriteLine(tsArray[i]);
			}
			Console.WriteLine();
			return true;
			//string tsB = tsArray[3] = s.Substring(Dot + 1);
		}


		//public static void validateIP(int a, int b, int c, int d) //(string teilIP)
		//{
			
		//}


	}
	
	//	Stings verwenden, private Methoden schreiben, um IP Adressen zu testen...

}


// Old Stuff´s Clipboard
/*
// Eingabe einer zu testenden IP!
			

			// Hier wird der String bestenfalls geschnippelt 
			public string EingabeIP { get => eingabeIP; set => eingabeIP = value; }



		(zahl > 3)
				Console.WriteLine("Falsches Eingabeformat x.x.x.x (255 > x > 0)");
			else
				Console.WriteLine("Bereit für die weitere Verarbeitung!");
			Console.WriteLine(" {0} <|Zahl|,  {1} <|ZahlL|", zahl, zahlL);
			Console.ReadKey();
*/
		/*
			Console.WriteLine("Bitte IP Adresse eingeben: ");
			eingabeIP = Console.ReadLine();

			//	Zahl > 3 abfangen!... buchstaben abfangen, sonstige zeichen statt punkt abfangen..
			char zeichen = '.';
			int zahl = EingabeIP.IndexOf(zeichen);
			int zahlL = EingabeIP.Length;
		*/
		// methode mit Substring()
		// methode mit IndexOf()...
		


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

/*

	
		Console.WriteLine("Die Eingegebene IP ist gültig!");
			//Console.WriteLine("Bitte IP Adresse eingeben: ");
			//eingabeIP = Console.ReadLine ();
	*/

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
