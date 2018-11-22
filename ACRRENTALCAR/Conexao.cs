using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ACRRENTALCAR
{
    class Conexao
    {
        public static SqlConnection GetConnection ()
            {
            SqlConnection cnn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BD_RENTALCAR; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            return cnn;
            }
    }
}
