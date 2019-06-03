using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    public struct FilePaths
    {
        public const string Ext = ".txt";
        public const string Areas = @"Data\areas\";
        public const string Items = @"Data\items\";

        public const string Actions = @"Data\commands\actions\";
        public const string Objects = @"Data\commands\objects\";

        public const string Cmds_Single = @"Data\commands\actions\singleWordOnly\";
        public const string Cmds_Constant = @"Data\commands\actions\constant\";
    }
}
