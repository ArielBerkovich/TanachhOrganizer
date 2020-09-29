namespace RonitOrganizer
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Genesis = new System.Windows.Forms.Button();
            this.Shmot = new System.Windows.Forms.Button();
            this.Vaikra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(131, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 645);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Vaikra);
            this.panel2.Controls.Add(this.Shmot);
            this.panel2.Controls.Add(this.Genesis);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 691);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Genesis
            // 
            this.Genesis.BackColor = System.Drawing.Color.SlateGray;
            this.Genesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Genesis.Location = new System.Drawing.Point(13, 131);
            this.Genesis.Name = "Genesis";
            this.Genesis.Size = new System.Drawing.Size(99, 40);
            this.Genesis.TabIndex = 0;
            this.Genesis.Text = "בראשית";
            this.Genesis.UseVisualStyleBackColor = false;
            this.Genesis.Click += new System.EventHandler(this.Genesis_Click);
            // 
            // Shmot
            // 
            this.Shmot.BackColor = System.Drawing.Color.SlateGray;
            this.Shmot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Shmot.Location = new System.Drawing.Point(15, 193);
            this.Shmot.Name = "Shmot";
            this.Shmot.Size = new System.Drawing.Size(99, 40);
            this.Shmot.TabIndex = 1;
            this.Shmot.Text = "שמות";
            this.Shmot.UseVisualStyleBackColor = false;
            this.Shmot.Click += new System.EventHandler(this.Shmot_Click);
            // 
            // Vaikra
            // 
            this.Vaikra.BackColor = System.Drawing.Color.SlateGray;
            this.Vaikra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Vaikra.Location = new System.Drawing.Point(15, 260);
            this.Vaikra.Name = "Vaikra";
            this.Vaikra.Size = new System.Drawing.Size(99, 40);
            this.Vaikra.TabIndex = 2;
            this.Vaikra.Text = "ויקרא";
            this.Vaikra.UseVisualStyleBackColor = false;
            this.Vaikra.Click += new System.EventHandler(this.Vaikra_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(13, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "הוסף מערך";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(15, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "הכל";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Vaikra;
        private System.Windows.Forms.Button Shmot;
        private System.Windows.Forms.Button Genesis;
    }
}

