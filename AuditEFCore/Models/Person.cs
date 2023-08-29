using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditEFCore.Models
{
    public class Person: Entity
    {
        [Required(ErrorMessage = "შეიყვანე მომხმარებლის სახელი ..")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "შეიყვანე კომენტარი ..")]
        public string CommentOne { get; set; }
        public DateTime SendData { get; set; }
        [Required(ErrorMessage = "შეიყვანე კომენტარი ..")]
        public string CommentTwo { get; set; }
        [Required(ErrorMessage = "შეიყვანე თანამშრომლის სახელი ..")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "შეიყვანე კომენტარი ..")]
        public string CommentThree { get; set; }
        [Required(ErrorMessage = "შეიყვანე შეტყობინების კატეგორია ..")]
        public string Category { get; set; }
        [Required(ErrorMessage = "შეიყვანე საკონტაქტო ინფორმაცია ..")]
        public string ContactType { get; set; }
    }
}
