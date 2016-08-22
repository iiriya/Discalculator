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
    using System.Drawing;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// Contains the main form.
    /// </summary>
    public class DiscalculatorForm : Form
    {
        #region DiscalculatorForm Fields
        /// <summary>
        /// The control that contains the discount value.
        /// </summary>
        private DecimalTextBox valueTextBox;

        /// <summary>
        /// The label of the value control.
        /// </summary>
        private Label valueLabel;

        /// <summary>
        /// The control that contains the discount percentage value.
        /// </summary>
        private DecimalTextBox percentageTextBox;

        /// <summary>
        /// The label of the percentage control.
        /// </summary>
        private Label percentageLabel;

        /// <summary>
        /// The control that contains the discount mode.
        /// </summary>
        private ComboBox percentageComboBox;

        /// <summary>
        /// The label of the percentage combo box.
        /// </summary>
        private Label discountLabel;

        /// <summary>
        /// The control that contains the discount result.
        /// </summary>
        private DecimalTextBox resultTextBox;

        /// <summary>
        /// The label of the result control.
        /// </summary>
        private Label resultLabel;

        /// <summary>
        /// The control that contains the discount round mode.
        /// </summary>
        private TextBox roundTextBox;

        /// <summary>
        /// The label of the result label control.
        /// </summary>
        private Label roundLabel;

        /// <summary>
        /// The control that contains the form always-on-top mode.
        /// </summary>
        private CheckBox onTopCheckBox;

        /// <summary>
        /// The control that contains the automatic copy to clipboard mode.
        /// </summary>
        private CheckBox autoClipCheckBox;

        /// <summary>
        /// The control that contains the discount round mode.
        /// </summary>
        private ComboBox modeComboBox;

        /// <summary>
        /// The label of the discount round mode control.
        /// </summary>
        private Label modeLabel;
        #endregion

        #region DiscalculatorForm Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Discalculator.DiscalculatorForm">DiscalculatorForm</see> class.
        /// </summary>
        public DiscalculatorForm() : base()
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

        /// <summary>
        /// Initializes the form components.
        /// </summary>
        private void InitializeComponent()
        {
            this.valueLabel = new Label();
            this.percentageLabel = new Label();
            this.percentageComboBox = new ComboBox();
            this.discountLabel = new Label();
            this.resultLabel = new Label();
            this.roundLabel = new Label();
            this.roundTextBox = new TextBox();
            this.onTopCheckBox = new CheckBox();
            this.autoClipCheckBox = new CheckBox();
            this.modeLabel = new Label();
            this.modeComboBox = new ComboBox();
            this.resultTextBox = new DecimalTextBox();
            this.percentageTextBox = new DecimalTextBox();
            this.valueTextBox = new DecimalTextBox();
            this.SuspendLayout();

            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new Point(12, 16);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new Size(34, 13);
            this.valueLabel.Text = "Value";
            this.valueLabel.TextAlign = ContentAlignment.MiddleRight;

            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new Point(257, 42);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new Size(15, 13);
            this.percentageLabel.Text = "%";

            this.percentageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.percentageComboBox.FormattingEnabled = true;
            this.percentageComboBox.Items.AddRange(new object[] { "-", "+" });
            this.percentageComboBox.Location = new Point(150, 38);
            this.percentageComboBox.MaxDropDownItems = 2;
            this.percentageComboBox.Name = "percentageComboBox";
            this.percentageComboBox.Size = new Size(37, 21);
            this.percentageComboBox.TabIndex = 3;
            this.percentageComboBox.TabStop = false;

            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new Point(95, 41);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new Size(49, 13);
            this.discountLabel.Text = "Discount";

            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new Point(13, 68);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new Size(37, 13);
            this.resultLabel.Text = "Result";
            this.resultLabel.TextAlign = ContentAlignment.MiddleRight;

            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new Point(184, 92);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new Size(50, 13);
            this.roundLabel.Text = "Decimals";
            this.roundLabel.TextAlign = ContentAlignment.MiddleRight;

            this.roundTextBox.Location = new Point(240, 88);
            this.roundTextBox.MaxLength = 2;
            this.roundTextBox.Name = "roundTextBox";
            this.roundTextBox.Size = new Size(35, 20);
            this.roundTextBox.TabIndex = 5;
            this.roundTextBox.TabStop = false;
            this.roundTextBox.Text = "2";
            this.roundTextBox.TextAlign = HorizontalAlignment.Right;

            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Location = new Point(11, 143);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.Size = new Size(98, 17);
            this.onTopCheckBox.TabIndex = 7;
            this.onTopCheckBox.Text = "Always On Top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;

            this.autoClipCheckBox.AutoSize = true;
            this.autoClipCheckBox.Location = new Point(11, 120);
            this.autoClipCheckBox.Name = "autoClipCheckBox";
            this.autoClipCheckBox.Size = new Size(134, 17);
            this.autoClipCheckBox.TabIndex = 6;
            this.autoClipCheckBox.Text = "Autocopy To Clipboard";
            this.autoClipCheckBox.UseVisualStyleBackColor = true;

            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new Point(16, 92);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new Size(34, 13);
            this.modeLabel.Text = "Mode";
            this.modeLabel.TextAlign = ContentAlignment.MiddleRight;

            this.modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] { MidpointRounding.AwayFromZero, MidpointRounding.ToEven });
            this.modeComboBox.Location = new Point(56, 89);
            this.modeComboBox.MaxDropDownItems = 2;
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new Size(122, 21);
            this.modeComboBox.TabIndex = 4;
            this.modeComboBox.TabStop = false;

            this.resultTextBox.Location = new Point(56, 65);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new Size(219, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = HorizontalAlignment.Right;

            this.percentageTextBox.Location = new Point(193, 39);
            this.percentageTextBox.MaxLength = 8;
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new Size(58, 20);
            this.percentageTextBox.TabIndex = 1;
            this.percentageTextBox.Text = "0";
            this.percentageTextBox.TextAlign = HorizontalAlignment.Right;

            this.valueTextBox.Location = new Point(53, 13);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new Size(219, 20);
            this.valueTextBox.TabIndex = 0;
            this.valueTextBox.Text = "0";
            this.valueTextBox.TextAlign = HorizontalAlignment.Right;

            this.ClientSize = new Size(294, 171);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.autoClipCheckBox);
            this.Controls.Add(this.onTopCheckBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.roundTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.percentageComboBox);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new Size(300, 200);
            this.MinimumSize = new Size(300, 200);
            this.Name = "DiscalculatorForm";
            this.ShowIcon = false;
            this.Text = "Discalculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}