using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moreniell.ArithmeticTrainer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Moreniell.ArithmeticTrainer
{
	public partial class TrainingForm : Form
	{
		private Example _ex;
		private readonly Timer _timer = new Timer();
		
		private int _successCounter;
		private int _progressCounter;
		private bool _disableWarning;

		public TrainingForm()
		{
			InitializeComponent();
			TopMost = true;
			_fieldAnswer.Focus();
			_ex = GenerateExample();
			_example.Text = _ex.ToString();

			_customProgressBar1.Width = 0;
			_customProgressBar2.Width = 0;

			_successTooltip.Text = $"Успешно 0 / {Settings.Default.NumRepetitions}";
			_progressTooltip.Text = $"Прогресс 0 / {Settings.Default.NumRepetitions}";

			if (Settings.Default.Pace)
			{
				_timer.Interval = (int)Settings.Default.DurationOfShow*1000;
				_timer.Tick += timer_Tick;
				_timer.Enabled = true;
				_timer.Start();
			}
		}

		private void RestartTimer(int newInterval)
		{
			_timer.Stop();
			_timer.Interval = newInterval;
			_timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (UpdateProgress())
			{
				NewExample(true);
				RestartTimer((int)Settings.Default.DurationOfShow * 1000);
			}
			else
			{
				Task.Delay(1000).ContinueWith(_ => { NewExample(); });
				RestartTimer(1000 + (int)Settings.Default.DurationOfShow * 1000);
			}
		}

		private void NewExample(bool auto = false)
		{
			_ex = GenerateExample();
			_example.Text = _ex.ToString();
			_fieldAnswer.Clear();
			
			if (auto)
			{
				Task.Delay(500).ContinueWith(_ =>
				{
					_fieldAnswer.Clear();
				});
			}
		}

		private void fieldAnswer_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (_fieldAnswer.Text != string.Empty)
				{
					if (UpdateProgress())
					{
						NewExample();
						RestartTimer((int)Settings.Default.DurationOfShow * 1000);
						e.Handled = true;
					}
					else
					{
						Task.Delay(1000).ContinueWith(_ => { NewExample(); });
						RestartTimer(1000 + (int)Settings.Default.DurationOfShow * 1000);
						e.Handled = true;
					}
				}
			}
			
			byte[] allowed = { 0x8, 0x18 };

			if (!char.IsDigit(e.KeyChar) && !allowed.Contains((byte)e.KeyChar))
			{
				if (e.KeyChar != ',' && e.KeyChar != '.'
				    || _fieldAnswer.Text.Contains(".") || _fieldAnswer.Text.Contains(",") || _fieldAnswer.SelectionStart == 0)
				{
					e.KeyChar = '\0';
				}
			}
		}

		private bool UpdateProgress()
		{
			bool isRightAnswer = false;
			try
			{
				// IDEA: Версия для примеров с дробной частью.
				// isRightAnswer = _ex.EqualsToAnswer(Math.Round(double.Parse(_fieldAnswer.Text.Replace(".",",")), 2));
				isRightAnswer = _ex.EqualsToAnswer(double.Parse(_fieldAnswer.Text.Replace(".",",")));
			}
			catch (Exception)
			{
				// ignored
			}

			using (Stream stream = isRightAnswer
				? Resources.RightSound
				: Resources.WrongSound)
			{
				SoundPlayer snd = new SoundPlayer(stream);
				snd.Play();
			}

			if (isRightAnswer)
			{
				_successTooltip.Text = $"Успешно {++_successCounter} / {Settings.Default.NumRepetitions}";

				IncrementProgressBar(_customProgressBar1, _successCounter);
			}

			_progressTooltip.Text = $"Прогресс {++_progressCounter} / {Settings.Default.NumRepetitions}";

			IncrementProgressBar(_customProgressBar2, _progressCounter);

			if (!isRightAnswer)
			{
				_example.Text = _ex.Answer.ToString();
			}
			return isRightAnswer;
		}

		void IncrementProgressBar(PictureBox progressBar, int counter)
		{
			if (counter != Settings.Default.NumRepetitions)
				progressBar.Width = Width / (int)(Settings.Default.NumRepetitions + 1) * counter;
			else
				progressBar.Width = Width;
		}

		private void progressBar_SizeChanged(object sender, EventArgs e)
		{
			if (_progressCounter >= Settings.Default.NumRepetitions)
			{
				_timer.Tick -= timer_Tick;
				MessageBox.Show($"Очков набрано: {_successCounter} / {Settings.Default.NumRepetitions}");
				_disableWarning = true;
				this.Close();
			}
		}

		private Example GenerateExample()
		{
			Random rand = new Random();
			
			List<Func<int>> rOperand = new List<Func<int>>();

			if (Settings.Default.SingleDigit) rOperand.Add(() => rand.Next(2, 10));
			if (Settings.Default.TwoDigit)    rOperand.Add(() => rand.Next(10, 100));
			if (Settings.Default.ThreeDigit)  rOperand.Add(() => rand.Next(100, 1000));
			if (Settings.Default.FourDigit)   rOperand.Add(() => rand.Next(1000, 10000));
			if (Settings.Default.FiveDigit)   rOperand.Add(() => rand.Next(10000, 100000));

			List<char> rOperation = new List<char>();

			if (Settings.Default.Sum) rOperation.Add('+');
			if (Settings.Default.Sub) rOperation.Add('-');
			if (Settings.Default.Mul) rOperation.Add('*');
			if (Settings.Default.Div) rOperation.Add('/');

			Example example;
			char operation = rOperation[rand.Next(rOperation.Count)];
			do
			{
				example = new Example(
					rOperand[rand.Next(rOperand.Count)](),
					operation,
					rOperand[rand.Next(rOperand.Count)]());
			} while (example.Answer % Math.Truncate(example.Answer) != 0 
					|| (_ex != null && _ex.Equals(example)));

			return example;
		}
		
		private void btnLeave_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_timer.Tick -= timer_Tick;
			if (!_disableWarning &&
				MessageBox.Show("Вы действительно хотите покинуть тренировку?", "Операция прерывания", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;

				if (Settings.Default.Pace) _timer.Tick += timer_Tick;
			}
		}
	}
}
