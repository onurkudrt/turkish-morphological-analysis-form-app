using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601038_odev1_1
{
    public class TxtFile
    {
        public string name { get; set; }
        public string path { get; set; }
        public TxtFile(string path, string name)
        {
            this.path = path;
            this.name = name;
        }

        public string getContent()
        {
            if( !File.Exists(this.path)  | this.name == null)
            {
                MessageBox.Show("Geçerli dosya bulunamadı.");
                return null;
            }
            return File.ReadAllText(this.path);
        }
    }
}
