using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Form1 : Form
    {
        private const string ScoresFileName = "scores.txt";
        public Form1()
        {
            InitializeComponent();
            LoadScores();
        }
        private int GenerateScore()
        {
            // Replace this with your actual game logic to generate a score
            Random random = new Random();
            return random.Next(0, 1000); // Adjust the range based on your game requirements
        }

        private void SaveScore(string playerName, int score)
        {
            // Save the new score to the file
            using (StreamWriter writer = new StreamWriter(ScoresFileName, true))
            {
                writer.WriteLine($"{playerName}: {score}");
            }
        }
        private void LoadScores()
        {
            // Load existing scores from the file
            if (File.Exists(ScoresFileName))
            {
                List<string> scores = new List<string>(File.ReadAllLines(ScoresFileName));

                // Sort scores in descending order
                scores.Sort((a, b) =>
                {
                    int scoreA = int.Parse(a.Split(':')[1].Trim());
                    int scoreB = int.Parse(b.Split(':')[1].Trim());
                    return scoreB.CompareTo(scoreA);
                });

                // Display sorted scores in the ListBox
                listBoxScores.Items.Clear();
                listBoxScores.Items.AddRange(scores.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = textBoxPlayerName.Text;
            int score;

            // Generate a score automatically using your game logic
            score = GenerateScore();

            SaveScore(playerName, score);
            LoadScores(); // Reload scores after saving

        }
    }
}

