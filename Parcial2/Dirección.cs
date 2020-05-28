namespace Parcial2
{
    public class Dirección
    {
        public int idAddress { get; set; }
        public int idUser { get; set; }
        public string address { get; set; }


        public Dirección()
        {
            idAddress = 0;
            idUser = 0;
            address = "";
        }
    }
}