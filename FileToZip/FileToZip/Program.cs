using FileToZip.Utility;
using System;
using System.IO;

namespace FileToZip
{
    class Program
    {
        /// <summary>
        /// 檔案壓縮測試
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("壓縮檔測試下載");

            string path = Path.GetFullPath(@"請輸入路徑!!");
            Console.WriteLine(path);

            byte[] zip = FileToZipHelper.CreateZip(Write(path), "檔案下載測試.txt", "123");

            TestHelper.Download(zip, path + "壓縮檔測試下載.zip");

            Console.WriteLine("壓縮檔測試下載成功");
            Console.ReadLine();
        }


        /// <summary>
        /// 測試檔案建立
        /// </summary>
        /// <param name="path">路徑</param>
        /// <returns>byte[]</returns>
        public static byte[] Write(string path)
        {

            FileStream fs = new FileStream(path + "Test.txt", FileMode.Create);
            //獲得位元組陣列
            byte[] data = System.Text.Encoding.Default.GetBytes("Hello World!");
            //開始寫入
            fs.Write(data, 0, data.Length);
            //清空緩衝區、關閉流
            fs.Flush();
            fs.Close();

            return data;
        }
    }

}
