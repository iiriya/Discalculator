//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the application entry point.</summary>
// <remarks>
//      Iiriya's Discalculator.
//      
//      This project contains a discount calculator.
//      
//      This solution and all its components its owned by Lucio Benini and his companies.
//      This solution is designed in C# for Microsoft .NET Framework and works only under the Windows Operative System.
//      For Mono or other platforms integrations contact the main project owner.
//      The designer and his companies aren't responsible for any damage due to unauthorized installations or usages.
//      
//      This project is created and designed under Microsoft .NET 2.0 environment and runtime and requires the runtime version 2.0 or later.
//      
//      This project is licensed. Copyright © Lucio Benini 2016. All Rights Reserved.
// </remarks>
//-----------------------------------------------------------------------------------------------------------------------

namespace Iiriya.Apps.Discalculator
{
    #region Using Directives
    using System;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// The application entry point.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main application entry point.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiscalculatorForm());
        }
    }
}