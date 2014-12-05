﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EFMVC.Model
{
    public class PostProfile
    {
        [Key]
        public int ProfileId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public string Headline { get; set; }
        public virtual Designation Designation { get; set; }
        public int DesignationId { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public int TotalExperience { get; set; }
        public int Mobile { get; set; }
        public int Landline { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string FileName { get; set; }
        public string FileURL { get; set; }
    }
}
