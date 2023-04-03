using HashHelper.Base;using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashHelper
{
    internal class SHA256Manager : HashManagerBase
    {
        public override string CreateHash(string fileFullPath)
        {
            FileInfo fi = new FileInfo(fileFullPath);

            if (!fi.Exists)
            {
                return string.Empty;
            }

            using (var sha256 = SHA256.Create())
            {
                using (FileStream stream = File.OpenRead(fileFullPath))
                {
                    var hash = sha256.ComputeHash(stream);
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (byte item in hash)
                    {
                        stringBuilder.AppendFormat("{0:x2}", item);
                    }
                    //sha.ComputeHash(Encoding.ASCII.GetBytes(data));
                    return stringBuilder.ToString();
                    //return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }

        }

    }
}
