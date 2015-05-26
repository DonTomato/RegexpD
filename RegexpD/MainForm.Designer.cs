namespace RegexpD
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.teInput = new System.Windows.Forms.TextBox();
			this.tePattern = new System.Windows.Forms.TextBox();
			this.teResult = new System.Windows.Forms.TextBox();
			this.cheIgnoreCase = new System.Windows.Forms.CheckBox();
			this.btAnalyze = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// teInput
			// 
			this.teInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.teInput.Location = new System.Drawing.Point(12, 12);
			this.teInput.Multiline = true;
			this.teInput.Name = "teInput";
			this.teInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.teInput.Size = new System.Drawing.Size(884, 149);
			this.teInput.TabIndex = 0;
			// 
			// tePattern
			// 
			this.tePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tePattern.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tePattern.Location = new System.Drawing.Point(12, 167);
			this.tePattern.Name = "tePattern";
			this.tePattern.Size = new System.Drawing.Size(714, 23);
			this.tePattern.TabIndex = 1;
			this.tePattern.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tePattern_KeyPress);
			// 
			// teResult
			// 
			this.teResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.teResult.Location = new System.Drawing.Point(12, 193);
			this.teResult.Multiline = true;
			this.teResult.Name = "teResult";
			this.teResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.teResult.Size = new System.Drawing.Size(884, 395);
			this.teResult.TabIndex = 2;
			// 
			// cheIgnoreCase
			// 
			this.cheIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cheIgnoreCase.AutoSize = true;
			this.cheIgnoreCase.Location = new System.Drawing.Point(732, 170);
			this.cheIgnoreCase.Name = "cheIgnoreCase";
			this.cheIgnoreCase.Size = new System.Drawing.Size(83, 17);
			this.cheIgnoreCase.TabIndex = 3;
			this.cheIgnoreCase.Text = "Ignore Case";
			this.cheIgnoreCase.UseVisualStyleBackColor = true;
			// 
			// btAnalyze
			// 
			this.btAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAnalyze.Location = new System.Drawing.Point(821, 166);
			this.btAnalyze.Name = "btAnalyze";
			this.btAnalyze.Size = new System.Drawing.Size(75, 23);
			this.btAnalyze.TabIndex = 4;
			this.btAnalyze.Text = "Start";
			this.btAnalyze.UseVisualStyleBackColor = true;
			this.btAnalyze.Click += new System.EventHandler(this.btAnalyze_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 600);
			this.Controls.Add(this.btAnalyze);
			this.Controls.Add(this.cheIgnoreCase);
			this.Controls.Add(this.teResult);
			this.Controls.Add(this.tePattern);
			this.Controls.Add(this.teInput);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "RegEXpTest";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox teInput;
		private System.Windows.Forms.TextBox tePattern;
		private System.Windows.Forms.TextBox teResult;
		private System.Windows.Forms.CheckBox cheIgnoreCase;
        private System.Windows.Forms.Button btAnalyze;
	}
}

