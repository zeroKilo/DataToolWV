
namespace DataToolWV
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORAWithBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORAWithBPlusOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESDecryptAWithBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESEncryptAWithBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtba = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbr = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.base64EncodeAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64DecodeAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zLIBCompressAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zLIBDecompressAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xORAWithBToolStripMenuItem,
            this.xORAWithBPlusOffsetToolStripMenuItem,
            this.aESDecryptAWithBToolStripMenuItem,
            this.aESEncryptAWithBToolStripMenuItem,
            this.base64EncodeAToolStripMenuItem,
            this.base64DecodeAToolStripMenuItem,
            this.zLIBCompressAToolStripMenuItem,
            this.zLIBDecompressAToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // xORAWithBToolStripMenuItem
            // 
            this.xORAWithBToolStripMenuItem.Name = "xORAWithBToolStripMenuItem";
            this.xORAWithBToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.xORAWithBToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.xORAWithBToolStripMenuItem.Text = "XOR A with B";
            this.xORAWithBToolStripMenuItem.Click += new System.EventHandler(this.xORAWithBToolStripMenuItem_Click);
            // 
            // xORAWithBPlusOffsetToolStripMenuItem
            // 
            this.xORAWithBPlusOffsetToolStripMenuItem.Name = "xORAWithBPlusOffsetToolStripMenuItem";
            this.xORAWithBPlusOffsetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.xORAWithBPlusOffsetToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.xORAWithBPlusOffsetToolStripMenuItem.Text = "XOR A with B plus Offset";
            this.xORAWithBPlusOffsetToolStripMenuItem.Click += new System.EventHandler(this.xORAWithBPlusOffsetToolStripMenuItem_Click);
            // 
            // aESDecryptAWithBToolStripMenuItem
            // 
            this.aESDecryptAWithBToolStripMenuItem.Name = "aESDecryptAWithBToolStripMenuItem";
            this.aESDecryptAWithBToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.aESDecryptAWithBToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aESDecryptAWithBToolStripMenuItem.Text = "AES Decrypt A with B";
            this.aESDecryptAWithBToolStripMenuItem.Click += new System.EventHandler(this.aESDecryptAWithBToolStripMenuItem_Click);
            // 
            // aESEncryptAWithBToolStripMenuItem
            // 
            this.aESEncryptAWithBToolStripMenuItem.Name = "aESEncryptAWithBToolStripMenuItem";
            this.aESEncryptAWithBToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.aESEncryptAWithBToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aESEncryptAWithBToolStripMenuItem.Text = "AES Encrypt A with B";
            this.aESEncryptAWithBToolStripMenuItem.Click += new System.EventHandler(this.aESEncryptAWithBToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbr);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 403);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtba);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbb);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(800, 251);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtba
            // 
            this.rtba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtba.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtba.Location = new System.Drawing.Point(0, 23);
            this.rtba.Name = "rtba";
            this.rtba.Size = new System.Drawing.Size(800, 126);
            this.rtba.TabIndex = 1;
            this.rtba.Text = "";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbb
            // 
            this.rtbb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbb.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbb.Location = new System.Drawing.Point(0, 23);
            this.rtbb.Name = "rtbb";
            this.rtbb.Size = new System.Drawing.Size(800, 75);
            this.rtbb.TabIndex = 2;
            this.rtbb.Text = "";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbr
            // 
            this.rtbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbr.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbr.Location = new System.Drawing.Point(0, 23);
            this.rtbr.Name = "rtbr";
            this.rtbr.ReadOnly = true;
            this.rtbr.Size = new System.Drawing.Size(800, 125);
            this.rtbr.TabIndex = 2;
            this.rtbr.Text = "";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb1.Location = new System.Drawing.Point(0, 427);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(800, 23);
            this.pb1.TabIndex = 2;
            this.pb1.Visible = false;
            // 
            // base64EncodeAToolStripMenuItem
            // 
            this.base64EncodeAToolStripMenuItem.Name = "base64EncodeAToolStripMenuItem";
            this.base64EncodeAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.base64EncodeAToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.base64EncodeAToolStripMenuItem.Text = "Base64 Encode A";
            this.base64EncodeAToolStripMenuItem.Click += new System.EventHandler(this.base64EncodeAToolStripMenuItem_Click);
            // 
            // base64DecodeAToolStripMenuItem
            // 
            this.base64DecodeAToolStripMenuItem.Name = "base64DecodeAToolStripMenuItem";
            this.base64DecodeAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.base64DecodeAToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.base64DecodeAToolStripMenuItem.Text = "Base64 Decode A";
            this.base64DecodeAToolStripMenuItem.Click += new System.EventHandler(this.base64DecodeAToolStripMenuItem_Click);
            // 
            // zLIBCompressAToolStripMenuItem
            // 
            this.zLIBCompressAToolStripMenuItem.Name = "zLIBCompressAToolStripMenuItem";
            this.zLIBCompressAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.zLIBCompressAToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.zLIBCompressAToolStripMenuItem.Text = "ZLIB Compress A";
            this.zLIBCompressAToolStripMenuItem.Click += new System.EventHandler(this.zLIBCompressAToolStripMenuItem_Click);
            // 
            // zLIBDecompressAToolStripMenuItem
            // 
            this.zLIBDecompressAToolStripMenuItem.Name = "zLIBDecompressAToolStripMenuItem";
            this.zLIBDecompressAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.zLIBDecompressAToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.zLIBDecompressAToolStripMenuItem.Text = "ZLIB Decompress A";
            this.zLIBDecompressAToolStripMenuItem.Click += new System.EventHandler(this.zLIBDecompressAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pb1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Data Tool WV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORAWithBToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem xORAWithBPlusOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESDecryptAWithBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESEncryptAWithBToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ToolStripMenuItem base64EncodeAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64DecodeAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zLIBCompressAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zLIBDecompressAToolStripMenuItem;
    }
}

