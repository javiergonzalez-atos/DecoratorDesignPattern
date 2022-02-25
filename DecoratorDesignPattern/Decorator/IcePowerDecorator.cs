using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.Decorator
{
    public class IcePowerDecorator : HeroDecorator
    {
        public IcePowerDecorator(IHero hero) : base(hero)
        {
        }

        public override string CastSpell()
        {
            return base.CastSpell() + "Ice Power ";
        }

        public string UseIcePower()
        {
            return "Using Ice Power...";
        }
    }
}