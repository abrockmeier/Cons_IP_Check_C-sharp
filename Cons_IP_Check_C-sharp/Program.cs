using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_IP_Check_C_sharp
{
	/* TODO: 
		2 mögliche Varianten: methode (ggf. auch Klasse) unten static  machen, dann müssen die Klassenvariablen raus,
							oder Objekt erzeugen und über Objektname.methode() auf rückgabewert zugreifen...
	*/

	class Program
	{
		static void Main(string[] args)
		{
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
			


			
			
			

			//if ( ) == true)
			{

				Console.WriteLine("Die Eingegebene IP ist gültig!");
			}

			
		}
	}

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
