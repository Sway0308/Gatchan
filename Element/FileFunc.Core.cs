using System;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Elementary.Core
{
    /// <summary>
    /// 檔案及目錄相關函式庫。
    /// </summary>
    /// <remarks>
    /// File：檔案相關的函式。
    /// Directory：目錄相關的函式。
    /// Path：路徑相關的函式。
    /// </remarks>
    public class FileFuncCore
    {
        /// <summary>
        /// 組合二個路徑字串。
        /// </summary>
        /// <param name="path1">第一個路徑。</param>
        /// <param name="path2">第二個路徑。</param>
        public static string PathCombine(string path1, string path2)
        {
            return System.IO.Path.Combine(path1, path2);
        }

        /// <summary>
        /// 判斷指定檔案是否存在。
        /// </summary>
        /// <param name="path">要檢查的檔案。</param>
        public static bool FileExists(string path)
        {
            return System.IO.File.Exists(path);
        }

        /// <summary>
        /// 檔案複製。
        /// </summary>
        /// <param name="sourceFileName">來源檔案。</param>
        /// <param name="destFileName">目的檔案。</param>
        public static void FileCopy(string sourceFileName, string destFileName)
        {
            // 確認目的資料夾是否存在
            DirectoryCheck(destFileName, true);
            // 執行檔案複製
            System.IO.File.Copy(sourceFileName, destFileName);
        }

        /// <summary>
        /// 檔案複製。
        /// </summary>
        /// <param name="sourceFileName">來源檔案。</param>
        /// <param name="destFileName">目的檔案。</param>
        /// <param name="overwrite">是否允許覆寫目的檔案。</param>
        public static void FileCopy(string sourceFileName, string destFileName, bool overwrite)
        {
            // 確認目的資料夾是否存在
            DirectoryCheck(destFileName, true);
            // 執行檔案複製
            System.IO.File.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <summary>
        /// 檔案搬移。
        /// </summary>
        /// <param name="sourceFileName">來源檔案。</param>
        /// <param name="destFileName">目的檔案。</param>
        /// <param name="overwrite">是否允許覆寫目的檔案。</param>
        public static void FileMove(string sourceFileName, string destFileName, bool overwrite)
        {
            DirectoryCheck(destFileName, true);
            File.Move(sourceFileName, destFileName);
        }

        /// <summary>
        /// 檔案刪除。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static void FileDelele(string filePath)
        {
            if (FileFuncCore.FileExists(filePath))
                System.IO.File.Delete(filePath);
        }

        /// <summary>
        /// 讀取文字檔所有資料，然後關閉檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string FileReadAllText(string filePath)
        {
            return System.IO.File.ReadAllText(filePath);
        }

        /// <summary>
        /// 讀取文字檔所有資料，然後關閉檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="encoding">編碼方式。</param>
        public static string FileReadAllText(string filePath, Encoding encoding)
        {
            return System.IO.File.ReadAllText(filePath, encoding);
        }

        /// <summary>
        /// 將資料寫入文字檔，然後關閉檔案。若檔案已存在則覆蓋。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="contents">要寫入檔案的字串。</param>
        public static void FileWriteAllText(string filePath, string contents)
        {
            System.IO.File.WriteAllText(filePath, contents);
        }

        /// <summary>
        /// 將資料寫入文字檔，然後關閉檔案。若檔案已存在則覆蓋。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        /// <param name="contents">要寫入檔案的字串。</param>
        /// <param name="encoding">編碼方式。</param>
        public static void FileWriteAllText(string filePath, string contents, Encoding encoding)
        {
            System.IO.File.WriteAllText(filePath, contents, encoding);
        }

        /// <summary>
        /// 判斷目錄是否存在。
        /// </summary>
        /// <param name="path">要檢查的目錄。</param>
        public static bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        /// <summary>
        /// 建立指定路徑的所有目錄及子目錄。
        /// </summary>
        /// <param name="path">目錄路徑。</param>
        public static void DirectoryCreate(string path)
        {
            Directory.CreateDirectory(path);
        }

        /// <summary>
        /// 刪除指定目錄。
        /// </summary>
        /// <param name="path">目錄路徑。</param>
        public static void DirectoryDelete(string path)
        {
            if (FileFuncCore.DirectoryExists(path))
                Directory.Delete(path, true);
        }

        /// <summary>
        /// 判斷目錄是否存在，不存在則建立。
        /// </summary>
        /// <param name="path">要檢查的路徑。</param>
        /// <param name="isFilePath">是否為檔案路徑。</param>
        public static void DirectoryCheck(string path, bool isFilePath = false)
        {
            string sPath;

            // 若路徑有包含檔案(路徑有副檔名)，則取檔案所在的資料夾路徑
            if (isFilePath || System.IO.Path.HasExtension(path))
                sPath = GetDirectoryName(path);
            else
                sPath = path;

            if (!DirectoryExists(sPath))
                DirectoryCreate(sPath);
        }

        /// <summary>
        /// 移動目錄。
        /// </summary>
        /// <param name="sourcePath">來源目錄路徑。</param>
        /// <param name="destPath">目的目錄路徑。</param>
        /// <param name="overwrite">是否覆寫。</param>
        public static void DirectoryMove(string sourcePath, string destPath, bool overwrite)
        {

            Directory.Move(sourcePath, destPath);
        }

        /// <summary>
        /// 複製目錄。
        /// </summary>
        /// <param name="sourcePath">來源目錄路徑。</param>
        /// <param name="destPath">目的目錄路徑。</param>
        /// <param name="copySubDirs">是否複製子目錄。</param>
        public static void DirectoryCopy(string sourcePath, string destPath, bool copySubDirs)
        {
            DirectoryInfo oDir = new DirectoryInfo(sourcePath);
            DirectoryInfo[] oDirs = oDir.GetDirectories();
            FileInfo[] oFiles = null;
            string sTempPath = string.Empty;

            // 判斷目錄是否存在，不存在則建立
            DirectoryCheck(destPath);

            // 取得來源目錄下的檔案清單
            oFiles = oDir.GetFiles();
            foreach (FileInfo oFile in oFiles)
            {
                sTempPath = Path.Combine(destPath, oFile.Name);
                oFile.CopyTo(sTempPath, true);
            }

            // 複製子目錄
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in oDirs)
                {
                    sTempPath = Path.Combine(destPath, subdir.Name + "\\");
                    DirectoryCopy(subdir.FullName, sTempPath, copySubDirs);
                }
            }
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
        /// 取得指定目錄的所有子資料夾。
        /// </summary>
        /// <param name="path">指定目錄。</param>
        public static string[] GetDirectories(string path)
        {
            if (FileFuncCore.DirectoryExists(path))
                return Directory.GetDirectories(path);
            else
                return new string[0];
        }

        /// <summary>
        /// 取得指定目錄符合條件的子資料夾。
        /// </summary>
        /// <param name="Path">指定目錄。</param>
        /// <param name="SearchOption">檔案搜尋選項。</param>
        /// <param name="SearchPattern">過濾條件，可使用萬用字元。</param>
        public static string[] GetDirectories(string Path, string SearchPattern, SearchOption SearchOption)
        {
            return Directory.GetDirectories(Path, SearchPattern, SearchOption);
        }

        /// <summary>
        /// 取得檔案路徑的檔案名稱和副檔名。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string GetFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }

        /// <summary>
        /// 取得檔案路徑的副檔案。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static string GetExtension(string filePath)
        {
            return System.IO.Path.GetExtension(filePath);
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
        /// 取得應用程式私用組件目錄。
        /// </summary>
        public static string GetAssemblyPath()
        {
            //取得程式組件路徑
            if (StrFuncCore.StrIsEmpty(AppDomain.CurrentDomain.RelativeSearchPath))
                return AppDomain.CurrentDomain.BaseDirectory;
            else
                return AppDomain.CurrentDomain.RelativeSearchPath;
        }

        /// <summary>
        /// 取得系統特定資料夾目錄路徑。
        /// </summary>
        /// <param name="folder">系統特定資料夾。</param>
        public static string GetSpecialFolderPath(Environment.SpecialFolder folder)
        {
            return Environment.GetFolderPath(folder);
        }

        /// <summary>
        /// 取得系統特殊資料夾的目錄路徑。
        /// </summary>
        /// <param name="folder">系統特殊資料夾。</param>
        public static string GetSystemPath(Environment.SpecialFolder folder)
        {
            return Environment.GetFolderPath(folder);
        }

        /// <summary>
        /// 傳回指定目錄中的檔案。
        /// </summary>
        /// <param name="path">指定目錄。</param>
        public static string[] GetFiles(string path)
        {
            if (FileFuncCore.DirectoryExists(path))
                return System.IO.Directory.GetFiles(path);
            else
                return new string[0];
        }

        /// <summary>
        /// 傳回指定目錄中，符合搜尋條件的檔案。
        /// </summary>
        /// <param name="path">指定目錄。</param>
        /// <param name="searchPattern">搜尋條件。</param>
        public static string[] GetFiles(string path, string searchPattern)
        {
            if (!FileFuncCore.DirectoryExists(path))
                return new string[0];
            else
                return System.IO.Directory.GetFiles(path, searchPattern);
        }

        /// <summary>
        /// 傳回指定目錄中，符合搜尋條件的檔案。
        /// </summary>
        /// <param name="path">指定目錄。</param>
        /// <param name="searchPattern">搜尋條件。</param>
        /// <param name="searchOption">檔案搜尋選項。</param>
        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
        }

        /// <summary>
        /// 檔案轉為二進位資料。
        /// </summary>
        /// <param name="filePath">檔案路徑。</param>
        public static byte[] FileToBytes(string filePath)
        {
            FileStream oFileStream;
            Byte[] oBytes;
            int iLen;

            oFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            iLen = (int)oFileStream.Length;
            oBytes = new Byte[iLen];
            oFileStream.Read(oBytes, 0, iLen);
            oFileStream.Close();
            return oBytes;
        }

        /// <summary>
        /// 二進位資料轉為檔案。
        /// </summary>
        /// <param name="bytes">二進位資料。</param>
        /// <param name="filePath">檔案路徑。</param>
        public static void BytesToFile(byte[] bytes, string filePath)
        {
            FileStream oFileStream;
            int iLen;

            FileFuncCore.DirectoryCheck(filePath, true);

            iLen = bytes.Length;
            oFileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            oFileStream.Write(bytes, 0, iLen);
            oFileStream.Close();
        }

        /// <summary>
        /// 資料串流轉為檔案。
        /// </summary>
        /// <param name="stream">資料串流。</param>
        /// <param name="filePath">檔案路徑。</param>
        public static void StreamToFile(Stream stream, string filePath)
        {
            FileStream oFileStream;

            FileFuncCore.DirectoryCheck(filePath, true);

            oFileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            stream.CopyTo(oFileStream);
            oFileStream.Close();
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
        /// 是否為網芳路徑。
        /// </summary>
        /// <param name="path">路徑。</param>
        public static bool IsRemotePath(string path)
        {
            return StrFuncCore.StrLeftWith(path, "\\");
        }

        /// <summary>
        /// 取得網芳路徑中的遠端主機。
        /// </summary>
        /// <param name="path">網芳路徑。</param>
        public static string GetRemoteHost(string path)
        {
            string sPath;
            int iPos;
            string sRemoteHost;

            if (!IsRemotePath(path)) { return string.Empty; }

            sPath = StrFuncCore.StrLeftCut(path, 2);
            iPos = StrFuncCore.StrPos(sPath, @"\");
            if (iPos == -1)
                sRemoteHost = sPath;
            else
                sRemoteHost = StrFuncCore.StrLeft(sPath, iPos);

            return sRemoteHost;
        }

        /// <summary>
        /// 遠端主機連線。
        /// </summary>
        /// <param name="remoteHost">遠端主機。</param>
        /// <param name="userName">登入帳號。</param>
        /// <param name="passWord">登入密碼。</param>        
        public static bool ServerConnect(string remoteHost, string userName, string passWord)
        {
            bool bConnect = true;
            Process oProc = new Process();
            string sCommand = string.Empty;
            string sErrorMsg = string.Empty;

            oProc.StartInfo.FileName = "cmd.exe";
            oProc.StartInfo.UseShellExecute = false;
            oProc.StartInfo.RedirectStandardInput = true;
            oProc.StartInfo.RedirectStandardOutput = true;
            oProc.StartInfo.RedirectStandardError = true;
            oProc.StartInfo.CreateNoWindow = true;

            try
            {
                oProc.Start();
                sCommand = @"net  use  \\" + remoteHost + "  " + passWord + "  " + "  /user:" + userName + ">NUL";
                oProc.StandardInput.WriteLine(sCommand);
                sCommand = "exit";
                oProc.StandardInput.WriteLine(sCommand);

                while (oProc.HasExited == false)
                {
                    oProc.WaitForExit(1000);
                }

                sErrorMsg = oProc.StandardError.ReadToEnd();
                if (StrFuncCore.StrIsNotEmpty(sErrorMsg))
                {
                    // 如錯誤訊息中有 1219 的代碼，則代表已經連線過了
                    if (StrFuncCore.StrPos(sErrorMsg, "1219") < 0)
                    {
                        bConnect = false;
                    }
                }

                oProc.StandardError.Close();
            }
            catch
            {
                bConnect = false;
                throw;
            }
            finally
            {
                oProc.Close();
                oProc.Dispose();
            }

            return bConnect;
        }

        /// <summary>
        /// 遠端主機斷線。
        /// </summary>
        /// <param name="remoteHost">遠端主機。</param>        
        public static bool ServerDisConnect(string remoteHost)
        {
            bool bDisConnect = true;
            Process oProc = new Process();
            string sCommand = string.Empty;
            string sErrorMsg = string.Empty;

            oProc.StartInfo.FileName = "cmd.exe";
            oProc.StartInfo.UseShellExecute = false;
            oProc.StartInfo.RedirectStandardInput = true;
            oProc.StartInfo.RedirectStandardOutput = true;
            oProc.StartInfo.RedirectStandardError = true;
            oProc.StartInfo.CreateNoWindow = true;

            try
            {
                oProc.Start();
                sCommand = @"net use \\" + remoteHost + " /delete";
                oProc.StandardInput.WriteLine(sCommand);
                sCommand = "exit";
                oProc.StandardInput.WriteLine(sCommand);

                while (oProc.HasExited == false)
                {
                    oProc.WaitForExit(1000);
                }

                sErrorMsg = oProc.StandardError.ReadToEnd();
                if (StrFuncCore.StrIsNotEmpty(sErrorMsg))
                    bDisConnect = false;

                oProc.StandardError.Close();
            }
            catch
            {
                bDisConnect = false;
                throw;
            }
            finally
            {
                oProc.Close();
                oProc.Dispose();
            }

            return bDisConnect;
        }
    }
}
