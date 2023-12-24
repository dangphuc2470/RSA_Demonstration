namespace RSA_Encrypt_Decrypt
{
    partial class RSA
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
            btGenerate = new Custom_button();
            tbP = new TextBox();
            roundedPanel1 = new OutlinePanel();
            tbQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            roundedPanel3 = new Addon_Round_Panel();
            roundedPanel8 = new OutlinePanel();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            roundedPanel2 = new Addon_Round_Panel();
            lbParameter = new Label();
            label8 = new Label();
            label9 = new Label();
            roundedPanel6 = new OutlinePanel();
            tbD = new TextBox();
            roundedPanel7 = new OutlinePanel();
            tbE = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btApply = new Custom_button();
            roundedPanel4 = new OutlinePanel();
            tbPhi = new TextBox();
            roundedPanel5 = new OutlinePanel();
            tbN = new TextBox();
            addon_Round_Panel1 = new Addon_Round_Panel();
            rtbInput = new RichTextBox();
            label12 = new Label();
            lbSegment = new Label();
            roundedPanel9 = new OutlinePanel();
            tbSegment = new TextBox();
            btEncrypt = new Custom_button();
            lbBase10 = new Label();
            roundedPanel10 = new OutlinePanel();
            tbBase10 = new TextBox();
            lbOutput = new Label();
            roundedPanel11 = new OutlinePanel();
            tbOutput = new TextBox();
            btDecrypt = new Custom_button();
            addon_Round_Panel2 = new Addon_Round_Panel();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            roundedPanel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel8.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel7.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            addon_Round_Panel1.SuspendLayout();
            roundedPanel9.SuspendLayout();
            roundedPanel10.SuspendLayout();
            roundedPanel11.SuspendLayout();
            addon_Round_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btGenerate
            // 
            btGenerate.BackColor = Color.White;
            btGenerate.BackgroundColor = Color.White;
            btGenerate.BorderColor = Color.FromArgb(121, 119, 112);
            btGenerate.BorderRadius = 18;
            btGenerate.BorderSize = 1;
            btGenerate.FlatStyle = FlatStyle.Flat;
            btGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGenerate.ForeColor = Color.FromArgb(98, 96, 51);
            btGenerate.Location = new Point(31, 151);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(223, 47);
            btGenerate.TabIndex = 0;
            btGenerate.Text = "Generate random prime";
            btGenerate.TextColor = Color.FromArgb(98, 96, 51);
            btGenerate.UseVisualStyleBackColor = false;
            btGenerate.Click += btGenerate_Click;
            // 
            // tbP
            // 
            tbP.BackColor = Color.FromArgb(247, 243, 245);
            tbP.BorderStyle = BorderStyle.None;
            tbP.Location = new Point(13, 9);
            tbP.Name = "tbP";
            tbP.Size = new Size(206, 20);
            tbP.TabIndex = 1;
            tbP.TextChanged += tbP_TextChanged;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel1.Controls.Add(tbQ);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.Location = new Point(31, 97);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(223, 37);
            roundedPanel1.TabIndex = 3;
            // 
            // tbQ
            // 
            tbQ.BackColor = Color.FromArgb(247, 243, 245);
            tbQ.BorderStyle = BorderStyle.None;
            tbQ.Location = new Point(13, 9);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(207, 20);
            tbQ.TabIndex = 1;
            tbQ.TextChanged += tbP_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(98, 96, 51);
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 4;
            label1.Text = "Prime number p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(98, 96, 51);
            label2.Location = new Point(43, 85);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Prime number q";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel3.Controls.Add(label1);
            roundedPanel3.Controls.Add(roundedPanel8);
            roundedPanel3.Controls.Add(label2);
            roundedPanel3.Controls.Add(label3);
            roundedPanel3.Controls.Add(btGenerate);
            roundedPanel3.Controls.Add(roundedPanel1);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.Location = new Point(21, 196);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(299, 221);
            roundedPanel3.TabIndex = 9;
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel8.Controls.Add(tbP);
            roundedPanel8.Controls.Add(textBox1);
            roundedPanel8.ForeColor = Color.Black;
            roundedPanel8.Location = new Point(31, 45);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(223, 37);
            roundedPanel8.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 243, 245);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(13, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 20);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(98, 96, 51);
            label3.Location = new Point(5, 3);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 37;
            label3.Text = "Prime number entry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(25, 24);
            label4.Name = "label4";
            label4.Size = new Size(254, 37);
            label4.TabIndex = 1;
            label4.Text = "RSA Demostration";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel2.Controls.Add(lbParameter);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(label9);
            roundedPanel2.Controls.Add(roundedPanel6);
            roundedPanel2.Controls.Add(roundedPanel7);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(label7);
            roundedPanel2.Controls.Add(btApply);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel5);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(345, 196);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(290, 377);
            roundedPanel2.TabIndex = 38;
            // 
            // lbParameter
            // 
            lbParameter.AutoSize = true;
            lbParameter.Location = new Point(109, 257);
            lbParameter.Name = "lbParameter";
            lbParameter.Size = new Size(161, 20);
            lbParameter.TabIndex = 42;
            lbParameter.Text = "Parameter not applied!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(43, 192);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 41;
            label8.Text = "Private key d";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(98, 96, 51);
            label9.Location = new Point(43, 140);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 40;
            label9.Text = "Public key e";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel6.Controls.Add(tbD);
            roundedPanel6.ForeColor = Color.Black;
            roundedPanel6.Location = new Point(31, 204);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(223, 37);
            roundedPanel6.TabIndex = 39;
            // 
            // tbD
            // 
            tbD.BackColor = Color.FromArgb(247, 243, 245);
            tbD.BorderStyle = BorderStyle.None;
            tbD.Location = new Point(13, 9);
            tbD.Name = "tbD";
            tbD.ReadOnly = true;
            tbD.Size = new Size(207, 20);
            tbD.TabIndex = 1;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel7.Controls.Add(tbE);
            roundedPanel7.ForeColor = Color.Black;
            roundedPanel7.Location = new Point(31, 151);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(223, 37);
            roundedPanel7.TabIndex = 38;
            // 
            // tbE
            // 
            tbE.BackColor = Color.FromArgb(247, 243, 245);
            tbE.BorderStyle = BorderStyle.None;
            tbE.Location = new Point(13, 9);
            tbE.Name = "tbE";
            tbE.Size = new Size(207, 20);
            tbE.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(43, 85);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 5;
            label5.Text = "phi(N) = (p-1)(q-1)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.FromArgb(98, 96, 51);
            label6.Location = new Point(5, 3);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 37;
            label6.Text = "RSA parameters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(43, 33);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 4;
            label7.Text = "RSA modulus N";
            // 
            // btApply
            // 
            btApply.BackColor = Color.White;
            btApply.BackgroundColor = Color.White;
            btApply.BorderColor = Color.FromArgb(121, 119, 112);
            btApply.BorderRadius = 18;
            btApply.BorderSize = 1;
            btApply.FlatStyle = FlatStyle.Flat;
            btApply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btApply.ForeColor = Color.FromArgb(98, 96, 51);
            btApply.Location = new Point(31, 303);
            btApply.Name = "btApply";
            btApply.Size = new Size(223, 47);
            btApply.TabIndex = 0;
            btApply.Text = "Apply parameter";
            btApply.TextColor = Color.FromArgb(98, 96, 51);
            btApply.UseVisualStyleBackColor = false;
            btApply.Click += btApply_Click;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel4.Controls.Add(tbPhi);
            roundedPanel4.ForeColor = Color.Black;
            roundedPanel4.Location = new Point(31, 97);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(223, 37);
            roundedPanel4.TabIndex = 3;
            // 
            // tbPhi
            // 
            tbPhi.BackColor = Color.FromArgb(247, 243, 245);
            tbPhi.BorderStyle = BorderStyle.None;
            tbPhi.Location = new Point(13, 9);
            tbPhi.Name = "tbPhi";
            tbPhi.ReadOnly = true;
            tbPhi.Size = new Size(207, 20);
            tbPhi.TabIndex = 1;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(247, 243, 245);
            roundedPanel5.Controls.Add(tbN);
            roundedPanel5.ForeColor = Color.Black;
            roundedPanel5.Location = new Point(31, 44);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(223, 37);
            roundedPanel5.TabIndex = 2;
            // 
            // tbN
            // 
            tbN.BackColor = Color.FromArgb(247, 243, 245);
            tbN.BorderStyle = BorderStyle.None;
            tbN.Location = new Point(13, 9);
            tbN.Name = "tbN";
            tbN.ReadOnly = true;
            tbN.Size = new Size(207, 20);
            tbN.TabIndex = 1;
            // 
            // addon_Round_Panel1
            // 
            addon_Round_Panel1.BackColor = Color.FromArgb(247, 243, 245);
            addon_Round_Panel1.Controls.Add(rtbInput);
            addon_Round_Panel1.Controls.Add(label12);
            addon_Round_Panel1.CornerRadius = 20;
            addon_Round_Panel1.ForeColor = Color.Black;
            addon_Round_Panel1.Location = new Point(21, 441);
            addon_Round_Panel1.Name = "addon_Round_Panel1";
            addon_Round_Panel1.Size = new Size(299, 132);
            addon_Round_Panel1.TabIndex = 39;
            // 
            // rtbInput
            // 
            rtbInput.BackColor = Color.FromArgb(247, 243, 245);
            rtbInput.BorderStyle = BorderStyle.None;
            rtbInput.Location = new Point(14, 29);
            rtbInput.Margin = new Padding(3, 4, 3, 4);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(270, 99);
            rtbInput.TabIndex = 38;
            rtbInput.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = Color.FromArgb(98, 96, 51);
            label12.Location = new Point(5, 3);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 37;
            label12.Text = "Input";
            // 
            // lbSegment
            // 
            lbSegment.AutoSize = true;
            lbSegment.BackColor = Color.Transparent;
            lbSegment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbSegment.ForeColor = Color.FromArgb(98, 96, 51);
            lbSegment.Location = new Point(33, 583);
            lbSegment.Name = "lbSegment";
            lbSegment.Size = new Size(75, 20);
            lbSegment.TabIndex = 41;
            lbSegment.Text = "Segments";
            // 
            // roundedPanel9
            // 
            roundedPanel9.BackColor = Color.White;
            roundedPanel9.Controls.Add(tbSegment);
            roundedPanel9.ForeColor = Color.Black;
            roundedPanel9.Location = new Point(21, 595);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(618, 37);
            roundedPanel9.TabIndex = 40;
            // 
            // tbSegment
            // 
            tbSegment.BackColor = Color.White;
            tbSegment.BorderStyle = BorderStyle.None;
            tbSegment.Location = new Point(13, 9);
            tbSegment.Name = "tbSegment";
            tbSegment.Size = new Size(597, 20);
            tbSegment.TabIndex = 1;
            // 
            // btEncrypt
            // 
            btEncrypt.BackColor = Color.FromArgb(231, 229, 174);
            btEncrypt.BackgroundColor = Color.FromArgb(231, 229, 174);
            btEncrypt.BorderColor = Color.FromArgb(121, 119, 112);
            btEncrypt.BorderRadius = 18;
            btEncrypt.BorderSize = 0;
            btEncrypt.FlatStyle = FlatStyle.Flat;
            btEncrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEncrypt.ForeColor = Color.FromArgb(98, 96, 51);
            btEncrypt.Location = new Point(510, 765);
            btEncrypt.Name = "btEncrypt";
            btEncrypt.Size = new Size(129, 47);
            btEncrypt.TabIndex = 42;
            btEncrypt.Text = "Encrypt";
            btEncrypt.TextColor = Color.FromArgb(98, 96, 51);
            btEncrypt.UseVisualStyleBackColor = false;
            btEncrypt.Click += btEncrypt_Click;
            // 
            // lbBase10
            // 
            lbBase10.AutoSize = true;
            lbBase10.BackColor = Color.Transparent;
            lbBase10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbBase10.ForeColor = Color.FromArgb(98, 96, 51);
            lbBase10.Location = new Point(33, 637);
            lbBase10.Name = "lbBase10";
            lbBase10.Size = new Size(232, 20);
            lbBase10.TabIndex = 44;
            lbBase10.Text = "Numbers input in base 10 format";
            // 
            // roundedPanel10
            // 
            roundedPanel10.BackColor = Color.White;
            roundedPanel10.Controls.Add(tbBase10);
            roundedPanel10.ForeColor = Color.Black;
            roundedPanel10.Location = new Point(21, 649);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Size = new Size(618, 37);
            roundedPanel10.TabIndex = 43;
            // 
            // tbBase10
            // 
            tbBase10.BackColor = Color.White;
            tbBase10.BorderStyle = BorderStyle.None;
            tbBase10.Location = new Point(13, 9);
            tbBase10.Name = "tbBase10";
            tbBase10.Size = new Size(597, 20);
            tbBase10.TabIndex = 1;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.BackColor = Color.Transparent;
            lbOutput.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbOutput.ForeColor = Color.FromArgb(98, 96, 51);
            lbOutput.Location = new Point(33, 697);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(79, 20);
            lbOutput.TabIndex = 46;
            lbOutput.Text = "Encrypted";
            // 
            // roundedPanel11
            // 
            roundedPanel11.BackColor = Color.White;
            roundedPanel11.Controls.Add(tbOutput);
            roundedPanel11.ForeColor = Color.Black;
            roundedPanel11.Location = new Point(21, 709);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(618, 37);
            roundedPanel11.TabIndex = 45;
            // 
            // tbOutput
            // 
            tbOutput.BackColor = Color.White;
            tbOutput.BorderStyle = BorderStyle.None;
            tbOutput.Location = new Point(13, 9);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(597, 20);
            tbOutput.TabIndex = 1;
            // 
            // btDecrypt
            // 
            btDecrypt.BackColor = Color.White;
            btDecrypt.BackgroundColor = Color.White;
            btDecrypt.BorderColor = Color.FromArgb(121, 119, 112);
            btDecrypt.BorderRadius = 18;
            btDecrypt.BorderSize = 0;
            btDecrypt.FlatStyle = FlatStyle.Flat;
            btDecrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDecrypt.ForeColor = Color.FromArgb(98, 96, 51);
            btDecrypt.Location = new Point(382, 765);
            btDecrypt.Name = "btDecrypt";
            btDecrypt.Size = new Size(129, 47);
            btDecrypt.TabIndex = 47;
            btDecrypt.Text = "Decrypt";
            btDecrypt.TextColor = Color.FromArgb(98, 96, 51);
            btDecrypt.UseVisualStyleBackColor = false;
            btDecrypt.Click += btDecrypt_Click;
            // 
            // addon_Round_Panel2
            // 
            addon_Round_Panel2.BackColor = Color.FromArgb(212, 231, 220);
            addon_Round_Panel2.Controls.Add(richTextBox1);
            addon_Round_Panel2.Controls.Add(pictureBox1);
            addon_Round_Panel2.CornerRadius = 10;
            addon_Round_Panel2.ForeColor = Color.Black;
            addon_Round_Panel2.Location = new Point(21, 76);
            addon_Round_Panel2.Name = "addon_Round_Panel2";
            addon_Round_Panel2.Size = new Size(615, 93);
            addon_Round_Panel2.TabIndex = 48;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(212, 231, 220);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(55, 13);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(541, 65);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Enter p, q, or generate them, input e, then click apply parameters, click \"Encrypt\" to encrypt your text. For decryption, paste the encrypted text into the input field and click \"Decrypt\".";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(16, 9);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(663, 832);
            Controls.Add(addon_Round_Panel2);
            Controls.Add(btDecrypt);
            Controls.Add(lbOutput);
            Controls.Add(roundedPanel11);
            Controls.Add(lbBase10);
            Controls.Add(roundedPanel10);
            Controls.Add(btEncrypt);
            Controls.Add(lbSegment);
            Controls.Add(roundedPanel9);
            Controls.Add(addon_Round_Panel1);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(label4);
            Name = "RSA";
            Text = "RSA";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            addon_Round_Panel1.ResumeLayout(false);
            addon_Round_Panel1.PerformLayout();
            roundedPanel9.ResumeLayout(false);
            roundedPanel9.PerformLayout();
            roundedPanel10.ResumeLayout(false);
            roundedPanel10.PerformLayout();
            roundedPanel11.ResumeLayout(false);
            roundedPanel11.PerformLayout();
            addon_Round_Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbP;
        private OutlinePanel roundedPanel1;
        private TextBox tbQ;
        private Label label1;
        private Label label2;
        private Custom_button btGenerate;
        private Addon_Round_Panel roundedPanel3;
        private Label label3;
        private Label label4;
        private Addon_Round_Panel roundedPanel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Custom_button btApply;
        private OutlinePanel roundedPanel4;
        private TextBox tbPhi;
        private OutlinePanel roundedPanel5;
        private TextBox tbN;
        private Label label8;
        private Label label9;
        private OutlinePanel roundedPanel6;
        private TextBox tbD;
        private OutlinePanel roundedPanel7;
        private TextBox tbE;
        private Label lbParameter;
        private OutlinePanel roundedPanel8;
        private TextBox textBox1;
        private Addon_Round_Panel addon_Round_Panel1;
        private RichTextBox rtbInput;
        private Label label12;
        private Label lbSegment;
        private OutlinePanel roundedPanel9;
        private TextBox tbSegment;
        private Custom_button btEncrypt;
        private Label lbBase10;
        private OutlinePanel roundedPanel10;
        private TextBox tbBase10;
        private Label lbOutput;
        private OutlinePanel roundedPanel11;
        private TextBox tbOutput;
        private Custom_button btDecrypt;
        private Addon_Round_Panel addon_Round_Panel2;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}
