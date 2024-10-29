namespace StanNaDan.Forme
{
    partial class SajtoviNekretnine
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
            Sajt = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Sajt });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(363, 249);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID:";
            // 
            // Sajt
            // 
            Sajt.Text = "Sajt:";
            Sajt.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 9F, FontStyle.Bold);
            button1.Location = new Point(522, 157);
            button1.Name = "button1";
            button1.Size = new Size(134, 49);
            button1.TabIndex = 3;
            button1.Text = "Dodaj Sajt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 9F, FontStyle.Bold);
            button2.Location = new Point(522, 212);
            button2.Name = "button2";
            button2.Size = new Size(134, 49);
            button2.TabIndex = 4;
            button2.Text = "Obrisi Sajt";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 31);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Modern No. 20", 9F, FontStyle.Bold);
            button3.Location = new Point(589, 49);
            button3.Name = "button3";
            button3.Size = new Size(67, 38);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 128);
            button5.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button5.Location = new Point(381, 212);
            button5.Name = "button5";
            button5.Size = new Size(124, 49);
            button5.TabIndex = 10;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // SajtoviNekretnine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(668, 273);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "SajtoviNekretnine";
            Text = "SajtoviNekretnine";
            Load += SajtoviNekretnine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private ColumnHeader ID;
        private ColumnHeader Sajt;
        private TextBox textBox1;
        private Button button3;
        private Button button5;
    }
}