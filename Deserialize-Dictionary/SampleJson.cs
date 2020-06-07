using System.Collections.Generic;

public class SampleJson
{
    public Dictionary<string, Endpoint> Endpoints { get; set; }
}

public class Endpoint
{
    public Dictionary<string, Method> Methods { get; set; }
}

public class Method
{
    public bool Authenticated { get; set; }
}