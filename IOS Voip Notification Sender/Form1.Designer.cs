namespace IOS_Voip_Notification_Sender
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtPayload = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(258, 369);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(229, 69);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(35, 50);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(719, 22);
            this.txtToken.TabIndex = 1;
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(35, 117);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(719, 246);
            this.txtPayload.TabIndex = 2;
            this.txtPayload.Text = "{\"exam\":{\"id\":1,\"refStatus\":1}}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pushkit Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payload Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayload);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Voip Push Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.RichTextBox txtPayload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

