using System;
using System.Windows.Forms;

namespace Tetris.Data.GUI.UserStatistic
{
	public partial class UserStatistic : Form
	{
		public UserStatistic()
		{
			InitializeComponent();
		}

		private void UserStatistic_Load(object sender, EventArgs e)
		{
			lbTimeInGame.Text = Properties.Settings.Default.TimeInGame.ToString("HH:mm:ss ");
			lbNumberOfGame.Text = Properties.Settings.Default.NumberOfGames.ToString();
		}

        private void lbMoney_Click(object sender, EventArgs e)
        {

        }
    }
}
