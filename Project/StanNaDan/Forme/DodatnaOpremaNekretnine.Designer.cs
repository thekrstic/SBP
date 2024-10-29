namespace StanNaDan.Forme
{
    partial class DodatnaOpremaNekretnine
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
            Cena = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Tip, Cena });
            listView1.Location = new Point(14, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(383, 249);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID:";
            // 
            // Tip
            // 
            Tip.Text = "Tip:";
            Tip.Width = 150;
            // 
            // Cena
            // 
            Cena.Text = "Cena:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 9F, FontStyle.Bold);
            button2.Location = new Point(417, 197);
            button2.Name = "button2";
            button2.Size = new Size(134, 79);
            button2.TabIndex = 9;
            button2.Text = "Obrisi Opremu";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 9F, FontStyle.Bold);
            button1.Location = new Point(417, 114);
            button1.Name = "button1";
            button1.Size = new Size(134, 79);
            button1.TabIndex = 8;
            button1.Text = "Dodaj Opremu";
            button1.UseVisualStyleBackColor = false;
            // 
            // DodatnaOpremaNekretnine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(567, 303);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DodatnaOpremaNekretnine";
            Text = "DodatnaOpremaNekretnine";
            Load += DodatnaOpremaNekretnine_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Tip;
        private Button button2;
        private Button button1;
        private ColumnHeader Cena;
    }
}