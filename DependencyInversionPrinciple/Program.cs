using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public enum Relationship
    {
        Parent,
        Child,
        Siblings
    }

    public class Person
    {
        public string Name { get; set; }
        // public DateTime DateOfBirth { get; set; }
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrens(string name);
    }

    // low level
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrens(string name)
        {
            foreach (var r in relations.Where(
                x => x.Item1.Name == name &&
                x.Item2 == Relationship.Parent
                ))
            {
                yield return r.Item3;
            }
        }

        // public List<(Person, Relationship, Person)> RelationList => relations;


    }

    // High level
    public class Querys
    {
        public Querys(Relationships relationships)
        {
            // high level access low level data breaks the rule
            /*var relations = relationships.RelationList;
            foreach (var r in relations.Where(
                x => x.Item1.Name == "John" &&
                x.Item2 == Relationship.Parent
                ))
            {
                Console.WriteLine($"John has child {r.Item3.Name}");
            }*/

            foreach (var relationship in relationships.FindAllChildrens("John"))
            {
                Console.WriteLine(relationship.Name);
            }
        }

        // high level should not directly depend on low level instead use abstraction
        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Messi" };
            var child2 = new Person { Name = "Ronaldo" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
            new Querys(relationships);
        }
    }
}
