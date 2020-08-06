using System.Globalization;

namespace Ex_video_60
{
    class ContaBancaria
    {
        private string _titular;
        public double Saldo { get; private set; }
        public int Numero { get; private set; }

       public ContaBancaria(int numero,string titular)
        {
            Numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double deposito_i) : this(numero,titular) //Este this é usado para
        {                                                                                         //Poupar código
            Saldo = deposito_i;
        }

 
        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                if (value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0);
        }

        public override string ToString()
        {
            return "Dados da conta atualizados:\n"
                + "Conta " +Numero
                +", Titular: " +Titular
                +", Saldo: R$ "+ Saldo.ToString("F2",CultureInfo.InvariantCulture)
                +"\n";
        }
    }
}
