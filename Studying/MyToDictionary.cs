// JUST FOR FUN!

TestPerson[] people = new TestPerson[] {new(1, "John", 135), new(22, "Smith", 1250), new(32, "Jimmy", 567)};
var dict = MyToDictionary.MyMToDictionaryMethod(people, (p) => p.ID, (p) => p.Name);
foreach (var d in dict)
{
    Console.WriteLine($"Key: {d.Key}, Value: {d.Value}");
}



public class MyToDictionary
{
    public static Dictionary<TKey, TValue> MyMToDictionaryMethod<T, TKey, TValue>
    (IEnumerable<T> elements, Func<T, TKey> keySelector, Func<T, TValue> valueSelector) where TKey: notnull
    {
        Dictionary<TKey, TValue> result = new();

        foreach (var element in elements)
        {
            result.TryAdd(keySelector(element), valueSelector(element));
        }

        return result;
    }
}


public class TestPerson
{
    public int ID {get; set;}
    public string Name {get; set;}
    public float Salary {get; set;}

    public TestPerson(int id, string name, float salary)
    {
        ID = id;
        Name = name;
        Salary = salary;
    }
}