using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStationDB.Services.Interfaces
{
    public interface IBackupMySqlDatabase : IDisposable
    {
        bool BackupDbToDesktop(string _connectingString);
    }
}
