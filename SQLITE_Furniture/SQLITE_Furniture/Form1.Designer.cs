namespace SQLITE_Furniture
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
            this.buttonREMOVE = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.furnitureTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBoxSelectToRemove = new System.Windows.Forms.ListBox();
            this.labelNumberOfItems = new System.Windows.Forms.Label();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonREMOVE
            // 
            this.buttonREMOVE.Location = new System.Drawing.Point(49, 32);
            this.buttonREMOVE.Name = "buttonREMOVE";
            this.buttonREMOVE.Size = new System.Drawing.Size(224, 23);
            this.buttonREMOVE.TabIndex = 0;
            this.buttonREMOVE.Text = "REMOVE";
            this.buttonREMOVE.UseVisualStyleBackColor = true;
            this.buttonREMOVE.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(339, 141);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(263, 23);
            this.buttonADD.TabIndex = 1;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.Location = new System.Drawing.Point(339, 242);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(263, 23);
            this.buttonSEARCH.TabIndex = 2;
            this.buttonSEARCH.Text = "SEARCH";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            // 
            // furnitureTextBox
            // 
            this.furnitureTextBox.Location = new System.Drawing.Point(431, 32);
            this.furnitureTextBox.Name = "furnitureTextBox";
            this.furnitureTextBox.Size = new System.Drawing.Size(171, 22);
            this.furnitureTextBox.TabIndex = 3;
            this.furnitureTextBox.TextChanged += new System.EventHandler(this.furnitureTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(431, 77);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(171, 22);
            this.priceTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "FURNITURE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRICE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 22);
            this.textBox3.TabIndex = 7;
            // 
            // listBoxSelectToRemove
            // 
            this.listBoxSelectToRemove.FormattingEnabled = true;
            this.listBoxSelectToRemove.ItemHeight = 16;
            this.listBoxSelectToRemove.Location = new System.Drawing.Point(49, 72);
            this.listBoxSelectToRemove.Name = "listBoxSelectToRemove";
            this.listBoxSelectToRemove.Size = new System.Drawing.Size(224, 132);
            this.listBoxSelectToRemove.TabIndex = 8;
            this.listBoxSelectToRemove.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelNumberOfItems
            // 
            this.labelNumberOfItems.AutoSize = true;
            this.labelNumberOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfItems.Location = new System.Drawing.Point(140, 219);
            this.labelNumberOfItems.Name = "labelNumberOfItems";
            this.labelNumberOfItems.Size = new System.Drawing.Size(49, 18);
            this.labelNumberOfItems.TabIndex = 9;
            this.labelNumberOfItems.Text = "items";
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 16;
            this.listBoxDetails.Location = new System.Drawing.Point(49, 252);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(224, 132);
            this.listBoxDetails.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 411);
            this.Controls.Add(this.listBoxDetails);
            this.Controls.Add(this.labelNumberOfItems);
            this.Controls.Add(this.listBoxSelectToRemove);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.furnitureTextBox);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonREMOVE);
            this.Name = "Form1";
            this.Text = "SQLITE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonREMOVE;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.TextBox furnitureTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBoxSelectToRemove;
        private System.Windows.Forms.Label labelNumberOfItems;
        private System.Windows.Forms.ListBox listBoxDetails;
    }
}

