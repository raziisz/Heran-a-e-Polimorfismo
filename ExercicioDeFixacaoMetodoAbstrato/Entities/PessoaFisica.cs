﻿

namespace ExercicioDeFixacaoMetodoAbstrato.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000.00)
            {
                if(GastosSaude > 0.0)
                {
                    return (RendaAnual * 0.15) - (GastosSaude * 0.5);
                }
                else
                {
                    return RendaAnual * 0.15;
                }
            } else //Se a renda atual for maior que 200000
            {
                if(GastosSaude > 0.0)
                {
                    return (RendaAnual * 0.25) - (GastosSaude * 0.5);
                }
                else
                {
                    return RendaAnual * 0.25;
                }
            }
        }

    }
}
