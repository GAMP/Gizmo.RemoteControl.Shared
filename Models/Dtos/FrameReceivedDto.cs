using System.Runtime.Serialization;

namespace Gizmo.RemoteControl.Shared.Models.Dtos;

[DataContract]
public sealed class FrameReceivedDto
{
    [DataMember]
    public long Timestamp { get; set; }
}
