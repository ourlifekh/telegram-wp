﻿// 
// This is the source code of Telegram for Windows Phone v. 3.x.x.
// It is licensed under GNU GPL v. 2 or later.
// You should have received a copy of the license in this archive (see LICENSE).
// 
// Copyright Evgeny Nadymov, 2013-present.
// 
namespace Telegram.Api.TL.Functions.Messages
{
    public class TLGetHistory : TLObject
    {
        public const uint Signature = 0xdcbb8260;

        public TLInputPeerBase Peer { get; set; }

        public TLInt OffsetId { get; set; }

        public TLInt OffsetDate { get; set; }

        public TLInt AddOffset { get; set; }

        public TLInt Limit { get; set; }

        public TLInt MaxId { get; set; }
        
        public TLInt MinId { get; set; }

        public TLInt Hash { get; set; }

        public override byte[] ToBytes()
        {
            return TLUtils.Combine(
                TLUtils.SignatureToBytes(Signature),
                Peer.ToBytes(),
                OffsetId.ToBytes(),
                OffsetDate.ToBytes(),
                AddOffset.ToBytes(),
                Limit.ToBytes(),
                MaxId.ToBytes(),
                MinId.ToBytes(),
                Hash.ToBytes());
        }
    }
}
