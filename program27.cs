namespace programa26
{
    class Quartos
    {
     public string NameDoCliente{ get; set; }

     public string EmailDoCliente { get; set; }

     public Quartos ( string nomedocliente, string emaildocliente){
        NameDoCliente = nomedocliente;
        EmailDoCliente = emaildocliente;
     }

        public override string ToString()
        {
            return NameDoCliente + "," +  EmailDoCliente;
        }
    }
}