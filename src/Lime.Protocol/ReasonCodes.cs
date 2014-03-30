﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lime.Protocol
{
    /// <summary>
    /// Default server reason codes
    /// </summary>
    public static class ReasonCodes
    {
        /// <summary>
        /// General error
        /// </summary>
        public const int GENERAL_ERROR = 1;
        /// <summary>
        /// General session error
        /// </summary>
        public const int SESSION_ERROR = 11;
        /// <summary>
        /// The session resource is already registered
        /// </summary>
        public const int SESSION_RESOURCE_ALREADY_REGISTERED = 12;
        /// <summary>
        /// An authentication error occurred
        /// </summary>
        public const int SESSION_AUTHENTICATION_FAILED = 13;
        /// <summary>
        /// An error occurred while unregistering the session 
        /// in the server
        /// </summary>
        public const int SESSION_UNREGISTER_FAILED = 14;
        /// <summary>
        /// The required action is invalid for
        /// current session state
        /// </summary>
        public const int SESSION_INVALID_STATE_FOR_ACTION = 15;
        /// <summary>
        /// General validation error
        /// </summary>
        public const int VALIDATION_ERROR = 21;
        /// <summary>
        /// The request envelope is null
        /// </summary>
        public const int VALIDATION_NULL_REQUEST = 22;
        /// <summary>
        /// The request status is invalid
        /// </summary>
        public const int VALIDATION_INVALID_STATUS = 23;
        /// <summary>
        /// The request identity is invalid
        /// </summary>
        public const int VALIDATION_INVALID_IDENTITY = 24;
        /// <summary>
        /// The request destination is invalid
        /// </summary>
        public const int VALIDATION_INVALID_DESTINATION = 25;
        /// <summary>
        /// General authorization error
        /// </summary>
        public const int AUTHORIZATION_ERROR = 31;
        /// <summary>
        /// The sender is not authorized to send
        /// messages to the message destination
        /// </summary>
        public const int AUTHORIZATION_UNAUTHORIZED_SENDER = 32;
        /// <summary>
        /// The destination doesn't have an active 
        /// account
        /// </summary>
        public const int AUTHORIZATION_DESTINATION_ACCOUNT_NOT_FOUND = 32;
        /// <summary>
        /// General dispatching error
        /// </summary>
        public const int DISPATCHING_ERROR = 41;
        /// <summary>
        /// The message destination was not found
        /// </summary>
        public const int DISPATCHING_DESTINATION_NOT_FOUND = 42;
        /// <summary>
        /// The message destination gateway was not found
        /// </summary>
        public const int DISPATCHING_GATEWAY_NOT_FOUND = 43;
        /// <summary>
        /// General command processing error
        /// </summary>
        public const int COMMAND_PROCESSING_ERROR = 51;
        /// <summary>
        /// There's no command processor available 
        /// for process the request
        /// </summary>
        public const int COMMAND_RESOURCE_NOT_SUPPORTED = 52;
        /// <summary>
        /// The command method is not supported
        /// </summary>
        public const int COMMAND_METHOD_NOT_SUPPORTED = 53;
        /// <summary>
        /// The command method has an invalid argument value
        /// </summary>
        public const int COMMAND_INVALID_ARGUMENT = 54;
        /// <summary>
        /// The requested command is not valid for current
        /// session mode
        /// </summary>
        public const int COMMAND_INVALID_SESSION_MODE = 55;
        /// <summary>
        /// The command method was not allowed
        /// </summary>
        public const int COMMAND_NOT_ALLOWED = 56;
        /// <summary>
        /// General gateway processing error
        /// </summary>
        public const int GATEWAY_ERROR = 61;
        /// <summary>
        /// The content type is not supported
        /// by the gateway
        /// </summary>
        public const int GATEWAY_CONTENT_TYPE_NOT_SUPPORTED = 62;
        /// <summary>
        /// The message destination was not found
        /// on gateway
        /// </summary>
        public const int GATEWAY_DESTINATION_NOT_FOUND = 63;
        /// <summary>
        /// The functionality is not supported 
        /// by the gateway
        /// </summary>
        public const int GATEWAY_NOT_SUPPORTED = 64;
    }
}