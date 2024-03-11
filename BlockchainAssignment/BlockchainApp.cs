using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            richTextBox1.Text = "New Blockchain Initialised";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (Int32.TryParse(textBox1.Text, out index))
            {
                richTextBox1.Text = blockchain.GetBlockAsString(index);
            }
            else
            {
                richTextBox1.Text = "Not a number";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;
            richTextBox1.Text = "Key Generated";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
            {
                richTextBox1.Text = "Keys are Valid";
            }
            else
            {
                richTextBox1.Text = "Keys are Invalid";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction newTransaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            blockchain.TransactionPool.Add(newTransaction);
            richTextBox1.Text = newTransaction.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions();
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
            blockchain.Blocks.Add(newBlock);

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
