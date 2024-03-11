using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> Blocks = new List<Block>();
        public List<Transaction> TransactionPool = new List<Transaction>();
        public int transactionsPerBlock = 5;

        public Blockchain() 
        {
            Blocks.Add(new Block());
        }

        public String GetBlockAsString(int index)
        {
            return Blocks[index].ToString();
        }

        public Block GetLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        public List<Transaction> getPendingTransactions()
        {
           int n = Math.Min(transactionsPerBlock, TransactionPool.Count);
            List<Transaction> transactions = TransactionPool.GetRange(0, n);
            TransactionPool.RemoveRange(0, n);
            return transactions;
        }

        public override string ToString()
        {
            String output = String.Empty;
            Blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }

    }
}
