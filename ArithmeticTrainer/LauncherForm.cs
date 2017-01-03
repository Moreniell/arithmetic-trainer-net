using System;
using System.Windows.Forms;
using MaZaiPC.ArithmeticTrainer.Properties;

namespace MaZaiPC.ArithmeticTrainer
{
	public partial class LauncherForm : Form
	{
		public LauncherForm()
		{
			InitializeComponent();
		}

		private void ButtonProceed_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			new TrainingForm().ShowDialog();
			this.Visible = true;
		}
		
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
		}

		private int opCounter = 1;
		private void checkBoxOperation_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;

			if (checkBox == null) return;

			if (checkBox.Checked)
				opCounter++;
			else
				opCounter--;

			if (opCounter == 0)
			{
				checkBoxSum.Checked = true;

				if (!sender.Equals(checkBoxSum))
				{
					// Фикс особенности, из за которой отменялось изменение следующего чекбокса.
					checkBox.Checked = checkBox.Checked = false;
				}
			}
		}

		private void mniAbout_Click(object sender, EventArgs e)
		{
			new AboutForm().ShowDialog();
		}
	}
}
