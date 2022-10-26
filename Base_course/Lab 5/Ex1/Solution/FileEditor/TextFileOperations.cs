using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileEditor
{
    /// <summary>
    /// Perform IO operations on text files
    /// </summary>
    class TextFileOperations
    {
        /// <summary>
        /// Read contents of a text file
        /// </summary>
        /// <param name="fileName">Full file name including path</param>
        /// <returns>File contents</returns>
        public static string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        /// <summary>
        /// Write to a text file
        /// </summary>
        /// <param name="fileName">Full file name including path</param>
        /// <param name="text">Text to write to file</param>
        public static void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
