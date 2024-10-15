namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.components = new System.ComponentModel.Container();
            this.item = new System.Windows.Forms.Label();
            this.itemTB = new System.Windows.Forms.TextBox();
            this.computeBT = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.Label();
            this.discountTB = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.paymentTB = new System.Windows.Forms.TextBox();
            this.submitBT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(3, 25);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(32, 16);
            this.item.TabIndex = 0;
            this.item.Text = "item";
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // itemTB
            // 
            this.itemTB.Location = new System.Drawing.Point(6, 44);
            this.itemTB.Name = "itemTB";
            this.itemTB.Size = new System.Drawing.Size(147, 22);
            this.itemTB.TabIndex = 1;
            // 
            // computeBT
            // 
            this.computeBT.Location = new System.Drawing.Point(108, 134);
            this.computeBT.Name = "computeBT";
            this.computeBT.Size = new System.Drawing.Size(89, 23);
            this.computeBT.TabIndex = 2;
            this.computeBT.Text = "Compute";
            this.computeBT.UseVisualStyleBackColor = true;
            this.computeBT.Click += new System.EventHandler(this.computeBT_Click);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(173, 25);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(69, 16);
            this.discount.TabIndex = 3;
            this.discount.Text = "discount%";
            // 
            // discountTB
            // 
            this.discountTB.Location = new System.Drawing.Point(171, 44);
            this.discountTB.Name = "discountTB";
            this.discountTB.Size = new System.Drawing.Size(120, 22);
            this.discountTB.TabIndex = 4;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(3, 89);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 16);
            this.price.TabIndex = 5;
            this.price.Text = "price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(53, 89);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 22);
            this.priceTB.TabIndex = 6;
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(229, 89);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(62, 22);
            this.quantityTB.TabIndex = 8;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(168, 89);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "Quantity";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(70, 168);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(79, 16);
            this.Total.TabIndex = 9;
            this.Total.Text = "total amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(6, 211);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(59, 16);
            this.payment.TabIndex = 11;
            this.payment.Text = "payment";
            // 
            // paymentTB
            // 
            this.paymentTB.Location = new System.Drawing.Point(79, 211);
            this.paymentTB.Name = "paymentTB";
            this.paymentTB.Size = new System.Drawing.Size(100, 22);
            this.paymentTB.TabIndex = 12;
            // 
            // submitBT
            // 
            this.submitBT.Location = new System.Drawing.Point(204, 211);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(75, 23);
            this.submitBT.TabIndex = 13;
            this.submitBT.Text = "submit";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 15;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(62, 260);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(52, 16);
            this.change.TabIndex = 14;
            this.change.Text = "change";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.change);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.paymentTB);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.price);
            this.Controls.Add(this.discountTB);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.computeBT);
            this.Controls.Add(this.itemTB);
            this.Controls.Add(this.item);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "PurchaseDiscountedItem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label item;
        private System.Windows.Forms.TextBox itemTB;
        private System.Windows.Forms.Button computeBT;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox discountTB;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.TextBox paymentTB;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}

