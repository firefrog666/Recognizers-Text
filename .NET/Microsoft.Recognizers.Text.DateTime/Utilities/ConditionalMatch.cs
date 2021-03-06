﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.DateTime
{
    public class ConditionalMatch
    {
        public Match Match { get; }

        public bool Success { get; }

        public ConditionalMatch(Match match, bool success)
        {
            Match = match;
            Success = success;
        }

        public int Index
        {
            get
            {
                return Match.Index;
            }
        }

        public int Length
        {
            get
            {
                return Match.Length;
            }
        }

        public string Value
        {
            get
            {
                return Match.Value;
            }
        }

        public GroupCollection Groups
        {
            get
            {
                return Match.Groups;
            }
        }
    }
}
