using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Control
{
    public interface IControlCommand
    {
        void Execute();
        void Undo();
    }
}
