using System.Drawing;

namespace _9zugangsdaten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.projectExplorer = new System.Windows.Forms.TreeView();
            this.zugangsdaten = new System.Windows.Forms.TextBox();
            this.fileSelector = new System.Windows.Forms.ComboBox();
            this.openInExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectExplorer
            // 
            this.projectExplorer.Location = new System.Drawing.Point(6, 10);
            this.projectExplorer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.projectExplorer.Name = "projectExplorer";
            this.projectExplorer.Size = new System.Drawing.Size(386, 900);
            this.projectExplorer.TabIndex = 0;
            this.projectExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectExplorer_AfterSelect);
            // 
            // zugangsdaten
            // 
            this.zugangsdaten.Location = new System.Drawing.Point(408, 62);
            this.zugangsdaten.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zugangsdaten.Multiline = true;
            this.zugangsdaten.Name = "zugangsdaten";
            this.zugangsdaten.ReadOnly = true;
            this.zugangsdaten.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.zugangsdaten.Size = new System.Drawing.Size(758, 848);
            this.zugangsdaten.TabIndex = 1;
            // 
            // fileSelector
            // 
            this.fileSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileSelector.FormattingEnabled = true;
            this.fileSelector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileSelector.Location = new System.Drawing.Point(458, 12);
            this.fileSelector.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fileSelector.Name = "fileSelector";
            this.fileSelector.Size = new System.Drawing.Size(708, 33);
            this.fileSelector.TabIndex = 2;
            this.fileSelector.SelectedIndexChanged += new System.EventHandler(this.fileSelector_SelectedIndexChanged);
            // 
            // openInExplorer
            // 
            this.openInExplorer.Location = new System.Drawing.Point(408, 10);
            this.openInExplorer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openInExplorer.Name = "openInExplorer";
            this.openInExplorer.Size = new System.Drawing.Size(46, 44);
            this.openInExplorer.TabIndex = 3;
            this.openInExplorer.UseVisualStyleBackColor = true;
            this.openInExplorer.BackgroundImage = Image.FromFile("../../graphic/folder.png");
            this.openInExplorer.Click += new System.EventHandler(this.openInExplorer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 917);
            this.Controls.Add(this.openInExplorer);
            this.Controls.Add(this.fileSelector);
            this.Controls.Add(this.zugangsdaten);
            this.Controls.Add(this.projectExplorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "9zugangsdaten " + Program.Version;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView projectExplorer;
        private System.Windows.Forms.TextBox zugangsdaten;
        private System.Windows.Forms.ComboBox fileSelector;
        private System.Windows.Forms.Button openInExplorer;
    }
}

