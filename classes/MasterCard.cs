namespace POO_encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        //ATRIBUTOS
        private int parcelas ;
        public int Parcelas{
            get {return parcelas;}
            set {parcelas = value;}
        }

        // MÉTODOS
        public string CompraComDesconto(){
            return "";
        }
    }
}