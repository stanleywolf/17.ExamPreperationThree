using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Command:ICommand
{
    public Command(List<string> args, IManager manager)
    {
        Args = args;
        Manager = manager;
    }

    public IManager Manager { get; protected set; }

    protected List<string> Args { get; set; }

    public abstract string Execute();
}
