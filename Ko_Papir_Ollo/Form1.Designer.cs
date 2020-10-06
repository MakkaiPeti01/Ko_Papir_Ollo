namespace Ko_Papir_Ollo
{
    partial class FrmFo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_jatekos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Szamitogep = new System.Windows.Forms.Label();
            this.pb_jatekos = new System.Windows.Forms.PictureBox();
            this.pb_szamitogep = new System.Windows.Forms.PictureBox();
            this.lbl_gyoztes = new System.Windows.Forms.Label();
            this.btn_ko = new System.Windows.Forms.Button();
            this.btn_papir = new System.Windows.Forms.Button();
            this.btn_ollo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.btn_ujjatek = new System.Windows.Forms.Button();
            this.btn_szabalyok = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jatekos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_szamitogep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos:";
            // 
            // lbl_jatekos
            // 
            this.lbl_jatekos.AutoSize = true;
            this.lbl_jatekos.Location = new System.Drawing.Point(105, 2);
            this.lbl_jatekos.Name = "lbl_jatekos";
            this.lbl_jatekos.Size = new System.Drawing.Size(51, 20);
            this.lbl_jatekos.TabIndex = 1;
            this.lbl_jatekos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Számítógép:";
            // 
            // lbl_Szamitogep
            // 
            this.lbl_Szamitogep.AutoSize = true;
            this.lbl_Szamitogep.Location = new System.Drawing.Point(434, 2);
            this.lbl_Szamitogep.Name = "lbl_Szamitogep";
            this.lbl_Szamitogep.Size = new System.Drawing.Size(51, 20);
            this.lbl_Szamitogep.TabIndex = 3;
            this.lbl_Szamitogep.Text = "label3";
            // 
            // pb_jatekos
            // 
            this.pb_jatekos.Location = new System.Drawing.Point(17, 48);
            this.pb_jatekos.Name = "pb_jatekos";
            this.pb_jatekos.Size = new System.Drawing.Size(200, 200);
            this.pb_jatekos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_jatekos.TabIndex = 4;
            this.pb_jatekos.TabStop = false;
            // 
            // pb_szamitogep
            // 
            this.pb_szamitogep.Location = new System.Drawing.Point(313, 48);
            this.pb_szamitogep.Name = "pb_szamitogep";
            this.pb_szamitogep.Size = new System.Drawing.Size(200, 200);
            this.pb_szamitogep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_szamitogep.TabIndex = 5;
            this.pb_szamitogep.TabStop = false;
            // 
            // lbl_gyoztes
            // 
            this.lbl_gyoztes.AutoSize = true;
            this.lbl_gyoztes.Location = new System.Drawing.Point(234, 262);
            this.lbl_gyoztes.Name = "lbl_gyoztes";
            this.lbl_gyoztes.Size = new System.Drawing.Size(51, 20);
            this.lbl_gyoztes.TabIndex = 6;
            this.lbl_gyoztes.Text = "label3";
            // 
            // btn_ko
            // 
            this.btn_ko.Location = new System.Drawing.Point(43, 13);
            this.btn_ko.Name = "btn_ko";
            this.btn_ko.Size = new System.Drawing.Size(75, 32);
            this.btn_ko.TabIndex = 7;
            this.btn_ko.Text = "Kő";
            this.btn_ko.UseVisualStyleBackColor = true;
            this.btn_ko.Click += new System.EventHandler(this.btn_ko_Click);
            // 
            // btn_papir
            // 
            this.btn_papir.Location = new System.Drawing.Point(236, 13);
            this.btn_papir.Name = "btn_papir";
            this.btn_papir.Size = new System.Drawing.Size(75, 32);
            this.btn_papir.TabIndex = 8;
            this.btn_papir.Text = "Papír";
            this.btn_papir.UseVisualStyleBackColor = true;
            this.btn_papir.Click += new System.EventHandler(this.btn_papir_Click);
            // 
            // btn_ollo
            // 
            this.btn_ollo.Location = new System.Drawing.Point(436, 13);
            this.btn_ollo.Name = "btn_ollo";
            this.btn_ollo.Size = new System.Drawing.Size(75, 32);
            this.btn_ollo.TabIndex = 9;
            this.btn_ollo.Text = "Olló";
            this.btn_ollo.UseVisualStyleBackColor = true;
            this.btn_ollo.Click += new System.EventHandler(this.btn_ollo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_gyoztes);
            this.panel1.Controls.Add(this.pb_szamitogep);
            this.panel1.Controls.Add(this.pb_jatekos);
            this.panel1.Controls.Add(this.lbl_Szamitogep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_jatekos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 297);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btn_ollo);
            this.panel2.Controls.Add(this.btn_papir);
            this.panel2.Controls.Add(this.btn_ko);
            this.panel2.Location = new System.Drawing.Point(15, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 59);
            this.panel2.TabIndex = 15;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kilepes.Location = new System.Drawing.Point(37, 3);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 34);
            this.btn_kilepes.TabIndex = 10;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // btn_ujjatek
            // 
            this.btn_ujjatek.Location = new System.Drawing.Point(431, 3);
            this.btn_ujjatek.Name = "btn_ujjatek";
            this.btn_ujjatek.Size = new System.Drawing.Size(75, 34);
            this.btn_ujjatek.TabIndex = 12;
            this.btn_ujjatek.Text = "Új játék";
            this.btn_ujjatek.UseVisualStyleBackColor = true;
            this.btn_ujjatek.Click += new System.EventHandler(this.btn_ujjatek_Click);
            // 
            // btn_szabalyok
            // 
            this.btn_szabalyok.Location = new System.Drawing.Point(230, 3);
            this.btn_szabalyok.Name = "btn_szabalyok";
            this.btn_szabalyok.Size = new System.Drawing.Size(91, 34);
            this.btn_szabalyok.TabIndex = 13;
            this.btn_szabalyok.Text = "Szabályok";
            this.btn_szabalyok.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.btn_szabalyok);
            this.panel3.Controls.Add(this.btn_ujjatek);
            this.panel3.Controls.Add(this.btn_kilepes);
            this.panel3.Location = new System.Drawing.Point(14, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 46);
            this.panel3.TabIndex = 16;
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_kilepes;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő,Papír,Olló";
            this.Load += new System.EventHandler(this.FrmFo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_jatekos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_szamitogep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_jatekos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Szamitogep;
        private System.Windows.Forms.PictureBox pb_jatekos;
        private System.Windows.Forms.PictureBox pb_szamitogep;
        private System.Windows.Forms.Label lbl_gyoztes;
        private System.Windows.Forms.Button btn_ko;
        private System.Windows.Forms.Button btn_papir;
        private System.Windows.Forms.Button btn_ollo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.Button btn_ujjatek;
        private System.Windows.Forms.Button btn_szabalyok;
        private System.Windows.Forms.Panel panel3;
    }
}

