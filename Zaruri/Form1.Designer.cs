namespace DiceSimulation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNumDice = new System.Windows.Forms.TextBox();
            this.txtNumSides = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblNumDice = new System.Windows.Forms.Label();
            this.lblNumSides = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumDice
            // 
            this.txtNumDice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumDice.Location = new System.Drawing.Point(24, 44);
            this.txtNumDice.Name = "txtNumDice";
            this.txtNumDice.Size = new System.Drawing.Size(160, 29);
            this.txtNumDice.TabIndex = 0;
            this.txtNumDice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumSides
            // 
            this.txtNumSides.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumSides.Location = new System.Drawing.Point(24, 114);
            this.txtNumSides.Name = "txtNumSides";
            this.txtNumSides.Size = new System.Drawing.Size(160, 29);
            this.txtNumSides.TabIndex = 1;
            this.txtNumSides.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollDice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRollDice.ForeColor = System.Drawing.Color.White;
            this.btnRollDice.Location = new System.Drawing.Point(24, 194);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(160, 40);
            this.btnRollDice.TabIndex = 2;
            this.btnRollDice.Text = "Aruncă zarurile";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 21;
            this.lstResults.Location = new System.Drawing.Point(265, 20);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(173, 214);
            this.lstResults.TabIndex = 3;
            // 
            // lblNumDice
            // 
            this.lblNumDice.AutoSize = true;
            this.lblNumDice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumDice.Location = new System.Drawing.Point(20, 20);
            this.lblNumDice.Name = "lblNumDice";
            this.lblNumDice.Size = new System.Drawing.Size(239, 21);
            this.lblNumDice.TabIndex = 4;
            this.lblNumDice.Text = "Introduceți numărul de zaruri:";
            // 
            // lblNumSides
            // 
            this.lblNumSides.AutoSize = true;
            this.lblNumSides.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumSides.Location = new System.Drawing.Point(20, 90);
            this.lblNumSides.Name = "lblNumSides";
            this.lblNumSides.Size = new System.Drawing.Size(225, 21);
            this.lblNumSides.TabIndex = 5;
            this.lblNumSides.Text = "Introduceți numărul de fețe:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(20, 240);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 6;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblError);
            this.panelMain.Controls.Add(this.lstResults);
            this.panelMain.Controls.Add(this.btnRollDice);
            this.panelMain.Controls.Add(this.txtNumSides);
            this.panelMain.Controls.Add(this.txtNumDice);
            this.panelMain.Controls.Add(this.lblNumSides);
            this.panelMain.Controls.Add(this.lblNumDice);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(461, 291);
            this.panelMain.TabIndex = 0;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(485, 312);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Simulare Aruncare Zaruri";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumDice;
        private System.Windows.Forms.TextBox txtNumSides;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblNumDice;
        private System.Windows.Forms.Label lblNumSides;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panelMain;
    }
}
