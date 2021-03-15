using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Word_Bank
{
    public class Word
    {
        enum Level
        {
            Beginner,
            Pre_intermediate,
            Intermediate,
            Upper_intermediate,
            Advanced
        }
        string word;
        string phonetics;
        string meaning;
        string type;
        List<String> collocations;
        List<String> insentence;
        List<String> synonyms;

        public Word()
        {


        }

        
    }
}
