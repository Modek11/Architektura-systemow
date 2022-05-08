
namespace Intel8086Emulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.FromAX = new System.Windows.Forms.RadioButton();
            this.FromBX = new System.Windows.Forms.RadioButton();
            this.ToBX = new System.Windows.Forms.RadioButton();
            this.ToAX = new System.Windows.Forms.RadioButton();
            this.ToDX = new System.Windows.Forms.RadioButton();
            this.ToCX = new System.Windows.Forms.RadioButton();
            this.FromDX = new System.Windows.Forms.RadioButton();
            this.FromCX = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MOV = new System.Windows.Forms.Button();
            this.XCHG = new System.Windows.Forms.Button();
            this.RandomInputs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(88, 58);
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAX.TabIndex = 0;
            this.textBoxAX.TextChanged += new System.EventHandler(this.textBoxAX_TextChanged);
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(88, 102);
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(100, 20);
            this.textBoxBX.TabIndex = 1;
            this.textBoxBX.TextChanged += new System.EventHandler(this.textBoxBX_TextChanged);
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(88, 146);
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCX.TabIndex = 3;
            this.textBoxCX.TextChanged += new System.EventHandler(this.textBoxCX_TextChanged);
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(89, 190);
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(100, 20);
            this.textBoxDX.TabIndex = 2;
            this.textBoxDX.TextChanged += new System.EventHandler(this.textBoxDX_TextChanged);
            // 
            // FromAX
            // 
            this.FromAX.AutoSize = true;
            this.FromAX.Location = new System.Drawing.Point(3, 9);
            this.FromAX.Name = "FromAX";
            this.FromAX.Size = new System.Drawing.Size(39, 17);
            this.FromAX.TabIndex = 8;
            this.FromAX.TabStop = true;
            this.FromAX.Text = "AX";
            this.FromAX.UseVisualStyleBackColor = true;
            // 
            // FromBX
            // 
            this.FromBX.AutoSize = true;
            this.FromBX.Location = new System.Drawing.Point(3, 40);
            this.FromBX.Name = "FromBX";
            this.FromBX.Size = new System.Drawing.Size(39, 17);
            this.FromBX.TabIndex = 9;
            this.FromBX.TabStop = true;
            this.FromBX.Text = "BX";
            this.FromBX.UseVisualStyleBackColor = true;
            // 
            // ToBX
            // 
            this.ToBX.AutoSize = true;
            this.ToBX.Location = new System.Drawing.Point(3, 40);
            this.ToBX.Name = "ToBX";
            this.ToBX.Size = new System.Drawing.Size(39, 17);
            this.ToBX.TabIndex = 11;
            this.ToBX.TabStop = true;
            this.ToBX.Text = "BX";
            this.ToBX.UseVisualStyleBackColor = true;
            // 
            // ToAX
            // 
            this.ToAX.AutoSize = true;
            this.ToAX.Location = new System.Drawing.Point(3, 9);
            this.ToAX.Name = "ToAX";
            this.ToAX.Size = new System.Drawing.Size(39, 17);
            this.ToAX.TabIndex = 10;
            this.ToAX.TabStop = true;
            this.ToAX.Text = "AX";
            this.ToAX.UseVisualStyleBackColor = true;
            // 
            // ToDX
            // 
            this.ToDX.AutoSize = true;
            this.ToDX.Location = new System.Drawing.Point(3, 103);
            this.ToDX.Name = "ToDX";
            this.ToDX.Size = new System.Drawing.Size(40, 17);
            this.ToDX.TabIndex = 15;
            this.ToDX.TabStop = true;
            this.ToDX.Text = "DX";
            this.ToDX.UseVisualStyleBackColor = true;
            // 
            // ToCX
            // 
            this.ToCX.AutoSize = true;
            this.ToCX.Location = new System.Drawing.Point(3, 72);
            this.ToCX.Name = "ToCX";
            this.ToCX.Size = new System.Drawing.Size(39, 17);
            this.ToCX.TabIndex = 14;
            this.ToCX.TabStop = true;
            this.ToCX.Text = "CX";
            this.ToCX.UseVisualStyleBackColor = true;
            // 
            // FromDX
            // 
            this.FromDX.AutoSize = true;
            this.FromDX.Location = new System.Drawing.Point(3, 103);
            this.FromDX.Name = "FromDX";
            this.FromDX.Size = new System.Drawing.Size(40, 17);
            this.FromDX.TabIndex = 13;
            this.FromDX.TabStop = true;
            this.FromDX.Text = "DX";
            this.FromDX.UseVisualStyleBackColor = true;
            // 
            // FromCX
            // 
            this.FromCX.AutoSize = true;
            this.FromCX.Location = new System.Drawing.Point(3, 72);
            this.FromCX.Name = "FromCX";
            this.FromCX.Size = new System.Drawing.Size(39, 17);
            this.FromCX.TabIndex = 12;
            this.FromCX.TabStop = true;
            this.FromCX.Text = "CX";
            this.FromCX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "AX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "BX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "CX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "DX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(252, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "FROM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(353, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "TO:";
            // 
            // MOV
            // 
            this.MOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MOV.Location = new System.Drawing.Point(83, 308);
            this.MOV.Name = "MOV";
            this.MOV.Size = new System.Drawing.Size(135, 54);
            this.MOV.TabIndex = 22;
            this.MOV.Text = "MOV";
            this.MOV.UseVisualStyleBackColor = true;
            this.MOV.Click += new System.EventHandler(this.MOV_Click);
            // 
            // XCHG
            // 
            this.XCHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XCHG.Location = new System.Drawing.Point(257, 308);
            this.XCHG.Name = "XCHG";
            this.XCHG.Size = new System.Drawing.Size(135, 54);
            this.XCHG.TabIndex = 23;
            this.XCHG.Text = "XCHG";
            this.XCHG.UseVisualStyleBackColor = true;
            this.XCHG.Click += new System.EventHandler(this.XCHG_Click);
            // 
            // RandomInputs
            // 
            this.RandomInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RandomInputs.Location = new System.Drawing.Point(48, 228);
            this.RandomInputs.Name = "RandomInputs";
            this.RandomInputs.Size = new System.Drawing.Size(140, 39);
            this.RandomInputs.TabIndex = 24;
            this.RandomInputs.Text = "Random";
            this.RandomInputs.UseVisualStyleBackColor = true;
            this.RandomInputs.Click += new System.EventHandler(this.RandomInputs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToBX);
            this.panel1.Controls.Add(this.ToAX);
            this.panel1.Controls.Add(this.ToDX);
            this.panel1.Controls.Add(this.ToCX);
            this.panel1.Location = new System.Drawing.Point(358, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 134);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FromAX);
            this.panel2.Controls.Add(this.FromBX);
            this.panel2.Controls.Add(this.FromCX);
            this.panel2.Controls.Add(this.FromDX);
            this.panel2.Location = new System.Drawing.Point(275, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 134);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RandomInputs);
            this.Controls.Add(this.XCHG);
            this.Controls.Add(this.MOV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.textBoxAX);
            this.MaximumSize = new System.Drawing.Size(476, 489);
            this.MinimumSize = new System.Drawing.Size(476, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intel 8086 emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.RadioButton FromAX;
        private System.Windows.Forms.RadioButton FromBX;
        private System.Windows.Forms.RadioButton ToBX;
        private System.Windows.Forms.RadioButton ToAX;
        private System.Windows.Forms.RadioButton ToDX;
        private System.Windows.Forms.RadioButton ToCX;
        private System.Windows.Forms.RadioButton FromDX;
        private System.Windows.Forms.RadioButton FromCX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MOV;
        private System.Windows.Forms.Button XCHG;
        private System.Windows.Forms.Button RandomInputs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

