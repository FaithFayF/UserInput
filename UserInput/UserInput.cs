using System;
using System.Text;

namespace UserInput
{
    public class UserInput
    {
        public abstract class TextInput
        {
            public StringBuilder sb = new StringBuilder();

            public virtual void Add(char c)
            { 
                sb.Append(c);
            }

            public string GetValue()
            {
                return sb.ToString();
            }
        }

        public class NumericInput : TextInput
        {
            public override void Add(char a)
            {
                if (Char.IsDigit(a))
                {
                    sb.Append(a);
                }
            }
        }
    }
}
