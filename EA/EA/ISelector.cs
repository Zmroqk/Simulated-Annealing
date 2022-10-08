﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.EA
{
    public interface ISelector<T> where T : ISpecimen
    {
        IList<T> Select(IList<T> currentPopulation);
    }
}
