﻿using ABCVEN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Interfaces
{
    public interface IViewService
    {
        IEnumerable<SalesViewModel> GetSalesViewModels();
        (DateTime, DateTime) GetTimeBorders();
        IEnumerable<SalesViewModel> GetFilteredViewModel(FilterView filterView);
        DiagrammViewModel GetDiagrammModel(DiagrammViewModel diagrammViewModel, FilterView filter);
    }
}
