namespace ex3.src
{
    public class contapoupanca
    {
          public contapoupanca(int numero, string titular, double saldo)
        {
            
        }
        public override double rendimento3(double saldo){
            return saldo *0.05;
        }    
        public override double impostocc(double rendimento3){
            return rendimento3 *0.25;

    }
}
}