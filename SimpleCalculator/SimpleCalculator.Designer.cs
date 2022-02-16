namespace SimpleCalculator
{
    partial class SimpleCalculator
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numberZeroButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.additionOpButton = new System.Windows.Forms.Button();
            this.numberOneButton = new System.Windows.Forms.Button();
            this.numberTwoButton = new System.Windows.Forms.Button();
            this.numberThreeButton = new System.Windows.Forms.Button();
            this.subtractionOpButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.numberFourButton = new System.Windows.Forms.Button();
            this.numberFiveButton = new System.Windows.Forms.Button();
            this.numberSixButton = new System.Windows.Forms.Button();
            this.multiplicationOpButton = new System.Windows.Forms.Button();
            this.numberSevenButton = new System.Windows.Forms.Button();
            this.numberEightButton = new System.Windows.Forms.Button();
            this.numberNineButton = new System.Windows.Forms.Button();
            this.divisionOpButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(620, 600);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 175);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 175);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 41);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.numberZeroButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.changeSignButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.additionOpButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberOneButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberTwoButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberThreeButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.subtractionOpButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberFourButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberFiveButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberSixButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationOpButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberSevenButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberEightButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberNineButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.divisionOpButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numberZeroButton
            // 
            this.numberZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberZeroButton.Location = new System.Drawing.Point(0, 267);
            this.numberZeroButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberZeroButton.Name = "numberZeroButton";
            this.numberZeroButton.Size = new System.Drawing.Size(123, 92);
            this.numberZeroButton.TabIndex = 15;
            this.numberZeroButton.Text = "0";
            this.numberZeroButton.UseVisualStyleBackColor = true;
            this.numberZeroButton.Click += new System.EventHandler(this.numberZeroButton_Click);
            // 
            // changeSignButton
            // 
            this.changeSignButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSignButton.Location = new System.Drawing.Point(123, 267);
            this.changeSignButton.Margin = new System.Windows.Forms.Padding(0);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(123, 92);
            this.changeSignButton.TabIndex = 16;
            this.changeSignButton.Text = "+/-";
            this.changeSignButton.UseVisualStyleBackColor = true;
            this.changeSignButton.Click += new System.EventHandler(this.changeSignButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(246, 267);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(0);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(123, 92);
            this.decimalButton.TabIndex = 17;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // additionOpButton
            // 
            this.additionOpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionOpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionOpButton.Location = new System.Drawing.Point(369, 267);
            this.additionOpButton.Margin = new System.Windows.Forms.Padding(0);
            this.additionOpButton.Name = "additionOpButton";
            this.additionOpButton.Size = new System.Drawing.Size(123, 92);
            this.additionOpButton.TabIndex = 18;
            this.additionOpButton.Text = "+";
            this.additionOpButton.UseVisualStyleBackColor = true;
            this.additionOpButton.Click += new System.EventHandler(this.additionOpButton_Click);
            // 
            // numberOneButton
            // 
            this.numberOneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOneButton.Location = new System.Drawing.Point(0, 178);
            this.numberOneButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberOneButton.Name = "numberOneButton";
            this.numberOneButton.Size = new System.Drawing.Size(123, 89);
            this.numberOneButton.TabIndex = 10;
            this.numberOneButton.Text = "1";
            this.numberOneButton.UseVisualStyleBackColor = true;
            this.numberOneButton.Click += new System.EventHandler(this.numberOneButton_Click);
            // 
            // numberTwoButton
            // 
            this.numberTwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwoButton.Location = new System.Drawing.Point(123, 178);
            this.numberTwoButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberTwoButton.Name = "numberTwoButton";
            this.numberTwoButton.Size = new System.Drawing.Size(123, 89);
            this.numberTwoButton.TabIndex = 11;
            this.numberTwoButton.Text = "2";
            this.numberTwoButton.UseVisualStyleBackColor = true;
            this.numberTwoButton.Click += new System.EventHandler(this.numberTwoButton_Click);
            // 
            // numberThreeButton
            // 
            this.numberThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThreeButton.Location = new System.Drawing.Point(246, 178);
            this.numberThreeButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberThreeButton.Name = "numberThreeButton";
            this.numberThreeButton.Size = new System.Drawing.Size(123, 89);
            this.numberThreeButton.TabIndex = 12;
            this.numberThreeButton.Text = "3";
            this.numberThreeButton.UseVisualStyleBackColor = true;
            this.numberThreeButton.Click += new System.EventHandler(this.numberThreeButton_Click);
            // 
            // subtractionOpButton
            // 
            this.subtractionOpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtractionOpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionOpButton.Location = new System.Drawing.Point(369, 178);
            this.subtractionOpButton.Margin = new System.Windows.Forms.Padding(0);
            this.subtractionOpButton.Name = "subtractionOpButton";
            this.subtractionOpButton.Size = new System.Drawing.Size(123, 89);
            this.subtractionOpButton.TabIndex = 13;
            this.subtractionOpButton.Text = "-";
            this.subtractionOpButton.UseVisualStyleBackColor = true;
            this.subtractionOpButton.Click += new System.EventHandler(this.subtractionOpButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(492, 178);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(0);
            this.equalsButton.Name = "equalsButton";
            this.tableLayoutPanel1.SetRowSpan(this.equalsButton, 2);
            this.equalsButton.Size = new System.Drawing.Size(124, 181);
            this.equalsButton.TabIndex = 14;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // numberFourButton
            // 
            this.numberFourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFourButton.Location = new System.Drawing.Point(0, 89);
            this.numberFourButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberFourButton.Name = "numberFourButton";
            this.numberFourButton.Size = new System.Drawing.Size(123, 89);
            this.numberFourButton.TabIndex = 5;
            this.numberFourButton.Text = "4";
            this.numberFourButton.UseVisualStyleBackColor = true;
            this.numberFourButton.Click += new System.EventHandler(this.numberFourButton_Click);
            // 
            // numberFiveButton
            // 
            this.numberFiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFiveButton.Location = new System.Drawing.Point(123, 89);
            this.numberFiveButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberFiveButton.Name = "numberFiveButton";
            this.numberFiveButton.Size = new System.Drawing.Size(123, 89);
            this.numberFiveButton.TabIndex = 6;
            this.numberFiveButton.Text = "5";
            this.numberFiveButton.UseVisualStyleBackColor = true;
            this.numberFiveButton.Click += new System.EventHandler(this.numberFiveButton_Click);
            // 
            // numberSixButton
            // 
            this.numberSixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSixButton.Location = new System.Drawing.Point(246, 89);
            this.numberSixButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberSixButton.Name = "numberSixButton";
            this.numberSixButton.Size = new System.Drawing.Size(123, 89);
            this.numberSixButton.TabIndex = 7;
            this.numberSixButton.Text = "6";
            this.numberSixButton.UseVisualStyleBackColor = true;
            this.numberSixButton.Click += new System.EventHandler(this.numberSixButton_Click);
            // 
            // multiplicationOpButton
            // 
            this.multiplicationOpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationOpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationOpButton.Location = new System.Drawing.Point(369, 89);
            this.multiplicationOpButton.Margin = new System.Windows.Forms.Padding(0);
            this.multiplicationOpButton.Name = "multiplicationOpButton";
            this.multiplicationOpButton.Size = new System.Drawing.Size(123, 89);
            this.multiplicationOpButton.TabIndex = 8;
            this.multiplicationOpButton.Text = "*";
            this.multiplicationOpButton.UseVisualStyleBackColor = true;
            this.multiplicationOpButton.Click += new System.EventHandler(this.multiplicationOpButton_Click);
            // 
            // numberSevenButton
            // 
            this.numberSevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSevenButton.Location = new System.Drawing.Point(0, 0);
            this.numberSevenButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberSevenButton.Name = "numberSevenButton";
            this.numberSevenButton.Size = new System.Drawing.Size(123, 89);
            this.numberSevenButton.TabIndex = 0;
            this.numberSevenButton.Text = "7";
            this.numberSevenButton.UseVisualStyleBackColor = true;
            this.numberSevenButton.Click += new System.EventHandler(this.numberSevenButton_Click);
            // 
            // numberEightButton
            // 
            this.numberEightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberEightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberEightButton.Location = new System.Drawing.Point(123, 0);
            this.numberEightButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberEightButton.Name = "numberEightButton";
            this.numberEightButton.Size = new System.Drawing.Size(123, 89);
            this.numberEightButton.TabIndex = 1;
            this.numberEightButton.Text = "8";
            this.numberEightButton.UseVisualStyleBackColor = true;
            this.numberEightButton.Click += new System.EventHandler(this.numberEightButton_Click);
            // 
            // numberNineButton
            // 
            this.numberNineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberNineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNineButton.Location = new System.Drawing.Point(246, 0);
            this.numberNineButton.Margin = new System.Windows.Forms.Padding(0);
            this.numberNineButton.Name = "numberNineButton";
            this.numberNineButton.Size = new System.Drawing.Size(123, 89);
            this.numberNineButton.TabIndex = 2;
            this.numberNineButton.Text = "9";
            this.numberNineButton.UseVisualStyleBackColor = true;
            this.numberNineButton.Click += new System.EventHandler(this.numberNineButton_Click);
            // 
            // divisionOpButton
            // 
            this.divisionOpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionOpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionOpButton.Location = new System.Drawing.Point(369, 0);
            this.divisionOpButton.Margin = new System.Windows.Forms.Padding(0);
            this.divisionOpButton.Name = "divisionOpButton";
            this.divisionOpButton.Size = new System.Drawing.Size(123, 89);
            this.divisionOpButton.TabIndex = 3;
            this.divisionOpButton.Text = "/";
            this.divisionOpButton.UseVisualStyleBackColor = true;
            this.divisionOpButton.Click += new System.EventHandler(this.divisionOpButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(492, 0);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.tableLayoutPanel1.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(124, 178);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SimpleCalculator";
            this.Size = new System.Drawing.Size(620, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button numberZeroButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button additionOpButton;
        private System.Windows.Forms.Button numberOneButton;
        private System.Windows.Forms.Button numberTwoButton;
        private System.Windows.Forms.Button numberThreeButton;
        private System.Windows.Forms.Button subtractionOpButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button numberFourButton;
        private System.Windows.Forms.Button numberFiveButton;
        private System.Windows.Forms.Button numberSixButton;
        private System.Windows.Forms.Button multiplicationOpButton;
        private System.Windows.Forms.Button numberSevenButton;
        private System.Windows.Forms.Button numberEightButton;
        private System.Windows.Forms.Button numberNineButton;
        private System.Windows.Forms.Button divisionOpButton;
        private System.Windows.Forms.Button clearButton;
    }
}
