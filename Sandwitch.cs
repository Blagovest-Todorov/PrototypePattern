namespace PrototypePattern
{
    using System;
    public class Sandwitch : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwitch(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }
        public override SandwichPrototype Clone()
        {
            string ingridientsList = this.GetIngridientsList();
            Console.WriteLine($"Cloning sandwich with ingridients:{ingridientsList}");
            return this.MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngridientsList() 
        {
            return $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}"; 
        }
    }
}
