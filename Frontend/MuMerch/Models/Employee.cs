﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        [Required]
        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Division")]
        public int DivisionId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        [Required]
        [StringLength(17)]
        public string NidNo { get; set; }
        [StringLength(25)]
        public string BrnNo { get; set; }
        [StringLength(25)]
        public string PassportNo { get; set; }
        [StringLength(35)]
        public string TinNo { get; set; }
        [Required]
        [StringLength(150)]
        public string FathersName { get; set; }
        [Required]
        [StringLength(150)]
        public string MothersName { get; set; }
        [Required]
        [StringLength(250)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(250)]
        public string PermanentAddress { get; set; }
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Grade")]
        public virtual Grade Grade { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Department Department { get; set; }
        public virtual Division Division { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }
}