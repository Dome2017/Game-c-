namespace WinFormsApp2
{
    partial class Form2
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
            this.label_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_gold = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label_attack = new System.Windows.Forms.Label();
            this.label_defense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_name.Location = new System.Drawing.Point(12, 46);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(67, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "label_name";
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Walka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sklep";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Wyjście";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp2.Properties.Resources.coin_04;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_gold
            // 
            this.label_gold.AutoSize = true;
            this.label_gold.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_gold.Location = new System.Drawing.Point(41, 9);
            this.label_gold.Name = "label_gold";
            this.label_gold.Size = new System.Drawing.Size(61, 15);
            this.label_gold.TabIndex = 5;
            this.label_gold.Text = "label_gold";
            this.label_gold.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_hp.Location = new System.Drawing.Point(12, 75);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(51, 15);
            this.label_hp.TabIndex = 6;
            this.label_hp.Text = "label_hp";
            // 
            // label_attack
            // 
            this.label_attack.AutoSize = true;
            this.label_attack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_attack.Location = new System.Drawing.Point(12, 102);
            this.label_attack.Name = "label_attack";
            this.label_attack.Size = new System.Drawing.Size(69, 15);
            this.label_attack.TabIndex = 7;
            this.label_attack.Text = "label_attack";
            // 
            // label_defense
            // 
            this.label_defense.AutoSize = true;
            this.label_defense.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_defense.Location = new System.Drawing.Point(12, 130);
            this.label_defense.Name = "label_defense";
            this.label_defense.Size = new System.Drawing.Size(78, 15);
            this.label_defense.TabIndex = 8;
            this.label_defense.Text = "label_defense";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp2.Properties.Resources.stoneentrance;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_defense);
            this.Controls.Add(this.label_attack);
            this.Controls.Add(this.label_hp);
            this.Controls.Add(this.label_gold);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_name);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label_gold;
        private Label label_hp;
        private Label label_attack;
        private Label label_defense;
        private Label label6;
    }
}