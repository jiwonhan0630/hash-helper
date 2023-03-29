using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace HashHelper.Base
{
    internal class MD5Manager : HashManagerBase
    {
        /// <summary>
        /// 해당 파일의 MD5 해쉬값을 스트링으로 반환해줍니다.
        /// </summary>
        public override string CreateHash(string fileFullPath)
        {
            FileInfo fi = new FileInfo(fileFullPath);

            if (!fi.Exists)
            {
                return string.Empty;
            }

            using (var md5 = MD5.Create())
            {
                using (FileStream stream = File.OpenRead(fileFullPath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }

        }

    }
}
