﻿using System;
using System.Numerics;
using Hyperbridge.Transaction;
using Hyperbridge.Wallet;

namespace Hyperbridge.Ethereum
{
    public class EthereumTransaction : ITransaction
    {
        public DateTime TransactionTime { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public WeiCoin Coin { get; set; }
        public BigInteger Amount => Coin.ToTransactionAmount();

        public ulong BlockNumber { get; set; }
        public string BlockHash { get; set; }
        public ulong TransactionIndex { get; set; }
        public string TransactionHash { get; set; }

        public ulong Gas { get; set; }
        public ulong GasPrice { get; set; }
        public ulong CumulativeGasUsed { get; set; }
        public ulong GasUsed { get; set; }
        public ulong NumberConfirmations { get; set; }

        public string ContractAddress { get; set; }
        public string Input { get; set; }
    }
}
