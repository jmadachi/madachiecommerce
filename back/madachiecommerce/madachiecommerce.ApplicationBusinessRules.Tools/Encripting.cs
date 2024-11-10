using System.Security.Cryptography;
using System.Text;

namespace madachiecommerce.ApplicationBusinessRules.Tools;
public static class Encripting
{
    public static string getSHA512(string texto)
    {
        SHA512 sha512 = SHA512.Create();
        ASCIIEncoding ENCODING = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
        stream = sha512.ComputeHash(Encoding.ASCII.GetBytes(texto));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }
}
