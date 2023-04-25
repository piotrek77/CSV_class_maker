using Microsoft.Win32.SafeHandles;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSV_class_maker
{
    public class CSVClassMaker
    {

        const string ZNAKIDOUSUNIECIA = "()'";
        const string ZNAKIDOZAMIANY = "-.";
        const char ZNAKZMIANA = '_'; //czyli na jaki znak będzie zamieniamy znak z ZNAKIDOZAMIENIENIA


        private string nazwaPola = "";

        private string nazwaaIdentyfikatora = "";

        public string NazwaIdentyfikatora
        {
            get
            {
                return nazwaaIdentyfikatora;
            }
        }

        public string NazwaPola
        {
            get
            {
                return nazwaPola;
            }
            set
            {
                nazwaPola = value;
                nazwaaIdentyfikatora = KonwertujNazwa(nazwaPola);
            }
        }

        //public CSVClassMaker(string nazwaPola)
        //{
        //    this.nazwaPola = nazwaPola;

        //    nazwaaIdentyfikatora = KonwertujNazwa(nazwaPola);
        //}


        private string KonwertujNazwa(string nazwaPola)
        {

            StringBuilder stringBuilder = new StringBuilder(nazwaPola);

            foreach(char ch in ZNAKIDOUSUNIECIA)
            {
                stringBuilder.Replace( ch.ToString(), "");
            }

            foreach (char ch in ZNAKIDOZAMIANY)
            {
                stringBuilder.Replace(ch , ZNAKZMIANA);
            }
            string[] wyrazy = stringBuilder.ToString().Split(' ');

            stringBuilder.Clear();

            foreach(string wyraz in wyrazy)
            {
                stringBuilder.Append(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(wyraz.ToLower()));
            }



            return stringBuilder.ToString();
        }
        public bool IsValidIdentifier()
        {
            
                return this.IsValidIdentifier(this.NazwaIdentyfikatora);
            
        }
        
        //https://stackoverflow.com/questions/1829679/how-to-determine-if-a-string-is-a-valid-variable-name
        private bool IsValidIdentifier(string input)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
            if (provider.IsValidIdentifier(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
