namespace Questao1
{
    public class ContaBancaria 
    {
        public int numero { get; private set; }
        public string titular { get; set; }
        public double depositoInicial;
        public double Saldo { get; private set; }
        public double Taxa= 3.50;

        public ContaBancaria(int numero, string titular, double depositoInicial=0)
        {
            this.numero = numero;
            this.titular = titular;
            this.depositoInicial = depositoInicial;
            this.Saldo += this.depositoInicial;
        }

        public void Deposito(double quantia)
        {
            this.Saldo +=  quantia;
        }

        public void Saque(double quantia)
        {
            this.Saldo -= this.Taxa;
            this.Saldo -= quantia;
        }
    }
}
