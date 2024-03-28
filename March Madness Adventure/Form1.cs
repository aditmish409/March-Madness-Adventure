using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace March_Madness_Adventure
{
    public partial class Form1 : Form
    {
        int page = 1; //assigning the integer "page" a value
        Random randGen = new Random(); //setting up for a random output later

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //setting up where button 1 takes you to from each page
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }

            DisplayPage();
        }

        private void button2_Click(object sender, EventArgs e) //setting up where button 2 takes you to from each page
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 13;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if ( page == 9)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 17) //when on page 17, and clicked button 2, choose a random output between 2 options
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 50)
                {
                    page = 23;
                }
                else
                {
                    page = 22;
                }
                
            }

            DisplayPage();
        }
        private void DisplayPage() //adding the text, image and sound to each page
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "Welcome! You are going to a March Madness Game. Do you want to:";
                    button1.Text = "Play";
                    button2.Text = "Watch";
                    button3.Enabled = false;
                    break;
                case 2:
                    imageBox.Image = Properties.Resources.walkingOut;
                    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.crowdCheering);
                    soundPlayer.Play();

                    outputLabel.Text = "You are walking out on to the court and the fans are cheering for you. Do you wish to celebrate?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 3:
                    imageBox.Image = Properties.Resources.courtsideSeats;

                    outputLabel.Text = "You are sitting courtside and see your favourite player. Do you try to talk to them?";
                    button1.Text = "Talk";
                    button2.Text = "Watch";
                    button3.Enabled = false;
                    break;
                case 4:
                    imageBox.Image = Properties.Resources.walkingOut;
                    SoundPlayer soundPlayer2 = new SoundPlayer(Properties.Resources.grunt);
                    soundPlayer2.Play();

                    outputLabel.Text = "You trip and hurt your leg. Now you're out for the game. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 5:
                    imageBox.Image = Properties.Resources.walkingOut;

                    outputLabel.Text = "You stay humble and the crowd cheers for you. Your coach sees this and wants you to start. Do you accept?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.shot;

                    outputLabel.Text = "You start in the game, and score 30 points. You need one more point to break the franchise record. There are 6 seconds left and you can either pass the ball to your open teammate or take the contested shot yourself. Your team needs 3 points to tie the game. What do you do?";
                    button1.Text = "Shoot";
                    button2.Text = "Pass";
                    button3.Enabled = false;
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.bench;

                    outputLabel.Text = "You don't start and your coach gets mad. You sit on the bench the entire game. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 8:
                    imageBox.Image = Properties.Resources.gamewinner;

                    outputLabel.Text = "You shot the contested shot and made it! But your foot was on the line and it only counted as 2 points! Your team loses the game but you broke the scoring record. You're seen as one of the team's greatest players ever. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 9:
                    imageBox.Image = Properties.Resources.gameloss;
                    SoundPlayer soundPlayer3 = new SoundPlayer(Properties.Resources.crowdboo);
                    soundPlayer3.Play();

                    outputLabel.Text = "You pass the ball to your wide open teammate who shoots... and misses. Everyone blames you for passing up the shot. You have a chance to redeem yourself in the post game interview. A reporter asks you why you passed up the shot. How do you respond?";
                    button1.Text = "I wanted my teammate to have the glory.";
                    button2.Text = "I don't care about the scoring record.";
                    button3.Enabled = false;
                    break;
                case 10:
                    imageBox.Image = Properties.Resources.pressconference;

                    outputLabel.Text = "You say you wanted your teammate to have the glory. Everyone looks at you as a hero and a team player. You are cemented into the hall of fame of the team. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.pressconference;

                    outputLabel.Text = "You say you don't want the scoring record but everyone accuses you of lying. They think you were too scared to shoot the game winning shot in case you missed. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 12:
                    imageBox.Image = Properties.Resources.autograph;

                    outputLabel.Text = "You get their attention and you ask for an autograph. They say they'll meet you at your seat at the end of the game. It's now the end of the game. Do you wait?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 13:
                    imageBox.Image = Properties.Resources.selfie;

                    outputLabel.Text = "You see the player's upset so you decide not to bother him. On your way out, you see the player again, and this time you decide to take an unwanted selfie with him. You capture him mid sneeze, and he wants you to delete it. Instead, you run away. Do you want to post the picture or keep it as a memory?";
                    button1.Text = "Post";
                    button2.Text = "Save";
                    button3.Enabled = false;
                    break;
                case 14:
                    imageBox.Image = Properties.Resources.talkingtocoach;

                    outputLabel.Text = "You wait for the player but they forget about you. Luckily , you see the coach and tell him what happened. The coach gives you an option. You can either get free courtside seats to the next game or get the player's autograph. What do you do?";
                    button1.Text = "Seats";
                    button2.Text = "Autograph";
                    button3.Enabled = false;
                    break;
                case 15:
                    imageBox.Image = Properties.Resources.autograph;

                    outputLabel.Text = "You decide you have better things to do with your time and leave. Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 16:
                    imageBox.Image = Properties.Resources.selfie;

                    outputLabel.Text = "You post the picture and end up gaining 4 million likes. The only downside is that you re banned from ever going to another game. You Lose! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 17:
                    imageBox.Image = Properties.Resources.autograph;

                    outputLabel.Text = "You save the picture and decide not to post it. The player texts you and offers three options. You can either get an autograph, play in a game, or sit with the announcers. What do you do?";
                    button1.Text = "Autograph";
                    button2.Text = "Play";
                    button3.Text = "Broadcast";
                    break;
                case 18:
                    imageBox.Image = Properties.Resources.courtsideSeats;

                    outputLabel.Text = "You take the seats and never get to meet your favourite player. On top of that, the team loses every game of the season that you are in attendance for. You Lose! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 19:
                    imageBox.Image = Properties.Resources.picturewithplayer;

                    outputLabel.Text = "You go with the coach and get your favourite player's autograph and a selfie with him. You Win! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 20:
                    imageBox.Image = Properties.Resources.jerseymailed;

                    outputLabel.Text = "You choose to get an autograph. An autographed jersey comes in your mail a few weeks later. You Win! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 21:
                    imageBox.Image = Properties.Resources.announcers;

                    outputLabel.Text = "You choose to sit with the announcers for the game and they let you introduce the players as they walk on. You mess up the pronounciation of every players' names horribly. You Lose! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 22:
                    imageBox.Image = Properties.Resources.loss;

                    outputLabel.Text = "You chose to play. The next day, you play in a game with the team. You end the game with 4 points and a broken collarbone. You Lose! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 23:
                    imageBox.Image = Properties.Resources.win;

                    outputLabel.Text = "You chose to play. The next day, you have a game with the team. You end the game with 30 points and a game winner. You Win! Play Again?";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Enabled = false;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing";
                    button1.Text = "";
                    button2.Text = "";
                    Refresh(); //the program closes after 1 second, if button 2 is clicked
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
