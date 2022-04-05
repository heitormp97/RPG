namespace Rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType, (level*20), (level*40))
        {

        }

        public override string Ability(int power)
        {
            int mana = 200;
            if(this.magicPoints > mana)
            {
                this.magicPoints -= mana;
                return this.name + " Usou meteoro com poder " + power;
            }
            else
                return this.name + " Não possui mana suficiente!";
        }
    }
}