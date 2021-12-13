using System;

namespace AbstractFactoryDesignPattern
{
    //According to Gang of Four Definition: “The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes“.
    // In simple words we can say, the Abstract Factory is a super factory that creates other factories.This Abstract Factory is also called the Factory of Factories.
    public interface IAnimal
    {
        string speak();
    }
}
