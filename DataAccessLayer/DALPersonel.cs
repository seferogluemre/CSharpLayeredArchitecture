using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    class DALPersonel
    {
        public static List<EntityDepartman> PersonelList()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand command = new SqlCommand("Select * from TblPersonelBilgi",Connection.connection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();

            
        
            
        }
                
    }
}
