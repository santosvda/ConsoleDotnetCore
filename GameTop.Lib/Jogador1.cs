using GameTop.Interfaces;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public Jogador1(string nome)
         {
             _Nome = nome;
         }
         private readonly string _Nome;

        public string Chuta()
        {
            return $"{_Nome} ta chutando";
        }

        public string Corre()
        {
            return $"{_Nome} ta correndo";
        }

        public string Passe()
        {
            return $"{_Nome} ta passando";
        }
    }
}