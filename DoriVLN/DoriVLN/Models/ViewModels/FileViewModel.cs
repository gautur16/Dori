using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DoriVLN.Models.ViewModels
{
    public class FileViewModel
    {
        [Display(Name = "File name")]
        [Required(ErrorMessage = "Please enter file name.")]
        public string name { get; set; }
        public int ownerID { get; set; }
        [Display(Name = "File type")]
        [Required(ErrorMessage = "Please choose a file type.")]
        public string fileType { get; set; }
        public DateTime dateTime { get; set; }
        public string content { get; set; }
        [Display(Name = "Choose folder")]
        [Required(ErrorMessage ="Please enter a file name")]
        public string folderName { get; set; }
        public int parentFolderID { get; set; }

    }
    public class ShareFileViewModel
    {
        public string fileToShare { get; set; }
        [EmailAddress(ErrorMessage = "This is not a valid email address.")]
        [Display(Name = "Enter the email of user to share with")]
        [Required(ErrorMessage = "Please enter the email address of the user to share with.")]
        public string email { get; set; } 
    }

}