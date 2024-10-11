// MIT License.

using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace System.Web.Script.Serialization;

// TODO: We'll want to use System.Text.Json and change it to be strongly typed
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Just making this work")]
internal sealed class JavaScriptSerializer
{
    public object MaxJsonLength { get; internal set; }

    internal static string SerializeInternal(OrderedDictionary orderedDictionary)
    {
        return Text.Json.JsonSerializer.Serialize(orderedDictionary);
    }

    internal void Serialize(object value, StringBuilder builder, SerializationFormat javaScript)
    {
        builder.Append(Text.Json.JsonSerializer.Serialize(value));
    }

    internal void Serialize(string clientID, StringBuilder sb)
    {
        sb.Append(Text.Json.JsonSerializer.Serialize(clientID));
    }

    internal string Serialize(OrderedDictionary attrs)
    {
        return Text.Json.JsonSerializer.Serialize(attrs);
    }

    internal string Serialize(string clientID)
    {
        return Text.Json.JsonSerializer.Serialize(clientID);
    }

    public enum SerializationFormat
    {
        JavaScript
    }
}
