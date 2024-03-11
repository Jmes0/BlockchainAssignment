using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlockchainAssignment
{
    class Block
    {
        int index;
        DateTime timestamp;
        public String hash;
        String prevHash;

        List<Transaction> transactionList = new List<Transaction>();
        public long nonce = 0;
        public int difficulty = 4;

        public double reward = 1.0;
        public double fees = 0.0;

        public String minerAddress = String.Empty;

        public Block()
        {
            this.timestamp = DateTime.Now;
            this.index = 0;
            this.prevHash = String.Empty;
            reward = 0;

            this.hash = Mine();
        }
        public Block(int index, String hash)
        {
            this.index = 0;
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = hash;
            this.hash = Mine();
        }

        public Block(Block lastBlock, List<Transaction> transactions, String address = "")
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;
            this.transactionList = transactions;

            minerAddress = address;
            transactions.Add(CreateRewardTransaction(transactions));


            this.hash = Mine();
        }

        public Transaction CreateRewardTransaction(List<Transaction> transactions)
        {
            fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        public String CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timestamp.ToString() + prevHash + nonce.ToString() + reward.ToString();
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            String hash = string.Empty;
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }

        public String Mine()
        {
            String hash = CreateHash();

            String re = new string('0', difficulty);
            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }

            return hash;
        }

        public override string ToString()
        {
            return "Index: " + index.ToString()
                + "\nTimestamp: " + timestamp.ToString()
                + "\nPrevious Hash: " + prevHash
                + "\nHash: " + hash
                + "\nNonce: " + nonce.ToString()
                + "\nDifficulty: " + difficulty.ToString()
                + "\nReward: " + reward.ToString()
                + "\nFees: " + fees.ToString()
                + "\nMiners Address: " + minerAddress;
        }
    }
}
 