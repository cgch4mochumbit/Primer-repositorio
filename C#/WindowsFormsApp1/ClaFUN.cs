using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{

    public class ClaFUN
    {

        public static string[] aVars;
        public static string[] aData;

        public static void Loadvars(params string[] oPaths)
        {
            string Line = "";
            int n; int x; int i; string[] c;

            for( i = 0;i <= oPaths.Length-1;i++)
            {
                StreamReader sr = new StreamReader(oPaths[i]);
                Line += sr.ReadToEnd();
            }

            c = Regex.Split(Line, "\n");
            Array.Resize(ref aVars, c.Length);
            Array.Resize(ref aData, c.Length);

            for (x = 0; x <= c.Length-1; x++) {
                string cValue = c[x].ToString();
                if (cValue.Trim() != "") {
                    n = cValue.IndexOf("=", 0);
                    aVars[x] = cValue.Substring(0, n - 1).Trim();
                    string cValue_2 = cValue.Substring(n + 1).Trim();
                    if (cValue_2.IndexOf("/*",0) > 0)
                    {
                        string[] c_2 = Regex.Split(cValue_2, "/*");
                        aData[x] = c_2[0].ToString();
                    }
                    else
                    {
                        aData[x] = cValue.Substring(n + 1).Trim();
                    }
                }
            }
        }
        
        public static string Getvars(string cVar)
        {
            int n; bool NoFound = true; string cReturn = "";

            for (n = 0; n <= aVars.Length - 1; n++)
            {
                if (cVar.ToUpper() == aVars[n].ToUpper())
                {
                    NoFound = false;
                    cReturn= aData[n];
                    n = aVars.Length + 1;
                }
            }

            return NoFound ? "" : cReturn;
        }

    }
}
