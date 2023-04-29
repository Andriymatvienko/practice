namespace Завдання
{
    partial class FrmClasses
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label CountryBox;
            this.MedalBox = new System.Windows.Forms.Label();
            this.PeopleBox = new System.Windows.Forms.Label();
            this.CountryBox1 = new System.Windows.Forms.TextBox();
            this.MedalBox2 = new System.Windows.Forms.TextBox();
            this.PeopleBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            CountryBox = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryBox
            // 
            CountryBox.AutoSize = true;
            CountryBox.Location = new System.Drawing.Point(8, 41);
            CountryBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new System.Drawing.Size(57, 21);
            CountryBox.TabIndex = 0;
            CountryBox.Text = "Країна";
            CountryBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // MedalBox
            // 
            this.MedalBox.AutoSize = true;
            this.MedalBox.Location = new System.Drawing.Point(8, 102);
            this.MedalBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedalBox.Name = "MedalBox";
            this.MedalBox.Size = new System.Drawing.Size(138, 21);
            this.MedalBox.TabIndex = 1;
            this.MedalBox.Text = "Кількість медалей";
            // 
            // PeopleBox
            // 
            this.PeopleBox.AutoSize = true;
            this.PeopleBox.Location = new System.Drawing.Point(8, 164);
            this.PeopleBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PeopleBox.Name = "PeopleBox";
            this.PeopleBox.Size = new System.Drawing.Size(147, 21);
            this.PeopleBox.TabIndex = 2;
            this.PeopleBox.Text = "Кількість учасників";
            // 
            // CountryBox1
            // 
            this.CountryBox1.Location = new System.Drawing.Point(8, 66);
            this.CountryBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CountryBox1.Name = "CountryBox1";
            this.CountryBox1.Size = new System.Drawing.Size(127, 29);
            this.CountryBox1.TabIndex = 3;
            this.CountryBox1.TextChanged += new System.EventHandler(this.CountryBox1_TextChanged);
            // 
            // MedalBox2
            // 
            this.MedalBox2.Location = new System.Drawing.Point(8, 127);
            this.MedalBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MedalBox2.Name = "MedalBox2";
            this.MedalBox2.Size = new System.Drawing.Size(127, 29);
            this.MedalBox2.TabIndex = 4;
            this.MedalBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PeopleBox3
            // 
            this.PeopleBox3.Location = new System.Drawing.Point(8, 189);
            this.PeopleBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PeopleBox3.Name = "PeopleBox3";
            this.PeopleBox3.Size = new System.Drawing.Size(127, 29);
            this.PeopleBox3.TabIndex = 5;
            this.PeopleBox3.TextChanged += new System.EventHandler(this.PeopleBox3_TextChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.MedalBox2);
            this.GroupBox1.Controls.Add(this.CountryBox1);
            this.GroupBox1.Controls.Add(this.PeopleBox);
            this.GroupBox1.Controls.Add(this.PeopleBox3);
            this.GroupBox1.Controls.Add(this.MedalBox);
            this.GroupBox1.Controls.Add(CountryBox);
            this.GroupBox1.Location = new System.Drawing.Point(82, 98);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(257, 287);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Інформація";
            this.GroupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(82, 431);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(129, 32);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Додати";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(420, 98);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(428, 285);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClasses";
            this.Text = "Перелік Країн";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.FrmClasses_BackgroundImageChanged);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.FrmClasses_BackgroundImageLayoutChanged);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CountryBox;
        private Label MedalBox;
        private Label PeopleBox;
        private TextBox CountryBox1;
        private TextBox MedalBox2;
        private TextBox PeopleBox3;
        private GroupBox GroupBox1;
        private Button StartButton;
        private TextBox ResultBox;
    }
}