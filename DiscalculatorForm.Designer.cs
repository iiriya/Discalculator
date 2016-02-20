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
//      This solution is designed in C# for Microsoft .NET Framework and works only under the Windows Operative 
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
    using System.ComponentModel;
    using System.Windows.Forms;
    #endregion

    partial class DiscalculatorForm
    {
        #region DiscalculatorForm Fields
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private IContainer components = null;

        private DecimalTextBox valueTextBox;
        private Label valueTextBoxLabel;
        private DecimalTextBox percentageTextBox;
        private Label percentageLabel;
        private ComboBox percentageComboBox;
        private Label discountLabel;
        private Label resultLabel;
        private DecimalTextBox resultTextBox;
        private Label roundLabel;
        private TextBox roundTextBox;
        private CheckBox onTopCheckBox;
        private CheckBox autoClipCheckBox;
        private Label modeLabel;
        private ComboBox modeComboBox;
        #endregion

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.valueTextBoxLabel = new Label();
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
            // 
            // valueTextBoxLabel
            // 
            this.valueTextBoxLabel.AutoSize = true;
            this.valueTextBoxLabel.Location = new Point(12, 16);
            this.valueTextBoxLabel.Name = "valueTextBoxLabel";
            this.valueTextBoxLabel.Size = new Size(34, 13);
            this.valueTextBoxLabel.TabIndex = 1;
            this.valueTextBoxLabel.Text = "Value";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new Point(267, 42);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new Size(15, 13);
            this.percentageLabel.TabIndex = 3;
            this.percentageLabel.Text = "%";
            // 
            // percentageComboBox
            // 
            this.percentageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.percentageComboBox.FormattingEnabled = true;
            this.percentageComboBox.Items.AddRange(new object[] {
            "-",
            "+"});
            this.percentageComboBox.Location = new Point(160, 38);
            this.percentageComboBox.MaxDropDownItems = 2;
            this.percentageComboBox.Name = "percentageComboBox";
            this.percentageComboBox.Size = new Size(37, 21);
            this.percentageComboBox.TabIndex = 4;
            this.percentageComboBox.TabStop = false;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new Point(105, 41);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new Size(49, 13);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.Text = "Discount";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new Point(13, 68);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new Size(37, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new Point(184, 92);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new Size(50, 13);
            this.roundLabel.TabIndex = 9;
            this.roundLabel.Text = "Decimals";
            // 
            // roundTextBox
            // 
            this.roundTextBox.Location = new Point(240, 88);
            this.roundTextBox.MaxLength = 2;
            this.roundTextBox.Name = "roundTextBox";
            this.roundTextBox.Size = new Size(35, 20);
            this.roundTextBox.TabIndex = 3;
            this.roundTextBox.TabStop = false;
            this.roundTextBox.Text = "2";
            this.roundTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Location = new Point(11, 143);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.Size = new Size(98, 17);
            this.onTopCheckBox.TabIndex = 10;
            this.onTopCheckBox.Text = "Always On Top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClipCheckBox
            // 
            this.autoClipCheckBox.AutoSize = true;
            this.autoClipCheckBox.Location = new Point(11, 120);
            this.autoClipCheckBox.Name = "autoClipCheckBox";
            this.autoClipCheckBox.Size = new Size(134, 17);
            this.autoClipCheckBox.TabIndex = 11;
            this.autoClipCheckBox.Text = "Autocopy To Clipboard";
            this.autoClipCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new Point(12, 95);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new Size(34, 13);
            this.modeLabel.TabIndex = 13;
            this.modeLabel.Text = "Mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            MidpointRounding.AwayFromZero,
            MidpointRounding.ToEven});
            this.modeComboBox.Location = new Point(56, 89);
            this.modeComboBox.MaxDropDownItems = 2;
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new Size(122, 21);
            this.modeComboBox.TabIndex = 12;
            this.modeComboBox.TabStop = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new Point(56, 65);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new Size(219, 20);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Location = new Point(203, 39);
            this.percentageTextBox.MaxLength = 8;
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new Size(58, 20);
            this.percentageTextBox.TabIndex = 2;
            this.percentageTextBox.Text = "0";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new Point(53, 13);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new Size(219, 20);
            this.valueTextBox.TabIndex = 0;
            this.valueTextBox.Text = "0";
            this.valueTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // DiscalculatorForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(294, 172);
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
            this.Controls.Add(this.valueTextBoxLabel);
            this.Controls.Add(this.valueTextBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new Size(300, 200);
            this.MinimumSize = new Size(300, 200);
            this.Name = "DiscalculatorForm";
            this.ShowIcon = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.Text = "Discalculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}