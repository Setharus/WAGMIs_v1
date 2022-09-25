using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            

            textBox1.Text = "     What is this WAGMIs?💙\r\n" +
                "  WAGMIs are iconic little characters designed and assembled" +
                "by the talented illustrator OYZO. Feel free to use them as profile " +
                "pictures, turn them into comics or do absolutely anything you want " +
                "with them! You own the IP to the WAGMIs characters in your wallet.\r\n" +
                "  They are made in an attempt to capture the best of internet & web3 " +
                "culture and shine some positive light to the NFT space that we love so much.\r\n\r\n" +
                "     What is the WAGMIs mission?🧐\r\n" +
                "  WAGMIs is a web3 culture brand for visionaries and web3 explorers. " +
                "It represents everything positive about the web3 space. An exclusive " +
                "club to network, learn, earn and enjoy web3. A place to find anything " +
                "from self improvement motivation, have some wholesome fun and read about " +
                "big investment news pushing the web3 space forward.\r\nYou will be " +
                "surrounding yourself with a community of positive minded individuals " +
                "that are committed to improving themselves and the environments around them!\r\n\r\n" +
                "     How much will the WAGMIs cost to mint & how many will there be in total?\r\n" +
                "  Team will determine/announce the mint price closer to the mint date, final " +
                "price will be decided considering development costs and fundraising goals. " +
                "Only 4242 WAGMIs will ever exist and they will live on the ETH PoS blockchain. " +
                "There will be a strict 1 mint per wallet rule.\r\n\r\n" +
                "     When will the WAGMIs mint?\r\n" +
                "  Aiming for early October - we’ll make sure to catch the moment when all stars align.\r\n\r\n" +
                "     How will the royalties work?\r\n" +
                "  Exact details are TBA.\r\n The goal behind our royalties system will be " +
                "to discourage emotional trading during the infancy of the project. While over " +
                "time, we hope to provide less friction for trading - as our brand identity is " +
                "solidified and community is unified.\r\n\r\nA portion of royalties will fund the " +
                "reward pool of RUGLESS (first comprehensive review platform of the Metaverse).";

            
            panel2.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int x, y;

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left += e.X - x;
            this.Top += e.Y - y;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "     What is this WAGMIs?💙\r\n" +
                "  WAGMIs are iconic little characters designed and assembled" +
                "by the talented illustrator OYZO. Feel free to use them as profile " +
                "pictures, turn them into comics or do absolutely anything you want " +
                "with them! You own the IP to the WAGMIs characters in your wallet.\r\n" +
                "  They are made in an attempt to capture the best of internet & web3 " +
                "culture and shine some positive light to the NFT space that we love so much.\r\n\r\n" +
                "     What is the WAGMIs mission?🧐\r\n" +
                "  WAGMIs is a web3 culture brand for visionaries and web3 explorers. " +
                "It represents everything positive about the web3 space. An exclusive " +
                "club to network, learn, earn and enjoy web3. A place to find anything " +
                "from self improvement motivation, have some wholesome fun and read about " +
                "big investment news pushing the web3 space forward.\r\nYou will be " +
                "surrounding yourself with a community of positive minded individuals " +
                "that are committed to improving themselves and the environments around them!\r\n\r\n" +
                "     How much will the WAGMIs cost to mint & how many will there be in total?\r\n" +
                "  Team will determine/announce the mint price closer to the mint date, final " +
                "price will be decided considering development costs and fundraising goals. " +
                "Only 4242 WAGMIs will ever exist and they will live on the ETH PoS blockchain. " +
                "There will be a strict 1 mint per wallet rule.\r\n\r\n" +
                "     When will the WAGMIs mint?\r\n" +
                "  Aiming for early October - we’ll make sure to catch the moment when all stars align.\r\n\r\n" +
                "     How will the royalties work?\r\n" +
                "  Exact details are TBA.\r\n The goal behind our royalties system will be " +
                "to discourage emotional trading during the infancy of the project. While over " +
                "time, we hope to provide less friction for trading - as our brand identity is " +
                "solidified and community is unified.\r\n\r\nA portion of royalties will fund the " +
                "reward pool of RUGLESS (first comprehensive review platform of the Metaverse).";
            textBox1.Show();
            panel2.Hide();
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            panel2.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.Hide();
            textBox1.Text = "\r\n\r\n  Crypto has been a part of my life for 3 years and so is " +
                "my acquaintance with NFTs it was thanks to BCC. After BCC's Nusret video, " +
                "I dived into my research wondering about NFTs and came this far.\r\n " +
                "  I learned a lot of new things and now there are NFT collections that " +
                "I love like crazy. It amazes me when people who give the same value to " +
                "an asset come together and print t-shirts, hang paintings on their walls, " +
                "write poems, and create different art images.\r\n  The art of WAGMIs and the " +
                "crew that valued it drew me here, and frankly, I loved it. I would also " +
                "like to thank Can -aka Alpha Caller- for inviting me. For this reason, " +
                "I coded this little program and shared it with you. I hope you like it🥰";
            textBox1.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}