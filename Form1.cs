using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinama_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            create(Convert.ToInt32(txtXCord.Text), Convert.ToInt32(txtYCord.Text), txtEmptyCord.Text, txtSelledCord.Text);
        }
        public void create(int xCord, int yCord, string emptyCord, string selledCord)
        {
            panelCords.Controls.Clear();
            
            string[] emptyCords = emptyCord.Split(',');
            string[] selledCords = selledCord.Split(',');
            string[] multiEmptyCords = emptyCord.Split('-');
            if (yCord > 27)
            {
                yCord = 27;

            }
            if(xCord > 60)
            {
                xCord = 47;
            }
            for(int y = 1; y < yCord; y++)
            for(int x = 1; x < xCord; x++)
            {
                    
                    string cordName = (char)(64 + y) + x.ToString();

                    
                    if (!emptyCords.Contains(cordName))
                    {
                        Button btn = new Button();
                        btn.Name = "btn0" + y.ToString() + x.ToString();
                        btn.Text = cordName;
                        btn.Size = new Size(45, 45);
                        btn.Location = new Point(x * 45, y * 45);
                        btn.BackColor = Color.Yellow;
                        
                        
                        if (selledCords.Contains(cordName))
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Gray;
                        }
                        else
                        {
                            btn.BackColor = Color.Green;
                        }
                        panelCords.Controls.Add(btn);
                    }
            }
        }
        public void multiDisable(string firstCord, string secCord)
        {
            for (char j = firstCord[0]; j <= secCord[0]; j++)
                for (char i = firstCord[1]; i <= secCord[1]; i++)
                {
                    string btnName = "btn0" + (j - 64).ToString() + i.ToString();
                    Button matches = (Button)this.Controls.Find(btnName, true).FirstOrDefault();
                    matches.Visible = false;
                    matches.BackColor = Color.Red;
                }
        }

        public void lineVisible(string firstCord, string secCord)
        {
            int a = 0;
            for (char j = firstCord[0]; j <= secCord[0]; j++)
            {
                a = j != secCord[0] ? Convert.ToInt32(txtYCord.Text) - 1 : int.Parse(secCord[1].ToString());
                for (int i = int.Parse(firstCord[1].ToString()); i <= a; i++)
                {
                    string btnName = "btn0" + (j - 64).ToString() + i.ToString();
                    Button matches = (Button)this.Controls.Find(btnName, true).FirstOrDefault();
                    matches.Enabled = false;
                    matches.BackColor = Color.Red;
                }
            }
        }
        private void btnMultiDisable_Click(object sender, EventArgs e)
        {
            string[] multiEmptyCords = txtEmptyCord.Text.Split('-');
            if(multiEmptyCords.Length == 2)
            {
                multiDisable(multiEmptyCords[0], multiEmptyCords[1]);
            }
            else
            {
                MessageBox.Show("Kaldırılmasını istediğiniz koltuk aralığını (-) koyarak giriniz... Örnek: A1-A3");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] multiEmptyCords = txtEmptyCord.Text.Split('-');
            if (multiEmptyCords.Length == 2)
            {
                lineVisible(multiEmptyCords[0], multiEmptyCords[1]);
            }
            else
            {
                MessageBox.Show("Satılmasını istediğiniz koltuk aralığına (-) koyarak giriniz... Örnek: A1-A3");
            }
        }
    }
}
