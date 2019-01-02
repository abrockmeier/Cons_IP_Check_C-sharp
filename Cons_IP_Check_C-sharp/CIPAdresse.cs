using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_IP_Check_C_sharp
{
	class CIPAdresse
	{
		private int a, b, c , d;

		//string teilIP;
		
		public bool IP { get => IP; set => IP = value; }
		//public bool IPvalid { get => IPvalid; set => IPvalid = value; }
		//public string TeilIP3 { get => teilIP3; set => teilIP3 = value; }
		//public string TeilIP4 { get => teilIP4; set => teilIP4 = value; }

		public CIPAdresse()
		{
		}
		
		public CIPAdresse(int a,int b, int c,int d)
		{
		IP = a;
		}
		
		public CIPAdresse(string s)
		{

		}

		// methode mit Substring()
		// methode mit IndexOf()...
				/*	
				// "cut-off bei kurzen ip´s zu hoch,..."
				char zeichen = '.';
				int zahl = teilIP.IndexOf(zeichen);
				teilIP = teilIP.Substring(zahl + 1);

				Console.WriteLine("teilIP {0}, zahl {1}, zeichen {2}", teilIP, zahl, zeichen);
				IPvalid = true;
				return teilIP;
				
				*/
	}

}

