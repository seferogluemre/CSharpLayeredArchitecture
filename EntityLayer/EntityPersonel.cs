namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string görev;
        private short maas;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Görev { get => görev; set => görev = value; }
        public short Maas { get => maas; set => maas = value; }
    }
}
