using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoriVLN.Models.ViewModels
{
    public class FileViewModel
    {
        [Display(Name = "File name")]
        [Required(ErrorMessage = "Please enter file name.")]
        public string name { get; set; }
        public int ownerID { get; set; }
        [Display(Name = "File type")]
        [Required]
        public string fileType { get; set; }
        public DateTime dateTime { get; set; }
        public string content { get; set; }
    }

    public class ShareFileViewModel
    {
        public string shareLink { get; set; }
        public string sendEmailRequest { get; set; } 
    }
}