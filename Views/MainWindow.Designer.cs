namespace PetrolStationDB.Views
{
    partial class MainWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialLiabilityBtn = new System.Windows.Forms.Button();
            this.equipmentsBtn = new System.Windows.Forms.Button();
            this.structuresBtn = new System.Windows.Forms.Button();
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.addPsBtn = new System.Windows.Forms.Button();
            this.typePsBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPsGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPsGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.materialLiabilityBtn);
            this.splitContainer1.Panel1.Controls.Add(this.equipmentsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.structuresBtn);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.addPsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.typePsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.profileBtn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 703);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 0;
            // 
            // materialLiabilityBtn
            // 
            this.materialLiabilityBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLiabilityBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLiabilityBtn.Location = new System.Drawing.Point(5, 400);
            this.materialLiabilityBtn.Name = "materialLiabilityBtn";
            this.materialLiabilityBtn.Size = new System.Drawing.Size(242, 65);
            this.materialLiabilityBtn.TabIndex = 6;
            this.materialLiabilityBtn.Text = "Материальная\r\nответвтвенность";
            this.materialLiabilityBtn.UseVisualStyleBackColor = true;
            // 
            // equipmentsBtn
            // 
            this.equipmentsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipmentsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equipmentsBtn.Location = new System.Drawing.Point(5, 335);
            this.equipmentsBtn.Name = "equipmentsBtn";
            this.equipmentsBtn.Size = new System.Drawing.Size(242, 65);
            this.equipmentsBtn.TabIndex = 5;
            this.equipmentsBtn.Text = "Оборудование";
            this.equipmentsBtn.UseVisualStyleBackColor = true;
            // 
            // structuresBtn
            // 
            this.structuresBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.structuresBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.structuresBtn.Location = new System.Drawing.Point(5, 270);
            this.structuresBtn.Name = "structuresBtn";
            this.structuresBtn.Size = new System.Drawing.Size(242, 65);
            this.structuresBtn.TabIndex = 4;
            this.structuresBtn.Text = "Сооружения";
            this.structuresBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeesBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeesBtn.Location = new System.Drawing.Point(5, 205);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(242, 65);
            this.EmployeesBtn.TabIndex = 3;
            this.EmployeesBtn.Text = "Сотрудники";
            this.EmployeesBtn.UseVisualStyleBackColor = true;
            // 
            // addPsBtn
            // 
            this.addPsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPsBtn.Location = new System.Drawing.Point(5, 140);
            this.addPsBtn.Name = "addPsBtn";
            this.addPsBtn.Size = new System.Drawing.Size(242, 65);
            this.addPsBtn.TabIndex = 2;
            this.addPsBtn.Text = "Добавить АЗС";
            this.addPsBtn.UseVisualStyleBackColor = true;
            this.addPsBtn.Click += new System.EventHandler(this.addPsBtn_Click);
            // 
            // typePsBtn
            // 
            this.typePsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.typePsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typePsBtn.Location = new System.Drawing.Point(5, 75);
            this.typePsBtn.Name = "typePsBtn";
            this.typePsBtn.Size = new System.Drawing.Size(242, 65);
            this.typePsBtn.TabIndex = 1;
            this.typePsBtn.Text = "Тип АЗС";
            this.typePsBtn.UseVisualStyleBackColor = true;
            this.typePsBtn.Click += new System.EventHandler(this.typePsBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.Location = new System.Drawing.Point(5, 10);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(242, 65);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "ПРОФИЛЬ";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OldLace;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 561);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1126, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опции";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.dataPsGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица АЗС";
            // 
            // dataPsGV
            // 
            this.dataPsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPsGV.Location = new System.Drawing.Point(3, 30);
            this.dataPsGV.Name = "dataPsGV";
            this.dataPsGV.RowHeadersWidth = 51;
            this.dataPsGV.RowTemplate.Height = 29;
            this.dataPsGV.Size = new System.Drawing.Size(1120, 323);
            this.dataPsGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по АЗС";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Общий поиск...";
            this.textBox1.Size = new System.Drawing.Size(1120, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPsGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button profileBtn;
        private Button typePsBtn;
        private Button materialLiabilityBtn;
        private Button equipmentsBtn;
        private Button structuresBtn;
        private Button EmployeesBtn;
        private Button addPsBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private DataGridView dataPsGV;
    }
}