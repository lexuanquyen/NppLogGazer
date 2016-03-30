﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.PatternExtractor.Model
{
    public enum PatternType { Normal, RegExp };

    [Serializable]
    public class PatternModel
    {
        public List<string> PatternText { get; set; }
        public PatternType Type { get; set; }
        public string Title { get; set; }

        public PatternModel() { }

        public PatternModel(List<string> pattern, PatternType type)
        {
            this.PatternText = pattern;
            this.Type = type;
        }

        public PatternModel(String title, List<string> pattern, PatternType type)
        {
            this.Title = title;
            this.PatternText = pattern;
            this.Type = type;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Title != null)
            {
                sb.Append(Title);
            }
            foreach (var pattern in this.PatternText)
            {
                sb.Append(pattern);
                sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}
