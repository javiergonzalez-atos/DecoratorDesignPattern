namespace DecoratorDesignPattern.Component
{
    public class BaseHero : IHero
    {
        public float HealthPoints { get; set; } = 100;

        public float TakeDamage()
        {
            return 10;
        }

        public string CastSpell()
        {
            return "Normal Spell ";
        }
    }
}