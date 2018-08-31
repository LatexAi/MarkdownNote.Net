using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MarkdownNote.Net {

    public static class Utils {

        /// <summary>
        /// 写入到文件
        /// </summary>
        /// <param name="FilePath">文件绝对路径</param>
        /// <param name="FileContent">文件内容</param>
        public static void WriteToFile(String FilePath, String FileContent) {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath))) {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            }
            using (Stream outStream = new FileStream(FilePath, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(outStream, Encoding.Default)) {
                sw.Write(FileContent);
            }
        }

        /// <summary>
        /// 从文件读取
        /// </summary>
        /// <param name="FilePath">文件绝对路径</param>
        /// <returns>文件内容</returns>
        public static String ReadFromFile(String FilePath) {
            String fileContent = "";
            using (Stream intStream = new FileStream(FilePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(intStream, Encoding.Default)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    fileContent += (line + Environment.NewLine);
                }
            }

            return fileContent;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        public static void DeleteFile(String FilePath) {
            try {
                File.Delete(FilePath);
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <returns>文件是否存在</returns>
        public static Boolean IsFileExists(String FilePath) {
            return File.Exists(FilePath);
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process, UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

        public static void ReleaseMemory(bool removePages) {
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            if (removePages) {
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle,
                                         (UIntPtr)0xFFFFFFFF,
                                         (UIntPtr)0xFFFFFFFF);
            }
        }

    }
}
