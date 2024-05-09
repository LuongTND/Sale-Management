namespace SalesWinApp
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            tsmiManagement = new ToolStripMenuItem();
            tsmiOrders = new ToolStripMenuItem();
            tsmiMembers = new ToolStripMenuItem();
            tsmiProducts = new ToolStripMenuItem();
            tsmiReport = new ToolStripMenuItem();
            tsmiSales = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiManagement, tsmiReport, tsmiExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiManagement
            // 
            tsmiManagement.DropDownItems.AddRange(new ToolStripItem[] { tsmiOrders, tsmiMembers, tsmiProducts });
            tsmiManagement.Name = "tsmiManagement";
            tsmiManagement.Size = new Size(90, 20);
            tsmiManagement.Text = "Management";
            // 
            // tsmiOrders
            // 
            tsmiOrders.Name = "tsmiOrders";
            tsmiOrders.Size = new Size(124, 22);
            tsmiOrders.Text = "Orders";
            tsmiOrders.Click += tsmiOrders_Click;
            // 
            // tsmiMembers
            // 
            tsmiMembers.Name = "tsmiMembers";
            tsmiMembers.Size = new Size(124, 22);
            tsmiMembers.Text = "Members";
            tsmiMembers.Click += tsmiMembers_Click;
            // 
            // tsmiProducts
            // 
            tsmiProducts.Name = "tsmiProducts";
            tsmiProducts.Size = new Size(124, 22);
            tsmiProducts.Text = "Products";
            tsmiProducts.Click += tsmiProducts_Click;
            // 
            // tsmiReport
            // 
            tsmiReport.DropDownItems.AddRange(new ToolStripItem[] { tsmiSales });
            tsmiReport.Name = "tsmiReport";
            tsmiReport.Size = new Size(54, 20);
            tsmiReport.Text = "Report";
            // 
            // tsmiSales
            // 
            tsmiSales.Name = "tsmiSales";
            tsmiSales.Size = new Size(180, 22);
            tsmiSales.Text = "Sales";
            tsmiSales.Click += tsmiSales_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(38, 20);
            tsmiExit.Text = "Exit";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fstore";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiManagement;
        private ToolStripMenuItem tsmiMembers;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem tsmiOrders;
        private ToolStripMenuItem tsmiProducts;
        private ToolStripMenuItem tsmiReport;
        private ToolStripMenuItem tsmiSales;
        private ToolStripMenuItem tsmiExit;
    }
}