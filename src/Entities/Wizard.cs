namespace rpg.src.Entities

{
    public class Wizard : Hero
    {
        public Wizard(string Name,int Level,string ClassHeroName,int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.ClassHeroName = ClassHeroName;
            this.Hp = Hp;
            this.Mp = Mp;
        }
       public override string Attack(){
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 30){
                return this.Name+" Hp: "+ this.Hp+ " Mp: "+this.Mp + " Lançou magia da luz super efetiva com bonus de " + Bonus;
            } else {
                return this.Name+ " Hp: "+this.Hp+" Mp: "+ this.Mp + " Lançou magia da luz com força fraca com bonus de " + Bonus;
            }

           
        }

    }
}