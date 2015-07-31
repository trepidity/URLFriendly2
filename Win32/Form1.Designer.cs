namespace Win32
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
            this.label1 = new System.Windows.Forms.Label();
            this.protocolTextBox = new System.Windows.Forms.TextBox();
            this.identityProviderTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SAML1 = new System.Windows.Forms.RadioButton();
            this.SAML2 = new System.Windows.Forms.RadioButton();
            this.idpInitiated = new System.Windows.Forms.RadioButton();
            this.spInitiated = new System.Windows.Forms.RadioButton();
            this.serviceProviderID = new System.Windows.Forms.TextBox();
            this.targetURLTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encodeDecodeTextBox = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Protocol";
            // 
            // protocolTextBox
            // 
            this.protocolTextBox.Location = new System.Drawing.Point(16, 29);
            this.protocolTextBox.Name = "protocolTextBox";
            this.protocolTextBox.Size = new System.Drawing.Size(40, 20);
            this.protocolTextBox.TabIndex = 1;
            this.protocolTextBox.Text = "https";
            this.protocolTextBox.WordWrap = false;
            // 
            // identityProviderTextBox
            // 
            this.identityProviderTextBox.Location = new System.Drawing.Point(62, 29);
            this.identityProviderTextBox.Name = "identityProviderTextBox";
            this.identityProviderTextBox.Size = new System.Drawing.Size(248, 20);
            this.identityProviderTextBox.TabIndex = 2;
            this.identityProviderTextBox.Text = "host.domain.com";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(316, 28);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(40, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "8443";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "Identity Provider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // SAML1
            // 
            this.SAML1.AutoSize = true;
            this.SAML1.Location = new System.Drawing.Point(6, 19);
            this.SAML1.Name = "SAML1";
            this.SAML1.Size = new System.Drawing.Size(63, 17);
            this.SAML1.TabIndex = 6;
            this.SAML1.TabStop = true;
            this.SAML1.Text = "SAML 1";
            this.SAML1.UseVisualStyleBackColor = true;
            // 
            // SAML2
            // 
            this.SAML2.AutoSize = true;
            this.SAML2.Checked = true;
            this.SAML2.Location = new System.Drawing.Point(95, 19);
            this.SAML2.Name = "SAML2";
            this.SAML2.Size = new System.Drawing.Size(63, 17);
            this.SAML2.TabIndex = 7;
            this.SAML2.TabStop = true;
            this.SAML2.Text = "SAML 2";
            this.SAML2.UseVisualStyleBackColor = true;
            // 
            // idpInitiated
            // 
            this.idpInitiated.AutoSize = true;
            this.idpInitiated.Checked = true;
            this.idpInitiated.Location = new System.Drawing.Point(6, 22);
            this.idpInitiated.Name = "idpInitiated";
            this.idpInitiated.Size = new System.Drawing.Size(83, 17);
            this.idpInitiated.TabIndex = 8;
            this.idpInitiated.TabStop = true;
            this.idpInitiated.Text = "IDP Initiated";
            this.idpInitiated.UseVisualStyleBackColor = true;
            // 
            // spInitiated
            // 
            this.spInitiated.AutoSize = true;
            this.spInitiated.Location = new System.Drawing.Point(95, 22);
            this.spInitiated.Name = "spInitiated";
            this.spInitiated.Size = new System.Drawing.Size(79, 17);
            this.spInitiated.TabIndex = 9;
            this.spInitiated.TabStop = true;
            this.spInitiated.Text = "SP Initiated";
            this.spInitiated.UseVisualStyleBackColor = true;
            // 
            // serviceProviderID
            // 
            this.serviceProviderID.Location = new System.Drawing.Point(12, 122);
            this.serviceProviderID.Name = "serviceProviderID";
            this.serviceProviderID.Size = new System.Drawing.Size(340, 20);
            this.serviceProviderID.TabIndex = 10;
            // 
            // targetURLTextBox
            // 
            this.targetURLTextBox.Location = new System.Drawing.Point(12, 165);
            this.targetURLTextBox.Name = "targetURLTextBox";
            this.targetURLTextBox.Size = new System.Drawing.Size(340, 20);
            this.targetURLTextBox.TabIndex = 11;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(240, 191);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 23);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate URL";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.OnClick_GenerateURL_Button);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Service Provider ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Target URL";
            // 
            // encodeDecodeTextBox
            // 
            this.encodeDecodeTextBox.Location = new System.Drawing.Point(14, 351);
            this.encodeDecodeTextBox.Multiline = true;
            this.encodeDecodeTextBox.Name = "encodeDecodeTextBox";
            this.encodeDecodeTextBox.Size = new System.Drawing.Size(730, 46);
            this.encodeDecodeTextBox.TabIndex = 16;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(15, 432);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(730, 97);
            this.resultsTextBox.TabIndex = 17;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(669, 403);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 18;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.OnClick_EncodeButton);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(588, 403);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 19;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.OnClick_DecodeButton);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "URL encode or decode a string";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Results";
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesTextBox.Enabled = false;
            this.messagesTextBox.Location = new System.Drawing.Point(15, 221);
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.Size = new System.Drawing.Size(336, 13);
            this.messagesTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SAML2);
            this.groupBox1.Controls.Add(this.SAML1);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 51);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAML Version";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idpInitiated);
            this.groupBox2.Controls.Add(this.spInitiated);
            this.groupBox2.Location = new System.Drawing.Point(205, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 53);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Federation Initiated by";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.messagesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.encodeDecodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.targetURLTextBox);
            this.Controls.Add(this.serviceProviderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.identityProviderTextBox);
            this.Controls.Add(this.protocolTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "URL Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox protocolTextBox;
        private System.Windows.Forms.TextBox identityProviderTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton SAML1;
        private System.Windows.Forms.RadioButton SAML2;
        private System.Windows.Forms.RadioButton idpInitiated;
        private System.Windows.Forms.RadioButton spInitiated;
        private System.Windows.Forms.TextBox serviceProviderID;
        private System.Windows.Forms.TextBox targetURLTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encodeDecodeTextBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

