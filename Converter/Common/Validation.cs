using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Converter.Common
{
    public class Validation
    {
        public bool IsValidValue(string textValue)
        {
            Regex pattern = new Regex(@"(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.[0-9][0-9]?$)");
            if (pattern.IsMatch(textValue))
                return true;
            else
                return false;
        }
    }
}
