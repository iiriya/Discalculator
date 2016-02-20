//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="DecimalTextBox.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains a TextBox used in decimal values process.</summary>
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
    using System.ComponentModel;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// A <see cref="System.Windows.Forms.TextBox">TextBox</see> used in decimal values process.
    /// </summary>
    public class DecimalTextBox : TextBox
    {
        #region DecimalTextBox Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Discalculator.DecimalTextBox">DecimalTextBox</see> class.
        /// </summary>
        public DecimalTextBox() : base()
        {
        }
        #endregion

        #region DecimalTextBox Properties
        /// <summary>
        /// Gets the decimal value.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public decimal DecimalValue
        {
            get
            {
                decimal d;

                if (decimal.TryParse(this.Text.Replace('.', ','), out d))
                {
                    return d;
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

        #region DecimalTextBox Methods
        /// <summary>
        /// Raises the <see cref="System.Windows.Forms.Control.KeyPress">KeyPress</see> event.
        /// </summary>
        /// <param name="e">Required parameter. Type: <see cref="System.Windows.Forms.KeyPressEventArgs">KeyPressEventArgs</see>. Contains the event data.</param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e != null)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                if (((e.KeyChar == '.') || (e.KeyChar == ',')) && ((this.Text.IndexOf('.') > -1) || (this.Text.IndexOf(',') > -1)))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
    }
}