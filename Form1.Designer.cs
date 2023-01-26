namespace TimeInTarkovDesk
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxTime1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTime2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTime1.SuspendLayout();
            this.groupBoxTime2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTime1
            // 
            this.groupBoxTime1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTime1.Controls.Add(this.label1);
            this.groupBoxTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTime1.Location = new System.Drawing.Point(70, 23);
            this.groupBoxTime1.Name = "groupBoxTime1";
            this.groupBoxTime1.Size = new System.Drawing.Size(188, 71);
            this.groupBoxTime1.TabIndex = 1;
            this.groupBoxTime1.TabStop = false;
            this.groupBoxTime1.Text = "Time I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:000";
            // 
            // groupBoxTime2
            // 
            this.groupBoxTime2.Controls.Add(this.label2);
            this.groupBoxTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTime2.Location = new System.Drawing.Point(345, 23);
            this.groupBoxTime2.Name = "groupBoxTime2";
            this.groupBoxTime2.Size = new System.Drawing.Size(188, 71);
            this.groupBoxTime2.TabIndex = 2;
            this.groupBoxTime2.TabStop = false;
            this.groupBoxTime2.Text = "Time II";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:00:000";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(549, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 125);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxTime2);
            this.Controls.Add(this.groupBoxTime1);
            this.Name = "Form1";
            this.Text = "Time in Escape  from Tarkov";
            this.groupBoxTime1.ResumeLayout(false);
            this.groupBoxTime1.PerformLayout();
            this.groupBoxTime2.ResumeLayout(false);
            this.groupBoxTime2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTime2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
    }
}

