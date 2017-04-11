﻿using System;
using System.Threading.Tasks.Dataflow;
using Consensus;
using Infrastructure;

namespace BlockChain.Data
{
	public class QueueAction
	{
		public static ITargetBlock<QueueAction> Target; // factor out static

		public void Publish()
		{
			Target.Post(this);
		}
	}

	public class MessageAction : QueueAction
	{
		public BlockChainMessage Message { get; set; }

		public MessageAction(BlockChainMessage message)
		{
			Message = message;
		}
	}

	public class HandleOrphansOfTxAction : QueueAction
	{
		public byte[] TxHash { get; set; }

		public HandleOrphansOfTxAction(byte[] txHash)
		{
			TxHash = txHash;
		}
	}

	public class HandleBlockAction : QueueAction
	{
		public byte[] BkHash { get; set; }
		public Types.Block Bk { get; set; }
		public bool IsOrphan { get; set; }

		public HandleBlockAction(byte[] bkHash, Types.Block bk, bool isOrphan)
		{
			BkHash = bkHash;
			Bk = bk;
			IsOrphan = isOrphan;
		}

		public HandleBlockAction(Types.Block bk)
		{
			BkHash = Merkle.blockHeaderHasher.Invoke(bk.header);
			Bk = bk;
			IsOrphan = false;
		}
	}
}