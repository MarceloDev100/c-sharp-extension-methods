namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int pos)
        {
            string newString = "";

            if (thisObj.Length <= pos)
            {
                return thisObj;
            }
            else
            {
                for (int i = 0; i < pos; i++)
                {
                    newString += thisObj[i] + "";
                }

                newString += "...";
            }

            return newString;
        }
    }
}
