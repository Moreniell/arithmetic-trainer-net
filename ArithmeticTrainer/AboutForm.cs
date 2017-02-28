using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Moreniell.ArithmeticTrainer
{
	public partial class AboutForm : Form
	{
		private readonly string subject;

		public AboutForm()
		{
			InitializeComponent();

			string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
			subject = "Вопрос по ArithmeticTrainer v" + ver;

			versionTooltip.Text = $"Версия {ver}";
		}

		private void autorSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://vk.com/id27951423");
			autorSite.LinkVisited = true;
		}
		
		private void feedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("mailto:and-ivant@yandex.ru" + "?subject=" + subject);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Moreniell/Junior-Code-CSharp");
		}
	}
}
