﻿namespace COMP123_S2019_FinalTestA.Views
{
    partial class HeroGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.HeroNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.AbilitiesPage = new System.Windows.Forms.TabPage();
            this.AbilityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhysicalAbilitiesLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.PopularityLabel = new System.Windows.Forms.Label();
            this.PopularityDataLabel = new System.Windows.Forms.Label();
            this.PsycheLabel = new System.Windows.Forms.Label();
            this.MentalAbilitiesLabel = new System.Windows.Forms.Label();
            this.PsycheDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.IntuitionDataLabel = new System.Windows.Forms.Label();
            this.FightingLabel = new System.Windows.Forms.Label();
            this.ReasonDataLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.FightingDataLabel = new System.Windows.Forms.Label();
            this.AgilityDataLabel = new System.Windows.Forms.Label();
            this.IntuitionLabel = new System.Windows.Forms.Label();
            this.GenerateAbilityButton = new System.Windows.Forms.Button();
            this.PowersPage = new System.Windows.Forms.TabPage();
            this.CharacterSheet = new System.Windows.Forms.TabPage();
            this.HeroToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HeroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilitiesPage.SuspendLayout();
            this.AbilityTableLayoutPanel.SuspendLayout();
            this.CharacterSheet.SuspendLayout();
            this.HeroToolStrip.SuspendLayout();
            this.HeroMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilitiesPage);
            this.MainTabControl.Controls.Add(this.PowersPage);
            this.MainTabControl.Controls.Add(this.CharacterSheet);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 482);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.GenerateNameButton);
            this.IdentityPage.Controls.Add(this.HeroNameTextBox);
            this.IdentityPage.Controls.Add(this.LastNameLabel);
            this.IdentityPage.Controls.Add(this.LastNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameLabel);
            this.IdentityPage.Controls.Add(this.HeroNameLabel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Size = new System.Drawing.Size(776, 445);
            this.IdentityPage.TabIndex = 2;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Location = new System.Drawing.Point(326, 282);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(170, 46);
            this.GenerateNameButton.TabIndex = 2;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // HeroNameTextBox
            // 
            this.HeroNameTextBox.Location = new System.Drawing.Point(229, 39);
            this.HeroNameTextBox.Name = "HeroNameTextBox";
            this.HeroNameTextBox.Size = new System.Drawing.Size(267, 29);
            this.HeroNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(34, 176);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(190, 43);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(229, 181);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(267, 32);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(229, 120);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(267, 31);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(34, 114);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(190, 43);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Location = new System.Drawing.Point(8, 33);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(190, 43);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "Enter Hero Name";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilitiesPage
            // 
            this.AbilitiesPage.Controls.Add(this.AbilityTableLayoutPanel);
            this.AbilitiesPage.Location = new System.Drawing.Point(4, 33);
            this.AbilitiesPage.Name = "AbilitiesPage";
            this.AbilitiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilitiesPage.Size = new System.Drawing.Size(776, 445);
            this.AbilitiesPage.TabIndex = 0;
            this.AbilitiesPage.Text = "Abilities";
            this.AbilitiesPage.UseVisualStyleBackColor = true;
            // 
            // AbilityTableLayoutPanel
            // 
            this.AbilityTableLayoutPanel.ColumnCount = 4;
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.Controls.Add(this.PhysicalAbilitiesLabel, 0, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularityLabel, 2, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularityDataLabel, 3, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsycheLabel, 2, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.MentalAbilitiesLabel, 2, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsycheDataLabel, 3, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonLabel, 2, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuitionDataLabel, 3, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingLabel, 0, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonDataLabel, 3, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityLabel, 0, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingDataLabel, 1, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityDataLabel, 1, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuitionLabel, 2, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.GenerateAbilityButton, 2, 6);
            this.AbilityTableLayoutPanel.Location = new System.Drawing.Point(8, 6);
            this.AbilityTableLayoutPanel.Name = "AbilityTableLayoutPanel";
            this.AbilityTableLayoutPanel.RowCount = 7;
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.Size = new System.Drawing.Size(756, 406);
            this.AbilityTableLayoutPanel.TabIndex = 5;
            // 
            // PhysicalAbilitiesLabel
            // 
            this.AbilityTableLayoutPanel.SetColumnSpan(this.PhysicalAbilitiesLabel, 2);
            this.PhysicalAbilitiesLabel.Location = new System.Drawing.Point(3, 0);
            this.PhysicalAbilitiesLabel.Name = "PhysicalAbilitiesLabel";
            this.PhysicalAbilitiesLabel.Size = new System.Drawing.Size(372, 43);
            this.PhysicalAbilitiesLabel.TabIndex = 3;
            this.PhysicalAbilitiesLabel.Text = "Physical Abilities";
            this.PhysicalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 228);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(183, 43);
            this.EnduranceLabel.TabIndex = 1;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularityLabel
            // 
            this.PopularityLabel.Location = new System.Drawing.Point(381, 228);
            this.PopularityLabel.Name = "PopularityLabel";
            this.PopularityLabel.Size = new System.Drawing.Size(183, 43);
            this.PopularityLabel.TabIndex = 1;
            this.PopularityLabel.Text = "Popularity";
            this.PopularityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularityDataLabel
            // 
            this.PopularityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PopularityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopularityDataLabel.Location = new System.Drawing.Point(570, 228);
            this.PopularityDataLabel.Name = "PopularityDataLabel";
            this.PopularityDataLabel.Size = new System.Drawing.Size(183, 39);
            this.PopularityDataLabel.TabIndex = 2;
            this.PopularityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheLabel
            // 
            this.PsycheLabel.Location = new System.Drawing.Point(381, 171);
            this.PsycheLabel.Name = "PsycheLabel";
            this.PsycheLabel.Size = new System.Drawing.Size(183, 43);
            this.PsycheLabel.TabIndex = 1;
            this.PsycheLabel.Text = "Psyche";
            this.PsycheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MentalAbilitiesLabel
            // 
            this.AbilityTableLayoutPanel.SetColumnSpan(this.MentalAbilitiesLabel, 2);
            this.MentalAbilitiesLabel.Location = new System.Drawing.Point(381, 0);
            this.MentalAbilitiesLabel.Name = "MentalAbilitiesLabel";
            this.MentalAbilitiesLabel.Size = new System.Drawing.Size(372, 43);
            this.MentalAbilitiesLabel.TabIndex = 4;
            this.MentalAbilitiesLabel.Text = "Mental Abilities";
            this.MentalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheDataLabel
            // 
            this.PsycheDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PsycheDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PsycheDataLabel.Location = new System.Drawing.Point(570, 171);
            this.PsycheDataLabel.Name = "PsycheDataLabel";
            this.PsycheDataLabel.Size = new System.Drawing.Size(183, 37);
            this.PsycheDataLabel.TabIndex = 2;
            this.PsycheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(192, 228);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(183, 39);
            this.EnduranceDataLabel.TabIndex = 2;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.Location = new System.Drawing.Point(381, 57);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(183, 43);
            this.ReasonLabel.TabIndex = 1;
            this.ReasonLabel.Text = "Reason";
            this.ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuitionDataLabel
            // 
            this.IntuitionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntuitionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntuitionDataLabel.Location = new System.Drawing.Point(570, 114);
            this.IntuitionDataLabel.Name = "IntuitionDataLabel";
            this.IntuitionDataLabel.Size = new System.Drawing.Size(183, 37);
            this.IntuitionDataLabel.TabIndex = 2;
            this.IntuitionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightingLabel
            // 
            this.FightingLabel.Location = new System.Drawing.Point(3, 57);
            this.FightingLabel.Name = "FightingLabel";
            this.FightingLabel.Size = new System.Drawing.Size(183, 43);
            this.FightingLabel.TabIndex = 1;
            this.FightingLabel.Text = "Fighting";
            this.FightingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonDataLabel
            // 
            this.ReasonDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonDataLabel.Location = new System.Drawing.Point(570, 57);
            this.ReasonDataLabel.Name = "ReasonDataLabel";
            this.ReasonDataLabel.Size = new System.Drawing.Size(183, 37);
            this.ReasonDataLabel.TabIndex = 2;
            this.ReasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.Location = new System.Drawing.Point(3, 114);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(183, 43);
            this.AgilityLabel.TabIndex = 1;
            this.AgilityLabel.Text = "Agility";
            this.AgilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(192, 171);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(183, 37);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Location = new System.Drawing.Point(3, 171);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(183, 43);
            this.StrengthLabel.TabIndex = 1;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightingDataLabel
            // 
            this.FightingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FightingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FightingDataLabel.Location = new System.Drawing.Point(192, 57);
            this.FightingDataLabel.Name = "FightingDataLabel";
            this.FightingDataLabel.Size = new System.Drawing.Size(183, 37);
            this.FightingDataLabel.TabIndex = 2;
            this.FightingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityDataLabel
            // 
            this.AgilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgilityDataLabel.Location = new System.Drawing.Point(192, 114);
            this.AgilityDataLabel.Name = "AgilityDataLabel";
            this.AgilityDataLabel.Size = new System.Drawing.Size(183, 37);
            this.AgilityDataLabel.TabIndex = 2;
            this.AgilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuitionLabel
            // 
            this.IntuitionLabel.Location = new System.Drawing.Point(381, 114);
            this.IntuitionLabel.Name = "IntuitionLabel";
            this.IntuitionLabel.Size = new System.Drawing.Size(183, 43);
            this.IntuitionLabel.TabIndex = 1;
            this.IntuitionLabel.Text = "Intuition";
            this.IntuitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateAbilityButton
            // 
            this.AbilityTableLayoutPanel.SetColumnSpan(this.GenerateAbilityButton, 2);
            this.GenerateAbilityButton.Location = new System.Drawing.Point(381, 345);
            this.GenerateAbilityButton.Name = "GenerateAbilityButton";
            this.GenerateAbilityButton.Size = new System.Drawing.Size(372, 56);
            this.GenerateAbilityButton.TabIndex = 5;
            this.GenerateAbilityButton.Text = "Generate Abilties";
            this.GenerateAbilityButton.UseVisualStyleBackColor = true;
            this.GenerateAbilityButton.Click += new System.EventHandler(this.GenerateAbilityButton_Click);
            // 
            // PowersPage
            // 
            this.PowersPage.Location = new System.Drawing.Point(4, 33);
            this.PowersPage.Name = "PowersPage";
            this.PowersPage.Padding = new System.Windows.Forms.Padding(3);
            this.PowersPage.Size = new System.Drawing.Size(776, 445);
            this.PowersPage.TabIndex = 1;
            this.PowersPage.Text = "Powers";
            this.PowersPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.CharacterSheet.Controls.Add(this.HeroToolStrip);
            this.CharacterSheet.Controls.Add(this.HeroMenuStrip);
            this.CharacterSheet.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheet.Name = "CharacterSheet";
            this.CharacterSheet.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterSheet.Size = new System.Drawing.Size(776, 445);
            this.CharacterSheet.TabIndex = 3;
            this.CharacterSheet.Text = "Character Sheet";
            this.CharacterSheet.UseVisualStyleBackColor = true;
            // 
            // HeroToolStrip
            // 
            this.HeroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.helpToolStripButton});
            this.HeroToolStrip.Location = new System.Drawing.Point(3, 27);
            this.HeroToolStrip.Name = "HeroToolStrip";
            this.HeroToolStrip.Size = new System.Drawing.Size(770, 25);
            this.HeroToolStrip.TabIndex = 1;
            this.HeroToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // HeroMenuStrip
            // 
            this.HeroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.HeroMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.HeroMenuStrip.Name = "HeroMenuStrip";
            this.HeroMenuStrip.Size = new System.Drawing.Size(770, 24);
            this.HeroMenuStrip.TabIndex = 0;
            this.HeroMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(670, 503);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 46);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(4, 503);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 46);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.HeroMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "HeroGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroGenerator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityPage.PerformLayout();
            this.AbilitiesPage.ResumeLayout(false);
            this.AbilityTableLayoutPanel.ResumeLayout(false);
            this.CharacterSheet.ResumeLayout(false);
            this.CharacterSheet.PerformLayout();
            this.HeroToolStrip.ResumeLayout(false);
            this.HeroToolStrip.PerformLayout();
            this.HeroMenuStrip.ResumeLayout(false);
            this.HeroMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilitiesPage;
        private System.Windows.Forms.TabPage PowersPage;
        private System.Windows.Forms.TabPage CharacterSheet;
        private System.Windows.Forms.MenuStrip HeroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip HeroToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TextBox HeroNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.TableLayoutPanel AbilityTableLayoutPanel;
        private System.Windows.Forms.Label PhysicalAbilitiesLabel;
        private System.Windows.Forms.Label MentalAbilitiesLabel;
        private System.Windows.Forms.Label PopularityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label PsycheDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label IntuitionDataLabel;
        private System.Windows.Forms.Label AgilityDataLabel;
        private System.Windows.Forms.Label ReasonDataLabel;
        private System.Windows.Forms.Label PopularityLabel;
        private System.Windows.Forms.Label FightingDataLabel;
        private System.Windows.Forms.Label PsycheLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntuitionLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label FightingLabel;
        private System.Windows.Forms.Button GenerateAbilityButton;
    }
}