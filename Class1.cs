using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCatalog
{
    internal class Class1
    {
    }
    public class FileItem
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class DirectoryItem
    {
        public string Name { get; set; }
        public ObservableCollection<FileItem> Files { get; set; }

        public DirectoryItem(string path)
        {
            Name = System.IO.Path.GetFileName(path);
            Files = new ObservableCollection<FileItem>();

            foreach (var file in Directory.GetFiles(path))
            {
                var fileInfo = new FileInfo(file);

                Files.Add(new FileItem()
                {
                    Name = fileInfo.Name,
                    Size = fileInfo.Length,
                    DateModified = fileInfo.LastWriteTime
                });
            }
        }
    }
}
