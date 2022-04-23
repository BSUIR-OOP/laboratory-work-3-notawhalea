namespace LabWork3
{
    partial class Form1
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
            this.MembersList = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ChooseMember = new System.Windows.Forms.ComboBox();
            this.Fio = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.Refactor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MembersList
            // 
            this.MembersList.FormattingEnabled = true;
            this.MembersList.ItemHeight = 20;
            this.MembersList.Location = new System.Drawing.Point(33, 21);
            this.MembersList.Name = "MembersList";
            this.MembersList.Size = new System.Drawing.Size(211, 444);
            this.MembersList.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(506, 207);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(102, 29);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(354, 207);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(102, 29);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChooseMember
            // 
            this.ChooseMember.FormattingEnabled = true;
            this.ChooseMember.Location = new System.Drawing.Point(408, 21);
            this.ChooseMember.Name = "ChooseMember";
            this.ChooseMember.Size = new System.Drawing.Size(303, 28);
            this.ChooseMember.TabIndex = 3;
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(408, 110);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(125, 27);
            this.Fio.TabIndex = 4;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(586, 110);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(125, 27);
            this.Age.TabIndex = 5;
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(617, 321);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(94, 29);
            this.Serialize.TabIndex = 6;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Location = new System.Drawing.Point(416, 321);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(94, 29);
            this.Deserialize.TabIndex = 7;
            this.Deserialize.Text = "Deseriazize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Refactor
            // 
            this.Refactor.Location = new System.Drawing.Point(654, 207);
            this.Refactor.Name = "Refactor";
            this.Refactor.Size = new System.Drawing.Size(94, 29);
            this.Refactor.TabIndex = 8;
            this.Refactor.Text = "Refactor";
            this.Refactor.UseVisualStyleBackColor = true;
            this.Refactor.Click += new System.EventHandler(this.Refactor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 492);
            this.Controls.Add(this.Refactor);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.ChooseMember);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.MembersList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MembersList;
        private Button Create;
        private Button Delete;


        Student member = new Student("asdf",18);
        private ComboBox ChooseMember;
        private TextBox Fio;
        private TextBox Age;
        private Button Serialize;
        private Button Deserialize;
        private Button Refactor;
    }
}