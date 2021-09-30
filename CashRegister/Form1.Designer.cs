namespace CashRegister
{
    partial class SushiDojo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SushiDojo));
            this.sushiName = new System.Windows.Forms.Label();
            this.caliRoll = new System.Windows.Forms.Label();
            this.spicyCaliRoll = new System.Windows.Forms.Label();
            this.avoCucRoll = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.caliRollText = new System.Windows.Forms.TextBox();
            this.sCaliRollText = new System.Windows.Forms.TextBox();
            this.avoCucRollText = new System.Windows.Forms.TextBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalPriceLabel = new System.Windows.Forms.Label();
            this.taxPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.tenderedButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changePriceLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.printedReceiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sushiName
            // 
            this.sushiName.BackColor = System.Drawing.Color.DarkOrange;
            this.sushiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushiName.ForeColor = System.Drawing.Color.Black;
            this.sushiName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sushiName.Location = new System.Drawing.Point(-2, -1);
            this.sushiName.Name = "sushiName";
            this.sushiName.Size = new System.Drawing.Size(923, 85);
            this.sushiName.TabIndex = 0;
            this.sushiName.Text = "The Sushi Dojo";
            this.sushiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caliRoll
            // 
            this.caliRoll.AutoSize = true;
            this.caliRoll.Location = new System.Drawing.Point(35, 109);
            this.caliRoll.Name = "caliRoll";
            this.caliRoll.Size = new System.Drawing.Size(162, 16);
            this.caliRoll.TabIndex = 1;
            this.caliRoll.Text = "Number of California Rolls";
            // 
            // spicyCaliRoll
            // 
            this.spicyCaliRoll.AutoSize = true;
            this.spicyCaliRoll.Location = new System.Drawing.Point(35, 150);
            this.spicyCaliRoll.Name = "spicyCaliRoll";
            this.spicyCaliRoll.Size = new System.Drawing.Size(199, 16);
            this.spicyCaliRoll.TabIndex = 1;
            this.spicyCaliRoll.Text = "Number of Spicy California Rolls";
            // 
            // avoCucRoll
            // 
            this.avoCucRoll.AutoSize = true;
            this.avoCucRoll.Location = new System.Drawing.Point(35, 191);
            this.avoCucRoll.Name = "avoCucRoll";
            this.avoCucRoll.Size = new System.Drawing.Size(251, 16);
            this.avoCucRoll.TabIndex = 1;
            this.avoCucRoll.Text = "Number of Avocado and Cucumber Rolls";
            // 
            // calculateTotal
            // 
            this.calculateTotal.Location = new System.Drawing.Point(140, 232);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(178, 33);
            this.calculateTotal.TabIndex = 2;
            this.calculateTotal.Text = "Calculate Totals";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // caliRollText
            // 
            this.caliRollText.Location = new System.Drawing.Point(316, 109);
            this.caliRollText.Name = "caliRollText";
            this.caliRollText.Size = new System.Drawing.Size(100, 22);
            this.caliRollText.TabIndex = 3;
            // 
            // sCaliRollText
            // 
            this.sCaliRollText.Location = new System.Drawing.Point(316, 147);
            this.sCaliRollText.Name = "sCaliRollText";
            this.sCaliRollText.Size = new System.Drawing.Size(100, 22);
            this.sCaliRollText.TabIndex = 3;
            // 
            // avoCucRollText
            // 
            this.avoCucRollText.Location = new System.Drawing.Point(316, 185);
            this.avoCucRollText.Name = "avoCucRollText";
            this.avoCucRollText.Size = new System.Drawing.Size(100, 22);
            this.avoCucRollText.TabIndex = 3;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(35, 297);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subTotalLabel.TabIndex = 4;
            this.subTotalLabel.Text = "Subtotal";
            this.subTotalLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(35, 319);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(145, 22);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "Tax";
            this.taxLabel.Visible = false;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(35, 341);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(130, 22);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total";
            this.totalLabel.Visible = false;
            // 
            // subtotalPriceLabel
            // 
            this.subtotalPriceLabel.AutoSize = true;
            this.subtotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalPriceLabel.Location = new System.Drawing.Point(242, 300);
            this.subtotalPriceLabel.Name = "subtotalPriceLabel";
            this.subtotalPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.subtotalPriceLabel.TabIndex = 5;
            // 
            // taxPriceLabel
            // 
            this.taxPriceLabel.AutoSize = true;
            this.taxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPriceLabel.Location = new System.Drawing.Point(242, 322);
            this.taxPriceLabel.Name = "taxPriceLabel";
            this.taxPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.taxPriceLabel.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(242, 344);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.totalPriceLabel.TabIndex = 5;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(35, 399);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(100, 23);
            this.tenderedLabel.TabIndex = 6;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.Visible = false;
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(186, 400);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(100, 22);
            this.tenderedText.TabIndex = 3;
            this.tenderedText.Visible = false;
            // 
            // tenderedButton
            // 
            this.tenderedButton.Enabled = false;
            this.tenderedButton.Location = new System.Drawing.Point(78, 453);
            this.tenderedButton.Name = "tenderedButton";
            this.tenderedButton.Size = new System.Drawing.Size(178, 26);
            this.tenderedButton.TabIndex = 2;
            this.tenderedButton.Text = "Calculate Change";
            this.tenderedButton.UseVisualStyleBackColor = true;
            this.tenderedButton.Visible = false;
            this.tenderedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(34, 496);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 23);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change";
            this.changeLabel.Visible = false;
            // 
            // changePriceLabel
            // 
            this.changePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePriceLabel.Location = new System.Drawing.Point(156, 496);
            this.changePriceLabel.Name = "changePriceLabel";
            this.changePriceLabel.Size = new System.Drawing.Size(100, 23);
            this.changePriceLabel.TabIndex = 6;
            this.changePriceLabel.Visible = false;
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Location = new System.Drawing.Point(78, 560);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(178, 26);
            this.receiptButton.TabIndex = 2;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // printedReceiptLabel
            // 
            this.printedReceiptLabel.BackColor = System.Drawing.Color.White;
            this.printedReceiptLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedReceiptLabel.Location = new System.Drawing.Point(451, 109);
            this.printedReceiptLabel.Name = "printedReceiptLabel";
            this.printedReceiptLabel.Size = new System.Drawing.Size(442, 410);
            this.printedReceiptLabel.TabIndex = 7;
            this.printedReceiptLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Enabled = false;
            this.newOrderButton.Location = new System.Drawing.Point(566, 547);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(222, 39);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CashRegister.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(271, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CashRegister.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(471, 592);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // SushiDojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(921, 696);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printedReceiptLabel);
            this.Controls.Add(this.changePriceLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.taxPriceLabel);
            this.Controls.Add(this.subtotalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.avoCucRollText);
            this.Controls.Add(this.sCaliRollText);
            this.Controls.Add(this.caliRollText);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.tenderedButton);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.avoCucRoll);
            this.Controls.Add(this.spicyCaliRoll);
            this.Controls.Add(this.caliRoll);
            this.Controls.Add(this.sushiName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SushiDojo";
            this.Text = "The Sushi Dojo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sushiName;
        private System.Windows.Forms.Label caliRoll;
        private System.Windows.Forms.Label spicyCaliRoll;
        private System.Windows.Forms.Label avoCucRoll;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.TextBox caliRollText;
        private System.Windows.Forms.TextBox sCaliRollText;
        private System.Windows.Forms.TextBox avoCucRollText;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalPriceLabel;
        private System.Windows.Forms.Label taxPriceLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Button tenderedButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changePriceLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label printedReceiptLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

