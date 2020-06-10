using System.Collections.Generic;

public class SampleJson
{
    public string Swagger { get; set; }
    public Info Info { get; set; }
    public Dictionary<string, Dictionary<string, JsonEndpoint>> Paths { get; set; }
}

public class Info
{
    public string Version { get; set; }
    public string Title { get; set; }
}

public class JsonEndpoint
{
    public List<string> Tags { get; set; }
    public string OperationId { get; set; }
    public List<Parameter> Parameters { get; set; }
}

public class Parameter
{
    public string Name { get; set; }
}