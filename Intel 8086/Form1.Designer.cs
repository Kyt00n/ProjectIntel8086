
namespace Intel_8086
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DXREG = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.ComboBox();
            this.Random = new System.Windows.Forms.Button();
            this.AXREG = new System.Windows.Forms.TextBox();
            this.BXREG = new System.Windows.Forms.TextBox();
            this.CXREG = new System.Windows.Forms.TextBox();
            this.Operand1 = new System.Windows.Forms.ComboBox();
            this.Operand2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DISP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SPREG = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SI = new System.Windows.Forms.Label();
            this.DoButton = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DX";
            // 
            // DXREG
            // 
            this.DXREG.Location = new System.Drawing.Point(39, 113);
            this.DXREG.Name = "DXREG";
            this.DXREG.PlaceholderText = "0000";
            this.DXREG.ReadOnly = true;
            this.DXREG.Size = new System.Drawing.Size(100, 23);
            this.DXREG.TabIndex = 5;
            this.DXREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Command
            // 
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "MOV",
            "XCHG",
            "PUSH",
            "POP"});
            this.Command.Location = new System.Drawing.Point(156, 162);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(121, 23);
            this.Command.TabIndex = 8;
            this.Command.Text = "Wybierz polecenie";
            this.Command.SelectedValueChanged += new System.EventHandler(this.Command_SelectedValueChanged);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(48, 337);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 23);
            this.Random.TabIndex = 9;
            this.Random.Text = "Wypełnij";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // AXREG
            // 
            this.AXREG.Location = new System.Drawing.Point(39, 26);
            this.AXREG.Name = "AXREG";
            this.AXREG.PlaceholderText = "0000";
            this.AXREG.ReadOnly = true;
            this.AXREG.Size = new System.Drawing.Size(100, 23);
            this.AXREG.TabIndex = 10;
            this.AXREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BXREG
            // 
            this.BXREG.Location = new System.Drawing.Point(39, 55);
            this.BXREG.Name = "BXREG";
            this.BXREG.PlaceholderText = "0000";
            this.BXREG.ReadOnly = true;
            this.BXREG.Size = new System.Drawing.Size(100, 23);
            this.BXREG.TabIndex = 11;
            this.BXREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CXREG
            // 
            this.CXREG.Location = new System.Drawing.Point(39, 84);
            this.CXREG.Name = "CXREG";
            this.CXREG.PlaceholderText = "0000";
            this.CXREG.ReadOnly = true;
            this.CXREG.Size = new System.Drawing.Size(100, 23);
            this.CXREG.TabIndex = 12;
            this.CXREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Operand1
            // 
            this.Operand1.FormattingEnabled = true;
            this.Operand1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.Operand1.Location = new System.Drawing.Point(156, 191);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(121, 23);
            this.Operand1.TabIndex = 14;
            this.Operand1.Text = "Operand 1";
            // 
            // Operand2
            // 
            this.Operand2.FormattingEnabled = true;
            this.Operand2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.Operand2.Location = new System.Drawing.Point(156, 220);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(121, 23);
            this.Operand2.TabIndex = 15;
            this.Operand2.Text = "Operand 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Polecenia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.DISP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SPREG);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.SI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Random);
            this.groupBox1.Controls.Add(this.AXREG);
            this.groupBox1.Controls.Add(this.BXREG);
            this.groupBox1.Controls.Add(this.CXREG);
            this.groupBox1.Controls.Add(this.DXREG);
            this.groupBox1.Location = new System.Drawing.Point(404, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 375);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wartości rejestrów";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "0000";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 25;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DISP
            // 
            this.DISP.AutoSize = true;
            this.DISP.Location = new System.Drawing.Point(6, 305);
            this.DISP.Name = "DISP";
            this.DISP.Size = new System.Drawing.Size(31, 15);
            this.DISP.TabIndex = 24;
            this.DISP.Text = "DISP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "SP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "BP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "DI";
            // 
            // SPREG
            // 
            this.SPREG.Location = new System.Drawing.Point(39, 272);
            this.SPREG.Name = "SPREG";
            this.SPREG.PlaceholderText = "0000";
            this.SPREG.ReadOnly = true;
            this.SPREG.Size = new System.Drawing.Size(100, 23);
            this.SPREG.TabIndex = 17;
            this.SPREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "0000";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "0000";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "0000";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SI
            // 
            this.SI.AutoSize = true;
            this.SI.Location = new System.Drawing.Point(11, 187);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(16, 15);
            this.SI.TabIndex = 13;
            this.SI.Text = "SI";
            // 
            // DoButton
            // 
            this.DoButton.Location = new System.Drawing.Point(156, 281);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(121, 23);
            this.DoButton.TabIndex = 20;
            this.DoButton.Text = "Wykonaj";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "Z rejestru do pamięci",
            "Z pamięci do rejestru"});
            this.Direction.Location = new System.Drawing.Point(156, 249);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(121, 23);
            this.Direction.TabIndex = 21;
            this.Direction.Text = "Rejestr-pamięć";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.Command);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DXREG;
        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.TextBox AXREG;
        private System.Windows.Forms.TextBox BXREG;
        private System.Windows.Forms.TextBox CXREG;
        private System.Windows.Forms.ComboBox Operand1;
        private System.Windows.Forms.ComboBox Operand2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SPREG;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SI;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label DISP;
        private System.Windows.Forms.ComboBox Direction;
    }
}

