using dynamic_json.Models;
using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public class UserJsonProcessor : IJsonProcessor
{
    public bool CanProcess(JObject json)
    {
        return json.ContainsKey(nameof(User.Name)) && json.ContainsKey(nameof(User.Email));
    }

    public object? Process(JObject json)
    {
        var user = json.ToObject<User>();

        if (user == null) return null;

        // update user
        return user with { Name = "John Doe 2" };
    }
}