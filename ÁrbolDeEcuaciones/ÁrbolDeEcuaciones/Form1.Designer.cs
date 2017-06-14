namespace ÁrbolDeEcuaciones
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
            if (disposing && (components != null)) {
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
            this.txtRpre = new System.Windows.Forms.TextBox();
            this.txtRpost = new System.Windows.Forms.TextBox();
            this.cmdEpre = new System.Windows.Forms.Button();
            this.cmdEpost = new System.Windows.Forms.Button();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.cmdEcuacion = new System.Windows.Forms.Button();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRpre
            // 
            this.txtRpre.Location = new System.Drawing.Point(161, 234);
            this.txtRpre.Margin = new System.Windows.Forms.Padding(2);
            this.txtRpre.Multiline = true;
            this.txtRpre.Name = "txtRpre";
            this.txtRpre.Size = new System.Drawing.Size(68, 26);
            this.txtRpre.TabIndex = 19;
            // 
            // txtRpost
            // 
            this.txtRpost.Location = new System.Drawing.Point(161, 133);
            this.txtRpost.Margin = new System.Windows.Forms.Padding(2);
            this.txtRpost.Multiline = true;
            this.txtRpost.Name = "txtRpost";
            this.txtRpost.Size = new System.Drawing.Size(68, 26);
            this.txtRpost.TabIndex = 18;
            // 
            // cmdEpre
            // 
            this.cmdEpre.Location = new System.Drawing.Point(89, 234);
            this.cmdEpre.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEpre.Name = "cmdEpre";
            this.cmdEpre.Size = new System.Drawing.Size(68, 26);
            this.cmdEpre.TabIndex = 17;
            this.cmdEpre.Text = "Evaluar";
            this.cmdEpre.UseVisualStyleBackColor = true;
            this.cmdEpre.Click += new System.EventHandler(this.cmdEpre_Click);
            // 
            // cmdEpost
            // 
            this.cmdEpost.Location = new System.Drawing.Point(89, 133);
            this.cmdEpost.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEpost.Name = "cmdEpost";
            this.cmdEpost.Size = new System.Drawing.Size(68, 26);
            this.cmdEpost.TabIndex = 16;
            this.cmdEpost.Text = "Evaluar";
            this.cmdEpost.UseVisualStyleBackColor = true;
            this.cmdEpost.Click += new System.EventHandler(this.cmdEpost_Click);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(14, 189);
            this.txtPre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPre.Multiline = true;
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(215, 41);
            this.txtPre.TabIndex = 15;
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(11, 70);
            this.lblPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(28, 13);
            this.lblPost.TabIndex = 14;
            this.lblPost.Text = "Post";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(11, 174);
            this.lblPre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(23, 13);
            this.lblPre.TabIndex = 13;
            this.lblPre.Text = "Pre";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(14, 88);
            this.txtPost.Margin = new System.Windows.Forms.Padding(2);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(215, 41);
            this.txtPost.TabIndex = 12;
            // 
            // cmdEcuacion
            // 
            this.cmdEcuacion.Location = new System.Drawing.Point(161, 35);
            this.cmdEcuacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEcuacion.Name = "cmdEcuacion";
            this.cmdEcuacion.Size = new System.Drawing.Size(68, 26);
            this.cmdEcuacion.TabIndex = 11;
            this.cmdEcuacion.Text = "Evaluar";
            this.cmdEcuacion.UseVisualStyleBackColor = true;
            this.cmdEcuacion.Click += new System.EventHandler(this.cmdEcuacion_Click);
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(11, 11);
            this.txtEcuacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(218, 20);
            this.txtEcuacion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 271);
            this.Controls.Add(this.txtRpre);
            this.Controls.Add(this.txtRpost);
            this.Controls.Add(this.cmdEpre);
            this.Controls.Add(this.cmdEpost);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.cmdEcuacion);
            this.Controls.Add(this.txtEcuacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRpre;
        private System.Windows.Forms.TextBox txtRpost;
        private System.Windows.Forms.Button cmdEpre;
        private System.Windows.Forms.Button cmdEpost;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button cmdEcuacion;
        private System.Windows.Forms.TextBox txtEcuacion;
    }
}

