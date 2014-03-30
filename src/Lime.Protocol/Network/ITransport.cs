﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lime.Protocol.Network
{
    /// <summary>
    /// Defines a network 
    /// connection with a node
    /// </summary>
    public interface ITransport
    {
        /// <summary>
        /// Sends an envelope to 
        /// the connected node
        /// </summary>
        /// <param name="envelope">Envelope to be transported</param>
        /// <returns></returns>
        Task SendAsync(Envelope envelope, CancellationToken cancellationToken);

        /// <summary>
        /// Occurs when an envelope
        /// is received by the node
        /// </summary>
        event EventHandler<EnvelopeEventArgs<Envelope>> EnvelopeReceived;

        /// <summary>
        /// Closes the connection
        /// </summary>
        Task CloseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Enumerates the supported compression
        /// options for the transport
        /// </summary>
        /// <returns></returns>
        SessionCompression[] GetSupportedCompression();

        /// <summary>
        /// Gets the current transport 
        /// compression option
        /// </summary>
        SessionCompression Compression { get; }

        /// <summary>
        /// Defines the compression mode
        /// for the transport
        /// </summary>
        /// <param name="compression">The compression mode</param>
        /// <returns></returns>
        Task SetCompressionAsync(SessionCompression compression, CancellationToken cancellationToken);

        /// <summary>
        /// Enumerates the supported encryption
        /// options for the transport
        /// </summary>
        SessionEncryption[] GetSupportedEncryption();

        /// <summary>
        /// Gets the current transport 
        /// encryption option
        /// </summary>
        SessionEncryption Encryption { get; }

        /// <summary>
        /// Defines the encryption mode
        /// for the transport
        /// </summary>
        /// <param name="compression">The compression mode</param>
        /// <returns></returns>
        Task SetEncryptionAsync(SessionEncryption encryption, CancellationToken cancellationToken);

        /// <summary>
        /// Occurs when the connection fails
        /// </summary>
        event EventHandler<ExceptionEventArgs> Failed;

        /// <summary>
        /// Occurs when the channel is about
        /// to be closed
        /// </summary>
        event EventHandler<DeferralEventArgs> Closing;

        /// <summary>
        /// Occurs after the connection was closed
        /// </summary>
        event EventHandler Closed;
    }
}