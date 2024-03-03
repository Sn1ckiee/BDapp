using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDapp.Models
{
    public class WellModel
    {
        //Поля
        private int id;
        private int number;
        private string area;
        private string cluster;
        private string instrumentType;
        private string hicenseHolder;
        private string user;
        private string customer;
        private string contractor;
        private string batchOperator;
        private string filesLocation;
        private string additionalInfo;
        //Свойства-Проверки
        [DisplayName("Well ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Area")]
        [Required(ErrorMessage = "Area is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        [DisplayName("Cluster")]
        [Required(ErrorMessage = "Cluster is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string Cluster
        {
            get { return cluster; }
            set { cluster = value; }
        }
        [DisplayName("InstrumentType")]
        [Required(ErrorMessage = "InstrumentType is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string InstrumentType
        {
            get { return instrumentType; }
            set { instrumentType = value; }
        }
        [DisplayName("HicenseHolder")]
        [Required(ErrorMessage = "HicenseHolder is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string HicenseHolder
        {
            get { return hicenseHolder; }
            set { hicenseHolder = value; }
        }
        [DisplayName("User")]
        [Required(ErrorMessage = "User is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Customer is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        [DisplayName("Contractor")]
        [Required(ErrorMessage = "Contractor is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string Contractor
        {
            get { return contractor; }
            set { contractor = value; }
        }
        [DisplayName("BatchOperator")]
        [Required(ErrorMessage = "BatchOperator is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string BatchOperator
        {
            get { return batchOperator; }
            set { batchOperator = value; }
        }
        [DisplayName("FilesLocation")]
        [Required(ErrorMessage = "FilesLocation is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string FilesLocation
        {
            get { return filesLocation; }
            set { filesLocation = value; }
        }
        [DisplayName("AdditionalInfo")]
        [Required(ErrorMessage = "AdditionalInfo is requerid")]
        [StringLength(50, MinimumLength = 3)]
        public string AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }
        [DisplayName("Number")]
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}

