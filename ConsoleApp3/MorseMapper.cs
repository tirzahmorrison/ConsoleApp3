using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseMapper
    {
        private Dictionary<string, string> morseMap = new Dictionary<string, string>();
        private Dictionary<string, string> reverseMorseMap = new Dictionary<string, string>();

        public MorseMapper(string path)
        {
            var fullPath = Path.GetFullPath(path);
            var lines = File.ReadAllLines(fullPath);
            foreach(var line in lines)
            {
                var parts = line.Split(',');
                morseMap.Add(parts[0].ToLower(), parts[1]);
                reverseMorseMap.Add(parts[1], parts[0].ToLower());
            }
        }

        public String AlphaMorph(string mightyMorpher)
        {
            return morph(mightyMorpher, morseMap);
        }

        public String MorseMorph(string mightyMorpher)
        {
            return morph(mightyMorpher, reverseMorseMap);

        }
        private String morph(String mightyMorpher, Dictionary<string, string> ranger)
        {
            var result = new List<string>();
            foreach(var c in mightyMorpher)
            {
                if (ranger.ContainsKey(c.ToString().ToLower())) {
                    result.Add(ranger[c.ToString().ToLower()]);
                    
                }
                else
                {
                    result.Add(c.ToString());
                }
            }
            return String.Join("", result); 



        }
    }
}
