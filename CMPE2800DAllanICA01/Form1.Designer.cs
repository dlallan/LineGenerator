namespace CMPE2800DAllanICA01
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
            this.btn_AddRed = new System.Windows.Forms.Button();
            this.btn_InsertRed = new System.Windows.Forms.Button();
            this.lab_CLine = new System.Windows.Forms.Label();
            this.btn_SortRed = new System.Windows.Forms.Button();
            this.btn_SortCColour = new System.Windows.Forms.Button();
            this.lab_CColourLine = new System.Windows.Forms.Label();
            this.btn_InsertCColour = new System.Windows.Forms.Button();
            this.btn_AddColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddRed
            // 
            this.btn_AddRed.Location = new System.Drawing.Point(11, 51);
            this.btn_AddRed.Name = "btn_AddRed";
            this.btn_AddRed.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRed.TabIndex = 0;
            this.btn_AddRed.Text = "Add";
            this.btn_AddRed.UseVisualStyleBackColor = true;
            this.btn_AddRed.Click += new System.EventHandler(this.btn_AddRed_Click);
            // 
            // btn_InsertRed
            // 
            this.btn_InsertRed.Location = new System.Drawing.Point(104, 51);
            this.btn_InsertRed.Name = "btn_InsertRed";
            this.btn_InsertRed.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertRed.TabIndex = 1;
            this.btn_InsertRed.Text = "Insert";
            this.btn_InsertRed.UseVisualStyleBackColor = true;
            this.btn_InsertRed.Click += new System.EventHandler(this.btn_InsertRed_Click);
            // 
            // lab_CLine
            // 
            this.lab_CLine.AutoSize = true;
            this.lab_CLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CLine.Location = new System.Drawing.Point(117, 18);
            this.lab_CLine.Name = "lab_CLine";
            this.lab_CLine.Size = new System.Drawing.Size(50, 20);
            this.lab_CLine.TabIndex = 2;
            this.lab_CLine.Text = "CLine";
            // 
            // btn_SortRed
            // 
            this.btn_SortRed.Location = new System.Drawing.Point(197, 51);
            this.btn_SortRed.Name = "btn_SortRed";
            this.btn_SortRed.Size = new System.Drawing.Size(75, 23);
            this.btn_SortRed.TabIndex = 3;
            this.btn_SortRed.Text = "Sort";
            this.btn_SortRed.UseVisualStyleBackColor = true;
            this.btn_SortRed.Click += new System.EventHandler(this.btn_SortRed_Click);
            // 
            // btn_SortCColour
            // 
            this.btn_SortCColour.Location = new System.Drawing.Point(198, 153);
            this.btn_SortCColour.Name = "btn_SortCColour";
            this.btn_SortCColour.Size = new System.Drawing.Size(75, 23);
            this.btn_SortCColour.TabIndex = 7;
            this.btn_SortCColour.Text = "Sort";
            this.btn_SortCColour.UseVisualStyleBackColor = true;
            this.btn_SortCColour.Click += new System.EventHandler(this.btn_SortCColour_Click);
            // 
            // lab_CColourLine
            // 
            this.lab_CColourLine.AutoSize = true;
            this.lab_CColourLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CColourLine.Location = new System.Drawing.Point(94, 120);
            this.lab_CColourLine.Name = "lab_CColourLine";
            this.lab_CColourLine.Size = new System.Drawing.Size(96, 20);
            this.lab_CColourLine.TabIndex = 6;
            this.lab_CColourLine.Text = "CColourLine";
            // 
            // btn_InsertCColour
            // 
            this.btn_InsertCColour.Location = new System.Drawing.Point(105, 153);
            this.btn_InsertCColour.Name = "btn_InsertCColour";
            this.btn_InsertCColour.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertCColour.TabIndex = 5;
            this.btn_InsertCColour.Text = "Insert";
            this.btn_InsertCColour.UseVisualStyleBackColor = true;
            this.btn_InsertCColour.Click += new System.EventHandler(this.btn_InsertCColour_Click);
            // 
            // btn_AddColour
            // 
            this.btn_AddColour.Location = new System.Drawing.Point(12, 153);
            this.btn_AddColour.Name = "btn_AddColour";
            this.btn_AddColour.Size = new System.Drawing.Size(75, 23);
            this.btn_AddColour.TabIndex = 4;
            this.btn_AddColour.Text = "Add";
            this.btn_AddColour.UseVisualStyleBackColor = true;
            this.btn_AddColour.Click += new System.EventHandler(this.btn_AddColour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.btn_SortCColour);
            this.Controls.Add(this.lab_CColourLine);
            this.Controls.Add(this.btn_InsertCColour);
            this.Controls.Add(this.btn_AddColour);
            this.Controls.Add(this.btn_SortRed);
            this.Controls.Add(this.lab_CLine);
            this.Controls.Add(this.btn_InsertRed);
            this.Controls.Add(this.btn_AddRed);
            this.Name = "Form1";
            this.Text = "ICA01 - Generic Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddRed;
        private System.Windows.Forms.Button btn_InsertRed;
        private System.Windows.Forms.Label lab_CLine;
        private System.Windows.Forms.Button btn_SortRed;
        private System.Windows.Forms.Button btn_SortCColour;
        private System.Windows.Forms.Label lab_CColourLine;
        private System.Windows.Forms.Button btn_InsertCColour;
        private System.Windows.Forms.Button btn_AddColour;
    }
}

