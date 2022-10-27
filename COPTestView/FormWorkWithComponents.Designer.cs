
namespace COPTestView
{
    partial class FormWorkWithComponents
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
            this.textBoxContextText = new System.Windows.Forms.TextBox();
            this.buttonCreatePdfContext = new System.Windows.Forms.Button();
            this.textBoxContextTitle = new System.Windows.Forms.TextBox();
            this.labelContentText = new System.Windows.Forms.Label();
            this.labelContentTitle = new System.Windows.Forms.Label();
            this.groupBoxContentPdf = new System.Windows.Forms.GroupBox();
            this.groupBoxTablePdf = new System.Windows.Forms.GroupBox();
            this.labelTableTitle = new System.Windows.Forms.Label();
            this.textBoxTableTitle = new System.Windows.Forms.TextBox();
            this.buttonCreateTablePdf = new System.Windows.Forms.Button();
            this.groupBoxDiagramPdf = new System.Windows.Forms.GroupBox();
            this.labelDiagramPdfDiagramName = new System.Windows.Forms.Label();
            this.textBoxDiagramPdfDiagramName = new System.Windows.Forms.TextBox();
            this.labelDiagramPdfDocTitle = new System.Windows.Forms.Label();
            this.textBoxDiagramPdfDocTitle = new System.Windows.Forms.TextBox();
            this.buttonCreateDiagramPdf = new System.Windows.Forms.Button();
            this.componentContextBigText = new ClassLibraryComponentsKurmyza.ComponentTextPdf(this.components);
            this.componentTablePdf = new ClassLibraryComponentsKurmyza.ComponentTablePdf(this.components);
            this.componentDiagramPdf = new ClassLibraryComponentsKurmyza.ComponentDiagramPdf(this.components);
            this.groupBoxContentPdf.SuspendLayout();
            this.groupBoxTablePdf.SuspendLayout();
            this.groupBoxDiagramPdf.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContextText
            // 
            this.textBoxContextText.Location = new System.Drawing.Point(8, 96);
            this.textBoxContextText.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContextText.Multiline = true;
            this.textBoxContextText.Name = "textBoxContextText";
            this.textBoxContextText.Size = new System.Drawing.Size(333, 169);
            this.textBoxContextText.TabIndex = 0;
            // 
            // buttonCreatePdfContext
            // 
            this.buttonCreatePdfContext.Location = new System.Drawing.Point(77, 273);
            this.buttonCreatePdfContext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreatePdfContext.Name = "buttonCreatePdfContext";
            this.buttonCreatePdfContext.Size = new System.Drawing.Size(179, 36);
            this.buttonCreatePdfContext.TabIndex = 1;
            this.buttonCreatePdfContext.Text = "Сгенерировать PDF";
            this.buttonCreatePdfContext.UseVisualStyleBackColor = true;
            this.buttonCreatePdfContext.Click += new System.EventHandler(this.buttonCreatePdfContext_Click);
            // 
            // textBoxContextTitle
            // 
            this.textBoxContextTitle.Location = new System.Drawing.Point(8, 48);
            this.textBoxContextTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContextTitle.Name = "textBoxContextTitle";
            this.textBoxContextTitle.Size = new System.Drawing.Size(333, 22);
            this.textBoxContextTitle.TabIndex = 2;
            // 
            // labelContentText
            // 
            this.labelContentText.AutoSize = true;
            this.labelContentText.Location = new System.Drawing.Point(8, 76);
            this.labelContentText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContentText.Name = "labelContentText";
            this.labelContentText.Size = new System.Drawing.Size(48, 16);
            this.labelContentText.TabIndex = 3;
            this.labelContentText.Text = "Текст:";
            // 
            // labelContentTitle
            // 
            this.labelContentTitle.AutoSize = true;
            this.labelContentTitle.Location = new System.Drawing.Point(8, 28);
            this.labelContentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContentTitle.Name = "labelContentTitle";
            this.labelContentTitle.Size = new System.Drawing.Size(80, 16);
            this.labelContentTitle.TabIndex = 4;
            this.labelContentTitle.Text = "Заголовок:";
            // 
            // groupBoxContentPdf
            // 
            this.groupBoxContentPdf.Controls.Add(this.labelContentTitle);
            this.groupBoxContentPdf.Controls.Add(this.labelContentText);
            this.groupBoxContentPdf.Controls.Add(this.textBoxContextTitle);
            this.groupBoxContentPdf.Controls.Add(this.buttonCreatePdfContext);
            this.groupBoxContentPdf.Controls.Add(this.textBoxContextText);
            this.groupBoxContentPdf.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContentPdf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxContentPdf.Name = "groupBoxContentPdf";
            this.groupBoxContentPdf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxContentPdf.Size = new System.Drawing.Size(351, 325);
            this.groupBoxContentPdf.TabIndex = 5;
            this.groupBoxContentPdf.TabStop = false;
            this.groupBoxContentPdf.Text = "Компонент с текстом";
            // 
            // groupBoxTablePdf
            // 
            this.groupBoxTablePdf.Controls.Add(this.labelTableTitle);
            this.groupBoxTablePdf.Controls.Add(this.textBoxTableTitle);
            this.groupBoxTablePdf.Controls.Add(this.buttonCreateTablePdf);
            this.groupBoxTablePdf.Location = new System.Drawing.Point(372, 13);
            this.groupBoxTablePdf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTablePdf.Name = "groupBoxTablePdf";
            this.groupBoxTablePdf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTablePdf.Size = new System.Drawing.Size(351, 134);
            this.groupBoxTablePdf.TabIndex = 6;
            this.groupBoxTablePdf.TabStop = false;
            this.groupBoxTablePdf.Text = "Компонент с таблицей";
            // 
            // labelTableTitle
            // 
            this.labelTableTitle.AutoSize = true;
            this.labelTableTitle.Location = new System.Drawing.Point(8, 28);
            this.labelTableTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTableTitle.Name = "labelTableTitle";
            this.labelTableTitle.Size = new System.Drawing.Size(80, 16);
            this.labelTableTitle.TabIndex = 4;
            this.labelTableTitle.Text = "Заголовок:";
            // 
            // textBoxTableTitle
            // 
            this.textBoxTableTitle.Location = new System.Drawing.Point(8, 48);
            this.textBoxTableTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTableTitle.Name = "textBoxTableTitle";
            this.textBoxTableTitle.Size = new System.Drawing.Size(333, 22);
            this.textBoxTableTitle.TabIndex = 2;
            // 
            // buttonCreateTablePdf
            // 
            this.buttonCreateTablePdf.Location = new System.Drawing.Point(85, 78);
            this.buttonCreateTablePdf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTablePdf.Name = "buttonCreateTablePdf";
            this.buttonCreateTablePdf.Size = new System.Drawing.Size(170, 36);
            this.buttonCreateTablePdf.TabIndex = 1;
            this.buttonCreateTablePdf.Text = "Сгенерировать PDF";
            this.buttonCreateTablePdf.UseVisualStyleBackColor = true;
            this.buttonCreateTablePdf.Click += new System.EventHandler(this.buttonCreateTablePdf_Click);
            // 
            // groupBoxDiagramPdf
            // 
            this.groupBoxDiagramPdf.Controls.Add(this.labelDiagramPdfDiagramName);
            this.groupBoxDiagramPdf.Controls.Add(this.textBoxDiagramPdfDiagramName);
            this.groupBoxDiagramPdf.Controls.Add(this.labelDiagramPdfDocTitle);
            this.groupBoxDiagramPdf.Controls.Add(this.textBoxDiagramPdfDocTitle);
            this.groupBoxDiagramPdf.Controls.Add(this.buttonCreateDiagramPdf);
            this.groupBoxDiagramPdf.Location = new System.Drawing.Point(732, 13);
            this.groupBoxDiagramPdf.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDiagramPdf.Name = "groupBoxDiagramPdf";
            this.groupBoxDiagramPdf.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDiagramPdf.Size = new System.Drawing.Size(351, 183);
            this.groupBoxDiagramPdf.TabIndex = 7;
            this.groupBoxDiagramPdf.TabStop = false;
            this.groupBoxDiagramPdf.Text = "Компонент с диаграммой";
            // 
            // labelDiagramPdfDiagramName
            // 
            this.labelDiagramPdfDiagramName.AutoSize = true;
            this.labelDiagramPdfDiagramName.Location = new System.Drawing.Point(8, 80);
            this.labelDiagramPdfDiagramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiagramPdfDiagramName.Name = "labelDiagramPdfDiagramName";
            this.labelDiagramPdfDiagramName.Size = new System.Drawing.Size(156, 16);
            this.labelDiagramPdfDiagramName.TabIndex = 6;
            this.labelDiagramPdfDiagramName.Text = "Заголовок диаграммы:";
            // 
            // textBoxDiagramPdfDiagramName
            // 
            this.textBoxDiagramPdfDiagramName.Location = new System.Drawing.Point(8, 100);
            this.textBoxDiagramPdfDiagramName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiagramPdfDiagramName.Name = "textBoxDiagramPdfDiagramName";
            this.textBoxDiagramPdfDiagramName.Size = new System.Drawing.Size(333, 22);
            this.textBoxDiagramPdfDiagramName.TabIndex = 5;
            // 
            // labelDiagramPdfDocTitle
            // 
            this.labelDiagramPdfDocTitle.AutoSize = true;
            this.labelDiagramPdfDocTitle.Location = new System.Drawing.Point(8, 28);
            this.labelDiagramPdfDocTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiagramPdfDocTitle.Name = "labelDiagramPdfDocTitle";
            this.labelDiagramPdfDocTitle.Size = new System.Drawing.Size(165, 16);
            this.labelDiagramPdfDocTitle.TabIndex = 4;
            this.labelDiagramPdfDocTitle.Text = "Заголовок в документе:";
            // 
            // textBoxDiagramPdfDocTitle
            // 
            this.textBoxDiagramPdfDocTitle.Location = new System.Drawing.Point(8, 48);
            this.textBoxDiagramPdfDocTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiagramPdfDocTitle.Name = "textBoxDiagramPdfDocTitle";
            this.textBoxDiagramPdfDocTitle.Size = new System.Drawing.Size(333, 22);
            this.textBoxDiagramPdfDocTitle.TabIndex = 2;
            // 
            // buttonCreateDiagramPdf
            // 
            this.buttonCreateDiagramPdf.Location = new System.Drawing.Point(81, 130);
            this.buttonCreateDiagramPdf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateDiagramPdf.Name = "buttonCreateDiagramPdf";
            this.buttonCreateDiagramPdf.Size = new System.Drawing.Size(185, 36);
            this.buttonCreateDiagramPdf.TabIndex = 1;
            this.buttonCreateDiagramPdf.Text = "Сгенерировать PDF";
            this.buttonCreateDiagramPdf.UseVisualStyleBackColor = true;
            this.buttonCreateDiagramPdf.Click += new System.EventHandler(this.buttonCreateDiagramPdf_Click);
            // 
            // FormWorkWithComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 348);
            this.Controls.Add(this.groupBoxDiagramPdf);
            this.Controls.Add(this.groupBoxTablePdf);
            this.Controls.Add(this.groupBoxContentPdf);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWorkWithComponents";
            this.Text = "Главное окно";
            this.groupBoxContentPdf.ResumeLayout(false);
            this.groupBoxContentPdf.PerformLayout();
            this.groupBoxTablePdf.ResumeLayout(false);
            this.groupBoxTablePdf.PerformLayout();
            this.groupBoxDiagramPdf.ResumeLayout(false);
            this.groupBoxDiagramPdf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContextText;
        private System.Windows.Forms.Button buttonCreatePdfContext;
        private System.Windows.Forms.TextBox textBoxContextTitle;
        private System.Windows.Forms.Label labelContentText;
        private System.Windows.Forms.Label labelContentTitle;
        private System.Windows.Forms.GroupBox groupBoxContentPdf;
        private ClassLibraryComponentsKurmyza.ComponentTextPdf componentContextBigText;
        private System.Windows.Forms.GroupBox groupBoxTablePdf;
        private System.Windows.Forms.Label labelTableTitle;
        private System.Windows.Forms.TextBox textBoxTableTitle;
        private System.Windows.Forms.Button buttonCreateTablePdf;
        private ClassLibraryComponentsKurmyza.ComponentTablePdf componentTablePdf;
        private System.Windows.Forms.GroupBox groupBoxDiagramPdf;
        private System.Windows.Forms.Label labelDiagramPdfDocTitle;
        private System.Windows.Forms.TextBox textBoxDiagramPdfDocTitle;
        private System.Windows.Forms.Button buttonCreateDiagramPdf;
        private System.Windows.Forms.Label labelDiagramPdfDiagramName;
        private System.Windows.Forms.TextBox textBoxDiagramPdfDiagramName;
        private ClassLibraryComponentsKurmyza.ComponentDiagramPdf componentDiagramPdf;
    }
}