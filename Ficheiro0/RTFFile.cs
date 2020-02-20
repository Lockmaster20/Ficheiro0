using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ficheiro0
{
    class RTFFile
    {
        private string _Path = Application.StartupPath + "\\Resources\\Texto.txt";
        private string _Text;

        public string Texto
        {
            get{
                _Text = File.ReadAllText(_Path);
                return _Text;
            }
            set{ _Text = value; }
        }
        public void Salvar()
        {
            File.WriteAllText(_Path, _Text);
        }

        public void Reset()
        {
            _Text = "";
        }
    }
}
