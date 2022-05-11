using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlLiteConnectionSettings
{
    public interface ISqlLiteDataAccess
    {
        string ReturnConnectionString();
    }
}
