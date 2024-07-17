namespace finalProjectProfElec
{
    partial class CurrencyConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverterForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelFrom = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownFrom = new Bunifu.Framework.UI.BunifuDropdown();
            this.labelTo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownTo = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuLabelResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuButtonClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuButtonConvert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextBoxAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.labelAmountToConvert = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuButtonSwap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblExchangeRate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblExchangeRateMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(207)))), ((int)(((byte)(106)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(120)))), ((int)(((byte)(221)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(483, 65);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.labelFrom.Location = new System.Drawing.Point(8, 78);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(42, 19);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "From";
            // 
            // bunifuDropdownFrom
            // 
            this.bunifuDropdownFrom.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownFrom.BorderRadius = 3;
            this.bunifuDropdownFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDropdownFrom.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownFrom.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownFrom.Items = new string[0];
            this.bunifuDropdownFrom.Location = new System.Drawing.Point(12, 104);
            this.bunifuDropdownFrom.Name = "bunifuDropdownFrom";
            this.bunifuDropdownFrom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.bunifuDropdownFrom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.bunifuDropdownFrom.selectedIndex = -1;
            this.bunifuDropdownFrom.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdownFrom.TabIndex = 2;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.labelTo.Location = new System.Drawing.Point(249, 78);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 19);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To";
            // 
            // bunifuDropdownTo
            // 
            this.bunifuDropdownTo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownTo.BorderRadius = 3;
            this.bunifuDropdownTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDropdownTo.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownTo.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownTo.Items = new string[0];
            this.bunifuDropdownTo.Location = new System.Drawing.Point(254, 104);
            this.bunifuDropdownTo.Name = "bunifuDropdownTo";
            this.bunifuDropdownTo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.bunifuDropdownTo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(196)))), ((int)(((byte)(244)))));
            this.bunifuDropdownTo.selectedIndex = -1;
            this.bunifuDropdownTo.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdownTo.TabIndex = 4;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.bunifuCards1.Controls.Add(this.bunifuLabelResult);
            this.bunifuCards1.Controls.Add(this.labelResult);
            this.bunifuCards1.Controls.Add(this.bunifuButtonClear);
            this.bunifuCards1.Controls.Add(this.bunifuButtonConvert);
            this.bunifuCards1.Controls.Add(this.bunifuTextBoxAmount);
            this.bunifuCards1.Controls.Add(this.labelAmountToConvert);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 190);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(459, 242);
            this.bunifuCards1.TabIndex = 5;
            // 
            // bunifuLabelResult
            // 
            this.bunifuLabelResult.AutoSize = true;
            this.bunifuLabelResult.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelResult.Location = new System.Drawing.Point(128, 194);
            this.bunifuLabelResult.Name = "bunifuLabelResult";
            this.bunifuLabelResult.Size = new System.Drawing.Size(201, 23);
            this.bunifuLabelResult.TabIndex = 6;
            this.bunifuLabelResult.Text = "Converted Amount";
            this.bunifuLabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(202, 164);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result:";
            // 
            // bunifuButtonClear
            // 
            this.bunifuButtonClear.ActiveBorderThickness = 1;
            this.bunifuButtonClear.ActiveCornerRadius = 20;
            this.bunifuButtonClear.ActiveFillColor = System.Drawing.Color.Tomato;
            this.bunifuButtonClear.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuButtonClear.ActiveLineColor = System.Drawing.Color.Tomato;
            this.bunifuButtonClear.BackColor = System.Drawing.Color.White;
            this.bunifuButtonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonClear.BackgroundImage")));
            this.bunifuButtonClear.ButtonText = "Clear";
            this.bunifuButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuButtonClear.IdleBorderThickness = 1;
            this.bunifuButtonClear.IdleCornerRadius = 20;
            this.bunifuButtonClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuButtonClear.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuButtonClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuButtonClear.Location = new System.Drawing.Point(242, 108);
            this.bunifuButtonClear.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuButtonClear.Name = "bunifuButtonClear";
            this.bunifuButtonClear.Size = new System.Drawing.Size(181, 41);
            this.bunifuButtonClear.TabIndex = 4;
            this.bunifuButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonClear.Click += new System.EventHandler(this.bunifuButtonClear_Click);
            // 
            // bunifuButtonConvert
            // 
            this.bunifuButtonConvert.ActiveBorderThickness = 1;
            this.bunifuButtonConvert.ActiveCornerRadius = 20;
            this.bunifuButtonConvert.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.bunifuButtonConvert.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuButtonConvert.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.bunifuButtonConvert.BackColor = System.Drawing.Color.White;
            this.bunifuButtonConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonConvert.BackgroundImage")));
            this.bunifuButtonConvert.ButtonText = "Convert";
            this.bunifuButtonConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonConvert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonConvert.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuButtonConvert.IdleBorderThickness = 1;
            this.bunifuButtonConvert.IdleCornerRadius = 20;
            this.bunifuButtonConvert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.bunifuButtonConvert.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuButtonConvert.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.bunifuButtonConvert.Location = new System.Drawing.Point(36, 108);
            this.bunifuButtonConvert.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuButtonConvert.Name = "bunifuButtonConvert";
            this.bunifuButtonConvert.Size = new System.Drawing.Size(181, 41);
            this.bunifuButtonConvert.TabIndex = 3;
            this.bunifuButtonConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonConvert.Click += new System.EventHandler(this.bunifuButtonConvert_Click);
            // 
            // bunifuTextBoxAmount
            // 
            this.bunifuTextBoxAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bunifuTextBoxAmount.Location = new System.Drawing.Point(153, 55);
            this.bunifuTextBoxAmount.Name = "bunifuTextBoxAmount";
            this.bunifuTextBoxAmount.Size = new System.Drawing.Size(164, 30);
            this.bunifuTextBoxAmount.TabIndex = 2;
            // 
            // labelAmountToConvert
            // 
            this.labelAmountToConvert.AutoSize = true;
            this.labelAmountToConvert.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountToConvert.Location = new System.Drawing.Point(139, 19);
            this.labelAmountToConvert.Name = "labelAmountToConvert";
            this.labelAmountToConvert.Size = new System.Drawing.Size(190, 22);
            this.labelAmountToConvert.TabIndex = 1;
            this.labelAmountToConvert.Text = "Currency Converter";
            // 
            // bunifuButtonSwap
            // 
            this.bunifuButtonSwap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuButtonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.bunifuButtonSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuButtonSwap.BorderRadius = 0;
            this.bunifuButtonSwap.ButtonText = "Swap Currencies";
            this.bunifuButtonSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonSwap.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuButtonSwap.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuButtonSwap.Iconimage = null;
            this.bunifuButtonSwap.Iconimage_right = null;
            this.bunifuButtonSwap.Iconimage_right_Selected = null;
            this.bunifuButtonSwap.Iconimage_Selected = null;
            this.bunifuButtonSwap.IconMarginLeft = 0;
            this.bunifuButtonSwap.IconMarginRight = 0;
            this.bunifuButtonSwap.IconRightVisible = true;
            this.bunifuButtonSwap.IconRightZoom = 0D;
            this.bunifuButtonSwap.IconVisible = true;
            this.bunifuButtonSwap.IconZoom = 90D;
            this.bunifuButtonSwap.IsTab = false;
            this.bunifuButtonSwap.Location = new System.Drawing.Point(337, 47);
            this.bunifuButtonSwap.Name = "bunifuButtonSwap";
            this.bunifuButtonSwap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.bunifuButtonSwap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.bunifuButtonSwap.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuButtonSwap.selected = false;
            this.bunifuButtonSwap.Size = new System.Drawing.Size(134, 34);
            this.bunifuButtonSwap.TabIndex = 6;
            this.bunifuButtonSwap.Text = "Swap Currencies";
            this.bunifuButtonSwap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonSwap.Textcolor = System.Drawing.Color.White;
            this.bunifuButtonSwap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButtonSwap.Click += new System.EventHandler(this.bunifuButtonSwap_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(251, 151);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(136, 13);
            this.lblExchangeRate.TabIndex = 8;
            this.lblExchangeRate.Text = "Exchange Rate Calculation";
            // 
            // lblExchangeRateMessage
            // 
            this.lblExchangeRateMessage.AutoSize = true;
            this.lblExchangeRateMessage.Location = new System.Drawing.Point(9, 151);
            this.lblExchangeRateMessage.Name = "lblExchangeRateMessage";
            this.lblExchangeRateMessage.Size = new System.Drawing.Size(127, 13);
            this.lblExchangeRateMessage.TabIndex = 9;
            this.lblExchangeRateMessage.Text = "Exchange Rate Message";
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 443);
            this.Controls.Add(this.lblExchangeRateMessage);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.bunifuButtonSwap);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuDropdownTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.bunifuDropdownFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrencyConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownTo;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTo;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownFrom;
        private Bunifu.Framework.UI.BunifuCustomLabel labelFrom;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuTextBoxAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel labelAmountToConvert;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuButtonSwap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuButtonConvert;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuButtonClear;
        private Bunifu.Framework.UI.BunifuCustomLabel labelResult;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuLabelResult;
        private Bunifu.Framework.UI.BunifuCustomLabel lblExchangeRateMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblExchangeRate;
    }
}

