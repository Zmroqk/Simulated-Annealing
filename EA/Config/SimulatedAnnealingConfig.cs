﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTP.Config
{
    public class SimulatedAnnealingConfig : IConfig
    {
        public MutatorType Mutator { get; set; }
        public bool GreedyKnapsackMutator { get; set; }
        public SpecimenInitializatorConfig SpecimenInitializator { get; set; }
        public int NeighborhoodSize { get; set; }
        public double AnnealingRate { get; set; }
        public double StartingTemperature { get; set; }
        public double TargetTemperature { get; set; }
        public string? TestName { get; set; }
        public string OutputFileName { get; set; }
        public string InputFileName { get; set; }
        public int Iterations { get; set; }
        /// <summary>
        /// Number of times current config will be run
        /// </summary>
        public int RunCount { get; set; }

        public string[] Include { get; set; }
    }
}
