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

			CipValidate IP = new CipValidate (eingabeIP);
			//CipValidate IP2 = new CipValidate ("192.168.1.1");
			
			

			//if ( ) == true)
			{

				Console.WriteLine("Die Eingegebene IP ist gültig!");
				//else Console.WriteLine("Die eingegebene IP ist ungültig");
			}
		}
	}

	class CipValidate
	{
		string teilIP;
		
		public string TeilIP { get => teilIP; set => teilIP = value; }
		public bool IPvalid { get => IPvalid; set => IPvalid = value; }
		//public string TeilIP3 { get => teilIP3; set => teilIP3 = value; }
		//public string TeilIP4 { get => teilIP4; set => teilIP4 = value; }

		public CipValidate()
		{
			
			//CipValidator();
		}
		
		public CipValidate(string eingabeIP)
		{
			teilIP = eingabeIP;
			
			
		}
		
		

		public string CipValidator() //(string teilIP)
		{
			
			
				// "cut-off bei kurzen ip´s zu hoch,..."
				char zeichen = '.';
				int zahl = teilIP.IndexOf(zeichen);
				teilIP = teilIP.Substring(zahl + 1);

				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilIP, zahl, zeichen);
				IPvalid = true;
				return teilIP;
				
			
		}

		/*
		
		*/
		
	}

}
