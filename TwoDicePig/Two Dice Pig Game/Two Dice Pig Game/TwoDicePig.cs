using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_Dice_Pig_Game
{
    public partial class frmTwoDicePig : Form
    {
        public frmTwoDicePig()
        {
            InitializeComponent();
        }

        // Created a user defined structure called "player" to hold game variables for player 1, and player 2
        public struct player
        {
            public int firstRoll;
            public int secondRoll;
            public int turnTotal;
            public int gameScore;

        }

        // Created global variables for player 1 and player 2
        player player1, player2;

        // Created global random number generator
        Random randomGenerator = new Random();

        // Method to update picture boxes for first and second dice rolls
        public void UpdatePictureBoxes(player p)
        {
            if (p.firstRoll == 1)
            {
                pbDice1.BackgroundImage = Image.FromFile("face1.png");
            }
            else if (p.firstRoll == 2)
            {
                pbDice1.BackgroundImage = Image.FromFile("face2.png");
            }
            else if (p.firstRoll == 3)
            {
                pbDice1.BackgroundImage = Image.FromFile("face3.png");
            }
            else if (p.firstRoll == 4)
            {
                pbDice1.BackgroundImage = Image.FromFile("face4.png");
            }
            else if (p.firstRoll == 5)
            {
                pbDice1.BackgroundImage = Image.FromFile("face5.png");
            }
            else
            {
                pbDice1.BackgroundImage = Image.FromFile("face6.png");
            }

            if (p.secondRoll == 1)
            {
                pbDice2.BackgroundImage = Image.FromFile("face1.png");
            }
            else if (p.secondRoll == 2)
            {
                pbDice2.BackgroundImage = Image.FromFile("face2.png");
            }
            else if (p.secondRoll == 3)
            {
                pbDice2.BackgroundImage = Image.FromFile("face3.png");
            }
            else if (p.secondRoll == 4)
            {
                pbDice2.BackgroundImage = Image.FromFile("face4.png");
            }
            else if (p.secondRoll == 5)
            {
                pbDice2.BackgroundImage = Image.FromFile("face5.png");
            }
            else
            {
                pbDice2.BackgroundImage = Image.FromFile("face6.png");
            }
        }

        // Created method to update turn total of players
        public int updateTurnTotal(ref player p)
        {
            p.turnTotal = p.turnTotal + p.firstRoll + p.secondRoll;
            return p.turnTotal;
        }

        // Method to update game score of players
        public int updateGameScore(ref player p)
        {
            p.gameScore = p.gameScore + p.turnTotal;
            return p.gameScore;
        }

        // Method to update scoreboard of players
        public void UpdateScoreBoard()
        {
            txtP1TurnTotal.Text = player1.turnTotal.ToString();
            txtP2TurnTotal.Text = player2.turnTotal.ToString();
            txtP1GameScore.Text = player1.gameScore.ToString();
            txtP2GameScore.Text = player2.gameScore.ToString();
        }

        // Method to reset the turn total to 0 
        public int resetTurnTotal(ref player p)
        {
            p.turnTotal = 0;
            return p.turnTotal;
        }

        // Method to reset game score to 0
        public int resetGameScore(ref player p)
        {
            p.gameScore = 0;
            return p.gameScore;
        }

        // Method to display a message when a player is in a winning position, and highlights the hold button to convince them to hold 
        public void winningMessage()
        {
            if (player1.gameScore + player1.turnTotal >= 100)
            {
                MessageBox.Show("Player 1, you are in a winning position! Click hold to lock it in!");

                btnP1Hold.ForeColor = Color.Yellow;
            }

            else if (player2.gameScore + player2.turnTotal >= 100)
            {
                MessageBox.Show("Player 2, you are in a winning position! Click hold to lock it in!");

                btnP2Hold.ForeColor = Color.Yellow;
            }
            else
            {
                btnP1Hold.ForeColor = Color.Black;
                btnP2Hold.ForeColor = Color.Black;
            }
        }

        // Method to display a winner and disable all buttons once winner is announced
            public void displayWinner()
            {
                if(player1.gameScore >= 100)
                {
                lblInfo.Text = "Player 1 Wins!";

                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;
            }
                else if(player2.gameScore >= 100)
                {
                lblInfo.Text = "Player 2 Wins!";

                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;
            }
            }

        private void btnP1Play_Click(object sender, EventArgs e)
        {
            // Randomly generating a side of the die on roll 1 and roll 2
            player1.firstRoll = randomGenerator.Next(1, 7);
            player1.secondRoll = randomGenerator.Next(1, 7);

            // updating picture boxes when player 1 plays
            UpdatePictureBoxes(player1);

            // Updating the turn total of player 1 on each roll
            player1.turnTotal = updateTurnTotal(ref player1);

            // runs when the first roll and second roll of player 1 are both 1 (snake eyes rolled!)
            if (player1.firstRoll == 1 && player1.secondRoll == 1)
            {
                // resetting turn total and game score of player 1
                player1.turnTotal = resetTurnTotal(ref player1);
                player1.gameScore = resetGameScore(ref player1);

                // disabling btns for player 1 and switching turn to player 2
                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = true;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 2's Turn!";
            }
            // runs when player 1 rolls a 1 on either roll
            else if(player1.firstRoll == 1 || player1.secondRoll == 1)
            {
                // resetting turn total of player 1
                player1.turnTotal = resetTurnTotal(ref player1);

                // disabling btns for player 1 and switching turn to player 2
                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = true;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 2's Turn!";
            }
            // runs when player rolls a double (that are not two 1's)
            else if(player1.firstRoll==player1.secondRoll)
            {
                // prevents player 1 from holding (forces them to play again)
                btnP1Play.Enabled = true;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 1's Turn!";
            }
            else
            {
                // Continued game for player 1 as normal, and enabled hold and play btns for player 1
                btnP1Play.Enabled = true;
                btnP1Hold.Enabled = true;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 1's Turn!";

                // shows winning message for player 1 through a label
                winningMessage();
            }

            // updates scoreboard of player 1 based on cases above
            UpdateScoreBoard();
        }

        private void btnP2Play_Click(object sender, EventArgs e)
        {
            // Randomly generating a side of the die on roll 1 and roll 2
            player2.firstRoll = randomGenerator.Next(1, 7);
            player2.secondRoll = randomGenerator.Next(1, 7);

            // updating picture boxes when player 2 plays
            UpdatePictureBoxes(player2);

            // Updating the turn total of player 2 on each roll
            player2.turnTotal = updateTurnTotal(ref player2);

            // runs when the first roll and second roll of player 2 are both 1 (snake eyes rolled!)
            if (player2.firstRoll == 1 && player2.secondRoll == 1)
            {
                // resetting turn total and game score of player 1
                player2.turnTotal = resetTurnTotal(ref player2);
                player2.gameScore = resetGameScore(ref player2);

                // disabling btns for player 2 and switching turn to player 1
                btnP1Play.Enabled = true;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 1's Turn!";
            }
            else if (player2.firstRoll == 1 || player2.secondRoll == 1)
            {
                // resetting turn total of player 2
                player2.turnTotal = resetTurnTotal(ref player2);

                // disabling btns for player 2 and switching turn to player 1
                btnP1Play.Enabled = true;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = false;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 1's Turn!";
            }
            // runs when player rolls a double (that are not two 1's)
            else if (player2.firstRoll == player2.secondRoll)
            {
                // prevents player 2 from holding (forces them to play again)
                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = true;
                btnP2Hold.Enabled = false;

                lblInfo.Text = "Player 2's Turn!";

            }
            else
            {
                // continued game for player 1 as normal, and enabled hold and play btns for player 1
                btnP1Play.Enabled = false;
                btnP1Hold.Enabled = false;

                btnP2Play.Enabled = true;
                btnP2Hold.Enabled = true;

                lblInfo.Text = "Player 2's Turn!";

                // shows winning message for player 2 through a label
                winningMessage();
            }
            // updates scoreboard of player 2 based on cases above
            UpdateScoreBoard();
        }

        private void btnP1Hold_Click(object sender, EventArgs e)
        {
            // updates game score when player 1 clicks hold
            player1.gameScore = updateGameScore(ref player1);
           
            // updates turn total when player 1 clicks hold
            player1.turnTotal = resetTurnTotal(ref player1);

            // disables btns for player 1 and enables the play btn for player 2
            btnP1Play.Enabled = false;
            btnP1Hold.Enabled = false;

            btnP2Play.Enabled = true;
            btnP2Hold.Enabled = false;

            // updates the scoreboard for player 1
            UpdateScoreBoard();

            // displayes the next players turn
            lblInfo.Text = "Player 2's Turn!";

            // displays winner if conditions in method are met
            displayWinner();
        }

        private void btnP2Hold_Click(object sender, EventArgs e)
        {
            // updates game score when player 2 clicks hold
            player2.gameScore = updateGameScore(ref player2);

            // updates turn total when player 2 clicks hold
            player2.turnTotal = resetTurnTotal(ref player2);

            // disables btns for player 2 and enables the play btn for player 1
            btnP1Play.Enabled = true;
            btnP1Hold.Enabled = false;

            btnP2Play.Enabled = false;
            btnP2Hold.Enabled = false;

            // updates the scoreboard for player 2
            UpdateScoreBoard();

            // displayes the next players turn
            lblInfo.Text = "Player 1's Turn!";

            // displays winner if conditions in method are met
            displayWinner();
        }

        // The following code runs when New Game Btn is clicked:
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Initializing turn total and game total for p1 and p2 to 0
            player1.turnTotal = 0;
            player1.gameScore = 0;

            player2.turnTotal = 0;
            player2.gameScore = 0;

            //Updating Score Board when New Game is Clicked
            UpdateScoreBoard();

            // Only enabling play btn of player 1
            btnP1Play.Enabled = true;
            btnP1Hold.Enabled = false;

            btnP2Play.Enabled = false;
            btnP2Hold.Enabled = false;

            // Stating which player's turn it is
            lblInfo.Text= "Player 1's Turn!";

        }

    }
}

