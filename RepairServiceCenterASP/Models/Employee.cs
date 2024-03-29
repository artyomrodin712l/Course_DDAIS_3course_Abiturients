﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepairServiceCenterASP.Models
{
    [Display(Name = "Сотрудник")]
    public class Employee
    {
        public enum SortState
        {
            FullNameAsc, FullNameDesc,
            ExperienceAsc, ExperienceDesc,
            PostAsc, PostDesc
        }

        [Display(Name = "Код")]
        public int EmployeeId { get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Опыт работы")]
        public int? Experience { get; set; }
        [Display(Name = "Id должности")]
        public int? PostId { get; set; }

        [Display(Name = "Должность")]
        public Post Post { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Employee()
        {
            Orders = new List<Order>();
        }
    }
}
