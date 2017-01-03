using System.Windows.Forms;
using MaZaiPC.ArithmeticTrainer.Properties;

namespace MaZaiPC.ArithmeticTrainer
{
	partial class LauncherForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
			this._btnProceed = new System.Windows.Forms.Button();
			this.checkBoxSum = new System.Windows.Forms.CheckBox();
			this.checkBoxSub = new System.Windows.Forms.CheckBox();
			this.checkBoxMul = new System.Windows.Forms.CheckBox();
			this.checkBoxDiv = new System.Windows.Forms.CheckBox();
			this.checkBoxSingleDigit = new System.Windows.Forms.CheckBox();
			this.checkBoxTwoDigit = new System.Windows.Forms.CheckBox();
			this.checkBoxThreeDigit = new System.Windows.Forms.CheckBox();
			this.checkBoxFourDigit = new System.Windows.Forms.CheckBox();
			this.checkBoxFiveDigit = new System.Windows.Forms.CheckBox();
			this._label1 = new System.Windows.Forms.Label();
			this._label3 = new System.Windows.Forms.Label();
			this.checkBoxPace = new System.Windows.Forms.CheckBox();
			this.DurationOfShow = new System.Windows.Forms.NumericUpDown();
			this._label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._label4 = new System.Windows.Forms.Label();
			this.NumRepetitions = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.DurationOfShow)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumRepetitions)).BeginInit();
			this.SuspendLayout();
			// 
			// _btnProceed
			// 
			this._btnProceed.Location = new System.Drawing.Point(32, 40);
			this._btnProceed.Name = "_btnProceed";
			this._btnProceed.Size = new System.Drawing.Size(224, 32);
			this._btnProceed.TabIndex = 1;
			this._btnProceed.Text = "Старт";
			this._btnProceed.UseVisualStyleBackColor = true;
			this._btnProceed.Click += new System.EventHandler(this.ButtonProceed_Click);
			// 
			// checkBoxSum
			// 
			this.checkBoxSum.AutoSize = true;
			this.checkBoxSum.Checked = true;
			this.checkBoxSum.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSum.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "Sum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxSum.Location = new System.Drawing.Point(40, 120);
			this.checkBoxSum.Name = "checkBoxSum";
			this.checkBoxSum.Size = new System.Drawing.Size(32, 17);
			this.checkBoxSum.TabIndex = 4;
			this.checkBoxSum.Text = "+";
			this.checkBoxSum.UseVisualStyleBackColor = true;
			this.checkBoxSum.CheckedChanged += new System.EventHandler(this.checkBoxOperation_CheckedChanged);
			// 
			// checkBoxSub
			// 
			this.checkBoxSub.AutoSize = true;
			this.checkBoxSub.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "Sub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxSub.Location = new System.Drawing.Point(80, 120);
			this.checkBoxSub.Name = "checkBoxSub";
			this.checkBoxSub.Size = new System.Drawing.Size(29, 17);
			this.checkBoxSub.TabIndex = 4;
			this.checkBoxSub.Text = "-";
			this.checkBoxSub.UseVisualStyleBackColor = true;
			this.checkBoxSub.CheckedChanged += new System.EventHandler(this.checkBoxOperation_CheckedChanged);
			// 
			// checkBoxMul
			// 
			this.checkBoxMul.AutoSize = true;
			this.checkBoxMul.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "Mul", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxMul.Location = new System.Drawing.Point(120, 120);
			this.checkBoxMul.Name = "checkBoxMul";
			this.checkBoxMul.Size = new System.Drawing.Size(32, 17);
			this.checkBoxMul.TabIndex = 4;
			this.checkBoxMul.Text = "×";
			this.checkBoxMul.UseVisualStyleBackColor = true;
			this.checkBoxMul.CheckedChanged += new System.EventHandler(this.checkBoxOperation_CheckedChanged);
			// 
			// checkBoxDiv
			// 
			this.checkBoxDiv.AutoSize = true;
			this.checkBoxDiv.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "Div", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxDiv.Location = new System.Drawing.Point(160, 120);
			this.checkBoxDiv.Name = "checkBoxDiv";
			this.checkBoxDiv.Size = new System.Drawing.Size(33, 17);
			this.checkBoxDiv.TabIndex = 4;
			this.checkBoxDiv.Text = "÷";
			this.checkBoxDiv.UseVisualStyleBackColor = true;
			this.checkBoxDiv.CheckedChanged += new System.EventHandler(this.checkBoxOperation_CheckedChanged);
			// 
			// checkBoxSingleDigit
			// 
			this.checkBoxSingleDigit.AutoSize = true;
			this.checkBoxSingleDigit.Checked = true;
			this.checkBoxSingleDigit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSingleDigit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "SingleDigit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxSingleDigit.Location = new System.Drawing.Point(40, 176);
			this.checkBoxSingleDigit.Name = "checkBoxSingleDigit";
			this.checkBoxSingleDigit.Size = new System.Drawing.Size(32, 17);
			this.checkBoxSingleDigit.TabIndex = 4;
			this.checkBoxSingleDigit.Text = "1";
			this.checkBoxSingleDigit.UseVisualStyleBackColor = true;
			// 
			// checkBoxTwoDigit
			// 
			this.checkBoxTwoDigit.AutoSize = true;
			this.checkBoxTwoDigit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "TwoDigit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxTwoDigit.Location = new System.Drawing.Point(80, 176);
			this.checkBoxTwoDigit.Name = "checkBoxTwoDigit";
			this.checkBoxTwoDigit.Size = new System.Drawing.Size(32, 17);
			this.checkBoxTwoDigit.TabIndex = 4;
			this.checkBoxTwoDigit.Text = "2";
			this.checkBoxTwoDigit.UseVisualStyleBackColor = true;
			// 
			// checkBoxThreeDigit
			// 
			this.checkBoxThreeDigit.AutoSize = true;
			this.checkBoxThreeDigit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "ThreeDigit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxThreeDigit.Location = new System.Drawing.Point(120, 176);
			this.checkBoxThreeDigit.Name = "checkBoxThreeDigit";
			this.checkBoxThreeDigit.Size = new System.Drawing.Size(32, 17);
			this.checkBoxThreeDigit.TabIndex = 4;
			this.checkBoxThreeDigit.Text = "3";
			this.checkBoxThreeDigit.UseVisualStyleBackColor = true;
			// 
			// checkBoxFourDigit
			// 
			this.checkBoxFourDigit.AutoSize = true;
			this.checkBoxFourDigit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "FourDigit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxFourDigit.Location = new System.Drawing.Point(160, 176);
			this.checkBoxFourDigit.Name = "checkBoxFourDigit";
			this.checkBoxFourDigit.Size = new System.Drawing.Size(32, 17);
			this.checkBoxFourDigit.TabIndex = 4;
			this.checkBoxFourDigit.Text = "4";
			this.checkBoxFourDigit.UseVisualStyleBackColor = true;
			// 
			// checkBoxFiveDigit
			// 
			this.checkBoxFiveDigit.AutoSize = true;
			this.checkBoxFiveDigit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "FiveDigit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxFiveDigit.Location = new System.Drawing.Point(200, 176);
			this.checkBoxFiveDigit.Name = "checkBoxFiveDigit";
			this.checkBoxFiveDigit.Size = new System.Drawing.Size(32, 17);
			this.checkBoxFiveDigit.TabIndex = 4;
			this.checkBoxFiveDigit.Text = "5";
			this.checkBoxFiveDigit.UseVisualStyleBackColor = true;
			// 
			// _label1
			// 
			this._label1.AutoSize = true;
			this._label1.Location = new System.Drawing.Point(32, 96);
			this._label1.Name = "_label1";
			this._label1.Size = new System.Drawing.Size(60, 13);
			this._label1.TabIndex = 5;
			this._label1.Text = "Операции:";
			// 
			// _label3
			// 
			this._label3.AutoSize = true;
			this._label3.Location = new System.Drawing.Point(32, 152);
			this._label3.Name = "_label3";
			this._label3.Size = new System.Drawing.Size(98, 13);
			this._label3.TabIndex = 5;
			this._label3.Text = "Значность чисел: ";
			// 
			// checkBoxPace
			// 
			this.checkBoxPace.AutoSize = true;
			this.checkBoxPace.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "Pace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxPace.Location = new System.Drawing.Point(40, 208);
			this.checkBoxPace.Name = "checkBoxPace";
			this.checkBoxPace.Size = new System.Drawing.Size(81, 17);
			this.checkBoxPace.TabIndex = 4;
			this.checkBoxPace.Text = "На время?";
			this.checkBoxPace.UseVisualStyleBackColor = true;
			// 
			// DurationOfShow
			// 
			this.DurationOfShow.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "DurationOfShow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DurationOfShow.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.checkBoxPace, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DurationOfShow.DecimalPlaces = 1;
			this.DurationOfShow.Enabled = false;
			this.DurationOfShow.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.DurationOfShow.Location = new System.Drawing.Point(216, 236);
			this.DurationOfShow.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.DurationOfShow.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
			this.DurationOfShow.Name = "DurationOfShow";
			this.DurationOfShow.Size = new System.Drawing.Size(56, 20);
			this.DurationOfShow.TabIndex = 6;
			this.DurationOfShow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// _label2
			// 
			this._label2.AutoSize = true;
			this._label2.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.checkBoxPace, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._label2.Enabled = false;
			this._label2.Location = new System.Drawing.Point(32, 240);
			this._label2.Name = "_label2";
			this._label2.Size = new System.Drawing.Size(171, 13);
			this._label2.TabIndex = 5;
			this._label2.Text = "Ограничение по времени в сек.:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referenceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// saveSettingsToolStripMenuItem
			// 
			this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
			this.saveSettingsToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.saveSettingsToolStripMenuItem.Text = "Сохранить настройки";
			this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.exitToolStripMenuItem.Text = "Выход";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// referenceToolStripMenuItem
			// 
			this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
			this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.referenceToolStripMenuItem.Text = "Справка";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.aboutToolStripMenuItem.Text = "О программе...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.mniAbout_Click);
			// 
			// _label4
			// 
			this._label4.AutoSize = true;
			this._label4.Location = new System.Drawing.Point(32, 272);
			this._label4.Name = "_label4";
			this._label4.Size = new System.Drawing.Size(122, 13);
			this._label4.TabIndex = 5;
			this._label4.Text = "Количество примеров:";
			// 
			// NumRepetitions
			// 
			this.NumRepetitions.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MaZaiPC.ArithmeticTrainer.Properties.Settings.Default, "NumRepetitions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.NumRepetitions.Location = new System.Drawing.Point(216, 269);
			this.NumRepetitions.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.NumRepetitions.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NumRepetitions.Name = "NumRepetitions";
			this.NumRepetitions.Size = new System.Drawing.Size(56, 20);
			this.NumRepetitions.TabIndex = 6;
			this.NumRepetitions.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// LauncherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 307);
			this.Controls.Add(this.NumRepetitions);
			this.Controls.Add(this.DurationOfShow);
			this.Controls.Add(this._label4);
			this.Controls.Add(this._label3);
			this.Controls.Add(this._label2);
			this.Controls.Add(this._label1);
			this.Controls.Add(this.checkBoxDiv);
			this.Controls.Add(this.checkBoxMul);
			this.Controls.Add(this.checkBoxSub);
			this.Controls.Add(this.checkBoxFiveDigit);
			this.Controls.Add(this.checkBoxFourDigit);
			this.Controls.Add(this.checkBoxThreeDigit);
			this.Controls.Add(this.checkBoxTwoDigit);
			this.Controls.Add(this.checkBoxPace);
			this.Controls.Add(this.checkBoxSingleDigit);
			this.Controls.Add(this.checkBoxSum);
			this.Controls.Add(this._btnProceed);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "LauncherForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Тренажер арифметики";
			((System.ComponentModel.ISupportInitialize)(this.DurationOfShow)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumRepetitions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		#endregion
		private System.Windows.Forms.Button _btnProceed;
		//public System.Windows.Forms.CheckBox CheckBoxSum { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxSub { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxMul { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxDiv { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxSingleDigit { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxTwoDigit { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxThreeDigit { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxFourDigit { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxFiveDigit { get; private set; }
		//public System.Windows.Forms.CheckBox CheckBoxPace { get; private set; }
		//public System.Windows.Forms.NumericUpDown DurationOfShow { get; private set; }
		private System.Windows.Forms.CheckBox checkBoxSum;
		private System.Windows.Forms.CheckBox checkBoxSub;
		private System.Windows.Forms.CheckBox checkBoxMul;
		private System.Windows.Forms.CheckBox checkBoxDiv;
		private System.Windows.Forms.CheckBox checkBoxSingleDigit;
		private System.Windows.Forms.CheckBox checkBoxTwoDigit;
		private System.Windows.Forms.CheckBox checkBoxThreeDigit;
		private System.Windows.Forms.CheckBox checkBoxFourDigit;
		private System.Windows.Forms.CheckBox checkBoxFiveDigit;
		private System.Windows.Forms.CheckBox checkBoxPace;
		private System.Windows.Forms.NumericUpDown DurationOfShow;
		private System.Windows.Forms.Label _label1;
		private System.Windows.Forms.Label _label3;
		private System.Windows.Forms.Label _label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label _label4;
		public System.Windows.Forms.NumericUpDown NumRepetitions;
	}
}

