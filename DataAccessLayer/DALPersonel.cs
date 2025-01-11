using EntityLayer;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelList()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand command = new SqlCommand("Select * from TblPersonelBilgi", Connection.connection);
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
                EntityPersonel.Sehir = dataReader["Sehir"].ToString();
                EntityPersonel.Maas = short.Parse(dataReader["Maas"].ToString());
                degerler.Add(EntityPersonel);
            }
            dataReader.Close();
            return degerler;
        }
        //Personel Ekleme
        public static int AddPersonel(EntityPersonel personel)
        {
            SqlCommand komut = new SqlCommand("insert into TblPersonelBilgi (Ad,Soyad,Görev,Sehir,Maas) values(@p1,@p2,@p3,@p4,@p5) ", Connection.connection);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", personel.Ad);
            komut.Parameters.AddWithValue("@p2", personel.Soyad);
            komut.Parameters.AddWithValue("@p3", personel.Görev);
            komut.Parameters.AddWithValue("@p4", personel.Sehir);
            komut.Parameters.AddWithValue("@p5", personel.Maas);
            return komut.ExecuteNonQuery();
        }

        //Personel Silme
        public static bool RemovePersonel(int personel)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from TblPersonelBilgi where Id=@p1", Connection.connection);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.Parameters.AddWithValue("@p1", personel);
            return sqlCommand.ExecuteNonQuery() > 0;
        }

        // Personel güncelleme
        public static bool UpdatePersonel(EntityPersonel entityPersonel)
        {
            SqlCommand komut = new SqlCommand("update TblPersonelBilgi set Ad=@p1,Soyad=@p2,Maas=@p3,Sehir=@p4,Görev=@p5 where Id=@p6", Connection.connection);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", entityPersonel.Ad);
            komut.Parameters.AddWithValue("@p2", entityPersonel.Soyad);
            komut.Parameters.AddWithValue("@p3", entityPersonel.Maas);
            komut.Parameters.AddWithValue("@p4", entityPersonel.Sehir);
            komut.Parameters.AddWithValue("@p5", entityPersonel.Görev);
            komut.Parameters.AddWithValue("@p6", entityPersonel.Id);
            return komut.ExecuteNonQuery();
        }
    }
}
