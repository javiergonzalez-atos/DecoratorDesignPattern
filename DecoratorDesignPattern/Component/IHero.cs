namespace DecoratorDesignPattern.Component
{
    public interface IHero
    {
        float HealthPoints { get; set; }
        float TakeDamage();
        string CastSpell();
    }
}