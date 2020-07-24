using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer
{
    class Analyzer
    {
        private char[] EuABC = new char[26];
        private char[] RuABC = new char[33];
        private char[] ExstraSym = new char[1]; // цифры, символы, пробелы и тд

        // инициализация массивов с анг/рус буквами и инициализация ключей в словарях
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

        public Dictionary<char, int> RuSymbols { get; } = new Dictionary<char, int>();
        public Dictionary<char, int> EuSymbols { get; } = new Dictionary<char, int>();     
        public Dictionary<char, int> ExstraSymbols { get; } = new Dictionary<char, int>(); // цифры, символы, пробелы и тд

        public Dictionary<char, double> ProbabilityRuSymblos { get; } = new Dictionary<char, double>();
        public Dictionary<char, double> ProbabilityEuSymblos { get; }  = new Dictionary<char, double>();

        private string Str;

        public Analyzer(string str)
        {
            Str = str.ToUpper();
            this.InitABC();
            this.CounterEverySymbol();
            this.CounterProbability();
        }

        // Заполнение словарей
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

        // возвращает количество английских букв
        public int EuCounter()
        {
            int EuCounter = 0;
            foreach (char symbol in EuSymbols.Keys)
            {
                EuCounter += EuSymbols[symbol];
            }
            return EuCounter;
        }

        // возвращает количество русских букв
        public int RuCounter()
        {
            int RuCounter = 0;
            foreach (char symbol in RuSymbols.Keys)
            {
                RuCounter += RuSymbols[symbol];
            }
            return RuCounter;
        }

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