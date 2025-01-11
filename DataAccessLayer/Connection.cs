using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Connection
    {
        public SqlConnection connection()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4DMQSS4;Initial Catalog=DbPersonel;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
