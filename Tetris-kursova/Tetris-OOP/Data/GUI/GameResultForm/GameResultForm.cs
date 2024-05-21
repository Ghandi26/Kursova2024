using System.Windows.Forms;
using Tetris.Data.Modules.Users;

namespace Tetris.Data.GUI.GameResultForm
{
	public partial class GameResultForm : Form
	{
		public GameResultForm()
		{
			InitializeComponent();
			btMenu.DialogResult = DialogResult.Cancel;
			btNewGame.DialogResult = DialogResult.OK;

			lbGameLevel.Text = Properties.Game.Default.GameLevel.ToString();
			lbGameTime.Text = Properties.Game.Default.GameTime.ToString("mm:ss");			
			lbGameScore.Text = Properties.Game.Default.CountScore.ToString();
			UserManager.CheckOnLevel();
		}

        private void GameResultForm_Load(object sender, System.EventArgs e)
        {

        }

        private void lbGameScore_Click(object sender, System.EventArgs e)
        {

        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }
    }
}
