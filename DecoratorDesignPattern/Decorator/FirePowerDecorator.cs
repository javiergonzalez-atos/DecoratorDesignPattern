using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class FirePowerDecorator : HeroDecorator
    {
        public FirePowerDecorator(IHero hero) : base(hero)
        {
        }
        
        public override string CastSpell()
        {
            return base.CastSpell() + "Fire Power ";
        }

        public string UseFirePower()
        {
            return "Using Fire Power...";
        }
    }
}
