
namespace PolygonGeopoints
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.savePointsToFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 35);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(306, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название географического объекта и нажмите кнопку Найти";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(324, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(69, 22);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(228, 80);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 22);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить полигон";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Location = new System.Drawing.Point(159, 80);
            this.numericUpDownPeriod.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownPeriod.TabIndex = 4;
            this.numericUpDownPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Период сохранения точек:";
            // 
            // savePointsToFileDialog
            // 
            this.savePointsToFileDialog.FileName = "PolygonCoordinates";
            this.savePointsToFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.savePointsToFileDialog_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вы можете сохранить полигон объекта, указав период сохранения точек";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 111);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "MainForm";
            this.Text = "PolygonGeopoints";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog savePointsToFileDialog;
        private System.Windows.Forms.Label label3;
    }
}

