namespace rpg.src.Entities
{
    public class BWizard : Hero
    {
        public BWizard(string Name,int Level,string ClassHeroName,int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.ClassHeroName = ClassHeroName;
            this.Hp = Hp;
            this.Mp = Mp;
        }
       public override string Attack(){
            return this.Name + " Lançou magia da corrução";
        }

        public string Attack(int Bonus){

            if (Bonus > 30){
                return this.Name+ " Hp: "+this.Hp+" Mp: "+ this.Mp + " Lançou corrupção super efetiva com bonus de " + Bonus;
            } else {
                return this.Name+ " Hp: "+this.Hp+ " Mp: "+this.Mp + " Lançou corrupção com força fraca com bonus de " + Bonus;
            }

           
        }
    }
}