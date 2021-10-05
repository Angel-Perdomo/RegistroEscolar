namespace Win.Escuela
{
    partial class FormEstudiante
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
            System.Windows.Forms.Label estMatriculadoLabel;
            System.Windows.Forms.Label numeroCuentaLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label primerNombreLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label segundoNombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiante));
            this.listaEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEstudiantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaEstudiantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estMatriculadoCheckBox = new System.Windows.Forms.CheckBox();
            this.numeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerNombreTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoNombreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            estMatriculadoLabel = new System.Windows.Forms.Label();
            numeroCuentaLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            primerNombreLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            segundoNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).BeginInit();
            this.listaEstudiantesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // estMatriculadoLabel
            // 
            estMatriculadoLabel.AutoSize = true;
            estMatriculadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estMatriculadoLabel.Location = new System.Drawing.Point(41, 431);
            estMatriculadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estMatriculadoLabel.Name = "estMatriculadoLabel";
            estMatriculadoLabel.Size = new System.Drawing.Size(119, 25);
            estMatriculadoLabel.TabIndex = 1;
            estMatriculadoLabel.Text = "Matriculado:";
            // 
            // numeroCuentaLabel
            // 
            numeroCuentaLabel.AutoSize = true;
            numeroCuentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroCuentaLabel.Location = new System.Drawing.Point(41, 97);
            numeroCuentaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroCuentaLabel.Name = "numeroCuentaLabel";
            numeroCuentaLabel.Size = new System.Drawing.Size(156, 25);
            numeroCuentaLabel.TabIndex = 3;
            numeroCuentaLabel.Text = "Cuenta Número:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            primerApellidoLabel.Location = new System.Drawing.Point(41, 303);
            primerApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(149, 25);
            primerApellidoLabel.TabIndex = 5;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // primerNombreLabel
            // 
            primerNombreLabel.AutoSize = true;
            primerNombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            primerNombreLabel.Location = new System.Drawing.Point(41, 162);
            primerNombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            primerNombreLabel.Name = "primerNombreLabel";
            primerNombreLabel.Size = new System.Drawing.Size(148, 25);
            primerNombreLabel.TabIndex = 7;
            primerNombreLabel.Text = "Primer Nombre:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            segundoApellidoLabel.Location = new System.Drawing.Point(41, 367);
            segundoApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(173, 25);
            segundoApellidoLabel.TabIndex = 9;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // segundoNombreLabel
            // 
            segundoNombreLabel.AutoSize = true;
            segundoNombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            segundoNombreLabel.Location = new System.Drawing.Point(41, 230);
            segundoNombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            segundoNombreLabel.Name = "segundoNombreLabel";
            segundoNombreLabel.Size = new System.Drawing.Size(172, 25);
            segundoNombreLabel.TabIndex = 11;
            segundoNombreLabel.Text = "Segundo Nombre:";
            // 
            // listaEstudiantesBindingSource
            // 
            this.listaEstudiantesBindingSource.DataSource = typeof(BL.Escuela.Estudiantes);
            // 
            // listaEstudiantesBindingNavigator
            // 
            this.listaEstudiantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaEstudiantesBindingNavigator.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listaEstudiantesBindingNavigator.BindingSource = this.listaEstudiantesBindingSource;
            this.listaEstudiantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEstudiantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaEstudiantesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEstudiantesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaEstudiantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaEstudiantesBindingNavigatorSaveItem});
            this.listaEstudiantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEstudiantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEstudiantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEstudiantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEstudiantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEstudiantesBindingNavigator.Name = "listaEstudiantesBindingNavigator";
            this.listaEstudiantesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.listaEstudiantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEstudiantesBindingNavigator.Size = new System.Drawing.Size(553, 38);
            this.listaEstudiantesBindingNavigator.TabIndex = 0;
            this.listaEstudiantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 35);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 35);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // listaEstudiantesBindingNavigatorSaveItem
            // 
            this.listaEstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEstudiantesBindingNavigatorSaveItem.Enabled = false;
            this.listaEstudiantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEstudiantesBindingNavigatorSaveItem.Image")));
            this.listaEstudiantesBindingNavigatorSaveItem.Name = "listaEstudiantesBindingNavigatorSaveItem";
            this.listaEstudiantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 35);
            this.listaEstudiantesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // estMatriculadoCheckBox
            // 
            this.estMatriculadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaEstudiantesBindingSource, "estMatriculado", true));
            this.estMatriculadoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estMatriculadoCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.estMatriculadoCheckBox.Location = new System.Drawing.Point(228, 425);
            this.estMatriculadoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estMatriculadoCheckBox.Name = "estMatriculadoCheckBox";
            this.estMatriculadoCheckBox.Size = new System.Drawing.Size(156, 38);
            this.estMatriculadoCheckBox.TabIndex = 2;
            this.estMatriculadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // numeroCuentaTextBox
            // 
            this.numeroCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "numeroCuenta", true));
            this.numeroCuentaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCuentaTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numeroCuentaTextBox.Location = new System.Drawing.Point(228, 89);
            this.numeroCuentaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeroCuentaTextBox.Name = "numeroCuentaTextBox";
            this.numeroCuentaTextBox.Size = new System.Drawing.Size(272, 30);
            this.numeroCuentaTextBox.TabIndex = 4;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "primerApellido", true));
            this.primerApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerApellidoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.primerApellidoTextBox.Location = new System.Drawing.Point(228, 295);
            this.primerApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(272, 30);
            this.primerApellidoTextBox.TabIndex = 6;
            // 
            // primerNombreTextBox
            // 
            this.primerNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "primerNombre", true));
            this.primerNombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerNombreTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.primerNombreTextBox.Location = new System.Drawing.Point(228, 155);
            this.primerNombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.primerNombreTextBox.Name = "primerNombreTextBox";
            this.primerNombreTextBox.Size = new System.Drawing.Size(272, 30);
            this.primerNombreTextBox.TabIndex = 8;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "segundoApellido", true));
            this.segundoApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoApellidoTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(228, 359);
            this.segundoApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(272, 30);
            this.segundoApellidoTextBox.TabIndex = 10;
            // 
            // segundoNombreTextBox
            // 
            this.segundoNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "segundoNombre", true));
            this.segundoNombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoNombreTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.segundoNombreTextBox.Location = new System.Drawing.Point(228, 222);
            this.segundoNombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segundoNombreTextBox.Name = "segundoNombreTextBox";
            this.segundoNombreTextBox.Size = new System.Drawing.Size(272, 30);
            this.segundoNombreTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 444);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de alumnos";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(553, 511);
            this.Controls.Add(estMatriculadoLabel);
            this.Controls.Add(this.estMatriculadoCheckBox);
            this.Controls.Add(numeroCuentaLabel);
            this.Controls.Add(this.numeroCuentaTextBox);
            this.Controls.Add(primerApellidoLabel);
            this.Controls.Add(this.primerApellidoTextBox);
            this.Controls.Add(primerNombreLabel);
            this.Controls.Add(this.primerNombreTextBox);
            this.Controls.Add(segundoApellidoLabel);
            this.Controls.Add(this.segundoApellidoTextBox);
            this.Controls.Add(segundoNombreLabel);
            this.Controls.Add(this.segundoNombreTextBox);
            this.Controls.Add(this.listaEstudiantesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).EndInit();
            this.listaEstudiantesBindingNavigator.ResumeLayout(false);
            this.listaEstudiantesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaEstudiantesBindingSource;
        private System.Windows.Forms.BindingNavigator listaEstudiantesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaEstudiantesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox estMatriculadoCheckBox;
        private System.Windows.Forms.TextBox numeroCuentaTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox primerNombreTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox segundoNombreTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}