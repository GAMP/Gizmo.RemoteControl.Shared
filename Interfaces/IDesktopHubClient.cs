using Gizmo.RemoteControl.Shared.Enums;
using Gizmo.RemoteControl.Shared.Models;

namespace Gizmo.RemoteControl.Shared.Interfaces;

public interface IDesktopHubClient
{
    Task Disconnect(string reason);

    Task GetScreenCast(
        string viewerId,
        string requesterName,
        bool notifyUser,
        Guid streamId);

    Task<PromptForAccessResult> PromptForAccess(RemoteControlAccessRequest accessRequest);

    Task RequestScreenCast(
        string viewerId,
        string requesterName,
        bool notifyUser,
        Guid streamId);

    Task SendDtoToClient(byte[] dtoWrapper, string viewerConnectionId);

    Task ViewerDisconnected(string viewerId);
}
