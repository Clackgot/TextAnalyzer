﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAnalyzer;

namespace TextAnalyzer
{

    enum Language
    {
        None = 0,
        Russian = 1,
        English = 2
    }




    public partial class Form1 : Form
    {
        /// <summary>
        /// Возвращает среднее значение последовательности из count элементов c aver среднем значением и нового элемента со значение add
        /// </summary>
        /// <param name="aver">Среднее значение последовательности</param>
        /// <param name="count">Количество элементов последовательности</param>
        /// <param name="add">Значение нового элемента</param>
        /// <returns>Среднее значение последовательности</returns>
        public static double Average(double aver, int count, double add)
        {
            double temp = count / (double)(count + 1);
            return aver * temp + add / (count + 1);
        }




        public Form1()
        {
            InitializeComponent();
            SetupInputText();
            SetupDataGridViewTextAlphabetInfo(Language.None);
        }



        private void SetupInputText()
        {
            richTextBoxInput.Text = data.defaultInputString;
        }
        /// <summary>
        /// Устанавливает базовую структуру DataGrid
        /// </summary>
        private void SetupDataGridViewTextAlphabetInfoNone()
        {
            dataGridViewTextAlphabetInfo.ColumnCount = 3;
            dataGridViewTextAlphabetInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewTextAlphabetInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTextAlphabetInfo.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewTextAlphabetInfo.Font, FontStyle.Bold);
            dataGridViewTextAlphabetInfo.GridColor = Color.Black;
            dataGridViewTextAlphabetInfo.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewTextAlphabetInfo.AllowUserToAddRows = false;
            dataGridViewTextAlphabetInfo.RowHeadersVisible = false;
            dataGridViewTextAlphabetInfo.ReadOnly = true;


            dataGridViewTextAlphabetInfo.Columns[0].Name = "Буква";
            dataGridViewTextAlphabetInfo.Columns[1].Name = "Количество";
            dataGridViewTextAlphabetInfo.Columns[2].Name = "Частота";
        }
        /// <summary>
        /// Устанавливает структуру DataGrid для отображения информации о русском алфавите
        /// </summary>
        private void SetupDataGridViewTextAlphabetInfoRussian()
        {
            dataGridViewTextAlphabetInfo.Name = "Английский алфавит";

            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            dataGridViewTextAlphabetInfo.Rows.Clear();
            foreach (var item in analyzer.RuSymbols)
            {
                string[] row = { string.Concat(item.Key), string.Concat(item.Value) };
                dataGridViewTextAlphabetInfo.Rows.Add(row);
            }
            int index = 0;
            foreach (var item in analyzer.ProbabilityRuSymblos)
            {

                string prop = string.Concat(item.Value.ToString("N2"));
                dataGridViewTextAlphabetInfo.Rows[index].Cells[2].Value = prop;
                index++;
            }
        }
        /// <summary>
        /// Устанавливает структуру DataGrid для отображения информации о английском алфавите
        /// </summary>
        private void SetupDataGridViewTextAlphabetInfoEnglish()
        {

            dataGridViewTextAlphabetInfo.Name = "Английский алфавит";

            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            dataGridViewTextAlphabetInfo.Rows.Clear();


            foreach (var item in analyzer.EuSymbols)
            {
                string[] row = { string.Concat(item.Key), string.Concat(item.Value)};
                
                dataGridViewTextAlphabetInfo.Rows.Add(row);
            }

            int index = 0;
            foreach (var item in analyzer.ProbabilityEuSymblos)
            {

                string prop = string.Concat(item.Value.ToString("N2"));
                dataGridViewTextAlphabetInfo.Rows[index].Cells[2].Value = prop;
                index++;
            }
        }
        /// <summary>
        /// Устанавливает структуру DataGrid в зависимости от языка
        /// </summary>
        /// <param name="language">Язык</param>
        private void SetupDataGridViewTextAlphabetInfo(Language language)
        {
            switch (language)
            {
                case Language.None:
                    SetupDataGridViewTextAlphabetInfoNone();
                    break;
                case Language.Russian:
                    SetupDataGridViewTextAlphabetInfoRussian();
                    break;
                case Language.English:
                    SetupDataGridViewTextAlphabetInfoEnglish();
                    break;
                default:
                    SetupDataGridViewTextAlphabetInfoNone();
                    break;
            }

        }
        /// <summary>
        /// Тумблер "Русский язык" изменился
        /// </summary>
        private void radioButtonRus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEng.Checked) SetupDataGridViewTextAlphabetInfo(Language.English);
            else if (radioButtonRus.Checked) SetupDataGridViewTextAlphabetInfo(Language.Russian);
        }
        /// <summary>
        /// Тумблер "Английский язык" изменился
        /// </summary>
        private void radioButtonEng_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEng.Checked) SetupDataGridViewTextAlphabetInfo(Language.English);
            else if (radioButtonRus.Checked) SetupDataGridViewTextAlphabetInfo(Language.Russian);
        }
        /// <summary>
        /// В верхнем меню в пункте "Файл" выбран пункт "Открыть файл" 
        /// </summary>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = fileName;
            openFileDialog1.Filter = data.openFileDialog1_Filter;
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                richTextBoxInput.Text = File.ReadAllText(fileName, Encoding.Default);
                selectEncodingToolStripMenuItem.Enabled = true;
            }
        }
        /// <summary>
        /// В верхнем меню в пункте "Кодировки" выбран пункт "UTF-8" 
        /// </summary>
        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = File.ReadAllText(fileName, Encoding.UTF8);
            radioButtonRus_CheckedChanged(this, e);
        }
        /// <summary>
        /// В верхнем меню в пункте "Кодировки" выбран пункт "Windows-1251" 
        /// </summary>
        private void windows1251ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            radioButtonRus_CheckedChanged(this, e);
        }
        /// <summary>
        /// В верхнем меню в пункте "Кодировки" выбран пункт "Default" 
        /// </summary>
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = File.ReadAllText(fileName, Encoding.Default);
            radioButtonRus_CheckedChanged(this, e);
        }
        /// <summary>
        /// Название загружаемого текстового файла для анализа
        /// </summary>
        private string fileName = "test.txt";
        /// <summary>
        /// Текст входящего текстового окна изменился
        /// </summary>
        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            
            string inputText = richTextBoxInput.Text;
            Analyzer analyzer = new Analyzer(inputText);

            if(analyzer.EuCounter() >= analyzer.RuCounter())
            {
                radioButtonEng.Checked = true;
                radioButtonRus.Checked = false;
            }
            else
            {
                radioButtonEng.Checked = false;
                radioButtonRus.Checked = true;
            }

            SetupDataGridViewTextAlphabetInfo(GetCurrentLanguage());

        }


        /// <summary>
        /// Текущий выбранный язык
        /// </summary>
        private Language GetCurrentLanguage()
        {
            if(radioButtonEng.Checked)
            {
                return Language.English;
            }
            else if(radioButtonRus.Checked)
            {
                return Language.Russian;
            }
            else
            {
                return Language.None;
            }
        }

        /// <summary>
        /// Нажатие на кнопку Сохранить на вкладке "Общая статистика"
        /// </summary>

        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Нажатие на кнопку О программе
        /// </summary>
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string messageBoxTitle = "О программе";
            string messageBoxText = "Text Analyzer v" + applicationVersion;
            MessageBox.Show(
        messageBoxText,
        messageBoxTitle,
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }
    }


}
