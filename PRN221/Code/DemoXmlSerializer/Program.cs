// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using DemoXmlSerializer;


Person p1 = new Person() {Name="David", Age=21 };
var xs = new XmlSerializer(typeof(Person));
using Stream s1 = File.Create("person.xml");
xs.Serialize(s1,p1);
s1.Close();

using Stream s2 = File.OpenRead("person.xml");
var p2 = (Person)xs.Deserialize(s2);
Console.WriteLine("Person Info");
Console.WriteLine($"Name:  {p2.Name},Age {p2.Age}");
Console.WriteLine("person.xml");
string xmlData = File.ReadAllText("person.xml");
Console.WriteLine(xmlData);
s2.Close();
Console.WriteLine();











