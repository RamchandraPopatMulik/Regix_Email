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
            Regex code = new Regex(@"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][r][i][d][g][e][l][a][b][z])\.([c][o])*$");
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
