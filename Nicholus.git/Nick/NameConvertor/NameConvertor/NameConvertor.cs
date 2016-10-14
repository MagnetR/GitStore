using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameConvertor
{
    public class NameConvertor
    {
        public string ReverseName(string firstName)
        {
            char[] chrLetters = firstName.ToCharArray(); //dynamic array.
            Array.Reverse(chrLetters);//reversing the array.

            StringBuilder sbReversedName = new StringBuilder();//creating the stringbuilder instance.

            foreach(char chrLetter in chrLetters)
            {
                sbReversedName.Append(chrLetter);
            }
            return sbReversedName.ToString(); //convert the returned charectors to string and return them.
        }
    }
}
