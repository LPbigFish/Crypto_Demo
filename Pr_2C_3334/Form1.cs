using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_2C_3334
{
    public partial class Form1 : Form
    {
        bool zalomeno = false;
        public int BlockID = 0;
        public string Data, Nonce, PrevBlock = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", ThisBlock;
        readonly List<Block> BlockChain = new List<Block>();

        private void Form1_Load(object sender, EventArgs e)
        {
            BlockIdTB.Text = BlockID.ToString();
            PrevBlockTB.Text = PrevBlock;
        }

        private void NextBT_Click(object sender, EventArgs e)
        {
            BlockID += 1; BlockIdTB.Text = BlockID.ToString();
            PrevBlockTB.Text = ThisBlock;
            ThisBlockTB.Text = "";
            NonceTB.Text = "";
            DataTB.Text = "";
            zalomeno = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void MineBT_Click(object sender, EventArgs e)
        {
            if (zalomeno == false)
            {
                Data = DataTB.Text;
                ThisBlock = "0";
                int j = 0;
                string i = "000000000";
                while (!ThisBlock.StartsWith("00000"))
                {
                    Nonce = Zalomení.Generatinon(i);
                    ThisBlock = SHA512((BlockID + Data, Nonce + PrevBlock).ToString());
                    j++;
                    i = $"{j:000000000}";
                }

                ThisBlockTB.Text = ThisBlock;
                NonceTB.Text = Nonce;
                BlockChain.Add(new Block(BlockID, Data, Nonce, PrevBlock, ThisBlock));
                MessageBox.Show("Block byl zalomen!");
                zalomeno = true;
            }
            else
            {
                MessageBox.Show("Nemůžete edditovat už zalomený BLOCK!" + Environment.NewLine + "Klikněte na tlačítko next pro vygenerování nového BLOCKU.");
            }
            
        }

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }

    public static class Zalomení
    {
        static readonly char[] Match = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j' ,'k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M','N','O','P','Q','R','S','T','U','V','X','Y','Z'};

        public static string Generatinon(string next)
        {
            string result = "";

            foreach (char i in next)
            {
                string j = i.ToString();
                result += Match[Convert.ToInt32(j)];   
            }

            return result;
        }
    }

    public class Block
    {
        public int BlockID;
        public string Data, Nonce, PrevBlock, ThisBlock;
        public Block(int _BlockID, string _Data, string _Nonce, string _PrevBlock, string _ThisBlock)
        {
            BlockID = _BlockID;
            Data = _Data;
            Nonce = _Nonce;
            PrevBlock = _PrevBlock;
            ThisBlock = _ThisBlock;
        }
    }
}
