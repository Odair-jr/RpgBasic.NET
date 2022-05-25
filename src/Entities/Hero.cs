namespace rpg.src.Entities
{
    public class Hero
    {
        public Hero(string Name,int Level,string ClassHeroName,int Hp, int Mp){
            this.Name = Name;
            this.Level = Level;
            this.ClassHeroName = ClassHeroName;
            this.Hp = Hp;
            this.Mp = Mp;

        }

    public Hero(){}

        public string Name;
        public int Level;
        public string ClassHeroName;
        public int Hp;
        public int Mp;


        public override string ToString()
        {  
            return this.Name + " " + this.Level + " " + this.ClassHeroName + "" + this.Hp + " " + this.Mp;
            

        }

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}