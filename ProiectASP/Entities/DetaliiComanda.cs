namespace ProiectASP.Entities
{
    public class DetaliiComanda
    {

        public Comenzi Comenzi { get; set; }
        public int IdComanda { get; set; }


        public Produs Produse { get; set; }
        public int IdProdus { get; set; }

        public int IdProiectant { get; set; }
        public Angajati Angajati { get; set; }
        public int IdExecutant { get; set; }

        
        public string Status { get; set; }
    }
}