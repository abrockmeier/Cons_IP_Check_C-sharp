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
			bool loopbreak = false;
			CIPAdresse IP = new CIPAdresse();
			//CIPAdresse.Dot = '.'; //Stack overflow wtf...

			if (IP.SetIP("12.111.222.123") == true)
				Console.WriteLine("Die IP-Adresse ist OK!");
			else Console.WriteLine("Die IP Adresse ist nicht OK!");
	
			Console.WriteLine("==========NeXt Ip=========");

			if (IP.SetIP("..0.000") == true)
				Console.WriteLine("Die IP-Adresse ist OK!");
			else Console.WriteLine("Die IP Adresse ist nicht OK!");

			Console.WriteLine("==========NeXt Ip=========");
			
			if (IP.SetIP("012.1.10.000") == true)
				Console.WriteLine("Die IP-Adresse ist OK!");
			else Console.WriteLine("Die IP Adresse ist nicht OK!");

			Console.WriteLine("==========NeXt Ip=========");
	
			if (IP.SetIP("123.12.0.") == true)
				Console.WriteLine("Die IP-Adresse ist OK!");
			else Console.WriteLine("Die IP Adresse ist nicht OK!");
			
			Console.WriteLine("Auto Test´s abgeschlossen! \n" +
			"Zum Fortfahren bitte eine Taste drücken!");
			Console.ReadKey();

			Console.Clear();
			Console.WriteLine();
			Console.WriteLine("			Eingabeaufforderung:		");
			Console.WriteLine();
			while(!loopbreak)
			{
				Console.WriteLine("Wenn Sie eine eigene IP testen wollen bitte 'i' drücken ");
				Console.WriteLine("Zum beenden bitte 'x' drücken!");
				//Console.Clear();
				ConsoleKeyInfo caseInput = Console.ReadKey(true);
                StringBuilder output = new StringBuilder(
                    String.Format("Ihre Auswahl: {0}", caseInput.KeyChar));
                Console.WriteLine(output.ToString());

				switch (caseInput.Key)
				{
					case ConsoleKey.I:
						Console.WriteLine("Bitte geben Sie eine Ip zum Validieren ein:");
						string eingabeIP = Console.ReadLine();
						if (IP.SetIP(eingabeIP))
						{
							Console.WriteLine("Die IP-Adresse ist OK!");
							//loopbreak = true;
						}
						else Console.WriteLine("Bitte eine gültige IP Im Format " +
						"(0-254).(0-254).(0-254).(0-254) eingeben!");			
						break;
						
					case ConsoleKey.X:
						loopbreak = true;
						Console.WriteLine("Auf Wiedertschüss!");
						break;
					default:
						Console.WriteLine("Bitte drücken sie 'i' oder 'x' !");	
						break;
				}
			}
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
			if (ValidateIP(IP))
				return true;
			else
			{
				return false;
			}
		}

		public bool SetIP(string s)
		{
			IP = s;
			if ((IP.Length >= 8 && IP.Length <= 15) && ValidateIP(IP))
				return true;
			else
			{
				return false;
			}
			// return true or false denpending on result of IP validation...
		}

		public string GetIP()
		{
			return IP;
		}

		public static bool ValidateIP(string s)
		{
			char dot = '.';
			int dotpos = s.IndexOf(dot);
			string ts1 = s.Substring(0, dotpos);
			string tsR = s.Substring(dotpos + 1);
			dotpos = tsR.IndexOf(dot);
			string ts2 = tsR.Substring(0, dotpos);
			tsR = tsR.Substring(dotpos + 1);
			dotpos = tsR.IndexOf(dot);
			string ts3 = tsR.Substring(0, dotpos);
			tsR = tsR.Substring(dotpos + 1);
			Console.WriteLine(" Ergebnis der Prüfung:		");
			//uint = ts1u;
			bool ts1b = UInt32.TryParse(ts1, out uint ts1u);
			if (ts1b && (0 <= ts1u && ts1u < 255)) ts1 = Convert.ToString(ts1u);
			else
			{
				Console.WriteLine("Fehler im ersten Teil der IP" +
				"(!!!.{0}.{1}.{2})", ts2, ts3, tsR);
				ts1b = false;
			}
			bool ts2b = UInt32.TryParse(ts2, out uint ts2u);
			if (ts2b && (0 <= ts2u && ts2u < 255)) ts2 = Convert.ToString(ts2u);
			else
			{
				Console.WriteLine("Fehler im zweiten Teil der IP" +
				"({0}.!!!.{1}.{2})", ts1, ts3, tsR);
				ts2b = false;
			}
			bool ts3b = UInt32.TryParse(ts3, out uint ts3u);
			if (ts3b && (0 <= ts3u && ts3u < 255)) ts3 = Convert.ToString(ts3u);
			else
			{
				Console.WriteLine("Fehler im dritten Teil der IP" +
				"({0}.{1}.!!!.{2})", ts1, ts2, tsR);
				ts3b = false;
			}
			bool tsRb = UInt32.TryParse(tsR, out uint tsRu);
			if (tsRb && (0 <= tsRu && tsRu < 255)) tsR = Convert.ToString(tsRu);
			else
			{
				Console.WriteLine("Fehler im letzten Teil der IP" +
				"({0}.{1}.{2}.!!!)", ts1, ts2, ts3);
				tsRb = false;
			}
			if (ts1b && ts2b && ts3b && tsRb)
			{ 
				return true; 
			}
			else return false;
		}
	}
}
