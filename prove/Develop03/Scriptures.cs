using System;

class Scripture 
{
    private List<Word> words;

    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText);

    private void CreateWords(string _scriptureText);

    public string GetScripture();

    public bool HaswordsLeft();

    public void Removewords();
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsToRemove = 0;

        do
        {
            int rndIndex = new Random().Next(2,4);
            // Only replace word if it hasn't been replaced yet
            if (words[rndIndex].GetIsHidden() == false)
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numWordsToRemove && this.HasWordsLeft());
    }
}