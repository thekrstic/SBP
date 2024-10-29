namespace StanNaDan.Forme
{
    partial class IzmeniNekretninu
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
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Tip = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Adresa = new ColumnHeader();
            Mesto = new ColumnHeader();
            Drzava = new ColumnHeader();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            listView2 = new ListView();
            Naziv = new ColumnHeader();
            Zona = new ColumnHeader();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox14 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(706, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 247);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vlasnici";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Tip, Ime, Prezime, Adresa, Mesto, Drzava });
            listView1.Location = new Point(6, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(456, 209);
            listView1.TabIndex = 51;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID:";
            ID.Width = 30;
            // 
            // Tip
            // 
            Tip.DisplayIndex = 2;
            Tip.Text = "Tip:";
            // 
            // Ime
            // 
            Ime.DisplayIndex = 1;
            Ime.Text = "Ime:";
            // 
            // Prezime
            // 
            Prezime.Text = "Prezime:";
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa:";
            // 
            // Mesto
            // 
            Mesto.Text = "Mesto:";
            // 
            // Drzava
            // 
            Drzava.Text = "Drzava:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "krevet za 1 osobu", "bračni krevet" });
            comboBox2.Location = new Point(223, 215);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 33);
            comboBox2.TabIndex = 82;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kuća", "Stan", "Soba" });
            comboBox1.Location = new Point(223, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 33);
            comboBox1.TabIndex = 81;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Enabled = false;
            numericUpDown5.Location = new Point(597, 219);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(69, 31);
            numericUpDown5.TabIndex = 80;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Enabled = false;
            numericUpDown4.Location = new Point(597, 172);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(69, 31);
            numericUpDown4.TabIndex = 79;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(597, 129);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(69, 31);
            numericUpDown3.TabIndex = 78;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(597, 86);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 31);
            numericUpDown2.TabIndex = 77;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Naziv, Zona });
            listView2.Location = new Point(6, 30);
            listView2.Name = "listView2";
            listView2.Size = new Size(196, 144);
            listView2.TabIndex = 52;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv:";
            // 
            // Zona
            // 
            Zona.Text = "Zona:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Location = new Point(706, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 180);
            groupBox2.TabIndex = 84;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kvartovi";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(597, 43);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 31);
            numericUpDown1.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label11.Location = new Point(521, 222);
            label11.Name = "label11";
            label11.Size = new Size(70, 24);
            label11.TabIndex = 75;
            label11.Text = "Sprat:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label10.Location = new Point(480, 178);
            label10.Name = "label10";
            label10.Size = new Size(111, 24);
            label10.TabIndex = 74;
            label10.Text = "Spratnost:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label9.Location = new Point(85, 219);
            label9.Name = "label9";
            label9.Size = new Size(132, 24);
            label9.TabIndex = 73;
            label9.Text = "Tip Kreveta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label8.Location = new Point(17, 259);
            label8.Name = "label8";
            label8.Size = new Size(200, 24);
            label8.TabIndex = 72;
            label8.Text = "Dimenzije Kreveta:";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Enabled = false;
            checkBox5.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            checkBox5.Location = new Point(300, 336);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(77, 28);
            checkBox5.TabIndex = 71;
            checkBox5.Text = "Lift";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            checkBox4.Location = new Point(238, 388);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(119, 28);
            checkBox4.TabIndex = 70;
            checkBox4.Text = "Dvorište";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            checkBox3.Location = new Point(104, 388);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(118, 28);
            checkBox3.TabIndex = 69;
            checkBox3.Text = "Kuhinja";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            checkBox2.Location = new Point(213, 336);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(66, 28);
            checkBox2.TabIndex = 68;
            checkBox2.Text = "TV";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            checkBox1.Location = new Point(78, 336);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 28);
            checkBox1.TabIndex = 67;
            checkBox1.Text = "Internet";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label7.Location = new Point(477, 132);
            label7.Name = "label7";
            label7.Size = new Size(114, 24);
            label7.TabIndex = 66;
            label7.Text = "Broj Soba:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label6.Location = new Point(458, 89);
            label6.Name = "label6";
            label6.Size = new Size(133, 24);
            label6.TabIndex = 65;
            label6.Text = "Broj Terasa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label5.Location = new Point(436, 46);
            label5.Name = "label5";
            label5.Size = new Size(155, 24);
            label5.TabIndex = 64;
            label5.Text = "Broj Kupatila:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label4.Location = new Point(89, 172);
            label4.Name = "label4";
            label4.Size = new Size(128, 24);
            label4.TabIndex = 63;
            label4.Text = "Kvadratura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(89, 128);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 62;
            label3.Text = "Kucni Broj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label2.Location = new Point(105, 87);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 61;
            label2.Text = "Ime Ulice:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label1.Location = new Point(50, 43);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 60;
            label1.Text = "Tip Nekretnine:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(223, 255);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(178, 31);
            textBox14.TabIndex = 59;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(223, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 31);
            textBox4.TabIndex = 58;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 31);
            textBox3.TabIndex = 57;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 31);
            textBox2.TabIndex = 56;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(1023, 378);
            button1.Name = "button1";
            button1.Size = new Size(151, 92);
            button1.TabIndex = 55;
            button1.Text = "Izmeni Nekretninu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // IzmeniNekretninu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1192, 502);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(groupBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox14);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "IzmeniNekretninu";
            Text = "IzmeniNekretninu";
            Load += IzmeniNekretninu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Tip;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Adresa;
        private ColumnHeader Mesto;
        private ColumnHeader Drzava;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private ListView listView2;
        private ColumnHeader Naziv;
        private ColumnHeader Zona;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox14;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
    }
}