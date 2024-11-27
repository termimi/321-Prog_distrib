namespace Transat;

public class NonResilientPublisher(FaillibleQos0Storage storage1, FaillibleQos0Storage storage2)
{
    private readonly string _id = Guid.NewGuid().ToString(format: "n");
    public void Send(int message)
    {
        var uniqueId = $"{_id}-{Guid.NewGuid().ToString(format: "n")}";
        while (!storage1.Data.Keys.Any(key => key.StartsWith(uniqueId)))
            storage1.Store(uniqueId, message);

        while (!storage2.Data.Keys.Any(key => key.StartsWith(uniqueId)))
            storage2.Store(uniqueId, message);
    }
}