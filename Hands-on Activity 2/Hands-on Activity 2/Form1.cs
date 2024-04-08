namespace Hands_on_Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("rock");
            UpdateLabels(game);
        }

        private void UpdateLabels(Game game)
        {
            playerChoiceLabel.Text = $"You chose: {game.PlayerChoice}";
            computerChoiceLabel.Text = $"Computer chose: {game.ComputerChoice}";
            resultLabel.Text = game.Result;
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("paper");
            UpdateLabels(game);
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("scissors");
            UpdateLabels(game);
        }
    }
}
