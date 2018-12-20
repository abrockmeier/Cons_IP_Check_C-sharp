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
			char zeichen = '.';
			string teilStringA;
			string teilStringB;
			string teilStringC;
			string teilStringD;
			//bool tA;
			//bool tB;
			//bool tC;
			//bool tD;

			
			Console.WriteLine("Bitte IP Adresse eingeben: ");
			eingabeIP = Console.ReadLine ();

			//CipValidate IP = new CipValidate (eingabeIP);
			//CipValidate IP2 = new CipValidate ("192.168.1.1");
			teilStringA = eingabeIP;
			//1
			int zahl = eingabeIP.IndexOf(zeichen);
			teilStringB = eingabeIP.Substring(zahl + 1);
			StringteilenA(zahl, eingabeIP, zeichen, teilStringA);
			
			//2
			zahl = teilStringB.IndexOf(zeichen);
			teilStringC = teilStringB.Substring(zahl + 1);
			StringteilenB(zahl, eingabeIP, zeichen, teilStringB);
			//3
			zahl = teilStringC.IndexOf(zeichen);
			teilStringD = teilStringC.Substring(zahl+1);
			StringteilenC(zahl, eingabeIP, zeichen, teilStringC);
			//4


			teilStringD = teilStringC.Substring(zahl);
			//Schleife bis letzer Teilstring
			
			
			//if () == true)
			{

				Console.WriteLine("Die Eingegebene IP ist gültig!");
				//else Console.WriteLine("Die eingegebene IP ist ungültig");
			}
		}

		public static bool StringteilenA(int zahl, string eingabeIP, char zeichen, string teilStringA)
			{
				
				teilStringA = teilStringA.Substring(0, zahl);
			if (Convert.ToInt32(teilStringA) < 256 && Convert.ToInt32(teilStringA) < 0)
			{
				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilStringA, zahl, zeichen);
				return true;
			}
			// Bereich prüfen
			else return false;			
			}
		
		public static bool StringteilenB(int zahl, string eingabeIP, char zeichen, string teilStringB)
			{
				
				teilStringB = teilStringB.Substring(0, zahl);
			if (Convert.ToInt32(teilStringB) < 256 && Convert.ToInt32(teilStringB) < 0)
			{
				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilStringB, zahl, zeichen);
				return true;
			}
			// Bereich prüfen
			else return false;			
			}

		public static bool StringteilenC(int zahl, string eingabeIP, char zeichen, string teilStringC)
		{
				
			teilStringC = teilStringC.Substring(0, zahl);
		if (Convert.ToInt32(teilStringC) < 256 && Convert.ToInt32(teilStringC) < 0)
		{
			Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilStringC, zahl, zeichen);
			return true;
		}
		// Bereich prüfen
		else return false;			
		}

		public static bool StringteilenD(int zahl, string eingabeIP, char zeichen, string teilStringD)
		{
				
			teilStringD = teilStringD.Substring(0, zahl);
		if (Convert.ToInt32(teilStringD) < 256 && Convert.ToInt32(teilStringD) < 0)
		{
			Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilStringD, zahl, zeichen);
			return true;
		}
		// Bereich prüfen
		else return false;			
		}

	}


	class CipValidate
	{
		//string teilIP;
		
		public string TeilIP { get => TeilIP; set => TeilIP = value; }
		//public bool IPvalid { get => IPvalid; set => IPvalid = value; }
		//public string TeilIP3 { get => teilIP3; set => teilIP3 = value; }
		//public string TeilIP4 { get => teilIP4; set => teilIP4 = value; }

		public CipValidate()
		{
			
			//CipValidator();
		}
		
		public CipValidate(string eingabeIP)
		{
			TeilIP = eingabeIP;
			
			
		}
		
		

		public static void CipValidator() //(string teilIP)
		{
			
			
				// "cut-off bei kurzen ip´s zu hoch,..."
				
				
			
		}

		/*
		
		*/
		
	}

}
