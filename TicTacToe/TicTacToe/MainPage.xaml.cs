using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        String currentPlayer = "O";
        public MainPage()
        {
            InitializeComponent();
            CurrentPlayer.Text = "Playing: " + currentPlayer;
        }

        private void NewGameClicked(object sender, EventArgs e)
        {
            TL.Text = "";
            CL.Text = "";
            BL.Text = "";
            TR.Text = "";
            CR.Text = "";
            CR.Text = "";
            TC.Text = "";
            CC.Text = "";
            CR.Text = "";
        }

        private void PlayClicked()
        {
            if (currentPlayer == "O")
                currentPlayer = "X";
            else if (currentPlayer == "X")
                currentPlayer = "O";
            CurrentPlayer.Text = "Playing: " + currentPlayer;
        }

        private void PlayMoveClicked(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                ((Button)sender).Text = currentPlayer;
                PlayClicked();
            }
        }
    }
}
