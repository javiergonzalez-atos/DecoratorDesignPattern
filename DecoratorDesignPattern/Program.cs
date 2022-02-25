using System;
using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHero myHero = new BaseHero();
            var myHeroWithHelmet = new HelmetDecorator(myHero);
            var myHeroWithHelmetAndArmor = new ArmorDecorator(myHeroWithHelmet);
            var myHeroWithHelmetArmorAndIcePower = new IcePowerDecorator(myHeroWithHelmetAndArmor);
            var myHeroWithHelmetArmorIceAndFirePower = new FirePowerDecorator(myHeroWithHelmetArmorAndIcePower);

            Console.WriteLine("=========================");
            Console.WriteLine("Hero with no clothes");
            Console.WriteLine("HP: " + myHero.HealthPoints);
            Console.WriteLine("Damage taken: " + myHero.TakeDamage());
            Console.WriteLine("My spells " + myHero.CastSpell());
            Console.WriteLine("=========================");
            Console.WriteLine("Hero with helmet");
            Console.WriteLine("Damage taken: " + myHeroWithHelmet.TakeDamage());
            Console.WriteLine("My spells " + myHeroWithHelmet.CastSpell());
            Console.WriteLine("=========================");
            Console.WriteLine("Hero with helmet and armor");
            Console.WriteLine("HP: " + myHeroWithHelmetAndArmor.HealthPoints);
            Console.WriteLine("Damage taken: " + myHeroWithHelmetAndArmor.TakeDamage());
            Console.WriteLine("My spells " + myHeroWithHelmet.CastSpell());
            Console.WriteLine("=========================");
            Console.WriteLine("myHeroWithHelmetArmorAndIcePower");
            Console.WriteLine("My spells " + myHeroWithHelmetArmorAndIcePower.CastSpell());
            Console.WriteLine("Specials: " + myHeroWithHelmetArmorAndIcePower.UseIcePower());
            Console.WriteLine("=========================");
            Console.WriteLine("myHeroWithHelmetArmorIceAndFIrePower");
            Console.WriteLine("My spells " + myHeroWithHelmetArmorIceAndFirePower.CastSpell());
            Console.WriteLine("Specials: " + myHeroWithHelmetArmorIceAndFirePower.UseFirePower());
            
        }
    }
}