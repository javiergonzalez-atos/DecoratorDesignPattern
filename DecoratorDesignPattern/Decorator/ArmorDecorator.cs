using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(IHero hero) : base(hero)
        {
            base.HealthPoints += 50;
        }

        public override float TakeDamage()
        {
            return base.TakeDamage() / 3;
        }
    }
}