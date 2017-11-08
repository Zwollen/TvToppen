using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TVtoppen.Models.ViewModels
{
    public class ProgramVM
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "Programmet måste ha ett namn")]
        public string Title { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string RunTime { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int ChannelId { get; set; }



    }
}