using System;
using System.Collections.Generic;
using System.Text;

namespace HelloConsole
{
    public class Greeting
    {
        public string Name { get; set; } = "runner";

        public string BuildMessage()
        {
            return $"Hello, world, {Name}!";
        }
    }
}
