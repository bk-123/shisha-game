using System.Text;

namespace System
{
    internal class TextStringBuilder
    {
        public TextStringBuilder()
        {
        }

        public static implicit operator StringBuilder(TextStringBuilder v)
        {
            throw new NotImplementedException();
        }
    }
}