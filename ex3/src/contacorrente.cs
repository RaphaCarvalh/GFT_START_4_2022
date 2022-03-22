namespace ex3.src
{
    public class contacorrente
    {
          public contacorrente(int numero, string titular, double saldo)
        {
            
        }
        public override double rendimento2(double saldo){
            return saldo *0.03;
        }    

        public override double impostocp(double rendimento2){
            return rendimento2 *0.25;
    }
}