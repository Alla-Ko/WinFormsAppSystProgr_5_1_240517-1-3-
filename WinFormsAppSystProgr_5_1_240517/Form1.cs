using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsAppSystProgr_5_1_240517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createLists();
            startSettings();
        }
        List<CheckBox> checkBoxes = new List<CheckBox>();
        List<TableLayoutPanel> panels = new List<TableLayoutPanel>();
        List<string> rows = new List<string>();
        List<Label> labels = new List<Label>();
        private CancellationTokenSource cts;
        private ManualResetEventSlim pauseEvent;
        private Task[] tasks;
        List<Task> runningTasks = new List<Task>();
        List<Action<CancellationToken, ManualResetEventSlim>> operations = new List<Action<CancellationToken, ManualResetEventSlim>>();
        private void createLists()
        {
            checkBoxes.Add(checkBoxSentenceCount);
            checkBoxes.Add(checkBoxCharacterCount);
            checkBoxes.Add(checkBoxWordCount);
            checkBoxes.Add(checkBoxInterrogativeCount);
            checkBoxes.Add(checkBoxExclamatoryCount);
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                groupBox1.Controls.Add(checkBox);
            }
            panels.Add(tableLayoutPanelSentenceCount);
            panels.Add(tableLayoutPanelCharacterCount);
            panels.Add(tableLayoutPanelWordCount);
            panels.Add(tableLayoutPanelInterrogativeCount);
            panels.Add(tableLayoutPanelExclamatoryCount);

            rows.Add("Number of sentences: ");
            rows.Add("Number of characters: ");
            rows.Add("Number of words: ");
            rows.Add("Number of interrogative sentences: ");
            rows.Add("Number of exclamatory sentences: ");

            labels.Add(labelSentenceCount);
            labels.Add(labelCharacterCount);
            labels.Add(labelWordCount);
            labels.Add(labelInterrogativeCount);
            labels.Add(labelExclamatoryCount);


            operations.Add(SentenceCountOperation);
            operations.Add(CharacterCountOperation);
            operations.Add(WordCountOperation);
            operations.Add(InterrogativeCountOperation);
            operations.Add(ExclamatoryCountOperation);
        }
        private void startSettings()
        {
            groupBox1.Enabled = true;
            textBox1.Text = "";
            groupBox1.Enabled = true;
            checkBoxAll.Checked = false;
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
            foreach (TableLayoutPanel tableLayoutPanel in panels)
            {
                tableLayoutPanel.Visible = false;
            }
            buttonStart.Visible = true;
            buttonPause.Visible = false;
            buttonContinue.Visible = false;
            buttonClear.Visible = true;
            buttonStop.Visible = false;
            buttonSave.Visible = false;
            foreach (Label label in labels)
            {
                label.Text = "0";
            }

        }
        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.Checked = true;
                }

            }
            else
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.Checked = false;
                }
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (checkBoxes[i] == checkBox)
                    {
                        if (checkBoxes[i].Checked)
                        {
                            panels[i].Visible = true;
                        }
                        else
                        {
                            panels[i].Visible = false;
                        }
                        return;
                    }
                }

            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("No text to check", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool anyOneChecked = false;
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    anyOneChecked = true;
                    break;
                }
            }
            if (!anyOneChecked)
            {
                MessageBox.Show("No report selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Label label in labels)
            {
                label.Text = "0";
            }
            groupBox1.Enabled = false;
            buttonStart.Visible = false;
            buttonPause.Visible = true;
            buttonContinue.Visible = false;
            buttonClear.Visible = false;
            buttonStop.Visible = true;
            buttonSave.Visible = false;

            //запуск всіх завдань
            cts = new CancellationTokenSource();
            pauseEvent = new ManualResetEventSlim(true);
            tasks = new Task[checkBoxes.Count];
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    switch (i)
                    {
                        case 0:
                            tasks[i] = Task.Run(() => SentenceCountOperation(cts.Token, pauseEvent), cts.Token);
                            break;
                        case 1:
                            tasks[i] = Task.Run(() => CharacterCountOperation(cts.Token, pauseEvent), cts.Token);
                            break;
                        case 2:
                            tasks[i] = Task.Run(() => WordCountOperation(cts.Token, pauseEvent), cts.Token);
                            break;
                        case 3:
                            tasks[i] = Task.Run(() => InterrogativeCountOperation(cts.Token, pauseEvent), cts.Token);
                            break;
                        case 4:
                            tasks[i] = Task.Run(() => ExclamatoryCountOperation(cts.Token, pauseEvent), cts.Token);
                            break;

                        default:
                            break;
                    }
                    if (tasks[i] != null)
                    {
                        runningTasks.Add(tasks[i]);
                    }
                }
            }
            await Task.WhenAll(runningTasks);

            groupBox1.Enabled = true;
            buttonStart.Visible = true;
            buttonPause.Visible = false;
            buttonContinue.Visible = false;
            buttonClear.Visible = true;
            buttonStop.Visible = false;
            buttonSave.Visible = true;

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            //призупинка всіх завдань
            pauseEvent.Reset();
            groupBox1.Enabled = false;
            buttonStart.Visible = false;
            buttonPause.Visible = false;
            buttonContinue.Visible = true;
            buttonClear.Visible = false;
            buttonStop.Visible = true;
            buttonSave.Visible = false;

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            //відновлення всіх завдань
            pauseEvent.Set();
            groupBox1.Enabled = false;
            buttonStart.Visible = false;
            buttonPause.Visible = true;
            buttonContinue.Visible = false;
            buttonClear.Visible = false;
            buttonStop.Visible = true;
            buttonSave.Visible = false;

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //повна зупинка всіх завдань
            cts.Cancel();
            groupBox1.Enabled = true;
            buttonStart.Visible = true;
            buttonPause.Visible = false;
            buttonContinue.Visible = false;
            buttonClear.Visible = true;
            buttonStop.Visible = false;
            buttonSave.Visible = false;


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            startSettings();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //збереження результатів у файл txt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "report.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < rows.Count; i++)
                {
                    sb.AppendLine(rows[i] + labels[i].Text);
                }
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }
        }

        private void SentenceCountOperation(CancellationToken token, ManualResetEventSlim pauseEvent)
        {
            int sentenceCount = 0;
            string text = ProcessTextForCounting(textBox1.Text);

            char[] sentenceEndings = { '.', '!', '?' };

            for (int i = 0; i < text.Length; i++)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (Array.IndexOf(sentenceEndings, text[i]) != -1)
                {
                    sentenceCount++;
                    // Оновлення лічильника співпадінь
                    Invoke(new Action(() => labelSentenceCount.Text = sentenceCount.ToString()));
                    Thread.Sleep(10);
                }
                if (i == text.Length - 1 && char.IsLetter(text[i]))
                {
                    sentenceCount++;
                    Invoke(new Action(() => labelSentenceCount.Text = sentenceCount.ToString()));
                    Thread.Sleep(10);
                }

            }
        }
        private void CharacterCountOperation(CancellationToken token, ManualResetEventSlim pauseEvent)
        {
            int сharacterCount = textBox1.Text.Length;

            Invoke(new Action(() => labelCharacterCount.Text = сharacterCount.ToString()));

        }
        private void WordCountOperation(CancellationToken token, ManualResetEventSlim pauseEvent)
        {
            int wordCount = 0;
            bool inWord = false;
            string text = textBox1.Text;
            foreach (char c in text)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (char.IsLetter(c))
                {
                    if (!inWord)
                    {
                        inWord = true;
                        wordCount++;
                        Invoke(new Action(() => labelWordCount.Text = wordCount.ToString()));
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    inWord = false;
                }
            }
        }
        private void InterrogativeCountOperation(CancellationToken token, ManualResetEventSlim pauseEvent)
        {
            int interrogativeCount = 0;

            string text = KeepLettersAndQuestionMarks(textBox1.Text);

            for (int i = 0; i < text.Length - 1; i++)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (text[i] == '?' && text[i + 1] == '?')
                {
                    text = text.Remove(i + 1, 1);
                }
            }
            foreach (char c in text)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (c == '?')
                {
                    interrogativeCount++;
                    Invoke(new Action(() => labelInterrogativeCount.Text = interrogativeCount.ToString()));
                    Thread.Sleep(10);
                }
            }
        }
        private void ExclamatoryCountOperation(CancellationToken token, ManualResetEventSlim pauseEvent)
        {
            int exclamatoryCount = 0;
            string text = KeepLettersAndExclamationMarks(textBox1.Text);

            for (int i = 0; i < text.Length - 1; i++)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (text[i] == '!' && text[i + 1] == '!')
                {
                    text = text.Remove(i + 1, 1);
                }
            }
            foreach (char c in text)
            {
                pauseEvent.Wait(); // Очікуємо, поки не буде відновлено
                if (token.IsCancellationRequested)
                {
                    return; // Виходимо, якщо завдання було скасовано
                }
                if (c == '!')
                {
                    exclamatoryCount++;
                    Invoke(new Action(() => labelExclamatoryCount.Text = exclamatoryCount.ToString()));
                    Thread.Sleep(10);
                }
            }
        }
        static string ProcessTextForCounting(string text)
        {
            char[] sentenceEndings = { '.', '!', '?' };
            text = Regex.Replace(text, @"[^\p{L}.!?]", "");
            //залишилися тільки букви і знаки кінця речень
            int index = 0;
            while (index < text.Length && !char.IsLetter(text[index]))
            {
                index++;
            }
            text = text.Substring(index);
            // Перебираємо всі можливі комбінації двох підряд знаків закінчення речення
            for (int i = 0; i < text.Length - 1; i++)
            {
                char currentChar = text[i];
                char nextChar = text[i + 1];

                if (Array.Exists(sentenceEndings, ending => ending == currentChar) &&
                    Array.Exists(sentenceEndings, ending => ending == nextChar))
                {
                    // Якщо два знаки закінчення літер ідуть підряд
                    text = text.Remove(i + 1, 1);
                }
            }

            return text;
        }
        static string KeepLettersAndQuestionMarks(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c) || c == '?')
                {
                    result.Append(c);
                }
            }
            string text2 = result.ToString();
            int index = 0;
            while (index < text2.Length && !char.IsLetter(text2[index]))
            {
                index++;
            }


            text2 = text2.Substring(index);
            return text2;
        }

        static string KeepLettersAndExclamationMarks(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c) || c == '!')
                {
                    result.Append(c);
                }
            }
            string text2 = result.ToString();
            int index = 0;
            while (index < text2.Length && !char.IsLetter(text2[index]))
            {
                index++;
            }


            text2 = text2.Substring(index);
            return text2;
        }
    }
}
