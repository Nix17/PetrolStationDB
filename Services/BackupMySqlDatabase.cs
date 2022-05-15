using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Services.Interfaces;
using MySql.Data.MySqlClient;

namespace PetrolStationDB.Services
{
    public class BackupMySqlDatabase : IBackupMySqlDatabase
    {
        public bool BackupDbToDesktop(string _connectingString)
        {
            bool result = false;

            StringBuilder filePath = new StringBuilder();

            try
            {
                //string constring = "server=localhost;user=root;pwd=;database=petrol_station;";
                
                string constring = _connectingString;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string guidCode = Guid.NewGuid().ToString();
                string shortDate = DateTime.Now.ToShortDateString();
                filePath.Append(path + "\\backup_" + shortDate + "_" + guidCode + ".sql");
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(filePath.ToString());
                            conn.Close();
                        }
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return result;
        }

        public void Dispose()
        {
        }

        
        
        /*Restore a MySQL database

        private void Restore()
        {
            string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
            string file = "C:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }
        ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ (Экспорт/импорт БД)
        https://stackoverflow.com/questions/12311492/backing-up-database-in-mysql-using-c-sharp
         */
    }
}
