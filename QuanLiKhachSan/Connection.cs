using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Connection
    {
        string connection = "Data Source=DESKTOP-89MPSAI; Initial Catalog = QuanLiKhachSan; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string getConnection()
        {
            return connection;
        }
    }
}
