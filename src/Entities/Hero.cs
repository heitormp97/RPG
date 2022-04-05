namespace Rpg.src.Entities
{
    public abstract class Hero
    {
        
        public Hero(string name, int level, string heroType, int healthPoints, int magicPoints)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.healthPoints = healthPoints;
            this.magicPoints = magicPoints;
            this.alive = true;
        }
         
        public string name;
        public int level;
        public string heroType;
        public int healthPoints;
        public int magicPoints;
        public bool alive;

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.heroType + " Health: " + this.healthPoints + " Mana: " + this.magicPoints;
        }

        public string Attack()
        {
            return this.name + " Atacou!";
        }

        public virtual string Ability(int power)
        {
            int mana = 20;
            if(this.magicPoints > mana)
            {
                this.magicPoints -= mana;
                return this.name + " Usou uma Habilidade com poder " + power;
            }
            else
                return this.name + " Não possui mana suficiente";
        }

        public virtual string LostHealth(int damage)
        {
            this.healthPoints -= damage;
            if(this.healthPoints <= 0)
            {
                this.healthPoints = 0;
                this.alive = false;
                return this.name + " Morreu!!!";
            }
            else
                return this.name + " Recebeu " + damage + " de dano e ficou com " + this.healthPoints + " de vida!";
        }

    }
}