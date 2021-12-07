using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaelEtronicoUp
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int numeroAgencia;
        public int numero = 01;
        public double _saldo;
        public double valor;
        
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;

            }

        }
       
        public bool sacar(double valor)
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("saldo insuficiente");


            }
            if (this._saldo < valor)
            {
                return false;

            }
            else
            {
                this._saldo -= valor;
                return true;

            }


        }
        public void depositar(double valor)
        {
            Console.WriteLine(" voce depositou " + valor);

            this._saldo += valor;

            
        }
        public bool transferir(double valor, ContaCorrente contadestino)
        {
            if (this._saldo < valor)
            {
                return false;

            }
            else
            {
                this._saldo -= valor;
                contadestino.depositar(valor);
                return true;

            }


        }



    }
    


}
