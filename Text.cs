using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Text
    {
        private  List<string> paragraphs = new List<string>();
        public void writeText() {
            Console.WriteLine("Enter block of text. Type \'exit\' in a new line to finish.");
            var line = Console.ReadLine();
            while (line.ToLower() != "exit")
            {
                if (!string.IsNullOrEmpty(line))
                {
                    this.paragraphs.Add(line);
                }
                line = Console.ReadLine();
            }
        }
        public int getParagraphCount()
        {
            return this.paragraphs.Count;
        }
        public int getSentenceCount()
        {
            List<string> sentences = new List<string>();
            List<string> nonEmptySentences = new List<string>();
            foreach (var paragraph in paragraphs)
                sentences.AddRange(paragraph.Split('.', '!', '?'));

            foreach (var sentence in sentences)
                if(!string.IsNullOrWhiteSpace(sentence))
                    nonEmptySentences.Add(sentence);
                    
            return nonEmptySentences.Count;
        }
        public int getWordCount()
        {
            List<string> words = new List<string>();
            List<string> nonEmptyWords = new List<string>();
            foreach (var paragraph in paragraphs)
                words.AddRange(paragraph.Split(' '));

            foreach (var word in words)
                if (!string.IsNullOrWhiteSpace(word))
                    nonEmptyWords.Add(word);

            return nonEmptyWords.Count;
        }
    }
}
