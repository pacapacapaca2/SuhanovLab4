using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.Interfaces
{
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
        string ExecuteQuery(string query);
    }
}
