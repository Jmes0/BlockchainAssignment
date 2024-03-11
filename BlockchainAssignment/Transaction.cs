using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Transaction
    {
        String hash, recipientAddress, senderAddress, signature;
        DateTime timestamp;
        double amount;
        public double fee;

        public Transaction(String from, String to, Double amount, Double fee, String privateKey)
        {
            this.senderAddress = from;
            this.recipientAddress = to;
            this.amount = amount;
            this.fee = fee;
            this.timestamp = DateTime.Now;
            this.hash = CreateHash();
            this.signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);
        }

        public String CreateHash()
        {
            String hash = string.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp.ToString() + senderAddress + recipientAddress + amount.ToString() + fee.ToString();
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }

        public override string ToString()
        {
            return "Transaction Hash: " + hash + "\n"
                + "Digital Signature: " + signature + "\n"
                + "Timestamp: " + timestamp.ToString() + "\n"
                + "Transferred: " + amount.ToString() + "\n"
                + "Fees: " + fee.ToString() + "\n"
                + "Sender Address: " + senderAddress + "\n"
                + "Reciever Address: " + recipientAddress + "\n";

        }


    }

    
}
