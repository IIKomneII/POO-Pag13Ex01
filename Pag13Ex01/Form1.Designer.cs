namespace Pag13Ex01
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOp = new ComboBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(125, 113);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            txtNum1.KeyPress += txtNum1_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(532, 113);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // cmbOp
            // 
            cmbOp.FormattingEnabled = true;
            cmbOp.Items.AddRange(new object[] { "+", "-", "x", "/" });
            cmbOp.Location = new Point(327, 168);
            cmbOp.Name = "cmbOp";
            cmbOp.Size = new Size(121, 23);
            cmbOp.TabIndex = 2;
            cmbOp.Text = "Operação";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(337, 263);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 3;
            txtResult.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(cmbOp);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOp;
        private TextBox txtResult;
    }
}
