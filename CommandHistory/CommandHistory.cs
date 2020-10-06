using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandHistory
{
    public class CommandHistory
    {
        private static  CommandHistory instance;

        private List<string> MyCommandHistoryList { get; set; }

        private CommandHistory()
        {
            MyCommandHistoryList = new List<string>();
        }

        public static CommandHistory getInstance()
        {
            if (instance == null)
            {
                instance = new CommandHistory();
            }
            return instance;
        }

        public void AddToList(string input)
        {
            MyCommandHistoryList.Add(input);
        }

        public void RemoveFromList(string input)
        {
            MyCommandHistoryList.Remove(input);
        }
    }
}
