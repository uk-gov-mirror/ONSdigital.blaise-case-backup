using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlaiseCaseBackup.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        NotSupported = 0,

        [EnumMember(Value = "start_backup")]
        StartBackup
    }
}
