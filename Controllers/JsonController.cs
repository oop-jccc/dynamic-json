using dynamic_json.JsonProcessors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace dynamic_json.Controllers;

[ApiController]
[Route("[controller]")]
public class JsonController : ControllerBase
{
    
    // "{\"Name\":\"John Doe\",\"Email\":\"john.doe@example.com\"}"
    private readonly IEnumerable<IJsonProcessor> _processors;

    public JsonController(IEnumerable<IJsonProcessor> processors)
    {
        _processors = processors;
    }

    // POST: /Json/{contextId}
    [HttpPost()]
    public ActionResult Set([FromBody] string jsonString)
    {
        return Ok(ProcessJsonString(jsonString));
    }

    private object? ProcessJsonString(string jsonString)
    {
        var json = JObject.Parse(jsonString);
        var handler = _processors.FirstOrDefault(h => h.CanProcess(json));
        if (handler == null)
        {
            throw new Exception("No handler found");
        }

        return handler.Process(json);
    }
}