using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TextAnalyzer
{
    class Analyzer
    {
        /// <summary>
        /// Инициализация массивов с анг/рус буквами и инициализация ключей в словарях
        /// </summary>
        private void InitABC()
        {
            string strRuABC = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string strEuABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] RuABC = strRuABC.ToCharArray();
            char[] EuABC = strEuABC.ToCharArray();

            foreach (char symbol in RuABC)
            {
                RuSymbols.Add(symbol, 0);
                ProbabilityRuSymblos.Add(symbol, 0);
            }
            foreach (char symbol in EuABC)
            {
                EuSymbols.Add(symbol, 0);
                ProbabilityEuSymblos.Add(symbol, 0);
            }
        }

        /// <summary>
        /// Словари с русскими, англ символами и с их количеством в строке
        /// </summary>
        public Dictionary<char, int> RuSymbols { get; } = new Dictionary<char, int>();
        public Dictionary<char, int> EuSymbols { get; } = new Dictionary<char, int>();     
        public Dictionary<char, int> ExstraSymbols { get; } = new Dictionary<char, int>(); // цифры, символы, пробелы и тд

        /// <summary>
        /// Словари с символами и с частотой в строке
        /// </summary>
        public Dictionary<char, double> ProbabilityRuSymblos { get; } = new Dictionary<char, double>();
        public Dictionary<char, double> ProbabilityEuSymblos { get; }  = new Dictionary<char, double>();

        private string Str;

        public Analyzer(string str)
        {
            Str = str.ToUpper(CultureInfo.CurrentUICulture);
            this.InitABC();
            this.CounterEverySymbol();
            this.CounterProbability();
        }

        /// <summary>
        /// Заполнение словарей
        /// </summary>
        private void CounterEverySymbol()
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (1040 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 1071)
                {
                    RuSymbols[Str[i]]++;
                }
                else if (65 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 90)
                {
                    EuSymbols[Str[i]]++;
                }
            }
        }       

        /// <summary>
        /// Возвращает количество англ букв
        /// </summary>
        /// <returns></returns>
        public int EuCounter()
        {
            int EuCounter = 0;
            foreach (char symbol in EuSymbols.Keys)
            {
                EuCounter += EuSymbols[symbol];
            }
            return EuCounter;
        }

        /// <summary>
        /// Возвращает количество русских букв
        /// </summary>
        /// <returns></returns>
        public int RuCounter()
        {
            int RuCounter = 0;
            foreach (char symbol in RuSymbols.Keys)
            {
                RuCounter += RuSymbols[symbol];
            }
            return RuCounter;
        }

        /// <summary>
        /// Счетчик частоты букв
        /// </summary>
        private void CounterProbability()
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (1040 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 1071)
                {
                    ProbabilityRuSymblos[Str[i]] = RuSymbols[Str[i]] * 100 / (double)RuCounter();
                }
                else if (65 <= Convert.ToInt32(Str[i]) && Convert.ToInt32(Str[i]) <= 90)
                {
                    ProbabilityEuSymblos[Str[i]] = EuSymbols[Str[i]] * 100 / (double)EuCounter();
                }
            }
        }

    }
}