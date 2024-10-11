namespace GenesisRossProject1.View
{
    partial class CarForm
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
            makeLabel = new Label();
            modelLabel = new Label();
            priceLabel = new Label();
            mpgLabel = new Label();
            makeTXB = new TextBox();
            modelTXB = new TextBox();
            mpgTXB = new TextBox();
            priceTXB = new TextBox();
            SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new Font("Segoe UI", 14F);
            makeLabel.Location = new Point(40, 92);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(58, 25);
            makeLabel.TabIndex = 0;
            makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Segoe UI", 14F);
            modelLabel.Location = new Point(40, 162);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(66, 25);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 14F);
            priceLabel.Location = new Point(40, 294);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(54, 25);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price";
            // 
            // mpgLabel
            // 
            mpgLabel.AutoSize = true;
            mpgLabel.Font = new Font("Segoe UI", 14F);
            mpgLabel.Location = new Point(40, 230);
            mpgLabel.Name = "mpgLabel";
            mpgLabel.Size = new Size(207, 25);
            mpgLabel.TabIndex = 3;
            mpgLabel.Text = "MPG (Miles Per Gallon)";
            // 
            // makeTXB
            // 
            makeTXB.Location = new Point(272, 92);
            makeTXB.Name = "makeTXB";
            makeTXB.Size = new Size(123, 23);
            makeTXB.TabIndex = 4;
            // 
            // modelTXB
            // 
            modelTXB.Location = new Point(272, 162);
            modelTXB.Name = "modelTXB";
            modelTXB.Size = new Size(123, 23);
            modelTXB.TabIndex = 5;
            // 
            // mpgTXB
            // 
            mpgTXB.Location = new Point(272, 235);
            mpgTXB.Name = "mpgTXB";
            mpgTXB.Size = new Size(123, 23);
            mpgTXB.TabIndex = 6;
            // 
            // priceTXB
            // 
            priceTXB.Location = new Point(272, 294);
            priceTXB.Name = "priceTXB";
            priceTXB.Size = new Size(123, 23);
            priceTXB.TabIndex = 7;
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 491);
            Controls.Add(priceTXB);
            Controls.Add(mpgTXB);
            Controls.Add(modelTXB);
            Controls.Add(makeTXB);
            Controls.Add(mpgLabel);
            Controls.Add(priceLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeLabel);
            Name = "CarForm";
            Text = "CarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeLabel;
        private Label modelLabel;
        private Label priceLabel;
        private Label mpgLabel;
        private TextBox makeTXB;
        private TextBox modelTXB;
        private TextBox mpgTXB;
        private TextBox priceTXB;
    }
}