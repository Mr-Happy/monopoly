﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restless.Monopoly.Domain.Model
{
    class Stats
    {
        public int Money { get; private set; }

        public void Stats()
        {
            Money = 0;
        }

        public void AddMoney(int moneyToAdd)
        {
            Money += moneyToAdd;
        }

        public int GetAndRemoveMoney(int moneyToRemove)
        {
            // TODO: handle not enough money
            Money -= moneyToRemove;

            return moneyToRemove;
        }
    }
}
