using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Collections;

namespace Kiran.Accountportal.Common
{
   public class UtilityFunctions
    {
        public string EncryptString(string inputString)
        {

            string key = "<RSAKeyValue><Modulus>vPfz2Yter2HbnpO1GiDg2EECgJ8ED2/9FlVFcZCVrvS8M+64VPmvy6CsdQD8wgUa2HgSiwxobMvHg+sLlY1cPR6zoZqBRnyJCodLdhMcKrAp7nqQg08YdltV8//jeZd+0O/Gkr8aTU1l3hXplrl1czqIJhtafrg2NW2ha7YErDs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            int dwKeySize = 1024;

            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(key);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);
            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                Array.Reverse(encryptedBytes);
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }

        public string DecryptString(string inputString)
        {
            string key = "<RSAKeyValue><Modulus>vPfz2Yter2HbnpO1GiDg2EECgJ8ED2/9FlVFcZCVrvS8M+64VPmvy6CsdQD8wgUa2HgSiwxobMvHg+sLlY1cPR6zoZqBRnyJCodLdhMcKrAp7nqQg08YdltV8//jeZd+0O/Gkr8aTU1l3hXplrl1czqIJhtafrg2NW2ha7YErDs=</Modulus><Exponent>AQAB</Exponent><P>6gRgmTonP3q57hdIzy7XXtxB+NjUuKSg2fjVqLQuo85atG87VmOIPI0wSIC7wkBeZjMbKgy6Q/h+glkLoql67w==</P><Q>zrhAgvdOdUbzyY51oIP330VRiMXFz0Zzxmxdyzg8ObV/ap1jkRACDUCCB9jX0tib5wgSUkKCZkNnFHbo34xTdQ==</Q><DP>4Z9KyzDIOmnG7YjBiA9vUmQlrxjPLx56fu1sgfUGqqP/y8saeJYJ+edeT+jeHdEVso8/d3FB/NqOjnnvv+qLPQ==</DP><DQ>S4mwqSrNlLVUqDZSbVFL5l5iKOR8H/3SmJNIwtXNzBiycrcIhx2eYlFMMqneU8GrVoTwjPaYx92hcSzyc53HcQ==</DQ><InverseQ>qzGtHnyPxKVjyoLBOftGJaXP8d7AZURBRDB3lMq0mjadmq43XehE9mWGSHBVmg6WV66ktT7JUWb8YT5Qn/Vf0Q==</InverseQ><D>D8H5cqWdkrBtWO7mRjSBq2bYZ5NbClKDX05jCRJOeRVtcEMy2dssXqWaW/NmIGO+lliE61Vwi8n+bDC4eZMdItLg4wilbTqLlGC4Z/TXf0mmCrgBrDCXxzOIifXh9zdpBxXmu7+65z4wfU3vMWPh1i+roHvau3pg6jF2rCME2Bk=</D></RSAKeyValue>";
            int dwKeySize = 1024;

            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(key);
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }
    }
}
