﻿namespace Section4CC
{
	partial class form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnList = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(13, 13);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(75, 23);
			this.btnList.TabIndex = 0;
			this.btnList.Text = "&List Stock";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(118, 1);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(499, 359);
			this.txtOutput.TabIndex = 1;
			// 
			// form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 359);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnList);
			this.Name = "form1";
			this.Text = "Warehouse";
			this.Load += new System.EventHandler(this.M_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtOutput;
	}
}

