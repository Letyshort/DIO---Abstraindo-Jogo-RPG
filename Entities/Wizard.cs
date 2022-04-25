namespace Desafio___Abstraindo_um_Jogo_de_RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "Lançou Magia";
        
        }

        public string Attack (int Bonus){
            
            if (Bonus > 6){

            
            return this.Name + "Lançou Magia Super Efetiva com bonus de " + Bonus;
            }else{
                return this.Name + "Lançou uma magia com força fraca com bonus de" + Bonus;
            }
        }
    }
}