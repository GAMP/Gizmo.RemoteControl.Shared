using Gizmo.RemoteControl.Shared.Models;

namespace Gizmo.RemoteControl.Shared.Interfaces
{
    public interface IRemoteControlSessionService
    {
        /// <summary>
        /// Creates a remote control session.
        /// <paramref name="hostId"/>Host id.</param>
        /// <paramref name="cToken"/>Cancellation token.</param>
        /// <returns>Remote control session.</returns>
        /// </summary>
        Task<RemoteControlSession> CreateSessionAsync(int hostId, CancellationToken cToken = default);
    }
}
