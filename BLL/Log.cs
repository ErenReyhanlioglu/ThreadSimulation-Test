using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Log
    {
        public int LogID { get; set; }
        public int? CustomerID { get; set; } 
        public int? OrderID { get; set; }    
        public DateTime LogDate { get; set; }
        public LogType LogType { get; set; } 
        public string LogDetails { get; set; }
    }

    public enum LogType
    {
        Error,
        Info,
        Warning
    }
}
