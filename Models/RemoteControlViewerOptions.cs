using System.Runtime.Serialization;

namespace Gizmo.RemoteControl.Shared.Models;

[DataContract]
public class RemoteControlViewerOptions
{
    [DataMember]
    public bool ShouldRecordSession { get; init; }
}
