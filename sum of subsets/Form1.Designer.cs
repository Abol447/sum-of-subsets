namespace sum_of_subsets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waightTxt = new System.Windows.Forms.TextBox();
            this.resultTable = new System.Windows.Forms.TableLayoutPanel();
            this.start = new System.Windows.Forms.Button();
            this.subset = new System.Windows.Forms.Panel();
            this.creatSubset = new System.Windows.Forms.Button();
            this.subsetLenght = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "subset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "waight";
            // 
            // waightTxt
            // 
            this.waightTxt.Location = new System.Drawing.Point(83, 118);
            this.waightTxt.Name = "waightTxt";
            this.waightTxt.Size = new System.Drawing.Size(50, 22);
            this.waightTxt.TabIndex = 4;
            // 
            // resultTable
            // 
            this.resultTable.ColumnCount = 1;
            this.resultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultTable.Location = new System.Drawing.Point(17, 211);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowCount = 1;
            this.resultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultTable.Size = new System.Drawing.Size(770, 176);
            this.resultTable.TabIndex = 5;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(17, 171);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(56, 23);
            this.start.TabIndex = 6;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // subset
            // 
            this.subset.Location = new System.Drawing.Point(15, 44);
            this.subset.Name = "subset";
            this.subset.Size = new System.Drawing.Size(772, 54);
            this.subset.TabIndex = 7;
            // 
            // creatSubset
            // 
            this.creatSubset.Location = new System.Drawing.Point(162, 5);
            this.creatSubset.Name = "creatSubset";
            this.creatSubset.Size = new System.Drawing.Size(56, 23);
            this.creatSubset.TabIndex = 8;
            this.creatSubset.Text = "cerat";
            this.creatSubset.UseVisualStyleBackColor = true;
            this.creatSubset.Click += new System.EventHandler(this.creatSubset_Click);
            // 
            // subsetLenght
            // 
            this.subsetLenght.Location = new System.Drawing.Point(83, 6);
            this.subsetLenght.Name = "subsetLenght";
            this.subsetLenght.Size = new System.Drawing.Size(50, 22);
            this.subsetLenght.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subsetLenght);
            this.Controls.Add(this.creatSubset);
            this.Controls.Add(this.subset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.waightTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox waightTxt;
        private System.Windows.Forms.TableLayoutPanel resultTable;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel subset;
        private System.Windows.Forms.Button creatSubset;
        private System.Windows.Forms.TextBox subsetLenght;
    }
}

