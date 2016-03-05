using System; 
using System.Security.Cryptography;
using System.Text;

namespace SCSOFT.FNC.Encryption
{
    public class Encryption
    {
        public static void RSACryp()
        { 
            RSACryptoServiceProvider rcp = new RSACryptoServiceProvider(); 
            RSAParameters parameter1 = rcp.ExportParameters(true); 
            RSAParameters parameter2 = rcp.ExportParameters(false); 
            WriteParameInfo(parameter1, "parameter1"); 
            WriteParameInfo(parameter2, "parameter2");
        }

        private static void WriteParameInfo(RSAParameters parameter, string name) 
        { 
            Console.WriteLine(name + ".D:"); 
            Console.WriteLine(ConverBitTostring(parameter.D)); 
            Console.WriteLine(name + "DP："); 
            Console.WriteLine(ConverBitTostring(parameter.DP)); 
            Console.WriteLine(name + ".DQ"); 
            Console.WriteLine(ConverBitTostring(parameter.DQ)); 
            Console.WriteLine(name + ".InverseQ"); 
            Console.WriteLine(ConverBitTostring(parameter.InverseQ)); 
            Console.WriteLine(name + ".Modulus"); 
            Console.WriteLine(ConverBitTostring(parameter.Modulus)); 
            Console.WriteLine(name + ".P"); 
            Console.WriteLine(ConverBitTostring(parameter.P)); 
            Console.WriteLine(name + ".Q"); 
            Console.WriteLine(ConverBitTostring(parameter.Q)); 
            Console.WriteLine(name + ".Exponent"); 
            Console.WriteLine(ConverBitTostring(parameter.Exponent)); 
        }

        public static string ConverBitTostring(byte[] bytes) 
        { 
            if (bytes == null) 
            { 
                return "该值为空!"; 
            } 
            else 
            { 
                StringBuilder sb = new StringBuilder(); 
                for (int i = 0; i < bytes.Length; i++) 
                { 
                    sb.Append(bytes[i].ToString()); 
                } 
                return sb.ToString(); 
            } 
        }

    }
}
