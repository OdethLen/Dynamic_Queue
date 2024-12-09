namespace Dynamic_Queue
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
            label1 = new Label();
            txtNumber = new TextBox();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeek = new Button();
            btnClear = new Button();
            lblCount = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 99);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(173, 96);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(116, 142);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(97, 33);
            btnEnqueue.TabIndex = 2;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(116, 181);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(97, 33);
            btnDequeue.TabIndex = 3;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(116, 220);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(97, 33);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(219, 142);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 33);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(352, 122);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(16, 15);
            lblCount.TabIndex = 6;
            lblCount.Text = "...";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(219, 181);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 33);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 294);
            Controls.Add(btnBack);
            Controls.Add(lblCount);
            Controls.Add(btnClear);
            Controls.Add(btnPeek);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeek;
        private Button btnClear;
        private Label lblCount;
        private Button btnBack;
    }
}
