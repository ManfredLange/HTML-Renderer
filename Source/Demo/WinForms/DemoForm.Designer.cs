using HtmlRenderer.WinForms;

namespace HtmlRenderer.Demo.WinForms
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._mainControl = new HtmlRenderer.Demo.WinForms.MainControl();
            this._openSampleFormTSB = new System.Windows.Forms.ToolStripButton();
            this._showIEViewTSSB = new System.Windows.Forms.ToolStripButton();
            this._openInExternalViewTSB = new System.Windows.Forms.ToolStripButton();
            this._useGeneratedHtmlTSB = new System.Windows.Forms.ToolStripButton();
            this._generatePdfTSB = new System.Windows.Forms.ToolStripButton();
            this._runPerformanceTSB = new System.Windows.Forms.ToolStripButton();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openSampleFormTSB,
            this.toolStripSeparator3,
            this._showIEViewTSSB,
            this._openInExternalViewTSB,
            this._useGeneratedHtmlTSB,
            this.toolStripSeparator1,
            this._generatePdfTSB,
            this.toolStripSeparator2,
            this._runPerformanceTSB});
            this._toolStrip.Location = new System.Drawing.Point(4, 4);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(878, 25);
            this._toolStrip.TabIndex = 1;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _mainControl
            // 
            this._mainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainControl.Location = new System.Drawing.Point(4, 32);
            this._mainControl.Name = "_mainControl";
            this._mainControl.Size = new System.Drawing.Size(878, 594);
            this._mainControl.TabIndex = 2;
            this._mainControl.UpdateLock = false;
            this._mainControl.UseGeneratedHtml = false;
            // 
            // _openSampleFormTSB
            // 
            this._openSampleFormTSB.Image = ((System.Drawing.Image)(resources.GetObject("_openSampleFormTSB.Image")));
            this._openSampleFormTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openSampleFormTSB.Name = "_openSampleFormTSB";
            this._openSampleFormTSB.Size = new System.Drawing.Size(129, 22);
            this._openSampleFormTSB.Text = "Open Sample Form";
            this._openSampleFormTSB.Click += new System.EventHandler(this.OnOpenSampleForm_Click);
            // 
            // _showIEViewTSSB
            // 
            this._showIEViewTSSB.Image = ((System.Drawing.Image)(resources.GetObject("_showIEViewTSSB.Image")));
            this._showIEViewTSSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showIEViewTSSB.Name = "_showIEViewTSSB";
            this._showIEViewTSSB.Size = new System.Drawing.Size(96, 22);
            this._showIEViewTSSB.Text = "Show IE View";
            this._showIEViewTSSB.Click += new System.EventHandler(this.OnShowIEView_ButtonClick);
            // 
            // _openInExternalViewTSB
            // 
            this._openInExternalViewTSB.Image = ((System.Drawing.Image)(resources.GetObject("_openInExternalViewTSB.Image")));
            this._openInExternalViewTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openInExternalViewTSB.Name = "_openInExternalViewTSB";
            this._openInExternalViewTSB.Size = new System.Drawing.Size(141, 22);
            this._openInExternalViewTSB.Text = "Open in External View";
            this._openInExternalViewTSB.Click += new System.EventHandler(this.OnOpenInExternalView_Click);
            // 
            // _useGeneratedHtmlTSB
            // 
            this._useGeneratedHtmlTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._useGeneratedHtmlTSB.Image = ((System.Drawing.Image)(resources.GetObject("_useGeneratedHtmlTSB.Image")));
            this._useGeneratedHtmlTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._useGeneratedHtmlTSB.Name = "_useGeneratedHtmlTSB";
            this._useGeneratedHtmlTSB.Size = new System.Drawing.Size(23, 22);
            this._useGeneratedHtmlTSB.Text = "Use Generated HTML";
            this._useGeneratedHtmlTSB.Click += new System.EventHandler(this.OnUseGeneratedHtml_Click);
            // 
            // _generatePdfTSB
            // 
            this._generatePdfTSB.Image = global::HtmlRenderer.Demo.WinForms.Properties.Resources.pdf;
            this._generatePdfTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._generatePdfTSB.Name = "_generatePdfTSB";
            this._generatePdfTSB.Size = new System.Drawing.Size(98, 22);
            this._generatePdfTSB.Text = "Generate PDF";
            this._generatePdfTSB.Click += new System.EventHandler(this.OnGeneratePdf_Click);
            // 
            // _runPerformanceTSB
            // 
            this._runPerformanceTSB.Image = global::HtmlRenderer.Demo.WinForms.Properties.Resources.stopwatch;
            this._runPerformanceTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._runPerformanceTSB.Name = "_runPerformanceTSB";
            this._runPerformanceTSB.Size = new System.Drawing.Size(119, 22);
            this._runPerformanceTSB.Text = "Run Performance";
            this._runPerformanceTSB.Click += new System.EventHandler(this.OnRunPerformance_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(886, 630);
            this.Controls.Add(this._mainControl);
            this.Controls.Add(this._toolStrip);
            this.KeyPreview = true;
            this.Name = "DemoForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "HTML Renderer Demo";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _generatePdfTSB;
        private MainControl _mainControl;
        private System.Windows.Forms.ToolStripButton _openInExternalViewTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _runPerformanceTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _openSampleFormTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _showIEViewTSSB;
        private System.Windows.Forms.ToolStripButton _useGeneratedHtmlTSB;

    }
}
