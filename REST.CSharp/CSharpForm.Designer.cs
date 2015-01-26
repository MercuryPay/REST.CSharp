namespace REST.CSharp
{
    partial class CSharpForm
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
            this.txtMerchantId = new System.Windows.Forms.TextBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcessReturnFromResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MerchantId:";
            // 
            // txtMerchantId
            // 
            this.txtMerchantId.Location = new System.Drawing.Point(96, 16);
            this.txtMerchantId.Name = "txtMerchantId";
            this.txtMerchantId.Size = new System.Drawing.Size(215, 20);
            this.txtMerchantId.TabIndex = 1;
            this.txtMerchantId.Text = "019588466313922";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(96, 70);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(215, 20);
            this.txtEndPoint.TabIndex = 3;
            this.txtEndPoint.Text = "https://w1.mercurycert.net/PaymentsAPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EndPoint:";
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(16, 119);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(256, 255);
            this.txtRequest.TabIndex = 4;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(310, 119);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(256, 255);
            this.txtResponse.TabIndex = 5;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(389, 48);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(177, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process Credit Sale";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Request:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(307, 103);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 9;
            this.lblResponse.Text = "Response:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "xyz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // btnProcessReturnFromResponse
            // 
            this.btnProcessReturnFromResponse.Location = new System.Drawing.Point(389, 77);
            this.btnProcessReturnFromResponse.Name = "btnProcessReturnFromResponse";
            this.btnProcessReturnFromResponse.Size = new System.Drawing.Size(177, 23);
            this.btnProcessReturnFromResponse.TabIndex = 12;
            this.btnProcessReturnFromResponse.Text = "Process Return From Response";
            this.btnProcessReturnFromResponse.UseVisualStyleBackColor = true;
            this.btnProcessReturnFromResponse.Click += new System.EventHandler(this.btnProcessReturnFromResponse_Click);
            // 
            // CSharpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 434);
            this.Controls.Add(this.btnProcessReturnFromResponse);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMerchantId);
            this.Controls.Add(this.label1);
            this.Name = "CSharpForm";
            this.Text = "REST.CSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMerchantId;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcessReturnFromResponse;
    }
}

