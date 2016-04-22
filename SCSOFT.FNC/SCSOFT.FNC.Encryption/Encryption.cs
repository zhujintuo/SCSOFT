using System; 
using System.Security.Cryptography;
using System.Text;

namespace SCSOFT.FNC.Encryption
{
    public class Encryption
    {
        #region 解决方案一
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
        #endregion

        #region 解决方案二

        public static void RSACryp2()
        {
            try
            {
                // Create a key and save it in a container.
                GenKey_SaveInContainer("MyKeyContainer");

                // Retrieve the key from the container.
                GetKeyFromContainer("MyKeyContainer");

                // Delete the key from the container.
                DeleteKeyFromContainer("MyKeyContainer");

                // Create a key and save it in a container.
                GenKey_SaveInContainer("MyKeyContainer");

                // Delete the key from the container.
                DeleteKeyFromContainer("MyKeyContainer");
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void GenKey_SaveInContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container MyKeyContainerName.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));
        }

        private static void GetKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container MyKeyContainerName.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.
            Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));
        }

        private static void DeleteKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Delete the key entry in the container.
            rsa.PersistKeyInCsp = false;

            // Call Clear to release resources and delete the key from the container.
            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }

        #endregion
    }
}
