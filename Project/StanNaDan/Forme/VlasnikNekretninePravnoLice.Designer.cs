namespace StanNaDan.Forme
{
    partial class VlasnikNekretninePravnoLice
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
            button11 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Tip = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Adresa = new ColumnHeader();
            Mesto = new ColumnHeader();
            Drzava = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vlasnici [pravna lica] izabrane Nekretnine";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 128);
            button11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button11.Location = new Point(565, 42);
            button11.Name = "button11";
            button11.Size = new Size(223, 53);
            button11.TabIndex = 13;
            button11.Text = "Dodaj Vlasnika";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(565, 101);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 14;
            button1.Text = "Izmeni Vlasnika";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button2.Location = new Point(565, 160);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 15;
            button2.Text = "Obriši Vlasnika";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button3.Location = new Point(565, 356);
            button3.Name = "button3";
            button3.Size = new Size(223, 76);
            button3.TabIndex = 16;
            button3.Text = "Broj telefona izabranog Vlasnika";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Tip, Ime, Prezime, Adresa, Mesto, Drzava });
            listView1.Location = new Point(6, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(516, 390);
            listView1.TabIndex = 53;
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
            // VlasnikNekretninePravnoLice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button11);
            Controls.Add(groupBox1);
            Name = "VlasnikNekretninePravnoLice";
            Text = "VlasnikNekretninePravnoLice";
            Load += VlasnikNekretninePravnoLice_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button11;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Tip;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Adresa;
        private ColumnHeader Mesto;
        private ColumnHeader Drzava;
    }
}