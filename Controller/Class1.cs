using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Controller
{
    public sealed class ADODBConnection
    {
        private static volatile SqlConnection instance;

    }
}
