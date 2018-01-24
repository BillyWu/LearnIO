﻿using System.Net;

namespace SocketAsyncServer
{
    internal class SocketListenerSettings
    {
        // the maximum number of connections the sample is designed to handle simultaneously 


        // this variable allows us to create some extra SAEA objects for the pool,
        // if we wish.

        // See comments in buffer manager.


        public SocketListenerSettings(int maxConnections, int excessSaeaObjectsInPool, int backlog,
            int maxSimultaneousAcceptOps, int receivePrefixLength, int receiveBufferSize, int sendPrefixLength,
            int opsToPreAlloc, IPEndPoint theLocalEndPoint)
        {
            MaxConnections = maxConnections;
            NumberOfSaeaForRecSend = maxConnections + excessSaeaObjectsInPool;
            Backlog = backlog;
            MaxAcceptOps = maxSimultaneousAcceptOps;
            ReceivePrefixLength = receivePrefixLength;
            BufferSize = receiveBufferSize;
            SendPrefixLength = sendPrefixLength;
            OpsToPreAllocate = opsToPreAlloc;
            LocalEndPoint = theLocalEndPoint;
        }
        // max # of pending connections the listener can hold in queue
        public int MaxConnections { get; }
        public int NumberOfSaeaForRecSend { get; }

        public int Backlog { get; }

        // tells us how many objects to put in pool for accept operations
        public int MaxAcceptOps { get; }

        // length of message prefix for receive ops
        public int ReceivePrefixLength { get; }

        // buffer size to use for each socket receive operation
        public int BufferSize { get; }

        // length of message prefix for send ops
        public int SendPrefixLength { get; }

        public int OpsToPreAllocate { get; }
        // Endpoint for the listener.
        public IPEndPoint LocalEndPoint { get; }
    }
}