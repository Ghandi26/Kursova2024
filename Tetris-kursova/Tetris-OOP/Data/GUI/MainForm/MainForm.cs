using System;
using Engine;
using System.Drawing;
using System.Windows.Forms;
using Tetris.Data.GUI.AboutGame;
using Tetris.Data.Modules.Users;
using Tetris.Data.GUI.UserControl;
using Tetris.Data.GUI.SettingsForm;
using Tetris.Data.GUI.UserStatistic;

namespace Tetris
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			SetSprite();
		}

		/// <summary>Загружает изображения для фигур.</summary>
		private static void SetSprite()
		{
			try
			{
				GameBoard.BackField = new Bitmap(Properties.Resources.spriteBG);
				GameBoard.BackBox   = new Bitmap(Properties.Resources.BackBox);

				Bitmap sprites      = new Bitmap(Properties.Resources.allShapes);
				GameBoard.LightBlue = sprites.Clone(new RectangleF(0, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Green     = sprites.Clone(new RectangleF(20, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Purple    = sprites.Clone(new RectangleF(40, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Blue      = sprites.Clone(new RectangleF(60, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Orange    = sprites.Clone(new RectangleF(80, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Red       = sprites.Clone(new RectangleF(100, 0, 20, 20), sprites.PixelFormat);
				GameBoard.Yellow    = sprites.Clone(new RectangleF(120, 0, 20, 20), sprites.PixelFormat);
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Не удалось загрузить: " + ex.Message, @"Ошибка при загрузке изображений!");
			}
		}

		#region События
		/// <summary>Открывает форму с игрой.</summary>
		private void BtPlay_Click(object sender, EventArgs e)
		{
			Hide(); // скрываем форму с меню
			GameForm game = new GameForm();
			game.ShowDialog(); // показываем форму с игрой
			Show(); // разворачиваем форму с меню после закрытия игры
		}

		/// <summary>Открывает форму с настройками игры.</summary>
		private void BtSettings_Click(object sender, EventArgs e)
		{
			SettingsForm settings = new SettingsForm();
			settings.ShowDialog();
		}

		/// <summary>Выход из приложения.</summary>
		private void BtExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>После закрытия игры, сохраняем все настройки.</summary>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
			UserManager.SaveUserData();
		}

		/// <summary>Открытие формы с информацией об игре и разработчике.</summary>
		private void BtAbout_Click(object sender, EventArgs e)
		{
			AboutGame about = new AboutGame();
			about.ShowDialog(); // показываем форму с игрой
		}

		/// <summary>Открытие формы с выбором пользователя.</summary>
		private void BtChangeUser_Click(object sender, EventArgs e)
		{
			var userControl = new FUserControl();
			userControl.ShowDialog();
		}

		/// <summary>Открытие формы с статистикой о пользователе.</summary>
		private void BtUserStatistic_Click(object sender, EventArgs e)
		{
			var userStat = new UserStatistic();
			userStat.ShowDialog();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			new UserManager();
		}
		#endregion

		private void MainForm_Activated(object sender, EventArgs e)
		{
			UserManager.CheckOnLevel();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


