namespace BIT706Assignment
{
    partial class FormHome
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonManageCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(321, 111);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(81, 31);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // buttonManageCustomers
            // 
            this.buttonManageCustomers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageCustomers.Location = new System.Drawing.Point(288, 164);
            this.buttonManageCustomers.Name = "buttonManageCustomers";
            this.buttonManageCustomers.Size = new System.Drawing.Size(144, 64);
            this.buttonManageCustomers.TabIndex = 2;
            this.buttonManageCustomers.Text = "Manage Customers";
            this.buttonManageCustomers.UseVisualStyleBackColor = true;
            this.buttonManageCustomers.Click += new System.EventHandler(this.ButtonManageCustomers_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 537);
            this.Controls.Add(this.buttonManageCustomers);
            this.Controls.Add(this.labelMenu);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Controls.SetChildIndex(this.labelMenu, 0);
            this.Controls.SetChildIndex(this.buttonManageCustomers, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonManageCustomers;
    }
}