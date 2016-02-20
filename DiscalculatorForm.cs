//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscalculatorForm.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the main form.</summary>
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
    /// Contains the main form.
    /// </summary>
    public partial class DiscalculatorForm : Form
    {
        #region DiscalculatorForm Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Discalculator.DiscalculatorForm">DiscalculatorForm</see> class.
        /// </summary>
        public DiscalculatorForm()
        {
            this.InitializeComponent();

            this.modeComboBox.SelectedIndex = 0;
            this.percentageComboBox.SelectedIndex = 0;

            this.roundTextBox.KeyPress += this.OnlyNumbersKeyPress;
            this.roundTextBox.TextChanged += this.UpdateResult;
            this.valueTextBox.TextChanged += this.UpdateResult;
            this.modeComboBox.SelectedIndexChanged += this.UpdateResult;
            this.percentageTextBox.TextChanged += this.UpdateResult;
            this.percentageComboBox.SelectedIndexChanged += this.UpdateResult;

            this.onTopCheckBox.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (this.onTopCheckBox.Checked)
                {
                    this.TopMost = true;
                }
                else
                {
                    this.TopMost = false;
                }
            };
        }
        #endregion

        #region DiscalculatorForm Properties
        /// <summary>
        /// Gets the discount result.
        /// </summary>
        public decimal Result
        {
            get
            {
                return this.resultTextBox.DecimalValue;
            }
        }
        #endregion

        #region DiscalculatorForm Methods
        /// <summary>
        /// Called when an input value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void UpdateResult(object sender, EventArgs e)
        {
            decimal original = this.valueTextBox.DecimalValue;
            decimal ratio = this.percentageTextBox.DecimalValue;
            int round;

            if (!int.TryParse(this.roundTextBox.Text, out round))
            {
                round = 0;
            }

            if (this.percentageComboBox.SelectedItem as string != "+")
            {
                this.resultTextBox.Text = Math.Round(original - ((original / 100.0m) * ratio), round, (MidpointRounding)this.modeComboBox.SelectedItem).ToString("F" + round, (IFormatProvider)null);
            }
            else
            {
                this.resultTextBox.Text = Math.Round(original + ((original / 100.0m) * ratio), round, (MidpointRounding)this.modeComboBox.SelectedItem).ToString("F" + round, (IFormatProvider)null);
            }

            if (this.autoClipCheckBox.Checked)
            {
                Clipboard.SetText(this.resultTextBox.Text, TextDataFormat.Text);
            }
        }

        /// <summary>
        /// Called when a key is pressed on an input field then preserve the field from non-numerical inputs.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.Windows.Forms.KeyPressEventArgs">KeyPressEventArgs</see>. Contains the event data.</param>
        private void OnlyNumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e != null)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
    }
}