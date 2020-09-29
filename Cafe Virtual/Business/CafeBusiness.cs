using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Virtual.Business
{
    class CafeBusiness
    {
        public Model.CafeModel Validacao (Model.CafeModel cafe)
        {          
            if (cafe.moeda1Real == true) 
                cafe.quantidade1Real *= 1;

            if (cafe.moeda50Centavos == true)
                cafe.quantidade50Centavos *= 0.50m;

            if (cafe.moeda25Centavos == true)
                cafe.quantidade25Centavos *= 0.25m;

            if (cafe.moeda10Centavos == true)
                cafe.quantidade10Centavos *= 0.10m;

            cafe.total = cafe.quantidade1Real +
                         cafe.quantidade50Centavos +
                         cafe.quantidade25Centavos +
                         cafe.quantidade10Centavos;

            if (cafe.total == 0)
            {
                if (cafe.quantidade5Centavos != 0 || cafe.quantidade1Centavo != 0)
                    throw new ArgumentException("Não é possível inserir moedas de 1 e 5 centavos");                  
            }

            if (cafe.total > 0 && cafe.total < 2)
            {
                if(cafe.quantidade5Centavos != 0 || cafe.quantidade1Centavo != 0)
                   throw new ArgumentException("Não é possível inserir moedas de 1 e 5 centavos, seu crédito é de R$ " + cafe.total + " Não é possível comprar nenhum tipo de café com esse valor");
            }

            if (cafe.total >= 2)
            {
                if(cafe.quantidade5Centavos != 0 || cafe.quantidade1Centavo != 0)
                   throw new ArgumentException("Não é possível inserir moedas de 1 e 5 centavos, seu crédito é de R$ " + cafe.total + " Escolha qual tipo de café você quer");
            }

            if (cafe.total < 2)
                throw new ArgumentException("Não é possível comprar nenhum tipo de café com esse valor");

            if (cafe.cafe == false
                && cafe.cafeComLeite == false
                && cafe.cappuccino == false
                && cafe.mocha == false)
                throw new ArgumentException("Escolha qual tipo de café você quer");

            if (cafe.cafe == true)
            {
                if(cafe.total >= 2)
                {
                    cafe.troco = cafe.total - 2;

                    if(cafe.troco != 0)
                    {
                        throw new ArgumentException("seu Café e seu troco de R$ " + cafe.troco);
                    }
                    else
                    {
                        throw new ArgumentException("seu Café");
                    }                 
                }
            }

            else if (cafe.cafeComLeite == true)
            {
                if (cafe.total < 3)
                    throw new ArgumentException("Seu dinheiro é insuficiente!");

                else if (cafe.total >= 2)
                {
                    cafe.troco = cafe.total - 3;

                    if (cafe.troco != 0)
                    {
                        throw new ArgumentException("seu Café com leite e seu troco de R$ " + cafe.troco);
                    }
                    else
                    {
                        throw new ArgumentException("seu Café com leite");
                    }
                }
            }

            else if (cafe.cappuccino == true)
            {
                if (cafe.total < 3.50m)
                    throw new ArgumentException("Seu dinheiro é insuficiente!");

                else if (cafe.total >= 2)
                {
                    cafe.troco = cafe.total - 3.50m;

                    if (cafe.troco != 0)
                    {
                        throw new ArgumentException("seu Cappuccino e seu troco de R$ " + cafe.troco);
                    }
                    else
                    {
                        throw new ArgumentException("Seu Cappuccino");
                    }
                }
            }

            else if (cafe.mocha == true)
            {
                if (cafe.total < 4)
                    throw new ArgumentException("Seu dinheiro é insuficiente!");

                else if (cafe.total >= 2)
                {
                    cafe.troco = cafe.total - 4;

                    if (cafe.troco != 0)
                    {
                        throw new ArgumentException("seu Mocha e seu troco de R$ " + cafe.troco);
                    }
                    else
                    {
                        throw new ArgumentException("seu Mocha");
                    }
                }
            }
            
            return cafe;
        }
    }
}
