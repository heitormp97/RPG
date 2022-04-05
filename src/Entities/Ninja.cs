namespace Rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int shurikenAmount) : base(name, level, heroType, (level*35), (level * 25))
        {
            this.shurikenAmount = shurikenAmount;
        }

        int shurikenAmount;

        public override string Ability(int power)
        {
            int mana = 100;
            if(this.magicPoints > mana)
            {
                this.magicPoints -= mana;
                return this.name + " Usou um Jutsu com poder " + power;
            }
            else
                return this.name + " Não possui mana suficiente!";
        }

        public string ThrowShuriken()
        {
            if(this.shurikenAmount == 0)
            {
                return this.name + " Não possui mais shuriken!";
            }
            else
            {
                this.shurikenAmount -= 1;
                return this.name + " Arremessou uma shuriken, possui " + this.shurikenAmount;
            }
        }
    }
}