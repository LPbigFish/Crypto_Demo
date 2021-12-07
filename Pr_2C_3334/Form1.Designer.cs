
namespace Pr_2C_3334
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
            this.MineBT = new System.Windows.Forms.Button();
            this.BlockIdTB = new System.Windows.Forms.TextBox();
            this.DataTB = new System.Windows.Forms.RichTextBox();
            this.PrevBlockTB = new System.Windows.Forms.TextBox();
            this.NonceTB = new System.Windows.Forms.TextBox();
            this.ThisBlockTB = new System.Windows.Forms.TextBox();
            this.NextBT = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BlockWrite = new System.Windows.Forms.TabPage();
            this.BlockExplorer = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.BlockWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // MineBT
            // 
            this.MineBT.Location = new System.Drawing.Point(6, 503);
            this.MineBT.Name = "MineBT";
            this.MineBT.Size = new System.Drawing.Size(75, 23);
            this.MineBT.TabIndex = 0;
            this.MineBT.Text = "Mine";
            this.MineBT.UseVisualStyleBackColor = true;
            this.MineBT.Click += new System.EventHandler(this.MineBT_Click);
            // 
            // BlockIdTB
            // 
            this.BlockIdTB.Location = new System.Drawing.Point(6, 6);
            this.BlockIdTB.Name = "BlockIdTB";
            this.BlockIdTB.ReadOnly = true;
            this.BlockIdTB.Size = new System.Drawing.Size(756, 20);
            this.BlockIdTB.TabIndex = 1;
            // 
            // DataTB
            // 
            this.DataTB.Location = new System.Drawing.Point(6, 32);
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(756, 384);
            this.DataTB.TabIndex = 2;
            this.DataTB.Text = "";
            // 
            // PrevBlockTB
            // 
            this.PrevBlockTB.Location = new System.Drawing.Point(6, 448);
            this.PrevBlockTB.Name = "PrevBlockTB";
            this.PrevBlockTB.ReadOnly = true;
            this.PrevBlockTB.Size = new System.Drawing.Size(756, 20);
            this.PrevBlockTB.TabIndex = 3;
            // 
            // NonceTB
            // 
            this.NonceTB.Location = new System.Drawing.Point(6, 422);
            this.NonceTB.Name = "NonceTB";
            this.NonceTB.ReadOnly = true;
            this.NonceTB.Size = new System.Drawing.Size(756, 20);
            this.NonceTB.TabIndex = 4;
            // 
            // ThisBlockTB
            // 
            this.ThisBlockTB.Location = new System.Drawing.Point(6, 474);
            this.ThisBlockTB.Name = "ThisBlockTB";
            this.ThisBlockTB.ReadOnly = true;
            this.ThisBlockTB.Size = new System.Drawing.Size(756, 20);
            this.ThisBlockTB.TabIndex = 5;
            // 
            // NextBT
            // 
            this.NextBT.Location = new System.Drawing.Point(687, 503);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(75, 23);
            this.NextBT.TabIndex = 6;
            this.NextBT.Text = "Next Block";
            this.NextBT.UseVisualStyleBackColor = true;
            this.NextBT.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BlockWrite);
            this.tabControl1.Controls.Add(this.BlockExplorer);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 558);
            this.tabControl1.TabIndex = 7;
            // 
            // BlockWrite
            // 
            this.BlockWrite.Controls.Add(this.MineBT);
            this.BlockWrite.Controls.Add(this.NextBT);
            this.BlockWrite.Controls.Add(this.DataTB);
            this.BlockWrite.Controls.Add(this.ThisBlockTB);
            this.BlockWrite.Controls.Add(this.BlockIdTB);
            this.BlockWrite.Controls.Add(this.PrevBlockTB);
            this.BlockWrite.Controls.Add(this.NonceTB);
            this.BlockWrite.Location = new System.Drawing.Point(4, 22);
            this.BlockWrite.Name = "BlockWrite";
            this.BlockWrite.Padding = new System.Windows.Forms.Padding(3);
            this.BlockWrite.Size = new System.Drawing.Size(768, 532);
            this.BlockWrite.TabIndex = 0;
            this.BlockWrite.Text = "Zapisování Blocku";
            this.BlockWrite.UseVisualStyleBackColor = true;
            // 
            // BlockExplorer
            // 
            this.BlockExplorer.Location = new System.Drawing.Point(4, 22);
            this.BlockExplorer.Name = "BlockExplorer";
            this.BlockExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.BlockExplorer.Size = new System.Drawing.Size(768, 532);
            this.BlockExplorer.TabIndex = 1;
            this.BlockExplorer.Text = "Block Explorer";
            this.BlockExplorer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.BlockWrite.ResumeLayout(false);
            this.BlockWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MineBT;
        private System.Windows.Forms.TextBox BlockIdTB;
        private System.Windows.Forms.RichTextBox DataTB;
        private System.Windows.Forms.TextBox PrevBlockTB;
        private System.Windows.Forms.TextBox NonceTB;
        private System.Windows.Forms.TextBox ThisBlockTB;
        private System.Windows.Forms.Button NextBT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BlockWrite;
        private System.Windows.Forms.TabPage BlockExplorer;
    }
}

