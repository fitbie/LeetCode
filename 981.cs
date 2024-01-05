TimeMap obj = new TimeMap();
obj.Set("love", "high",10);
obj.Set("love", "low",20);
string param_2 = obj.Get("love", 5);
Console.WriteLine(param_2);
// param_2 = obj.Get("love", 10);
// Console.WriteLine(param_2);
// param_2 = obj.Get("love", 15);
// Console.WriteLine(param_2);
// param_2 = obj.Get("love", 20);
// Console.WriteLine(param_2);
// param_2 = obj.Get("love", 25);
// Console.WriteLine(param_2);

// for (int i = 0; i < 3500; i++)
// {
//     obj.Set("one", $"{i}", i);
// }
// param_2 = obj.Get("one", 7000);
// Console.WriteLine(param_2);



public class TimeMap 
{
    // public struct ValueTimestampPair // Or use tuple 🙆
    // {
    //     public string value;
    //     public int timestamp;
    //     public ValueTimestampPair(string value, int timestamp) 
    //     {
    //         this.value = value;
    //         this.timestamp = timestamp;
    //     }
    // }

    private Dictionary<string, List<(string value, int timestamp)>> records;


    public TimeMap()
    {
        records = new();
    }

    
    public void Set(string key, string value, int timestamp)
    {
        if (!records.ContainsKey(key))
        {
            records.Add(key, new List<(string value, int timestamp)>());
        }
        
        records[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp)
    {
        var result = "";

        if (records.TryGetValue(key, out var record))
        {
            if (record.Count == 1) 
            { 
                if (record[0].timestamp <= timestamp) { return record[0].value; }
                else return result;
            }
            if (record.Count == 2)
            {
                if (record[1].timestamp <= timestamp) { return record[1].value; }
                else if (record[0].timestamp <= timestamp) { return record[0].value; }
                else return result;
            }

            int left = 0;
            int right = record.Count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (record[middle].timestamp > timestamp) { right = middle - 1; }
                else if (record[middle].timestamp < timestamp) { left = middle + 1; }
                else { return record[middle].value; }
            }

            if (record[right].timestamp < timestamp) { return record[right].value; }
        }

        return result;
    }
}