namespace GenesisRossProject1.View
{
    partial class ShopperForm
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
            nameLabel = new Label();
            moneyAvailableLabel = new Label();
            moneyAvailableTXB = new TextBox();
            nameTXB = new TextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14F);
            nameLabel.Location = new Point(25, 95);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // moneyAvailableLabel
            // 
            moneyAvailableLabel.AutoSize = true;
            moneyAvailableLabel.Font = new Font("Segoe UI", 14F);
            moneyAvailableLabel.Location = new Point(25, 180);
            moneyAvailableLabel.Name = "moneyAvailableLabel";
            moneyAvailableLabel.Size = new Size(156, 25);
            moneyAvailableLabel.TabIndex = 1;
            moneyAvailableLabel.Text = "Money Available:";
            // 
            // moneyAvailableTXB
            // 
            moneyAvailableTXB.Location = new Point(200, 180);
            moneyAvailableTXB.Name = "moneyAvailableTXB";
            moneyAvailableTXB.Size = new Size(130, 23);
            moneyAvailableTXB.TabIndex = 2;
            // 
            // nameTXB
            // 
            nameTXB.Location = new Point(200, 100);
            nameTXB.Name = "nameTXB";
            nameTXB.Size = new Size(130, 23);
            nameTXB.TabIndex = 3;
            // 
            // ShopperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 370);
            Controls.Add(nameTXB);
            Controls.Add(moneyAvailableTXB);
            Controls.Add(moneyAvailableLabel);
            Controls.Add(nameLabel);
            Name = "ShopperForm";
            Text = "ShopperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label moneyAvailableLabel;
        private TextBox moneyAvailableTXB;
        private TextBox nameTXB;
    }
}