using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZemberekDotNet;
using ZemberekDotNet.Morphology;
using ZemberekDotNet.Normalization;

namespace _200601038_odev1_1
{
    public class MorphologicalAnalysis
    {
        private TurkishMorphology turkishMorphology;
        private TurkishSpellChecker turkishSpellChecker;
        string[] words;
        string text;
        public MorphologicalAnalysis(string text)
        {
            this.turkishMorphology = TurkishMorphology.CreateWithDefaults();
            this.words = this.getTextWords(text);
            this.text = text;
            this.turkishSpellChecker = new TurkishSpellChecker(this.turkishMorphology);
        }


        /*
         * remove punctutaions then apply spelling correction
         */
        public string[] spellingCorrection()
        {
            this.words = this.removePunctuations(this.text);
            return this.getCorrectedWords();
        }

        /*
         * Get word array without any word processing except for space removing
         */
        public string[] getTextWords()
        {
            return this.getTextWords(this.text);
        }

        /*
         * Remove puntations in text
         */
        public string[] removePunctuations(string text)
        {
            string[] words = this.getTextWords(text);
            string[] temp;
            for (int i=0;i<words.Length;i+=1)
            {
                temp = words[i].Split('.', ',', ';', '\'', '"', '?', '!', ':', '-');
                for (int j=0; j<temp.Length;j+=1)
                    if (temp[j] != "")
                    {
                        words[i] = temp[j];
                        break;
                    }
            }
            return words;
        }
        /*
         *
         */
        public string[] removePunctuationsFromWords(string[] words)
        {            
            string[] temp;
            for (int i = 0; i < words.Length; i += 1)
            {
                temp = words[i].Split('.', ',', ';', '\'', '"', '?', '!', ':', '-');
                for (int j = 0; j < temp.Length; j += 1)
                    if (temp[j] != "")
                    {
                        words[i] = temp[j];
                        break;
                    }
            }
            return words;
        }

        /*
         * For any word array
         */
        public bool[] getWordTags(string[] words)
        {
            if (words == null)
                return null;

            bool[] tags = new bool[words.Length];
            for(int i=0;i<words.Length; i++)
                tags[i] = this.turkishSpellChecker.Check(words[i]);
            return tags;
        }

        /*
         * For this class
         */
        public bool[] getWordTags()
        {
            return this.getWordTags(this.words);
        }

        /*
         * Get word array
         */
        public string[] getTextWords(string text)
        {
            return text.Split(' ');
        }
        
        /*
         * Get corrected words for any text
         */
        public string[] getCorrectedWords(string text)
        {
            string[] words = this.getTextWords(text);
            return this.getCorrectedWords(words);
        }
        
        /*
         * Get corrected words for word array
         */
        public string[] getCorrectedWords(string[] words)
        {
            bool[] wordTags = this.getWordTags(words);
            for (int i = 0; i < words.Length; i += 1)
                if (!wordTags[i])
                    words[i] = this.correctWord(words[i]);
            return words;
        }


        /*
         * Get corrected words for object text
         */
        public string[] getCorrectedWords()
        {

            return this.getCorrectedWords(this.getTextWords(this.text));
        }

        /*
         * Correct word
         */
        public string correctWord(string word)
        {
            string temp = word;
            int maxSameLetter = 0, counter;
            List<string> suggests = this.turkishSpellChecker.SuggestForWord(word);
            
            for(int i=0; i< suggests.Count;i+=1)
            {
               
                counter = 0;
                for(int j = 0; j< suggests[i].Length; j+=1)
                {
                    if (j >= word.Length)
                        break;
                    if (word[j] == suggests[i][j])
                        counter += 1;
                }
                if(counter>maxSameLetter)
                {
                    maxSameLetter = counter;
                    temp = suggests[i];
                }
            }
            return temp;
        }

        /*
         * Returns words that splitted from spaces and punctuations
         */
        public string[] getProcessedTextWords(string text)
        {
            string[] words = this.getTextWords(text);
            words = this.removePunctuationsFromWords(words);
            return words;
        }

        public string[] getProcessedAndCorrectedWords(string text)
        {
            string[] words = this.getProcessedTextWords(text);
            words = this.getCorrectedWords(words);
            return words;
        }

        /**
         * Returns corrected and processed words for this object text
         */
        public string[] getProcessedAndCorrectedWords()
        {
            return this.getProcessedAndCorrectedWords(this.text);
        }
        public TurkishMorphology getTurkisMorphology()
        {
            return this.turkishMorphology;
        }
    }
}
