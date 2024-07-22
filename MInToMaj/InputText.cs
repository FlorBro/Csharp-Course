using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InputText
    {
        public string OriginalText { get; set; }
        public string OutputText { get; set; }
        public void ConversionMaj()
        {
            OutputText = OriginalText.ToUpper();
        }
        public void Check()
        {
            if (OriginalText.Length > 8) {
                Console.WriteLine("Caractère incompatiple, 8 caractère maximum");    
            }
        }
    }
}
