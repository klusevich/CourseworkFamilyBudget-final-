using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Budget
{
    class FileService
    {
        private readonly string path = Environment.CurrentDirectory + "\\expenses.txt";

        public void writeIntoFile(String writeString)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default))
                {
                    streamWriter.WriteLine(writeString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
