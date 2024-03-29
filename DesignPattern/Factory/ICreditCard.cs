﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public interface ICreditCard
    {
        string GetCardType();

        int GetCreditLimit();

        int GetAnnualCharge();
    }
}
