﻿// -----------------------------------------------------------------------
// <copyright file="IPlayerRepository.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Restless.Monopoly.Domain.Model.Players
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IPlayerRepository
    {
        Player GetByName(string playerName);
    }
}
