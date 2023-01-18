namespace L_MDB
{
    partial class LMDBMain
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 4;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 54);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 100);
            this.mainTableLayout.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LMDBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.titleLabel);
            this.Name = "LMDBMain";
            this.Text = "LMDB";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Button button1;
    }
}

