namespace StanNaDan.Forme
{
    partial class NajmoviForm
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
            DatumOd = new ColumnHeader();
            DatumDo = new ColumnHeader();
            CenaPoDanu = new ColumnHeader();
            BrojDana = new ColumnHeader();
            Popust = new ColumnHeader();
            Provizija = new ColumnHeader();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(29, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 523);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Najmova";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, DatumOd, DatumDo, CenaPoDanu, BrojDana, Popust, Provizija });
            listView1.Location = new Point(19, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(691, 474);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // DatumOd
            // 
            DatumOd.Text = "Datum Od:";
            DatumOd.Width = 130;
            // 
            // DatumDo
            // 
            DatumDo.Text = "Datum Do:";
            DatumDo.Width = 130;
            // 
            // CenaPoDanu
            // 
            CenaPoDanu.Text = "Cena Po Danu: ";
            CenaPoDanu.Width = 100;
            // 
            // BrojDana
            // 
            BrojDana.Text = "Broj Dana: ";
            BrojDana.Width = 80;
            // 
            // Popust
            // 
            Popust.Text = "Popust:";
            Popust.Width = 80;
            // 
            // Provizija
            // 
            Provizija.Text = "Provizija: ";
            Provizija.Width = 80;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(786, 262);
            button1.Name = "button1";
            button1.Size = new Size(243, 53);
            button1.TabIndex = 14;
            button1.Text = "Obriši Najam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label2.Location = new Point(786, 38);
            label2.Name = "label2";
            label2.Size = new Size(243, 74);
            label2.TabIndex = 9;
            label2.Text = "Svi najmovi nekretnina su prikazani u tabeli. ";
            // 
            // label1
            // 
            label1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label1.Location = new Point(786, 121);
            label1.Name = "label1";
            label1.Size = new Size(243, 120);
            label1.TabIndex = 8;
            label1.Text = "NAPOMENA: Brisanjem najma iz ove tabele nepovratno ga izbacujete iz sistema!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(957, 501);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 31);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(858, 448);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 16;
            label3.Text = "Ukupan broj Najmova:";
            // 
            // NajmoviForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1054, 563);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "NajmoviForm";
            Text = "NajmoviForm";
            Load += NajmoviForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ColumnHeader ID;
        private ColumnHeader DatumOd;
        private ColumnHeader DatumDo;
        private ColumnHeader CenaPoDanu;
        private ColumnHeader BrojDana;
        private ColumnHeader Popust;
        private ColumnHeader Provizija;
    }
}