﻿
//TODO: Implement Null transport without .NET dependency.

//namespace Zyan.Communication.Protocols.Null
//{
//    /// <summary>
//    /// <see cref="IServerProtocolSetup"/> implementation for the <see cref="NullChannel"/>.
//    /// </summary>
//    public class NullServerProtocolSetup : ServerProtocolSetup
//    {
//        /// <summary>
//        /// Initializes a new instance of the <see cref="NullServerProtocolSetup"/> class.
//        /// </summary>
//        public NullServerProtocolSetup(int port)
//            : base((props, clientSinkProvider, serverSinkProvider) => new NullChannel(props, clientSinkProvider, serverSinkProvider))
//        {
//            _channelName = "NullChannel:" + port;
//        }
//    }
//}
