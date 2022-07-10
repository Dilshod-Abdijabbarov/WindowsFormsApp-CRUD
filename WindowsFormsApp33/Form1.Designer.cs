
namespace WindowsFormsApp33
{
    partial class Form1
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnQoshish = new System.Windows.Forms.Button();
            this.btnOchirish = new System.Windows.Forms.Button();
            this.btnIzlash = new System.Windows.Forms.Button();
            this.btnTozalash = new System.Windows.Forms.Button();
            this.txtIzlash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelifonraqam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telifon_raqam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.City,
            this.Telifon_raqam});
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvStudent.Location = new System.Drawing.Point(263, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(525, 241);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(122, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(122, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(122, 103);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 176);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // btnQoshish
            // 
            this.btnQoshish.BackColor = System.Drawing.Color.Lime;
            this.btnQoshish.Location = new System.Drawing.Point(91, 210);
            this.btnQoshish.Name = "btnQoshish";
            this.btnQoshish.Size = new System.Drawing.Size(75, 23);
            this.btnQoshish.TabIndex = 9;
            this.btnQoshish.Text = "Qo\'shish";
            this.btnQoshish.UseVisualStyleBackColor = false;
            this.btnQoshish.Click += new System.EventHandler(this.btnQoshish_Click);
            // 
            // btnOchirish
            // 
            this.btnOchirish.BackColor = System.Drawing.Color.Red;
            this.btnOchirish.Location = new System.Drawing.Point(91, 239);
            this.btnOchirish.Name = "btnOchirish";
            this.btnOchirish.Size = new System.Drawing.Size(75, 23);
            this.btnOchirish.TabIndex = 10;
            this.btnOchirish.Text = "O\'chirish";
            this.btnOchirish.UseVisualStyleBackColor = false;
            this.btnOchirish.Click += new System.EventHandler(this.btnOchirish_Click);
            // 
            // btnIzlash
            // 
            this.btnIzlash.BackColor = System.Drawing.Color.Fuchsia;
            this.btnIzlash.Location = new System.Drawing.Point(263, 269);
            this.btnIzlash.Name = "btnIzlash";
            this.btnIzlash.Size = new System.Drawing.Size(75, 23);
            this.btnIzlash.TabIndex = 11;
            this.btnIzlash.Text = "Izlash";
            this.btnIzlash.UseVisualStyleBackColor = false;
            this.btnIzlash.Click += new System.EventHandler(this.btnIzlash_Click);
            // 
            // btnTozalash
            // 
            this.btnTozalash.BackColor = System.Drawing.Color.Yellow;
            this.btnTozalash.Location = new System.Drawing.Point(182, 210);
            this.btnTozalash.Name = "btnTozalash";
            this.btnTozalash.Size = new System.Drawing.Size(75, 23);
            this.btnTozalash.TabIndex = 12;
            this.btnTozalash.Text = "Tozalash";
            this.btnTozalash.UseVisualStyleBackColor = false;
            this.btnTozalash.Click += new System.EventHandler(this.btnTozalash_Click);
            // 
            // txtIzlash
            // 
            this.txtIzlash.Location = new System.Drawing.Point(74, 271);
            this.txtIzlash.Name = "txtIzlash";
            this.txtIzlash.Size = new System.Drawing.Size(148, 20);
            this.txtIzlash.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "First Name";
            // 
            // txtTelifonraqam
            // 
            this.txtTelifonraqam.Location = new System.Drawing.Point(122, 139);
            this.txtTelifonraqam.Name = "txtTelifonraqam";
            this.txtTelifonraqam.Size = new System.Drawing.Size(100, 20);
            this.txtTelifonraqam.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telifon raqam";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Telifon_raqam
            // 
            this.Telifon_raqam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telifon_raqam.DataPropertyName = "Telifon_raqam";
            this.Telifon_raqam.HeaderText = "Telifon raqam";
            this.Telifon_raqam.Name = "Telifon_raqam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.txtTelifonraqam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIzlash);
            this.Controls.Add(this.btnTozalash);
            this.Controls.Add(this.btnIzlash);
            this.Controls.Add(this.btnOchirish);
            this.Controls.Add(this.btnQoshish);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnQoshish;
        private System.Windows.Forms.Button btnOchirish;
        private System.Windows.Forms.Button btnIzlash;
        private System.Windows.Forms.Button btnTozalash;
        private System.Windows.Forms.TextBox txtIzlash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelifonraqam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telifon_raqam;
    }
}

