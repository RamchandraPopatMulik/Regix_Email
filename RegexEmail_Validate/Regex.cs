using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEmail_Validate
{
    public class RegexProgram
    {
        public void CheckValidate(string Pattern)
        {
            Regex code = new Regex(@"(abc)");
            bool matches=code.IsMatch(Pattern);
            if(matches == true)
            {
                Console.WriteLine("Valide Email");
            }
            else
            {
                Console.WriteLine("InValide Email");
            }
        }
    }
}
