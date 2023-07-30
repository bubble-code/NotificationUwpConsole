using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace notif
{
    class MiCommand
    {
        [Option('c', "head", Required = false, HelpText = "Texto de cabecera")]
        public string? Head { get; set; } = " ";
        [Option('b', "body", Required = false, HelpText = "Texto del cuerpo")]
        public string? Body { get; set; } = " ";
    }
}
