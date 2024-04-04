using System.Text.Json;
using ValueOfObjects.Models;

namespace ValueOfObjects.Tests;

public class JsonTest
{
    [Test]
    public void JsonSerializerTest()
    {
        var testObject = new JsonObject1
        {
            Name = "Test Name",
            FieldValue = 10,
            IsEnabled = true,
            AnyObject = new string("Test Object")
        };

        var jsonString = JsonSerializer.Serialize<JsonObject1>(testObject);

        Console.WriteLine(jsonString);
    }

    [Test]
    public void JsonDeserializerTest1()
    {
        string json = "{\"Name\":\"Test Name\",\"FieldValue\":10,\"IsEnabled\":true,\"AnyObject\":\"Test Object\"}";
        var jsonObject1 = JsonSerializer.Deserialize<JsonObject1>(json);

        Console.WriteLine(jsonObject1);
    }

    [Test]
    public void JsonDeserializerTest2()
    {
        using FileStream fs = new FileStream(@"Resources/testObject1.json", FileMode.Open);
        var jsonObject1 = JsonSerializer.Deserialize<JsonObject1>(fs);

        Console.WriteLine(jsonObject1);
    }

    [Test]
    public void JsonSerializerTest1()
    {
        List<JsonObject1> list = new List<JsonObject1>();

        var testObj1 = new JsonObject1
        {
            Name = "Test Name 1",
            FieldValue = 1,
            IsEnabled = true,
            AnyObject = new string("Test Object 1")
        };

        var testObj2 = new JsonObject1
        {
            Name = "Test Name 2",
            FieldValue = 2,
            IsEnabled = false,
            AnyObject = new string("Test Object 2")
        };

        list.Add(testObj1);
        list.Add(testObj2);

        string jsonString = JsonSerializer.Serialize(list);

        Console.WriteLine(jsonString);
    }

    [Test]
    public void JsonDeserializerTest3()
    {
        using FileStream fs = new FileStream(@"Resources/testList.json", FileMode.Open);

        List<JsonObject1> objList = JsonSerializer.Deserialize<List<JsonObject1>>(fs);

        objList!.ForEach(Console.WriteLine);
    }

    [Test]
    public void JsonDeserializerTest4()
    {
        using FileStream fs = new FileStream(@"Resources/testObject2.json", FileMode.Open);

        JsonObject2 jsonObject2 = JsonSerializer.Deserialize<JsonObject2>(fs);

        Console.WriteLine(jsonObject2.ToString());
    }
}