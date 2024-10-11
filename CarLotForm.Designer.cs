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
            carListView = new ListView();
            carLotInfoTXB = new TextBox();
            carLotLabel = new Label();
            addCarButton = new Button();
            removeCarButton = new Button();
            shopperInfoLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // carListView
            // 
            carListView.Location = new Point(33, 47);
            carListView.Name = "carListView";
            carListView.Size = new Size(270, 341);
            carListView.TabIndex = 0;
            carListView.UseCompatibleStateImageBehavior = false;
            // 
            // carLotInfoTXB
            // 
            carLotInfoTXB.Enabled = false;
            carLotInfoTXB.Location = new Point(527, 47);
            carLotInfoTXB.Multiline = true;
            carLotInfoTXB.Name = "carLotInfoTXB";
            carLotInfoTXB.ReadOnly = true;
            carLotInfoTXB.Size = new Size(325, 341);
            carLotInfoTXB.TabIndex = 1;
            // 
            // carLotLabel
            // 
            carLotLabel.AutoSize = true;
            carLotLabel.Font = new Font("Segoe UI", 14F);
            carLotLabel.Location = new Point(122, 19);
            carLotLabel.Name = "carLotLabel";
            carLotLabel.Size = new Size(72, 25);
            carLotLabel.TabIndex = 2;
            carLotLabel.Text = "Car Lot";
            // 
            // addCarButton
            // 
            addCarButton.Font = new Font("Segoe UI", 11F);
            addCarButton.Location = new Point(94, 394);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(94, 39);
            addCarButton.TabIndex = 3;
            addCarButton.Text = "Add Car";
            addCarButton.UseVisualStyleBackColor = true;
            // 
            // removeCarButton
            // 
            removeCarButton.Font = new Font("Segoe UI", 11F);
            removeCarButton.Location = new Point(85, 439);
            removeCarButton.Name = "removeCarButton";
            removeCarButton.Size = new Size(109, 39);
            removeCarButton.TabIndex = 4;
            removeCarButton.Text = "Purchase Car";
            removeCarButton.UseVisualStyleBackColor = true;
            // 
            // shopperInfoLabel
            // 
            shopperInfoLabel.AutoSize = true;
            shopperInfoLabel.Font = new Font("Segoe UI", 14F);
            shopperInfoLabel.Location = new Point(627, 19);
            shopperInfoLabel.Name = "shopperInfoLabel";
            shopperInfoLabel.Size = new Size(187, 25);
            shopperInfoLabel.TabIndex = 5;
            shopperInfoLabel.Text = "Shopper Information";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(55, 484);
            button1.Name = "button1";
            button1.Size = new Size(172, 39);
            button1.TabIndex = 6;
            button1.Text = "Inventory Information";
            button1.UseVisualStyleBackColor = true;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 603);
            Controls.Add(button1);
            Controls.Add(shopperInfoLabel);
            Controls.Add(removeCarButton);
            Controls.Add(addCarButton);
            Controls.Add(carLotLabel);
            Controls.Add(carLotInfoTXB);
            Controls.Add(carListView);
            Name = "CarLotForm";
            Text = "CarLotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView carListView;
        private TextBox carLotInfoTXB;
        private Label carLotLabel;
        private Button addCarButton;
        private Button removeCarButton;
        private Label shopperInfoLabel;
        private Button button1;
    }
}
