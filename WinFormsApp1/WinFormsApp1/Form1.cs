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
                ("���� + ���� = ������", new Dictionary<string, int> { { "�", 1 }, { "�", 0 }, { "�", 5 }, { "�", 2 }, { "�", 2 }, { "�", 0 }, { "�", 3 }, { "�", 1 } }),
                ("Ѳ� + Ѳ� = ����������", new Dictionary<string, int> { { "�", 2 }, { "�", 3 }, { "�", 7 }, { "�", 1 }, { "�", 0 }, { "�", 6 }, { "�", 4 }, { "�", 5 }, { "�", 8 } }),
                ("�'��� + �'��� = ������", new Dictionary<string, int> { { "�", 1 }, { "�", 0 }, { "�", 5 }, { "�", 6 }, { "�", 7 }, { "�", 2 }, { "�", 8 } }),
                ("��� + ��� = �в�", new Dictionary<string, int> { { "�", 4 }, { "�", 3 }, { "�", 2 }, { "�", 6 }, { "�", 1 }, { "�", 7 }, { "�", 5 } }),
                ("ʲ� + ʲ� = ���", new Dictionary<string, int> { { "�", 5 }, { "�", 3 }, { "�", 4 }, { "�", 1 }, { "�", 6 }, { "�", 2 } }),
                ("�Ҳ� + �Ҳ� = �Ҳ�", new Dictionary<string, int> { { "�", 1 }, { "�", 2 }, { "�", 3 }, { "�", 4 } }),
                ("Ĳ� + Ĳ� = ����", new Dictionary<string, int> { { "�", 1 }, { "�", 5 }, { "�", 4 }, { "�", 7 }, { "�", 3 }, { "�", 6 } }),
                ("в� + в� = ���", new Dictionary<string, int> { { "�", 6 }, { "�", 2 }, { "�", 7 }, { "�", 1 }, { "�", 3 }, { "�", 8 } }),
                ("����� + ����� = ����", new Dictionary<string, int> { { "�", 4 }, { "�", 2 }, { "�", 5 }, { "�", 3 }, { "�", 1 }, { "�", 7 }, { "�", 6 } }),
                ("��ײ� + ��ײ� = ����ֲ", new Dictionary<string, int> { { "�", 1 }, { "�", 3 }, { "�", 4 }, { "�", 5 }, { "�", 6 }, { "�", 2 }, { "�", 0 }, { "�", 7 } })
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

                Result.Text = isCorrect ? "³���!" : "������!";
            }
            catch
            {
                Result.Text = "������!";
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
