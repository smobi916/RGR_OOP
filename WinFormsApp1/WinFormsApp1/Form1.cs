using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<(string puzzle, Dictionary<string, int> solution)> puzzles;
        private (string puzzle, Dictionary<string, int> solution) currentPuzzle;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            InitializePuzzles();
            random = new Random();
            LoadNextPuzzle();
        }

        private void InitializePuzzles()
        {
            puzzles = new List<(string puzzle, Dictionary<string, int> solution)>
            {
                ("ÎÄÈÍ + ÎÄÈÍ = ÁÀÃÀÒÎ", new Dictionary<string, int> { { "Î", 1 }, { "Ä", 0 }, { "È", 5 }, { "Í", 2 }, { "Á", 2 }, { "À", 0 }, { "Ã", 3 }, { "Ò", 1 } }),
                ("Ñ²Ì + Ñ²Ì = ÄÂÀÍÀÄÖßÒÜ", new Dictionary<string, int> { { "Ñ", 2 }, { "²", 3 }, { "Ì", 7 }, { "Ä", 1 }, { "Â", 0 }, { "À", 6 }, { "Í", 4 }, { "Ö", 5 }, { "Ü", 8 } }),
                ("Ï'ßÒÜ + Ï'ßÒÜ = ÄÅÑßÒÜ", new Dictionary<string, int> { { "Ï", 1 }, { "ß", 0 }, { "Ò", 5 }, { "Ü", 6 }, { "Ä", 7 }, { "Å", 2 }, { "Ñ", 8 } }),
                ("ÑÎÍ + ÑÎÍ = ÌÐ²ß", new Dictionary<string, int> { { "Ñ", 4 }, { "Î", 3 }, { "Í", 2 }, { "Ì", 6 }, { "Ð", 1 }, { "²", 7 }, { "ß", 5 } }),
                ("Ê²Ò + Ê²Ò = ÏÅÑ", new Dictionary<string, int> { { "Ê", 5 }, { "²", 3 }, { "Ò", 4 }, { "Ï", 1 }, { "Å", 6 }, { "Ñ", 2 } }),
                ("ÑÒ²Ë + ÑÒ²Ë = ÑÒ²Ë", new Dictionary<string, int> { { "Ñ", 1 }, { "Ò", 2 }, { "²", 3 }, { "Ë", 4 } }),
                ("Ä²Ì + Ä²Ì = ÕÀÒÀ", new Dictionary<string, int> { { "Ä", 1 }, { "²", 5 }, { "Ì", 4 }, { "Õ", 7 }, { "À", 3 }, { "Ò", 6 } }),
                ("Ð²Ê + Ð²Ê = ×ÀÑ", new Dictionary<string, int> { { "Ð", 6 }, { "²", 2 }, { "Ê", 7 }, { "×", 1 }, { "À", 3 }, { "Ñ", 8 } }),
                ("ÑÎÍÖÅ + ÑÎÍÖÅ = ßÑÍÎ", new Dictionary<string, int> { { "Ñ", 4 }, { "Î", 2 }, { "Í", 5 }, { "Ö", 3 }, { "Å", 1 }, { "ß", 7 }, { "À", 6 } }),
                ("ÂÅ×²Ð + ÂÅ×²Ð = ÂÐÀÍÖ²", new Dictionary<string, int> { { "Â", 1 }, { "Å", 3 }, { "×", 4 }, { "²", 5 }, { "Ð", 6 }, { "À", 2 }, { "Í", 0 }, { "Ö", 7 } })
            };
        }

        private void LoadNextPuzzle()
        {
            currentPuzzle = puzzles[random.Next(puzzles.Count)];
            Combinate.Text = currentPuzzle.puzzle;
            First.Clear();
            Second.Clear();
            Third.Clear();
            Result.Text = string.Empty;
        }

        private void CheckSolution()
        {
            try
            {
                var userSolution = new Dictionary<string, int>
                {
                    { "First", int.Parse(First.Text) },
                    { "Second", int.Parse(Second.Text) },
                    { "Third", int.Parse(Third.Text) }
                };

                var correctSolution = currentPuzzle.solution;
                bool isCorrect = correctSolution.Values.Contains(userSolution["First"]) &&
                                 correctSolution.Values.Contains(userSolution["Second"]) &&
                                 correctSolution.Values.Contains(userSolution["Third"]) &&
                                 userSolution.Count == correctSolution.Count;

                Result.Text = isCorrect ? "Â³ðíî!" : "Íåâ³ðíî!";
            }
            catch
            {
                Result.Text = "Íåâ³ðíî!";
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            CheckSolution();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadNextPuzzle();
        }
    }
}
