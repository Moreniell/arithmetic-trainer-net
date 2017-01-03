namespace MaZaiPC.ArithmeticTrainer
{
	partial class TrainingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
			this._example = new System.Windows.Forms.Label();
			this._fieldAnswer = new System.Windows.Forms.TextBox();
			this._btnLeave = new System.Windows.Forms.Button();
			this._successTooltip = new System.Windows.Forms.Label();
			this._progressTooltip = new System.Windows.Forms.Label();
			this._customProgressBar1 = new System.Windows.Forms.PictureBox();
			this._customProgressBar2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._customProgressBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._customProgressBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// _example
			// 
			this._example.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._example.Location = new System.Drawing.Point(0, 80);
			this._example.Name = "_example";
			this._example.Size = new System.Drawing.Size(432, 56);
			this._example.TabIndex = 0;
			this._example.Text = "2 + 2";
			this._example.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _fieldAnswer
			// 
			this._fieldAnswer.Location = new System.Drawing.Point(136, 144);
			this._fieldAnswer.Name = "_fieldAnswer";
			this._fieldAnswer.Size = new System.Drawing.Size(152, 20);
			this._fieldAnswer.TabIndex = 1;
			this._fieldAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this._fieldAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fieldAnswer_KeyPress);
			// 
			// _btnLeave
			// 
			this._btnLeave.Location = new System.Drawing.Point(144, 224);
			this._btnLeave.Name = "_btnLeave";
			this._btnLeave.Size = new System.Drawing.Size(136, 23);
			this._btnLeave.TabIndex = 2;
			this._btnLeave.Text = "Покинуть тренировку";
			this._btnLeave.UseVisualStyleBackColor = true;
			this._btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
			// 
			// _successTooltip
			// 
			this._successTooltip.Location = new System.Drawing.Point(8, 16);
			this._successTooltip.Name = "_successTooltip";
			this._successTooltip.Size = new System.Drawing.Size(128, 16);
			this._successTooltip.TabIndex = 3;
			this._successTooltip.Text = "Успешно {0} из {1}";
			// 
			// _progressTooltip
			// 
			this._progressTooltip.Location = new System.Drawing.Point(336, 16);
			this._progressTooltip.Name = "_progressTooltip";
			this._progressTooltip.Size = new System.Drawing.Size(96, 16);
			this._progressTooltip.TabIndex = 3;
			this._progressTooltip.Text = "{0} / {1}";
			this._progressTooltip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _customProgressBar1
			// 
			this._customProgressBar1.BackColor = System.Drawing.Color.MediumAquamarine;
			this._customProgressBar1.Location = new System.Drawing.Point(0, 0);
			this._customProgressBar1.Name = "_customProgressBar1";
			this._customProgressBar1.Size = new System.Drawing.Size(432, 8);
			this._customProgressBar1.TabIndex = 4;
			this._customProgressBar1.TabStop = false;
			// 
			// _customProgressBar2
			// 
			this._customProgressBar2.BackColor = System.Drawing.Color.Gray;
			this._customProgressBar2.Location = new System.Drawing.Point(0, 0);
			this._customProgressBar2.Name = "_customProgressBar2";
			this._customProgressBar2.Size = new System.Drawing.Size(432, 8);
			this._customProgressBar2.TabIndex = 5;
			this._customProgressBar2.TabStop = false;
			this._customProgressBar2.SizeChanged += new System.EventHandler(this.progressBar_SizeChanged);
			// 
			// TrainingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 261);
			this.Controls.Add(this._customProgressBar1);
			this.Controls.Add(this._progressTooltip);
			this.Controls.Add(this._successTooltip);
			this.Controls.Add(this._btnLeave);
			this.Controls.Add(this._fieldAnswer);
			this.Controls.Add(this._example);
			this.Controls.Add(this._customProgressBar2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TrainingForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Тренировка";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this._customProgressBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._customProgressBar2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _example;
		private System.Windows.Forms.TextBox _fieldAnswer;
		private System.Windows.Forms.Button _btnLeave;
		private System.Windows.Forms.Label _successTooltip;
		private System.Windows.Forms.Label _progressTooltip;
		private System.Windows.Forms.PictureBox _customProgressBar1;
		private System.Windows.Forms.PictureBox _customProgressBar2;
	}
}