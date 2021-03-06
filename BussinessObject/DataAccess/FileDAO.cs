using System;
using System.IO;

namespace BussinessObject.DataAccess
{
    public class FileDAO
    {
        public static string Folder = "ImagePet";
        public static void CopyImage(string pathSource, string pathDestination)
        {
            try
            {
                bool exists = Directory.Exists(Folder);
                if (exists)
                    File.Copy(pathSource, Folder + "/" + pathDestination, true);
                else
                {
                    Directory.CreateDirectory(Folder);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
