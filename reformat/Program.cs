using System;

namespace Reformat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phones = new string[]
            {
                "222-111-3333",
                "152-312-6204"
            };                      
            Reformat(phones);
        }

        static void Reformat(string[] phoneNumbers)
        {
            int cont = 0;
            foreach (string phoneNumber in phoneNumbers)
            {
                //Remove dashes if needed
                string plainNumber = phoneNumber;
                if (plainNumber.Contains("-"))
                {
                    plainNumber = plainNumber.Replace("-", string.Empty);
                }

                string prefix = string.Empty, areaCode = string.Empty, lineNumber = string.Empty;                
                for (int i=0; i<=plainNumber.Length-1; i++)
                {
                    if (i >= 0 && i<=2)
                    {
                        //prefix = plainNumber.ToCharArray(i, 3).ToString();
                        prefix = prefix + plainNumber.ToCharArray()[i].ToString();
                    }
                    else if (i >= 3 && i<= 5)
                    {
                        //areaCode = areaCode + plainNumber.ToCharArray(i, 3).ToString();
                        areaCode = areaCode + plainNumber.ToCharArray()[i].ToString();
                    }
                    else
                    {
                        //lineNumber = lineNumber + plainNumber.ToCharArray(i, 4).ToString();
                        lineNumber = lineNumber + plainNumber.ToCharArray()[i].ToString();
                    }                   
                }
                plainNumber = areaCode + "-" + prefix + "-" + lineNumber;
                phoneNumbers[cont] = plainNumber;
                cont++;
                Console.WriteLine(plainNumber);                
            }
        }
    }
}