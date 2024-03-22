namespace Gizmo.RemoteControl.Shared.Models
{
    /// <summary>
    /// Represents a remote control viewer session.
    /// </summary>
    public sealed record RemoteControlSession
    {
        /// <summary>
        /// Gets created remote session id.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets create session id access key.
        /// </summary>
        public string AccessKey { get; init; } = null!;

        /// <summary>
        /// Gets the server url of the remote control host.
        /// </summary>
        public string Host { get; init; } = null!;
    }
}
