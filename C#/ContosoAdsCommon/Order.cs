using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoAdsCommon
{
    public enum Category
    {
        [Display(Name = "Mini Lunch")]
        Mini,
        [Display(Name="Medium Pack ")]
        Medium,
        [Display(Name = "Big Jumbo Pack")]
        Big
    }
    public class Order
    {
        public int OrderId { get; set; }
        [StringLength(100)]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        [DisplayName("Class")]
        public string Class { get; set; }
        
        [StringLength(2083)]
        [DisplayName("School")]
        public string School { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostedDate { get; set; }
        public Category? Category { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
    }

}

