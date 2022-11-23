using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method();    //Sirf kecdiklerimize esasen bitire bilmediyim method
            basicMethod();   //Replace ederek bitirdiyim method
            //ClassMethod();   //Internetden arasdirib tapib bitirdiyim class method ( Ancaq menasini tam olaraq anlamadim)
        }


        #region NotFinishedMethod
        static void Method()
        {
            string write = Console.ReadLine();
            string writeLower = write.ToLower();
            string[] arr = writeLower.Split();


                for (int i = 0; i < arr.Length; i++)
                {
                    string stringItem = arr[i];
                    char[] charArr = stringItem.ToCharArray();
                    char newUp = char.ToUpper(charArr[0]);
                    string newUpStr = newUp.ToString();
                    string str = new string(charArr);
                    string removed = str.Remove(0, 1);
                    string salam = removed.Insert(0, newUpStr);
                    Console.WriteLine(salam);

                }

        }
        #endregion


        #region CultureInfoMethod
        static void ClassMethod()
        {
            string word = Console.ReadLine();
            string total = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
            Console.WriteLine(total);
        } 
        #endregion




        #region ReplaceMethod

        static void basicMethod()
        {
            string name = "bU tasKI metHodla yAzmAliSiz";
            name = name.Replace("bU", "Bu");
            name = name.Replace("tasKI", "Taski");
            name = name.Replace("metHodla", "Methodla");
            name = name.Replace("yAzmAliSiz", "Yazmalisiz");
            Console.WriteLine(name);
        } 
        #endregion
    }

}