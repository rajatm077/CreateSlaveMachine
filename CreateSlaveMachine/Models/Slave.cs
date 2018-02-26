using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateSlaveMachine.Models
{
    public enum OSType
    {
        Windows = 1,
        Linux
    }

    public class Slave
    {
        [Required]
        public string Machine { get; set; }

        [Required]
        public OSType OS { get; set; } = OSType.Windows;

        [Required]
        public string Description { get; set; }

        public string Name { get; set; }

        
        [Display(Name = "Remote Root Directory")]
        public string Rrd { get; set; } //Remote root directory

        public string Label { get; set; }
        
        
        [DisplayName("# of executors")]
        public int Threads { get; set; }

    }
}