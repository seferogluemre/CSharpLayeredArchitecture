namespace EntityLayer
{
    public class EntityDepartman
    {
        private int id;
        private string ad;
        private string aciklama;

        public string Aciklama { get => aciklama; set => aciklama = value; }
        public string Ad { get => ad; set => ad = value; }
        public int Id { get => id; set => id = value; }
    }
}
