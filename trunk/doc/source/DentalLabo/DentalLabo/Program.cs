using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DentalLabo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (connectDatabase())                
                Application.Run(new frmDentalLabo());
            
        }

        static bool connectDatabase() {
            
            string filePath = @"config.dat";
            string line, server = "", user = "", pass = "", db = "";
            int countLine = 0;

            if (File.Exists(filePath))
            {
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(filePath);

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (countLine == 0)
                            server = line;
                        else if (countLine == 1)
                            user = line;
                        else if (countLine == 2)
                            pass = line;
                        else if (countLine == 3)
                            db = line;
                        Console.WriteLine(line);
                        countLine++;
                    }

                    if (countLine < 4) {
                        MessageBox.Show(null, "Thông tin cấu hình không đầy đủ", "Lỗi config server", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                    else
                    {
                        Database.connectDatabase(server, user, pass, db);
                        return Database.hasConnect;
                    }

                }
                catch
                {
                    MessageBox.Show(null, "File cấu hình bị lỗi", "Lỗi cấu hình server", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            else {
                MessageBox.Show(null, "Không tìm thấy file cấu hình", "Lỗi cấu hình server", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            return false;
         }
    }
}
