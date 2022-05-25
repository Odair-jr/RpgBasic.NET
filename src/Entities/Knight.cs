namespace rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name,int Level,string ClassHeroName,int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.ClassHeroName = ClassHeroName;
            this.Hp = Hp;
            this.Mp = Mp;
            
        }

        public override string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

        public string Attack(int Bonus){

            if (Bonus > 30){
                return this.Name+" Hp: "+ this.Hp+" Mp: "+ this.Mp + " ataque critico com a sua espada com bonus de " + Bonus;
            } else {
                return this.Name+" Hp: "+ this.Hp+" Mp: " + this.Mp + " ataque fraco com sua espara com bonus de " + Bonus;
            }

           
        }


    }
}