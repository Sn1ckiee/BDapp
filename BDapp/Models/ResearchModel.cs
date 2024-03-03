using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDapp.Models
{
    public class ResearchModel
    {
        //Поля
        private int id;
        private int data;
        private string method;

        //Свойства-Проверки
        [DisplayName("Research ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Data")]
        [Required(ErrorMessage = "Data is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        [DisplayName("Method")]
        [Required(ErrorMessage = "Method is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string Method
        {
            get { return method; }
            set { method = value; }
        }
    }
}