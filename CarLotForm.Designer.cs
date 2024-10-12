namespace GenesisRossProject1
{
    partial class CarLotForm
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
            shopperInfoTXB = new TextBox();
            carLotLabel = new Label();
            addCarButton = new Button();
            removeCarButton = new Button();
            shopperInfoLabel = new Label();
            button1 = new Button();
            addShopperBTN = new Button();
            carLotListBox = new ListBox();
            SuspendLayout();
            // 
            // shopperInfoTXB
            // 
            shopperInfoTXB.Enabled = false;
            shopperInfoTXB.Location = new Point(527, 47);
            shopperInfoTXB.Multiline = true;
            shopperInfoTXB.Name = "shopperInfoTXB";
            shopperInfoTXB.ReadOnly = true;
            shopperInfoTXB.Size = new Size(325, 341);
            shopperInfoTXB.TabIndex = 1;
            // 
            // carLotLabel
            // 
            carLotLabel.AutoSize = true;
            carLotLabel.Font = new Font("Segoe UI", 14F);
            carLotLabel.Location = new Point(170, 9);
            carLotLabel.Name = "carLotLabel";
            carLotLabel.Size = new Size(72, 25);
            carLotLabel.TabIndex = 2;
            carLotLabel.Text = "Car Lot";
            // 
            // addCarButton
            // 
            addCarButton.Font = new Font("Segoe UI", 11F);
            addCarButton.Location = new Point(100, 394);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(94, 39);
            addCarButton.TabIndex = 3;
            addCarButton.Text = "Add Car";
            addCarButton.UseVisualStyleBackColor = true;
            addCarButton.Click += addCarButton_Click;
            // 
            // removeCarButton
            // 
            removeCarButton.Font = new Font("Segoe UI", 11F);
            removeCarButton.Location = new Point(94, 448);
            removeCarButton.Name = "removeCarButton";
            removeCarButton.Size = new Size(109, 39);
            removeCarButton.TabIndex = 4;
            removeCarButton.Text = "Purchase Car";
            removeCarButton.UseVisualStyleBackColor = true;
            removeCarButton.Click += purchaseCarButton_Click;
            // 
            // shopperInfoLabel
            // 
            shopperInfoLabel.AutoSize = true;
            shopperInfoLabel.Font = new Font("Segoe UI", 14F);
            shopperInfoLabel.Location = new Point(627, 19);
            shopperInfoLabel.Name = "shopperInfoLabel";
            shopperInfoLabel.Size = new Size(187, 25);
            shopperInfoLabel.TabIndex = 7;
            shopperInfoLabel.Text = "Shopper Information";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(70, 552);
            button1.Name = "button1";
            button1.Size = new Size(172, 39);
            button1.TabIndex = 6;
            button1.Text = "Inventory Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += inventoryBTN_Click;
            // 
            // addShopperBTN
            // 
            addShopperBTN.Font = new Font("Segoe UI", 11F);
            addShopperBTN.Location = new Point(94, 500);
            addShopperBTN.Name = "addShopperBTN";
            addShopperBTN.Size = new Size(109, 39);
            addShopperBTN.TabIndex = 5;
            addShopperBTN.Text = "Add Shopper";
            addShopperBTN.UseVisualStyleBackColor = true;
            addShopperBTN.Click += addShopperBTN_Click;
            // 
            // carLotListBox
            // 
            carLotListBox.FormattingEnabled = true;
            carLotListBox.ItemHeight = 15;
            carLotListBox.Location = new Point(70, 41);
            carLotListBox.Name = "carLotListBox";
            carLotListBox.Size = new Size(325, 349);
            carLotListBox.TabIndex = 8;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 603);
            Controls.Add(carLotListBox);
            Controls.Add(addShopperBTN);
            Controls.Add(button1);
            Controls.Add(shopperInfoLabel);
            Controls.Add(removeCarButton);
            Controls.Add(addCarButton);
            Controls.Add(carLotLabel);
            Controls.Add(shopperInfoTXB);
            Name = "CarLotForm";
            Text = "CarLotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox shopperInfoTXB;
        private Label carLotLabel;
        private Button addCarButton;
        private Button removeCarButton;
        private Label shopperInfoLabel;
        private Button button1;
        private Button addShopperBTN;
        private ListBox carLotListBox;
    }
}
