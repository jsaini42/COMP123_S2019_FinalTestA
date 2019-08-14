using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : Form
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for BackButton clivk event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for NextButton clivk event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex <  MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

 

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            List<string> line = new List<string>();
            line = File.ReadAllLines("../../Data/firstNames.txt").ToList();
            Random r = new Random();
            int i = r.Next(0, line.Count - 1);
            FirstNameDataLabel.Text = line[i];

            List<string> lines= new List<string>();
            lines = File.ReadAllLines("../../Data/lastNames.txt").ToList();
            Random rand = new Random();
            int value = rand.Next(0, lines.Count - 1);
            LastNameDataLabel.Text = lines[value];
        }

        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
