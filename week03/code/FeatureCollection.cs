using System.ComponentModel;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Nodes;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}
public class Feature {
    public Properties Properties { get; set; }
}

public class Properties {
    public decimal mag { get; set; }
    public string Place { get; set; }
}