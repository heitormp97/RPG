namespace Rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType, (level*50), (level * 10))
        {
            this.armor = this.level * 2;
        }

        int armor;
        public override string Ability(int power)
        {
            int mana = 50;
            if(this.magicPoints > mana)
            {
                this.magicPoints -= mana;
                return this.name + " Usou um Ataque giratório com poder " + power;
            }
            else
                return this.name + " Não possui mana suficiente!";
        }

        public override string LostHealth(int damage)
        {
            int trueDamage = damage - this.armor;

            if(trueDamage < 0)
                trueDamage = 0;

            this.healthPoints -= trueDamage;

            if(this.healthPoints <= 0)
            {
                this.healthPoints = 0;
                this.alive = false;
                return this.name + " Morreu!!!";
            }
            else
                return this.name + " Recebeu " + trueDamage + " de dano, em que bloqueou " + this.armor + " de dano e ficou com " + this.healthPoints + " de vida!";
        }
    }
}