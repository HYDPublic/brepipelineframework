﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BREPipelineFramework.SampleInstructions
{
    /// <summary>
    /// See http://msdn.microsoft.com/en-us/library/ms962162.aspx for an explanation of the Message Queueing Adapter context properties
    /// </summary>
    public enum BizTalkMSMQTPropertySchemaEnum
    {
        Acknowledge = 0,
        AdminQueue = 1,
        AppSpecific = 2,
        ArrivedTime = 3,
        Audit = 4,
        Authenticated = 5,
        AuthLevel = 6,
        Class = 7,
        CorrelationId = 8,
        Delivery = 9,
        DestinationQueue = 10,
        EncryptionAlgorithm = 11,
        Extension = 12,
        FragmentN = 13,
        HashAlg = 14,
        InboundCorrelationId = 15,
        InboundResponseQueue = 16,
        IsAuthenticated = 17,
        IsFirstInTransaction = 18,
        IsLastInTransaction = 19,
        IsSecurityIncluded = 20,
        IsXactMsg = 21,
        Label = 22,
        LastFragment = 23,
        MessageType = 24,
        MsgID = 25,
        NonTransactionalQueue = 26,
        OrderQueue = 27,
        OutboundTransportLocation = 28,
        PrevN = 29,
        Priority = 30,
        PrivLevel = 31,
        ResponseQueue = 32,
        RouterName = 33,
        SenderID = 34,
        SenderIDLength = 35,
        SenderIDType = 36,
        SentTime = 37,
        SeqID = 38,
        SeqN = 39,
        Signature = 40,
        SignatureSize = 41,
        SourceMachineGuid = 42,
        TimerChain = 43,
        TimeToReachQueue = 44,
        Trace = 45,
        TransactionId = 46,
        Version = 47,
        WakeupTime = 48
    }
}
