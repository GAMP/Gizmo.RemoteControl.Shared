using System.Runtime.Serialization;

namespace Gizmo.RemoteControl.Shared.Models.Dtos;

[DataContract]
public class ToggleAudioDto
{
    [DataMember(Name = "ToggleOn")]
    public bool ToggleOn { get; set; }
}
