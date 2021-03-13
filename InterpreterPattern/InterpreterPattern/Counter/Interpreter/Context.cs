using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Counter.Interpreter
{
    public class Context
    {

        private int _currentLine = -1;

        public string[] FileContent { get; set; }

        public Context(string[] fileContent)
        {
            this.FileContent = fileContent;
        }

        public string Line { get; set; }
        public bool LineHandled { get; set; }

        public bool HasNext()
        {
            bool hasNext = (_currentLine + 1) < FileContent.Length;
            return hasNext;
        }

        public string MoveNext()
        {
            if (!HasNext())
            {
                Line = null;
                return Line;
            }

            _currentLine++;
            Line = FileContent[_currentLine].Trim();
            LineHandled = false;

            return Line;
        }

        public string PartName { get; set; }
        public int ItemsCount { get; set; }
        public int Size { get; set; }

    }
}
