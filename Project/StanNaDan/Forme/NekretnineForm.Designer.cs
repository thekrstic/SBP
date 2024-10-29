namespace StanNaDan.Forme
{
    partial class NekretnineForm
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
            listView1 = new ListView();
            ID = new ColumnHeader();
            Tip = new ColumnHeader();
            KucniBr = new ColumnHeader();
            NazivUlice = new ColumnHeader();
            Kvadratura = new ColumnHeader();
            BrojKupatila = new ColumnHeader();
            BrojTerasa = new ColumnHeader();
            BrojSoba = new ColumnHeader();
            Internet = new ColumnHeader();
            TV = new ColumnHeader();
            Kuhinja = new ColumnHeader();
            Dimenzije = new ColumnHeader();
            TipKreveta = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button4 = new Button();
            groupBox4 = new GroupBox();
            button8 = new Button();
            groupBox6 = new GroupBox();
            button10 = new Button();
            groupBox7 = new GroupBox();
            button11 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Tip, KucniBr, NazivUlice, Kvadratura, BrojKupatila, BrojTerasa, BrojSoba, Internet, TV, Kuhinja, Dimenzije, TipKreveta });
            listView1.Location = new Point(18, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(633, 577);
            listView1.TabIndex = 0;
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
            Tip.Text = "Tip:";
            Tip.Width = 70;
            // 
            // KucniBr
            // 
            KucniBr.Text = "Kucni Broj:";
            // 
            // NazivUlice
            // 
            NazivUlice.Text = "Naziv Ulice:";
            // 
            // Kvadratura
            // 
            Kvadratura.Text = "Kvadratura:";
            // 
            // BrojKupatila
            // 
            BrojKupatila.Text = "Broj Kupatila:";
            // 
            // BrojTerasa
            // 
            BrojTerasa.DisplayIndex = 7;
            BrojTerasa.Text = "Broj Terasa:";
            // 
            // BrojSoba
            // 
            BrojSoba.DisplayIndex = 6;
            BrojSoba.Text = "Broj Soba:";
            // 
            // Internet
            // 
            Internet.Text = "Internet:";
            // 
            // TV
            // 
            TV.DisplayIndex = 12;
            TV.Text = "TV:";
            // 
            // Kuhinja
            // 
            Kuhinja.DisplayIndex = 9;
            Kuhinja.Text = "Kuhinja:";
            // 
            // Dimenzije
            // 
            Dimenzije.DisplayIndex = 10;
            Dimenzije.Text = "Dimenzije:";
            // 
            // TipKreveta
            // 
            TipKreveta.DisplayIndex = 11;
            TipKreveta.Text = "Tip Kreveta:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(35, 41);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 2;
            button1.Text = "Dodaj Nekretninu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button2.Location = new Point(35, 100);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 3;
            button2.Text = "Obriši Nekretninu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button3.Location = new Point(35, 159);
            button3.Name = "button3";
            button3.Size = new Size(223, 53);
            button3.TabIndex = 4;
            button3.Text = "Izmeni Nekretninu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(711, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 225);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o Nekretninama";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 637);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Nekretnina";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(711, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 202);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vlasnici";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 192, 128);
            button7.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button7.Location = new Point(35, 113);
            button7.Name = "button7";
            button7.Size = new Size(223, 76);
            button7.TabIndex = 8;
            button7.Text = "Prikazi Brojeve Racuna Vlasnika";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button4.Location = new Point(35, 30);
            button4.Name = "button4";
            button4.Size = new Size(223, 77);
            button4.TabIndex = 5;
            button4.Text = "Prikazi Vlasnika Nekretnine";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button8);
            groupBox4.Location = new Point(1040, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 142);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kvartovi";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 192, 128);
            button8.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button8.Location = new Point(40, 35);
            button8.Name = "button8";
            button8.Size = new Size(223, 89);
            button8.TabIndex = 9;
            button8.Text = "Prikazi Kvart Nekretnine";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button10);
            groupBox6.Location = new Point(1040, 181);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(300, 169);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sajtovi";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 192, 128);
            button10.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button10.Location = new Point(40, 30);
            button10.Name = "button10";
            button10.Size = new Size(223, 120);
            button10.TabIndex = 11;
            button10.Text = "Prikazi Sajtove na kojima je oglasena Nekretnina";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button11);
            groupBox7.Location = new Point(1040, 384);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(300, 148);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "Dodatna Oprema";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 128);
            button11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button11.Location = new Point(40, 36);
            button11.Name = "button11";
            button11.Size = new Size(223, 77);
            button11.TabIndex = 12;
            button11.Text = "Prikazi Dodatnu Opremu Nekretnine";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(711, 448);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 20;
            label3.Text = "Ukupan broj Nekretnina:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(781, 501);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 31);
            textBox1.TabIndex = 19;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 128);
            button5.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button5.Location = new Point(700, 573);
            button5.Name = "button5";
            button5.Size = new Size(142, 76);
            button5.TabIndex = 9;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // NekretnineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1352, 690);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NekretnineForm";
            Text = "NekretnineForm";
            Load += NekretnineForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button4;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button button7;
        private Button button8;
        private Button button11;
        private Button button10;
        private Label label3;
        private TextBox textBox1;
        private ColumnHeader ID;
        private ColumnHeader Tip;
        private ColumnHeader KucniBr;
        private ColumnHeader NazivUlice;
        private ColumnHeader Kvadratura;
        private ColumnHeader BrojKupatila;
        private ColumnHeader BrojSoba;
        private ColumnHeader BrojTerasa;
        private ColumnHeader Internet;
        private ColumnHeader Kuhinja;
        private ColumnHeader Dimenzije;
        private ColumnHeader TipKreveta;
        private ColumnHeader TV;
        private Button button5;
    }
}