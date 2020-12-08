namespace POO_encapsulamento.classes
{
    public class Cartao
    {
        // declaração dos atributos
        private string numero;
        public string Numero{
            get{ return numero;}
            set{ numero = value;}
        }

        private string bandeira = "MasterCard";
        public string Bandeira {
            get {return bandeira;}
        }

        protected string token = "qwertyui";
        public string Token {
            get { return token;}
        }

        private string cvv;
        public string Cvv {get ;set ;}

        protected float limiteDeCompra = 5000;
        public float LimiteDeCompra {
            get{ return limiteDeCompra;}
        }

        // Declaração dos metodos
        public string RegistrarCompra(bool validado) {

            return "";
        }

        public bool ValidarCompra(float saldo){

            return true ;
        }

        public string ValidarToken( string token){

            return "";
        }
    }
}