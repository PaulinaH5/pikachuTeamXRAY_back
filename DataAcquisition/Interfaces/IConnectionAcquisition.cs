﻿using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcquisition.Interfaces
{
    public interface IConnectionAcquisition : IConnectionDetails
    {
        string GetLocalIPAddress();
    }
}
