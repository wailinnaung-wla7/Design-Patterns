using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder
{
    //public abstract class FunctionBuilder<TSubject, TSelf> where TSelf : FunctionBuilder<TSubject, TSelf>
    //    where TSubject : new()
    //{
    //    private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
    //    public TSelf Do(Action<Person> action) => AddAction(action);
    //    public Person Build => actions.Aggregate(new Person(), (p, f) => f(p));

    //    private TSelf AddAction(Action<Person> action)
    //    {
    //        actions.Add(p =>
    //        {
    //            action(p);
    //            return p;
    //        });
    //        return (TSelf) this;
    //    }
    //}

    //public sealed class PersonBuilder : FunctionBuilder<Person,PersonBuilder>
    //{
    //    public PersonBuilder Called(string Name) => Do(p => p.Name = Name);
    //}

    ////public sealed class PersonBuilder
    ////{
    ////    private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
    ////    public PersonBuilder Called(string name)
    ////    {
    ////        return Do(p => p.Name = name);
    ////    }

    ////    public PersonBuilder Do(Action<Person> action) => AddAction(action);
    ////    public Person Build => actions.Aggregate(new Person(),(p,f)=> f(p));

    ////    private PersonBuilder AddAction(Action<Person> action)
    ////    {
    ////        actions.Add(p => { action(p);
    ////            return p;
    ////            });
    ////        return this;
    ////    }

    ////}
    //public static class PersonBuilderExtension
    //{
    //    public static PersonBuilder WorksAsA(this PersonBuilder builder, string Position) => builder.Do(p => p.Position = Position);
    //}

    //public class Person
    //{
    //    public string Name, Position;
    //}
}
