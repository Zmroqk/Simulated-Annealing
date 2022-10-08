﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.EA
{
    public interface IMutator<T> where T : ISpecimen
    {
        IList<T> Mutate(IList<T> currentPopulation);
    }
}
