﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.PatternExtractor.Model
{
    public enum PatternType { Normal, RegExp };

    [Serializable]
    class Pattern
    {
        public List<string> PatternText { get; set; }
        public PatternType Type { get; set; }

        public Pattern() { }

        public Pattern(List<string> pattern, PatternType type)
        {
            this.PatternText = pattern;
            this.Type = type;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pattern in this.PatternText)
            {
                sb.Append(pattern);
                sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}
