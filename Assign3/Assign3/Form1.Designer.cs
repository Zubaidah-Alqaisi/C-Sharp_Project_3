namespace Assign3
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
            this.mysqlCommand = new System.Windows.Forms.TextBox();
            this.excute = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type the SQL command:";
            // 
            // mysqlCommand
            // 
            this.mysqlCommand.Location = new System.Drawing.Point(243, 70);
            this.mysqlCommand.Name = "mysqlCommand";
            this.mysqlCommand.Size = new System.Drawing.Size(262, 20);
            this.mysqlCommand.TabIndex = 2;
            // 
            // excute
            // 
            this.excute.AutoSize = true;
            this.excute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excute.Location = new System.Drawing.Point(520, 68);
            this.excute.Name = "excute";
            this.excute.Size = new System.Drawing.Size(127, 29);
            this.excute.TabIndex = 3;
            this.excute.Text = "Excute Command";
            this.excute.UseVisualStyleBackColor = true;
            this.excute.Click += new System.EventHandler(this.Excute_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.FormattingEnabled = true;
            this.Output.HorizontalScrollbar = true;
            this.Output.ItemHeight = 18;
            this.Output.Location = new System.Drawing.Point(43, 109);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(615, 292);
            this.Output.TabIndex = 4;
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(459, 424);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 43);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(73, 426);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(120, 41);
            this.quit.TabIndex = 6;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(703, 502);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.excute);
            this.Controls.Add(this.mysqlCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Assign3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mysqlCommand;
        private System.Windows.Forms.Button excute;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button quit;
    }
}

