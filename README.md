PetrolStationDB
Здесь будет описание




ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ (Экспорт/импорт БД)
https://stackoverflow.com/questions/12311492/backing-up-database-in-mysql-using-c-sharp

Sample codes:

Backup a MySQL database

using MySql.Data.MySqlClient; 
then the code,

private void Backup()
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
                mb.ExportToFile(file);
                conn.Close();
            }
        }
    }
}

Restore a MySQL database

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
Update:
I am one of the author of this library.