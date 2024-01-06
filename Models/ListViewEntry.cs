using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FolderBrowser.Models
{
    public class ListViewEntry
    {
        public ImageSource? icon { get; set; }
        public string? fileName { get; set; }
        public string? filePath { get; set; }

    }
}
