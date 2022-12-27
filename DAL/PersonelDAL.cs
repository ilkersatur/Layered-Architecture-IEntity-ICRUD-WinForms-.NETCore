namespace DAL
{
    public class PersonelDAL
    {
        public PersonelDAL()
        {
            //Connection string i al 
            //Connection nesnesi oluştur
            Personel = new PersonelYonetici();
            Bolum = new BolumYonetici();
        }
        public PersonelYonetici Personel { get; set; }
        public BolumYonetici Bolum { get; set; }
    }
}