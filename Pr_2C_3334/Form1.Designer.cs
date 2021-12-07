
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
            this.SuspendLayout();
            // 
            // MineBT
            // 
            this.MineBT.Location = new System.Drawing.Point(12, 547);
            this.MineBT.Name = "MineBT";
            this.MineBT.Size = new System.Drawing.Size(75, 23);
            this.MineBT.TabIndex = 0;
            this.MineBT.Text = "Mine";
            this.MineBT.UseVisualStyleBackColor = true;
            this.MineBT.Click += new System.EventHandler(this.MineBT_Click);
            // 
            // BlockIdTB
            // 
            this.BlockIdTB.Location = new System.Drawing.Point(12, 14);
            this.BlockIdTB.Name = "BlockIdTB";
            this.BlockIdTB.ReadOnly = true;
            this.BlockIdTB.Size = new System.Drawing.Size(775, 20);
            this.BlockIdTB.TabIndex = 1;
            // 
            // DataTB
            // 
            this.DataTB.Location = new System.Drawing.Point(12, 40);
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(775, 423);
            this.DataTB.TabIndex = 2;
            this.DataTB.Text = "";
            // 
            // PrevBlockTB
            // 
            this.PrevBlockTB.Location = new System.Drawing.Point(12, 495);
            this.PrevBlockTB.Name = "PrevBlockTB";
            this.PrevBlockTB.ReadOnly = true;
            this.PrevBlockTB.Size = new System.Drawing.Size(775, 20);
            this.PrevBlockTB.TabIndex = 3;
            // 
            // NonceTB
            // 
            this.NonceTB.Location = new System.Drawing.Point(12, 469);
            this.NonceTB.Name = "NonceTB";
            this.NonceTB.ReadOnly = true;
            this.NonceTB.Size = new System.Drawing.Size(775, 20);
            this.NonceTB.TabIndex = 4;
            // 
            // ThisBlockTB
            // 
            this.ThisBlockTB.Location = new System.Drawing.Point(12, 521);
            this.ThisBlockTB.Name = "ThisBlockTB";
            this.ThisBlockTB.ReadOnly = true;
            this.ThisBlockTB.Size = new System.Drawing.Size(775, 20);
            this.ThisBlockTB.TabIndex = 5;
            // 
            // NextBT
            // 
            this.NextBT.Location = new System.Drawing.Point(713, 547);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(75, 23);
            this.NextBT.TabIndex = 6;
            this.NextBT.Text = "Next Block";
            this.NextBT.UseVisualStyleBackColor = true;
            this.NextBT.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.NextBT);
            this.Controls.Add(this.ThisBlockTB);
            this.Controls.Add(this.NonceTB);
            this.Controls.Add(this.PrevBlockTB);
            this.Controls.Add(this.DataTB);
            this.Controls.Add(this.BlockIdTB);
            this.Controls.Add(this.MineBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MineBT;
        private System.Windows.Forms.TextBox BlockIdTB;
        private System.Windows.Forms.RichTextBox DataTB;
        private System.Windows.Forms.TextBox PrevBlockTB;
        private System.Windows.Forms.TextBox NonceTB;
        private System.Windows.Forms.TextBox ThisBlockTB;
        private System.Windows.Forms.Button NextBT;
    }
}

