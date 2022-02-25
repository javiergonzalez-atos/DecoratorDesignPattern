using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;
        public float HealthPoints { get; set; }

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
            HealthPoints = _hero.HealthPoints;
        }
        
        public virtual float TakeDamage()
        {
            return _hero.TakeDamage();
        }

        public virtual string CastSpell()
        {
            return _hero.CastSpell();
        }
    }
}