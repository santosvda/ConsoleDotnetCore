using GameTop.Interfaces;

namespace GameTop
{
    class JogoFODA
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            this._jogador1 = jogador1;
            this._jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
             System.Console.WriteLine(_jogador1.Chuta());
             System.Console.WriteLine(_jogador1.Corre());
             System.Console.WriteLine(_jogador1.Passe());
             System.Console.WriteLine("PROXIMO JOGADOR!");  
             System.Console.WriteLine(_jogador2.Chuta());
             System.Console.WriteLine(_jogador2.Corre());
             System.Console.WriteLine(_jogador2.Passe());
        }
    }
     
}