﻿namespace Together_Culture__Dream_Team_.Front_End.Screens.Skill_Share_Forms.latest.user_controls
{
    partial class SearchResultsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            comboBox1 = new ComboBox();
            guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2CustomGradientPanel2.Controls.Add(textBox1);
            guna2CustomGradientPanel2.Controls.Add(dataGridView1);
            guna2CustomGradientPanel2.Controls.Add(label1);
            guna2CustomGradientPanel2.Controls.Add(guna2Button8);
            guna2CustomGradientPanel2.Controls.Add(comboBox1);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel2.FillColor = Color.DarkRed;
            guna2CustomGradientPanel2.FillColor2 = Color.DarkRed;
            guna2CustomGradientPanel2.FillColor3 = Color.Red;
            guna2CustomGradientPanel2.FillColor4 = Color.DarkRed;
            guna2CustomGradientPanel2.Location = new Point(0, 0);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel2.Size = new Size(863, 524);
            guna2CustomGradientPanel2.TabIndex = 5;
            guna2CustomGradientPanel2.Paint += guna2CustomGradientPanel2_Paint;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(479, 47);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 128, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(795, 362);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 87);
            label1.Name = "label1";
            label1.Size = new Size(139, 39);
            label1.TabIndex = 33;
            label1.Text = "Results";
            // 
            // guna2Button8
            // 
            guna2Button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button8.AutoRoundedCorners = true;
            guna2Button8.BackColor = Color.Transparent;
            guna2Button8.BorderColor = Color.FromArgb(64, 0, 30);
            guna2Button8.BorderRadius = 21;
            guna2Button8.CustomizableEdges = customizableEdges1;
            guna2Button8.DisabledState.BorderColor = Color.DarkGray;
            guna2Button8.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button8.FillColor = Color.FromArgb(64, 0, 30);
            guna2Button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button8.ForeColor = Color.White;
            guna2Button8.Location = new Point(713, 22);
            guna2Button8.Margin = new Padding(3, 4, 3, 4);
            guna2Button8.Name = "guna2Button8";
            guna2Button8.PressedColor = Color.FromArgb(64, 0, 30);
            guna2Button8.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button8.Size = new Size(128, 45);
            guna2Button8.TabIndex = 32;
            guna2Button8.Text = "Search";
            guna2Button8.Click += guna2Button8_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Skills Requested", "Skills Offered" });
            comboBox1.Location = new Point(531, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 45);
            comboBox1.TabIndex = 3;
            // 
            // SearchResultsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel2);
            Name = "SearchResultsUserControl";
            Size = new Size(863, 524);
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private ComboBox comboBox1;
        public TextBox textBox1;
    }
}
