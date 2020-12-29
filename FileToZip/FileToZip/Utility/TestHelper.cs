using System.IO;

namespace FileToZip.Utility
{
    public static class TestHelper
    {
        /// <summary>
        /// 檔案下載
        /// </summary>
        /// <param name="files">檔案</param>
        /// <param name="downloadPath">指定路徑</param>
        public static void Download(byte[] files, string downloadPath)
        {
            using(FileStream fileStream = new FileStream(downloadPath, FileMode.Create))
            {
                fileStream.Write(files, 0, files.Length);
            }
        }
    }
}
