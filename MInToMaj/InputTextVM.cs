using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InputTextVM
    {
        private InputText _inputText;
        public string OriginalTextVm { get; set; }

         
        public InputTextVM()
        {
            _inputText = new InputText();
        }
        public string Convert()
        {
            _inputText.OriginalText = OriginalTextVm;
            _inputText.ConversionMaj();
            return _inputText.OutputText;
        }
    }
}
