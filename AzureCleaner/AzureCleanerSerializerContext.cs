using System.Text.Json.Serialization;

namespace AzureCleaner;

[JsonSerializable(typeof(AzdoEvent))]
[JsonSerializable(typeof(AzureDevOpsEventPullRequestResource))]
internal partial class AzureCleanerSerializerContext : JsonSerializerContext
{

}
