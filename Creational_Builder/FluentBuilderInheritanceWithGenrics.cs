
//public class Person
//{
//    public string Name { get; set; }
//    public string Position { get; set; }

//    public class Builder : PersonJobBuilder<Builder>
//    {

//    } 
//    public static Builder New => new Builder();
    
//    public override string? ToString()
//    {
//        return base.ToString();
//    }
//}


//public abstract class PersonBuilder
//{
//    protected Person person = new Person();
//    public Person Build() { return person; }
//}

//public class PersonInfoBuilder<Self> : PersonBuilder where Self : PersonInfoBuilder<Self>
//{
//    public Self Called(string name)
//    {
//        person.Name = name;
//        return (Self) this;
//    }
//}

//public class PersonJobBuilder<Self> : PersonInfoBuilder<Self> where Self : PersonJobBuilder<Self> 
//{
//    public Self WorksAsA(string position)
//    {
//        person.Position = position;
//        return (Self) this;
//    }
//}