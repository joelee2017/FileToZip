using Ionic.Zip;
using System;
using System.IO;
using System.Text;

namespace FileToZip.Utility
{
    public static class FileToZipHelper
    {
        /// <summary>
        /// 建立壓縮檔
        /// </summary>
        /// <param name="files">檔案</param>
        /// <param name="fileName">檔名</param>
        /// <param name="passwrod">密碼</param>
        /// <returns>byte[]</returns>
        public static byte[] CreateZip(byte[] files, string fileName, string passwrod = null)
        {
            byte[] byteZip = default(byte[]);
            try
            {
                using (ZipFile zip = new ZipFile(Encoding.UTF8))
                {
                    if (passwrod != null)
                        zip.Password = passwrod;

                    zip.AddEntry(fileName, files);
                    using(var memoryStream = new MemoryStream())
                    {
                        zip.Save(memoryStream);
                        byteZip = memoryStream.ToArray();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return byteZip;
        }
    }
}
