using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_MDB
{
    public partial class LMDBMain : Form
    {
        public LMDBMain()
        {
            InitializeComponent();
            titleLabel.Text = "LMDB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*mainTableLayout.Size = new System.Drawing.Size(800, (Size.Height + 100));
            //mainTableLayout.Size = new System.Drawing.Size(800, 100);
            mainTableLayout.RowCount = mainTableLayout.RowCount + 1;
            mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            mainTableLayout.Controls.Add(new Label { Text = "New lable", Anchor = AnchorStyles.None, AutoSize = false}, 0, 0);*/

            TableLayoutPanel layoutPanel = new TableLayoutPanel();

            layoutPanel.Location = new System.Drawing.Point(26, 12);
            layoutPanel.Name = "layoutPanel1";
            layoutPanel.Size = new System.Drawing.Size(420, 240);
            layoutPanel.TabIndex = 2;

            Controls.Add(layoutPanel);

            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            layoutPanel.Controls.Add(new TextBox { Text = "Test" }, 0, 0);

            layoutPanel.Visible = false;

            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Location = new System.Drawing.Point(26, 12);
            tableLayout.Name = "TableLayoutP1";
            tableLayout.Size = new System.Drawing.Size(240, 200);
            tableLayout.BackColor = Color.LightPink;

            tableLayout.ColumnCount = 3;
            tableLayout.RowCount = 5;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));

            TextBox textBox = new TextBox();
            textBox.Location = new Point(10, 10);
            textBox.Text = "Test Textbox 94192848";
            textBox.Size = new Size(200, 30);

            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(10, 50);
            checkBox.Text = "Check this box";
            checkBox.Size = new Size(200, 30);

            tableLayout.Controls.Add(textBox, 0, 0);
            tableLayout.Controls.Add(checkBox, 0, 1);
            Controls.Add(tableLayout);

        }
    }
}
