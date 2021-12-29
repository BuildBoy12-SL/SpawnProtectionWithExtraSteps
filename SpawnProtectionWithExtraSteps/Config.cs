// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace SpawnProtectionWithExtraSteps
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets each team with their respective spawn protection times in seconds.
        /// </summary>
        [Description("Each team with their respective spawn protection times in seconds.")]
        public Dictionary<Team, float> SpawnProtectionTimes { get; set; } = new Dictionary<Team, float>
        {
            { Team.CHI, 30f },
            { Team.MTF, 30f },
            { Team.CDP, 15f },
        };
    }
}