using GameTop.Interfaces;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Marada estas a chupas la bola";
        }

        public string Corre()
        {
            return "Marada estas a correr";
        }

        public string Passe()
        {
            return "Marada estas passar";
        }
    }
}