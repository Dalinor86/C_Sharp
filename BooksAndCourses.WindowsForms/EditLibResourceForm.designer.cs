namespace BooksAndCourses.WinForms
{
    partial class EditLibResourceForm
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
            this.comboResourceTypes = new System.Windows.Forms.ComboBox();
            this.labelResourceTypes = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.listThemes = new System.Windows.Forms.ListBox();
            this.labelThemes = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.labelLinks = new System.Windows.Forms.Label();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.labelCover = new System.Windows.Forms.Label();
            this.treeDivisions = new System.Windows.Forms.TreeView();
            this.labelDivisions = new System.Windows.Forms.Label();
            this.panelDivisions = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.numericPages = new System.Windows.Forms.NumericUpDown();
            this.labelPages = new System.Windows.Forms.Label();
            this.numericEdition = new System.Windows.Forms.NumericUpDown();
            this.labelEdition = new System.Windows.Forms.Label();
            this.textBoxPublishment = new System.Windows.Forms.TextBox();
            this.labelPublishment = new System.Windows.Forms.Label();
            this.labelMainLink = new System.Windows.Forms.Label();
            this.textBoxMainLink = new System.Windows.Forms.TextBox();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.authorsAddBtn = new System.Windows.Forms.Button();
            this.authorsRemoveBtn = new System.Windows.Forms.Button();
            this.linksAddBtn = new System.Windows.Forms.Button();
            this.linksRemoveBtn = new System.Windows.Forms.Button();
            this.listAuthors = new System.Windows.Forms.ListBox();
            this.authorsEditBtn = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionLink = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxCover = new System.Windows.Forms.TextBox();
            this.pictureRefreshBtn = new System.Windows.Forms.Button();
            this.descriptionRefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.panelDivisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // comboResourceTypes
            // 
            this.comboResourceTypes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboResourceTypes.FormattingEnabled = true;
            this.comboResourceTypes.Location = new System.Drawing.Point(604, 13);
            this.comboResourceTypes.Name = "comboResourceTypes";
            this.comboResourceTypes.Size = new System.Drawing.Size(268, 24);
            this.comboResourceTypes.TabIndex = 0;
            this.comboResourceTypes.SelectedIndexChanged += new System.EventHandler(this.comboResourceTypes_SelectedIndexChanged);
            // 
            // labelResourceTypes
            // 
            this.labelResourceTypes.AutoSize = true;
            this.labelResourceTypes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResourceTypes.Location = new System.Drawing.Point(504, 15);
            this.labelResourceTypes.Name = "labelResourceTypes";
            this.labelResourceTypes.Size = new System.Drawing.Size(94, 16);
            this.labelResourceTypes.TabIndex = 1;
            this.labelResourceTypes.Text = "Тип ресурса";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(34, 16);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Имя";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(78, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(321, 23);
            this.textBoxTitle.TabIndex = 4;
            // 
            // listThemes
            // 
            this.listThemes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listThemes.FormattingEnabled = true;
            this.listThemes.ItemHeight = 16;
            this.listThemes.Location = new System.Drawing.Point(604, 52);
            this.listThemes.Name = "listThemes";
            this.listThemes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listThemes.Size = new System.Drawing.Size(268, 68);
            this.listThemes.TabIndex = 5;
            // 
            // labelThemes
            // 
            this.labelThemes.AutoSize = true;
            this.labelThemes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThemes.Location = new System.Drawing.Point(504, 60);
            this.labelThemes.Name = "labelThemes";
            this.labelThemes.Size = new System.Drawing.Size(43, 16);
            this.labelThemes.TabIndex = 6;
            this.labelThemes.Text = "Темы";
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthors.Location = new System.Drawing.Point(12, 60);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(57, 16);
            this.labelAuthors.TabIndex = 7;
            this.labelAuthors.Text = "Авторы";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(12, 157);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(31, 16);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Год";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(139, 611);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(118, 40);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(15, 611);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(118, 40);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // labelLinks
            // 
            this.labelLinks.AutoSize = true;
            this.labelLinks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLinks.Location = new System.Drawing.Point(507, 128);
            this.labelLinks.Name = "labelLinks";
            this.labelLinks.Size = new System.Drawing.Size(58, 16);
            this.labelLinks.TabIndex = 14;
            this.labelLinks.Text = "Ссылки";
            // 
            // numericYear
            // 
            this.numericYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericYear.Location = new System.Drawing.Point(78, 155);
            this.numericYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(321, 23);
            this.numericYear.TabIndex = 15;
            this.numericYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // pictureCover
            // 
            this.pictureCover.Location = new System.Drawing.Point(340, 198);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(100, 120);
            this.pictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCover.TabIndex = 16;
            this.pictureCover.TabStop = false;
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCover.Location = new System.Drawing.Point(12, 198);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(69, 16);
            this.labelCover.TabIndex = 17;
            this.labelCover.Text = "Обложка";
            // 
            // treeDivisions
            // 
            this.treeDivisions.Location = new System.Drawing.Point(72, 20);
            this.treeDivisions.Name = "treeDivisions";
            this.treeDivisions.Size = new System.Drawing.Size(334, 199);
            this.treeDivisions.TabIndex = 21;
            // 
            // labelDivisions
            // 
            this.labelDivisions.AutoSize = true;
            this.labelDivisions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivisions.Location = new System.Drawing.Point(6, 20);
            this.labelDivisions.Name = "labelDivisions";
            this.labelDivisions.Size = new System.Drawing.Size(48, 16);
            this.labelDivisions.TabIndex = 22;
            this.labelDivisions.Text = "Главы";
            // 
            // panelDivisions
            // 
            this.panelDivisions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDivisions.Controls.Add(this.EditBtn);
            this.panelDivisions.Controls.Add(this.RemoveBtn);
            this.panelDivisions.Controls.Add(this.AddBtn);
            this.panelDivisions.Controls.Add(this.labelDivisions);
            this.panelDivisions.Controls.Add(this.treeDivisions);
            this.panelDivisions.Location = new System.Drawing.Point(15, 326);
            this.panelDivisions.Name = "panelDivisions";
            this.panelDivisions.Size = new System.Drawing.Size(425, 279);
            this.panelDivisions.TabIndex = 23;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Yellow;
            this.EditBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(147, 229);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(160, 40);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBtn.Location = new System.Drawing.Point(325, 229);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(85, 40);
            this.RemoveBtn.TabIndex = 24;
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(9, 229);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 40);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // numericPages
            // 
            this.numericPages.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPages.Location = new System.Drawing.Point(607, 429);
            this.numericPages.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericPages.Name = "numericPages";
            this.numericPages.Size = new System.Drawing.Size(268, 23);
            this.numericPages.TabIndex = 25;
            this.numericPages.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPages.Location = new System.Drawing.Point(507, 431);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(65, 16);
            this.labelPages.TabIndex = 24;
            this.labelPages.Text = "Страниц";
            // 
            // numericEdition
            // 
            this.numericEdition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericEdition.Location = new System.Drawing.Point(607, 477);
            this.numericEdition.Name = "numericEdition";
            this.numericEdition.Size = new System.Drawing.Size(268, 23);
            this.numericEdition.TabIndex = 27;
            this.numericEdition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdition.Location = new System.Drawing.Point(510, 479);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(64, 16);
            this.labelEdition.TabIndex = 26;
            this.labelEdition.Text = "Издание";
            // 
            // textBoxPublishment
            // 
            this.textBoxPublishment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPublishment.Location = new System.Drawing.Point(607, 524);
            this.textBoxPublishment.Name = "textBoxPublishment";
            this.textBoxPublishment.Size = new System.Drawing.Size(268, 23);
            this.textBoxPublishment.TabIndex = 29;
            // 
            // labelPublishment
            // 
            this.labelPublishment.AutoSize = true;
            this.labelPublishment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublishment.Location = new System.Drawing.Point(500, 527);
            this.labelPublishment.Name = "labelPublishment";
            this.labelPublishment.Size = new System.Drawing.Size(101, 16);
            this.labelPublishment.TabIndex = 28;
            this.labelPublishment.Text = "Издательство";
            // 
            // labelMainLink
            // 
            this.labelMainLink.AutoSize = true;
            this.labelMainLink.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainLink.Location = new System.Drawing.Point(484, 245);
            this.labelMainLink.Name = "labelMainLink";
            this.labelMainLink.Size = new System.Drawing.Size(117, 16);
            this.labelMainLink.TabIndex = 30;
            this.labelMainLink.Text = "Главная ссылка";
            // 
            // textBoxMainLink
            // 
            this.textBoxMainLink.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainLink.Location = new System.Drawing.Point(607, 245);
            this.textBoxMainLink.Name = "textBoxMainLink";
            this.textBoxMainLink.Size = new System.Drawing.Size(268, 23);
            this.textBoxMainLink.TabIndex = 31;
            // 
            // numericLength
            // 
            this.numericLength.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericLength.Location = new System.Drawing.Point(691, 599);
            this.numericLength.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(184, 23);
            this.numericLength.TabIndex = 33;
            this.numericLength.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(500, 601);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(178, 16);
            this.labelLength.TabIndex = 32;
            this.labelLength.Text = "Продолжительность, сек";
            // 
            // dgvLinks
            // 
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Location = new System.Drawing.Point(604, 126);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.Size = new System.Drawing.Size(268, 88);
            this.dgvLinks.TabIndex = 35;
            // 
            // authorsAddBtn
            // 
            this.authorsAddBtn.BackColor = System.Drawing.Color.Lime;
            this.authorsAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsAddBtn.Location = new System.Drawing.Point(405, 47);
            this.authorsAddBtn.Name = "authorsAddBtn";
            this.authorsAddBtn.Size = new System.Drawing.Size(35, 33);
            this.authorsAddBtn.TabIndex = 36;
            this.authorsAddBtn.UseVisualStyleBackColor = false;
            this.authorsAddBtn.Click += new System.EventHandler(this.authorsAddBtn_Click);
            // 
            // authorsRemoveBtn
            // 
            this.authorsRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.authorsRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsRemoveBtn.Location = new System.Drawing.Point(405, 126);
            this.authorsRemoveBtn.Name = "authorsRemoveBtn";
            this.authorsRemoveBtn.Size = new System.Drawing.Size(35, 34);
            this.authorsRemoveBtn.TabIndex = 37;
            this.authorsRemoveBtn.UseVisualStyleBackColor = false;
            this.authorsRemoveBtn.Click += new System.EventHandler(this.authorsRemoveBtn_Click);
            // 
            // linksAddBtn
            // 
            this.linksAddBtn.BackColor = System.Drawing.Color.Lime;
            this.linksAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linksAddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linksAddBtn.Location = new System.Drawing.Point(787, 216);
            this.linksAddBtn.Name = "linksAddBtn";
            this.linksAddBtn.Size = new System.Drawing.Size(35, 24);
            this.linksAddBtn.TabIndex = 38;
            this.linksAddBtn.UseVisualStyleBackColor = false;
            // 
            // linksRemoveBtn
            // 
            this.linksRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linksRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linksRemoveBtn.Location = new System.Drawing.Point(837, 216);
            this.linksRemoveBtn.Name = "linksRemoveBtn";
            this.linksRemoveBtn.Size = new System.Drawing.Size(35, 24);
            this.linksRemoveBtn.TabIndex = 39;
            this.linksRemoveBtn.UseVisualStyleBackColor = false;
            // 
            // listAuthors
            // 
            this.listAuthors.FormattingEnabled = true;
            this.listAuthors.Location = new System.Drawing.Point(78, 49);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(321, 95);
            this.listAuthors.TabIndex = 40;
            // 
            // authorsEditBtn
            // 
            this.authorsEditBtn.BackColor = System.Drawing.Color.Yellow;
            this.authorsEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsEditBtn.Location = new System.Drawing.Point(405, 86);
            this.authorsEditBtn.Name = "authorsEditBtn";
            this.authorsEditBtn.Size = new System.Drawing.Size(35, 34);
            this.authorsEditBtn.TabIndex = 41;
            this.authorsEditBtn.UseVisualStyleBackColor = false;
            this.authorsEditBtn.Click += new System.EventHandler(this.authorsEditBtn_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(487, 313);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(388, 101);
            this.textBoxDescription.TabIndex = 42;
            // 
            // textBoxDescriptionLink
            // 
            this.textBoxDescriptionLink.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescriptionLink.Location = new System.Drawing.Point(607, 284);
            this.textBoxDescriptionLink.Name = "textBoxDescriptionLink";
            this.textBoxDescriptionLink.Size = new System.Drawing.Size(268, 23);
            this.textBoxDescriptionLink.TabIndex = 44;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(484, 287);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(74, 16);
            this.labelDescription.TabIndex = 43;
            this.labelDescription.Text = "Описание";
            // 
            // textBoxCover
            // 
            this.textBoxCover.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCover.Location = new System.Drawing.Point(12, 217);
            this.textBoxCover.Name = "textBoxCover";
            this.textBoxCover.Size = new System.Drawing.Size(322, 23);
            this.textBoxCover.TabIndex = 46;
            // 
            // pictureRefreshBtn
            // 
            this.pictureRefreshBtn.BackColor = System.Drawing.Color.Aqua;
            this.pictureRefreshBtn.Location = new System.Drawing.Point(289, 276);
            this.pictureRefreshBtn.Name = "pictureRefreshBtn";
            this.pictureRefreshBtn.Size = new System.Drawing.Size(44, 44);
            this.pictureRefreshBtn.TabIndex = 47;
            this.pictureRefreshBtn.UseVisualStyleBackColor = false;
            this.pictureRefreshBtn.Click += new System.EventHandler(this.pictureRefreshBtn_Click);
            // 
            // descriptionRefreshBtn
            // 
            this.descriptionRefreshBtn.BackColor = System.Drawing.Color.Aqua;
            this.descriptionRefreshBtn.Location = new System.Drawing.Point(560, 284);
            this.descriptionRefreshBtn.Name = "descriptionRefreshBtn";
            this.descriptionRefreshBtn.Size = new System.Drawing.Size(44, 24);
            this.descriptionRefreshBtn.TabIndex = 48;
            this.descriptionRefreshBtn.UseVisualStyleBackColor = false;
            this.descriptionRefreshBtn.Click += new System.EventHandler(this.descriptionRefreshBtn_Click);
            // 
            // EditLibResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.descriptionRefreshBtn);
            this.Controls.Add(this.pictureRefreshBtn);
            this.Controls.Add(this.textBoxCover);
            this.Controls.Add(this.textBoxDescriptionLink);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.authorsEditBtn);
            this.Controls.Add(this.listAuthors);
            this.Controls.Add(this.linksRemoveBtn);
            this.Controls.Add(this.linksAddBtn);
            this.Controls.Add(this.authorsRemoveBtn);
            this.Controls.Add(this.authorsAddBtn);
            this.Controls.Add(this.dgvLinks);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxMainLink);
            this.Controls.Add(this.labelMainLink);
            this.Controls.Add(this.textBoxPublishment);
            this.Controls.Add(this.labelPublishment);
            this.Controls.Add(this.numericEdition);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.numericPages);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.panelDivisions);
            this.Controls.Add(this.labelCover);
            this.Controls.Add(this.pictureCover);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.labelLinks);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.labelThemes);
            this.Controls.Add(this.listThemes);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelResourceTypes);
            this.Controls.Add(this.comboResourceTypes);
            this.Name = "EditLibResourceForm";
            this.Text = "Редактирование ресурса";
            this.Load += new System.EventHandler(this.EditLibResourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.panelDivisions.ResumeLayout(false);
            this.panelDivisions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboResourceTypes;
        private System.Windows.Forms.Label labelResourceTypes;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ListBox listThemes;
        private System.Windows.Forms.Label labelThemes;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label labelLinks;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.PictureBox pictureCover;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.TreeView treeDivisions;
        private System.Windows.Forms.Label labelDivisions;
        private System.Windows.Forms.Panel panelDivisions;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.NumericUpDown numericPages;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.NumericUpDown numericEdition;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.TextBox textBoxPublishment;
        private System.Windows.Forms.Label labelPublishment;
        private System.Windows.Forms.Label labelMainLink;
        private System.Windows.Forms.TextBox textBoxMainLink;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.DataGridView dgvLinks;
        private System.Windows.Forms.Button authorsAddBtn;
        private System.Windows.Forms.Button authorsRemoveBtn;
        private System.Windows.Forms.Button linksAddBtn;
        private System.Windows.Forms.Button linksRemoveBtn;
        private System.Windows.Forms.ListBox listAuthors;
        private System.Windows.Forms.Button authorsEditBtn;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescriptionLink;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxCover;
        private System.Windows.Forms.Button pictureRefreshBtn;
        private System.Windows.Forms.Button descriptionRefreshBtn;
    }
}