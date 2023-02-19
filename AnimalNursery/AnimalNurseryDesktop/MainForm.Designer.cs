namespace AnimalNurseryDesktop
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
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirhday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderCommand,
            this.columnHeaderBirhday});
            this.listViewAnimals.HideSelection = false;
            this.listViewAnimals.Location = new System.Drawing.Point(12, 12);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(965, 368);
            this.listViewAnimals.TabIndex = 0;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewAnimals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            this.columnHeaderType.Width = 200;
            // 
            // columnHeaderCommand
            // 
            this.columnHeaderCommand.Text = "Команды";
            this.columnHeaderCommand.Width = 400;
            // 
            // columnHeaderBirhday
            // 
            this.columnHeaderBirhday.Text = "День Рождение";
            this.columnHeaderBirhday.Width = 100;
            // 
            // buttonLoadAnimals
            // 
            this.buttonLoadAnimals.Location = new System.Drawing.Point(12, 406);
            this.buttonLoadAnimals.Name = "buttonLoadAnimals";
            this.buttonLoadAnimals.Size = new System.Drawing.Size(104, 32);
            this.buttonLoadAnimals.TabIndex = 1;
            this.buttonLoadAnimals.Text = "Загрузить";
            this.buttonLoadAnimals.UseVisualStyleBackColor = true;
            this.buttonLoadAnimals.Click += new System.EventHandler(this.buttonLoadAnimals_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.buttonLoadAnimals);
            this.Controls.Add(this.listViewAnimals);
            this.Name = "MainForm";
            this.Text = "Мой приют";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.Button buttonLoadAnimals;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderCommand;
        private System.Windows.Forms.ColumnHeader columnHeaderBirhday;
    }
}

