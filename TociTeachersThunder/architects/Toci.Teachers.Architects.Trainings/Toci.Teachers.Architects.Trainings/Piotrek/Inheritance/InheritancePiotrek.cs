﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Architects.Training.Interfaces.GhostRider.Inheritance;

namespace Toci.Architects.Training.Piotrek.Inheritance
{
    public class InheritancePiotrek : ICsprojPropagator
    {
        public void SendCharacter(int position, string text)
        {
            throw new NotImplementedException();
        }

        public bool CanPropagateCsproj(string path)
        {
            throw new NotImplementedException();
        }
    }
}