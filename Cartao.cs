namespace Listas
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public float NumeroC { get; set; }
        public string Vencimento { get; set; }
        public float CVV { get; set; }

        public Cartao(){
            
        }
         public Cartao(string _titular, float _numeroc, string _bandeira, string _vencimento, float _cvv){ 
            this.Titular = _titular;
            this.NumeroC = _numeroc;
            this.Bandeira = _bandeira;
            this.CVV = _cvv;
            this.Vencimento = _vencimento;
        }
        
    }
}