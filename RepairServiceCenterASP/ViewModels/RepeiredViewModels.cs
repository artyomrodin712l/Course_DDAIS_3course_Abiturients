﻿using RepairServiceCenterASP.Models;
using System.Collections.Generic;

namespace RepairServiceCenterASP.ViewModels
{
    public class RepeiredViewModels
    {
        public IEnumerable<RepairedModel> RepairedModels { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
