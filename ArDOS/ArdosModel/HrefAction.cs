﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdosModel
{
    public class HrefAction : IAction
    {
        public string ActionType { get; } = "href".ToUpper();

        public string Href { get; set; }

        /// <summary>
        /// Creates an instance of an HrefAction.
        /// </summary>
        /// <param name="href">The href to open.</param>
        public HrefAction(string href)
        {
            Href = href;
        }

        /// <summary>
        /// Open an href.
        /// </summary>
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
