﻿using System.Threading;
using System.Threading.Tasks;

namespace Messaging
{
    /// <summary>
    /// Raw message publisher
    /// </summary>
    public interface IRawMessagePublisher
    {
        /// <summary>
        /// Publishes the byte array into the specified topic
        /// </summary>
        /// <param name="topic">The destination to send the message</param>
        /// <param name="message"The deserialized message
        /// <param name="token">A cancellation token</param>
        /// </param>
        Task Publish(string topic, byte[] message, CancellationToken token);
    }
}