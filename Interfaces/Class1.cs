namespace Interfaces
{
    public interface Ientity { }
    //Arayüzler hiyerarşik ağacı esnetir.
    public interface ICRUD<T> where T : class
    {
        public List<T> Liste();

        public T Ara(int ID);

        public void Ekle(T entity);

        public void Guncelle(T entity);

        public void Sil(int ID);
    }
}