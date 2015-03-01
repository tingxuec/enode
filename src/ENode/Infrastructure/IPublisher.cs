﻿using System.Threading.Tasks;

namespace ENode.Infrastructure
{
    /// <summary>Represents a message publisher.
    /// </summary>
    public interface IPublisher<TMessage> where TMessage : class
    {
        /// <summary>Publish the given message to all the subscribers.
        /// </summary>
        /// <param name="message"></param>
        void Publish(TMessage message);
        /// <summary>Publish the given message to all the subscribers async.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> PublishAsync(TMessage message);
    }
}
