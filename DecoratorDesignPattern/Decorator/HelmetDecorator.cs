using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class HelmetDecorator : HeroDecorator
    {
        
        public HelmetDecorator(IHero hero) : base(hero)
        {
            
        }

        public override float TakeDamage()
        {
            return base.TakeDamage() / 2;
        }

    }
}