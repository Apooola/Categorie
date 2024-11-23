namespace Categorie
{
    partial class Categorie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 23);
            label1.Name = "label1";
            label1.Size = new Size(171, 39);
            label1.TabIndex = 0;
            label1.Text = "Categorie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F);
            label2.Location = new Point(79, 114);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(173, 111);
            txtID.Name = "txtID";
            txtID.Size = new Size(422, 32);
            txtID.TabIndex = 2;
            toolTip1.SetToolTip(txtID, "Enter Here Categorie ID");
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(173, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(422, 32);
            txtName.TabIndex = 4;
            toolTip1.SetToolTip(txtName, "Enter Here Categorie Name ");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F);
            label3.Location = new Point(79, 154);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 3;
            label3.Text = "Name :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(69, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New";
            toolTip1.SetToolTip(btnAdd, "Click Here To Add New Categorie");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkTurquoise;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(206, 227);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 41);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            toolTip1.SetToolTip(btnEdit, "Click Here To Edit ");
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkTurquoise;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(343, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            toolTip1.SetToolTip(btnDelete, "Click Here TO Delete");
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkTurquoise;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(476, 227);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 41);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            toolTip1.SetToolTip(btnExit, "Click Here To Exit ");
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Notes:";
            // 
            // Categorie
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 297);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Categorie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtName;
        private Label label3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExit;
        private ToolTip toolTip1;
    }
}
