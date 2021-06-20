namespace Breakout
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
            this.components = new System.ComponentModel.Container();
            this.picKockica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPloca = new System.Windows.Forms.PictureBox();
            this.labelNivo = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKockica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPloca)).BeginInit();
            this.SuspendLayout();
            // 
            // picKockica
            // 
            this.picKockica.BackColor = System.Drawing.Color.Red;
            this.picKockica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picKockica.Location = new System.Drawing.Point(287, 288);
            this.picKockica.Name = "picKockica";
            this.picKockica.Size = new System.Drawing.Size(25, 25);
            this.picKockica.TabIndex = 0;
            this.picKockica.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPaddle
            // 
            this.picPloca.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picPloca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPloca.Location = new System.Drawing.Point(214, 481);
            this.picPloca.Name = "picPaddle";
            this.picPloca.Size = new System.Drawing.Size(200, 25);
            this.picPloca.TabIndex = 1;
            this.picPloca.TabStop = false;
            // 
            // label1
            // 
            this.labelNivo.AutoSize = true;
            this.labelNivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNivo.Location = new System.Drawing.Point(12, 528);
            this.labelNivo.Name = "label1";
            this.labelNivo.Size = new System.Drawing.Size(63, 24);
            this.labelNivo.TabIndex = 2;
            this.labelNivo.Text = "Nivo 1";
            // 
            // label2
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSkor.Location = new System.Drawing.Point(126, 528);
            this.labelSkor.Name = "label2";
            this.labelSkor.Size = new System.Drawing.Size(83, 24);
            this.labelSkor.TabIndex = 3;
            this.labelSkor.Text = "Bodovi 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelNivo);
            this.Controls.Add(this.picPloca);
            this.Controls.Add(this.picKockica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picKockica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPloca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picKockica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPloca;
        private System.Windows.Forms.Label labelNivo;
        private System.Windows.Forms.Label labelSkor;
    }
}

