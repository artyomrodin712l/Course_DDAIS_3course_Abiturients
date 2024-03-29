﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepairServiceCenterASP.Models
{
    [Display(Name = "Тип повреждения")]
    public class TypeOfFault
    {
        public enum SortState
        {
            RepairedModelAsc, RepairedModelDesc,
            NameAsc, NameDesc,
            MethodRepairAsc, MethodRepairDesc,
            WorkPriceAsc, WorkPriceDesc
        }

        [Display(Name = "Код")]
        public int TypeOfFaultId { get; set; }
        [Display(Name = "Ремонтируемая модель")]
        public int RepairedModelId { get; set; }
        [Display(Name = "Тип повреждения")]
        public string Name { get; set; }
        [Display(Name = "Метод починки")]
        public string MethodRepair { get; set; }
        [Display(Name = "Цена работы")]
        public double? WorkPrice { get; set; }

        public RepairedModel RepairedModel { get; set; }
        public IEnumerable<SparePart> SpareParts { get; set; }

        public ICollection<Order> Orders { get; set; }

        public TypeOfFault()
        {
            Orders = new List<Order>();
        }
    }
}
