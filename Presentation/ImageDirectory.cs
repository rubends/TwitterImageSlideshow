using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class ImageDirectory
    {

        private string _imagesDir;
        private string[] _files;

        public ImageDirectory(string imagesDir)
        {
            _imagesDir = imagesDir;
            _files = GetFilesFrom();
        }

        public String[] GetFilesFrom(String[] filters = null, bool isRecursive = false)
        {
            if(filters == null)
            {
                filters = new string[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            }

            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(_imagesDir, String.Format("*.{0}", filter), searchOption));
            }

            return filesFound.ToArray();
        }

        public int getLength()
        {
            return _files.Length;
        }

        public string[] getImagePaths()
        {
            return _files;
        }
    }
}
