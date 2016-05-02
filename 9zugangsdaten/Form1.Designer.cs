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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.zugangsdaten = new System.Windows.Forms.TextBox();
            this.fileSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(195, 470);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // zugangsdaten
            // 
            this.zugangsdaten.Location = new System.Drawing.Point(204, 32);
            this.zugangsdaten.Multiline = true;
            this.zugangsdaten.Name = "zugangsdaten";
            this.zugangsdaten.ReadOnly = true;
            this.zugangsdaten.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.zugangsdaten.Size = new System.Drawing.Size(381, 443);
            this.zugangsdaten.TabIndex = 1;
            this.zugangsdaten.TextChanged += new System.EventHandler(this.zugangsdaten_TextChanged);
            // 
            // fileSelector
            // 
            this.fileSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileSelector.FormattingEnabled = true;
            this.fileSelector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileSelector.Location = new System.Drawing.Point(204, 5);
            this.fileSelector.Name = "fileSelector";
            this.fileSelector.Size = new System.Drawing.Size(674, 21);
            this.fileSelector.TabIndex = 2;
            this.fileSelector.SelectedIndexChanged += new System.EventHandler(this.fileSelector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 477);
            this.Controls.Add(this.fileSelector);
            this.Controls.Add(this.zugangsdaten);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "9zugangsdaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox zugangsdaten;
        private System.Windows.Forms.ComboBox fileSelector;
    }
}

