﻿using System;
using System.Collections.Generic;
using Store;
using System.Linq;
using BlockChain.Data;
using System.Text;

namespace BlockChain
{
	public class ACSItem
	{
		public byte[] Hash { get; set; }
		public string AssemblyFile { get; set; }
		public byte[] CostFn { get; set; }
		public ulong KalapasPerBlock { get; set; }
		public UInt32 LastBlock { get; set; }
	}

	public class ActiveContractSet : MsgPackStore<ACSItem>
	{
		public ActiveContractSet() : base("contract-set") { }

		public void Add(TransactionContext dbTx, ACSItem item)
		{
			Put(dbTx, item.Hash, item);
		}

		public HashSet Keys(TransactionContext dbTx)
		{
			return new HashSet(All(dbTx).Select(t => t.Value.Hash));
		}

		public bool IsActive(TransactionContext dbTx, byte[] contractHash)
		{
			return ContainsKey(dbTx, contractHash);
		}

		public UInt32 LastBlock(TransactionContext dbTx, byte[] contractHash)
		{
			return Get(dbTx, contractHash).Value.LastBlock;
		}

		public void Extend(TransactionContext dbTx, byte[] contractHash, ulong kalapas)
		{
			var acsItem = Get(dbTx, contractHash);
			acsItem.Value.LastBlock += (uint)(kalapas / acsItem.Value.KalapasPerBlock);

			Add(dbTx, acsItem.Value);
		}

		public static ulong KalapasPerBlock(string fsharpCode)
		{
			if (string.IsNullOrEmpty(fsharpCode))
				return 0;
			
			return KalapasPerBlock(Encoding.ASCII.GetBytes(fsharpCode));
		}

		public static ulong KalapasPerBlock(byte[] fsharpCode)
		{
			if (fsharpCode == null)
				return 0;
			
			return (ulong)fsharpCode.Length * 1000;
		}

		public bool Activate(TransactionContext dbTx, byte[] contractCode, ulong kalapas)
		{
			byte[] fsharpCode;
			ContractHelper.Extract(contractCode, out fsharpCode);
			//	var fsharpCode = new StrongBox<byte[]>();
			//	return ContractHelper.Extract(contractCode, fsharpCode).ContinueWith(t => {

			byte[] contractHash;
			if (ContractHelper.Compile(contractCode, out contractHash))
			{
				var kalapasPerBlock = KalapasPerBlock(fsharpCode);

				if (kalapas < kalapasPerBlock)
				{
					return false;
				}

				Add(dbTx, new ACSItem()
				{
					Hash = contractHash,
					KalapasPerBlock = kalapasPerBlock,
					LastBlock = Convert.ToUInt32(kalapas / kalapasPerBlock)
				});

				return true;
			}
			//	}, TaskContinuationOptions.OnlyOnRanToCompletion).Wait();

			return false;
		}

		public HashDictionary<ACSItem> GetExpiringList(TransactionContext dbTx, uint blockNumber)
		{
#if TRACE
			All(dbTx).Where(t => t.Value.LastBlock == blockNumber).ToList().ForEach(t => BlockChainTrace.Information($"contract due to expire at {blockNumber}", t.Key));
#endif

			var values = new HashDictionary<ACSItem>();

			foreach (var contract in All(dbTx).Where(t => t.Value.LastBlock <= blockNumber))
			{
				values[contract.Key] = contract.Value;
			}

			return values;
		}

		public void DeactivateContracts(TransactionContext dbTx, IEnumerable<byte[]> list)
		{
			foreach (var item in list)
			{
				if (IsActive(dbTx, item))
					Remove(dbTx, item);
				else
					throw new Exception();
			}
		}
	}
}