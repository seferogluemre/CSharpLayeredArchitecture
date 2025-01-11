using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    class DALPersonel
    {
        public static List<EntityPersonel> PersonelList()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand command = new SqlCommand("Select * from TblPersonelBilgi",Connection.connection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPersonel EntityPersonel = new EntityPersonel();
                EntityPersonel.Id = int.Parse(dataReader["Id"].ToString());
                EntityPersonel.Ad = dataReader["Ad"].ToString();
                EntityPersonel.Soyad = dataReader["Soyad"].ToString();
                EntityPersonel.Görev = dataReader["Görev"].ToString();
                EntityPersonel.Maas = short.Parse(dataReader["Maas"].ToString());
                degerler.Add(EntityPersonel);
            }
            dataReader.Close();
            return degerler;
        }
                
    }
}
