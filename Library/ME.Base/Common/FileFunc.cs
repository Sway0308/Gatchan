using System;
using System.IO;
using System.Text;

namespace ME.Base
{
    /// <summary>
    /// 檔案及目錄相關函式庫。
    /// </summary>
    /// <remarks>
    /// File：檔案相關的函式。
    /// Directory：目錄相關的函式。
    /// Path：路徑相關的函式。
    /// </remarks>
    public class FileFunc
    {
        /// <summary>
        /// 取得應用程式根目錄的路徑。
        /// </summary>
        public static string GetAppPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// 取得應用程式下指定子目錄的路徑。
        /// </summary>
        /// <param name="subPath">子目錄。</param>
        public static string GetAppPath(string subPath)
        {
            return PathCombine(GetAppPath(), subPath);
        }

        /// <summary>
        /// 組合二個路徑字串。
        /// </summary>
        /// <param name="path1">第一個路徑。</param>
        /// <param name="path2">第二個路徑。</param>
        public static string PathCombine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        /// <summary>
        /// 取得指定路徑字串的目錄資訊。
        /// </summary>
        /// <param name="path">路徑。</param>
        public static string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        /// <summary>
        /// 取得檔案路徑的檔案名稱和副檔名。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        /// <summary>
        /// 取得檔案路徑的副檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string GetExtension(string filePath)
        {
            return Path.GetExtension(filePath);
        }

        /// <summary>
        /// 取得指定路徑字串的不含副檔名的檔案名稱。
        /// </summary>
        /// <param name="path">路徑。</param>
        public static string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// 資料流轉換為二進位資料。
        /// </summary>
        /// <param name="stream">資料流。</param>
        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] oBytes;

            oBytes = new byte[stream.Length];
            stream.Read(oBytes, 0, oBytes.Length);

            // 設置資料流的起始位置
            stream.Seek(0, SeekOrigin.Begin);
            return oBytes;
        }

        /// <summary>
        /// 將二進位資料轉換為資料流。
        /// </summary>
        /// <param name="bytes">二進位資料。</param>
        public static Stream BytesToStream(byte[] bytes)
        {
            Stream oStream;

            oStream = new MemoryStream(bytes);
            return oStream;
        }

        /// <summary>
        /// 讀取文字檔所有資料，然後關閉檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string FileReadAllText(string filePath)
        {
            return FileReadAllText(filePath, Encoding.UTF8);
        }

        /// <summary>
        /// 讀取文字檔所有資料，然後關閉檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="encoding">編碼方式。</param>
        public static string FileReadAllText(string filePath, Encoding encoding)
        {
            return File.ReadAllText(filePath, encoding);
        }

        /// <summary>
        /// 將資料寫入文字檔，然後關閉檔案。若檔案已存在則覆蓋。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="contents">要寫入檔案的字串。</param>
        public static void FileWriteAllText(string filePath, string contents)
        {
            File.WriteAllText(filePath, contents);
        }

        /// <summary>
        /// 將資料寫入文字檔，然後關閉檔案。若檔案已存在則覆蓋。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="contents">要寫入檔案的字串。</param>
        /// <param name="encoding">編碼方式。</param>
        public static void FileWriteAllText(string filePath, string contents, Encoding encoding)
        {
            File.WriteAllText(filePath, contents, encoding);
        }

        /// <summary>
        /// 將資料寫入文字檔，然後關閉檔案。若檔案已存在則覆蓋。
        /// 若資料夾不存在則新建
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        /// <param name="contents"></param>
        public static void FileWriteAllText(string path, string fileName, string contents)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var filePath = PathCombine(path, fileName);
            File.WriteAllText(filePath, contents);
        }

        /// <summary>
        /// 取得應用程式私用組件目錄。
        /// </summary>
        public static string GetAssemblyPath()
        {
            //取得程式組件路徑
            if (StrFunc.StrIsEmpty(AppDomain.CurrentDomain.RelativeSearchPath))
                return AppDomain.CurrentDomain.BaseDirectory;
            else
                return AppDomain.CurrentDomain.RelativeSearchPath;
        }
    }
}
