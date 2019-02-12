namespace Bender_Gestalt_Test
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bender_Gestalt_Test_dbDataSet = new Bender_Gestalt_Test.Bender_Gestalt_Test_dbDataSet();
            this.bendergestalttesttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bender_gestalt_test_tableTableAdapter = new Bender_Gestalt_Test.Bender_Gestalt_Test_dbDataSetTableAdapters.bender_gestalt_test_tableTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overlappingdifficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simplificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fragmentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retrogressionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collusiontendecyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impotenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clouserdifficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorincoordinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bender_Gestalt_Test_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bendergestalttesttableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalScoreDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.rotationDataGridViewTextBoxColumn,
            this.overlappingdifficultyDataGridViewTextBoxColumn,
            this.simplificationDataGridViewTextBoxColumn,
            this.fragmentationDataGridViewTextBoxColumn,
            this.retrogressionDataGridViewTextBoxColumn,
            this.preservationDataGridViewTextBoxColumn,
            this.collusiontendecyDataGridViewTextBoxColumn,
            this.impotenceDataGridViewTextBoxColumn,
            this.clouserdifficultyDataGridViewTextBoxColumn,
            this.motorincoordinationDataGridViewTextBoxColumn,
            this.angulationDataGridViewTextBoxColumn,
            this.cohesionDataGridViewTextBoxColumn,
            this.caseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bendergestalttesttableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(1350, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // bender_Gestalt_Test_dbDataSet
            // 
            this.bender_Gestalt_Test_dbDataSet.DataSetName = "Bender_Gestalt_Test_dbDataSet";
            this.bender_Gestalt_Test_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bendergestalttesttableBindingSource
            // 
            this.bendergestalttesttableBindingSource.DataMember = "bender_gestalt_test_table";
            this.bendergestalttesttableBindingSource.DataSource = this.bender_Gestalt_Test_dbDataSet;
            // 
            // bender_gestalt_test_tableTableAdapter
            // 
            this.bender_gestalt_test_tableTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalScoreDataGridViewTextBoxColumn
            // 
            this.totalScoreDataGridViewTextBoxColumn.DataPropertyName = "Total_Score";
            this.totalScoreDataGridViewTextBoxColumn.HeaderText = "Total_Score";
            this.totalScoreDataGridViewTextBoxColumn.Name = "totalScoreDataGridViewTextBoxColumn";
            this.totalScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            this.rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            this.rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            this.rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            this.rotationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overlappingdifficultyDataGridViewTextBoxColumn
            // 
            this.overlappingdifficultyDataGridViewTextBoxColumn.DataPropertyName = "Over_lapping_difficulty";
            this.overlappingdifficultyDataGridViewTextBoxColumn.HeaderText = "Over_lapping_difficulty";
            this.overlappingdifficultyDataGridViewTextBoxColumn.Name = "overlappingdifficultyDataGridViewTextBoxColumn";
            this.overlappingdifficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simplificationDataGridViewTextBoxColumn
            // 
            this.simplificationDataGridViewTextBoxColumn.DataPropertyName = "Simplification";
            this.simplificationDataGridViewTextBoxColumn.HeaderText = "Simplification";
            this.simplificationDataGridViewTextBoxColumn.Name = "simplificationDataGridViewTextBoxColumn";
            this.simplificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fragmentationDataGridViewTextBoxColumn
            // 
            this.fragmentationDataGridViewTextBoxColumn.DataPropertyName = "Fragmentation";
            this.fragmentationDataGridViewTextBoxColumn.HeaderText = "Fragmentation";
            this.fragmentationDataGridViewTextBoxColumn.Name = "fragmentationDataGridViewTextBoxColumn";
            this.fragmentationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retrogressionDataGridViewTextBoxColumn
            // 
            this.retrogressionDataGridViewTextBoxColumn.DataPropertyName = "Retrogression";
            this.retrogressionDataGridViewTextBoxColumn.HeaderText = "Retrogression";
            this.retrogressionDataGridViewTextBoxColumn.Name = "retrogressionDataGridViewTextBoxColumn";
            this.retrogressionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preservationDataGridViewTextBoxColumn
            // 
            this.preservationDataGridViewTextBoxColumn.DataPropertyName = "Preservation";
            this.preservationDataGridViewTextBoxColumn.HeaderText = "Preservation";
            this.preservationDataGridViewTextBoxColumn.Name = "preservationDataGridViewTextBoxColumn";
            this.preservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collusiontendecyDataGridViewTextBoxColumn
            // 
            this.collusiontendecyDataGridViewTextBoxColumn.DataPropertyName = "Collusion_tendecy";
            this.collusiontendecyDataGridViewTextBoxColumn.HeaderText = "Collusion_tendecy";
            this.collusiontendecyDataGridViewTextBoxColumn.Name = "collusiontendecyDataGridViewTextBoxColumn";
            this.collusiontendecyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impotenceDataGridViewTextBoxColumn
            // 
            this.impotenceDataGridViewTextBoxColumn.DataPropertyName = "Impotence";
            this.impotenceDataGridViewTextBoxColumn.HeaderText = "Impotence";
            this.impotenceDataGridViewTextBoxColumn.Name = "impotenceDataGridViewTextBoxColumn";
            this.impotenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clouserdifficultyDataGridViewTextBoxColumn
            // 
            this.clouserdifficultyDataGridViewTextBoxColumn.DataPropertyName = "Clouser_difficulty";
            this.clouserdifficultyDataGridViewTextBoxColumn.HeaderText = "Clouser_difficulty";
            this.clouserdifficultyDataGridViewTextBoxColumn.Name = "clouserdifficultyDataGridViewTextBoxColumn";
            this.clouserdifficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motorincoordinationDataGridViewTextBoxColumn
            // 
            this.motorincoordinationDataGridViewTextBoxColumn.DataPropertyName = "Motor_incoordination";
            this.motorincoordinationDataGridViewTextBoxColumn.HeaderText = "Motor_incoordination";
            this.motorincoordinationDataGridViewTextBoxColumn.Name = "motorincoordinationDataGridViewTextBoxColumn";
            this.motorincoordinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angulationDataGridViewTextBoxColumn
            // 
            this.angulationDataGridViewTextBoxColumn.DataPropertyName = "Angulation";
            this.angulationDataGridViewTextBoxColumn.HeaderText = "Angulation";
            this.angulationDataGridViewTextBoxColumn.Name = "angulationDataGridViewTextBoxColumn";
            this.angulationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cohesionDataGridViewTextBoxColumn
            // 
            this.cohesionDataGridViewTextBoxColumn.DataPropertyName = "Cohesion";
            this.cohesionDataGridViewTextBoxColumn.HeaderText = "Cohesion";
            this.cohesionDataGridViewTextBoxColumn.Name = "cohesionDataGridViewTextBoxColumn";
            this.cohesionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseDataGridViewTextBoxColumn
            // 
            this.caseDataGridViewTextBoxColumn.DataPropertyName = "Case";
            this.caseDataGridViewTextBoxColumn.HeaderText = "Case";
            this.caseDataGridViewTextBoxColumn.Name = "caseDataGridViewTextBoxColumn";
            this.caseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 485);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bender_Gestalt_Test_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bendergestalttesttableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bender_Gestalt_Test_dbDataSet bender_Gestalt_Test_dbDataSet;
        private System.Windows.Forms.BindingSource bendergestalttesttableBindingSource;
        private Bender_Gestalt_Test_dbDataSetTableAdapters.bender_gestalt_test_tableTableAdapter bender_gestalt_test_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overlappingdifficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simplificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fragmentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retrogressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collusiontendecyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impotenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clouserdifficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorincoordinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseDataGridViewTextBoxColumn;
    }
}