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

        /// <summary>
        /// this method will generate random first and last name 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            List<string> line = new List<string>();
            line = File.ReadAllLines("../../Data/firstNames.txt").ToList();
            Random r = new Random();
            int i = r.Next(0, line.Count - 1);
            FirstNameDataLabel.Text = line[i];

            List<string> lines= new List<string>();
            lines = File.ReadAllLines("../../Data/lastNames.txt").ToList();
            Random r1 = new Random();
            int value = r1.Next(0, lines.Count - 1);
            LastNameDataLabel.Text = lines[value];
        }
        /// <summary>
        /// it will generate random number for each abilities in ability page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            FightingDataLabel.Text = rand.Next(10, 50).ToString();
            AgilityDataLabel.Text = rand.Next(10, 50).ToString();
            StrengthDataLabel.Text = rand.Next(10, 50).ToString();
            EnduranceDataLabel.Text = rand.Next(10, 50).ToString();
            ReasonDataLabel.Text = rand.Next(10, 50).ToString();
            IntuitionDataLabel.Text = rand.Next(10, 50).ToString();
            PsycheDataLabel.Text = rand.Next(10, 50).ToString();
            PopularityDataLabel.Text = rand.Next(10, 50).ToString();
        }

        private void HeroGenerator_Activated(object sender, EventArgs e)
        {
           /* Program.hero.Fighting = FightingDataLabel.Text;
            Program.hero.Agility = AgilityDataLabel.Text;
            Program.hero.Strength = StrengthDataLabel.Text;
            Program.hero.Endurance = EnduranceDataLabel.Text;
            Program.hero.Reason = ReasonDataLabel.Text;
            Program.hero.Intuition = IntuitionDataLabel.Text;
            Program.hero.Psyche = PsycheDataLabel.Text;
            Program.hero.Popularity = PopularityDataLabel.Text;*/
        }
        private void GenerateRandomPowers()
        {
            List<string> powerlist = new List<string>();
            powerlist = File.ReadAllLines("../../Data/powers.txt").ToList();
            Random r2 = new Random();
            int i = r2.Next(0, powerlist.Count - 1);
            PowerDataLabel1.Text = powerlist[i];
            PowerDataLabel2.Text = powerlist[r2.Next(0, powerlist.Count - 1)];
            PowerDataLabel3.Text = powerlist[r2.Next(0, powerlist.Count - 1)];
            PowerDataLabel4.Text = powerlist[r2.Next(0, powerlist.Count - 1)];
        }

        /// <summary>
        /// This is click event handler fro PowerButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();
        }
    }
}
