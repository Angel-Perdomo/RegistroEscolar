using System;

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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label clasesLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label gradoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiante));
            this.listaEstudiantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaEstudiantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.clasesTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.gradoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            activoLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            clasesLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            gradoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).BeginInit();
            this.listaEstudiantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.ForeColor = System.Drawing.Color.Black;
            activoLabel.Location = new System.Drawing.Point(34, 428);
            activoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(72, 25);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.ForeColor = System.Drawing.Color.Black;
            apellidoLabel.Location = new System.Drawing.Point(34, 181);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(88, 25);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.ForeColor = System.Drawing.Color.Black;
            celularLabel.Location = new System.Drawing.Point(34, 265);
            celularLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(80, 25);
            celularLabel.TabIndex = 5;
            celularLabel.Text = "Celular:";
            // 
            // clasesLabel
            // 
            clasesLabel.AutoSize = true;
            clasesLabel.ForeColor = System.Drawing.Color.Black;
            clasesLabel.Location = new System.Drawing.Point(34, 349);
            clasesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            clasesLabel.Name = "clasesLabel";
            clasesLabel.Size = new System.Drawing.Size(79, 25);
            clasesLabel.TabIndex = 7;
            clasesLabel.Text = "Clases:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.ForeColor = System.Drawing.Color.Black;
            correoLabel.Location = new System.Drawing.Point(34, 307);
            correoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(78, 25);
            correoLabel.TabIndex = 9;
            correoLabel.Text = "Correo:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.ForeColor = System.Drawing.Color.Black;
            edadLabel.Location = new System.Drawing.Point(34, 223);
            edadLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(64, 25);
            edadLabel.TabIndex = 11;
            edadLabel.Text = "Edad:";
            // 
            // gradoLabel
            // 
            gradoLabel.AutoSize = true;
            gradoLabel.ForeColor = System.Drawing.Color.Black;
            gradoLabel.Location = new System.Drawing.Point(34, 391);
            gradoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            gradoLabel.Name = "gradoLabel";
            gradoLabel.Size = new System.Drawing.Size(72, 25);
            gradoLabel.TabIndex = 13;
            gradoLabel.Text = "Grado:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.Color.Black;
            idLabel.Location = new System.Drawing.Point(34, 55);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 15;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(34, 139);
            nombreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(87, 25);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.ForeColor = System.Drawing.Color.Black;
            cedulaLabel.Location = new System.Drawing.Point(34, 97);
            cedulaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(81, 25);
            cedulaLabel.TabIndex = 19;
            cedulaLabel.Text = "Cedula:";
            // 
            // listaEstudiantesBindingNavigator
            // 
            this.listaEstudiantesBindingNavigator.AddNewItem = null;
            this.listaEstudiantesBindingNavigator.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listaEstudiantesBindingNavigator.BindingSource = this.listaEstudiantesBindingSource;
            this.listaEstudiantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEstudiantesBindingNavigator.DeleteItem = null;
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
            this.listaEstudiantesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaEstudiantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEstudiantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEstudiantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEstudiantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEstudiantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEstudiantesBindingNavigator.Name = "listaEstudiantesBindingNavigator";
            this.listaEstudiantesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.listaEstudiantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEstudiantesBindingNavigator.Size = new System.Drawing.Size(565, 35);
            this.listaEstudiantesBindingNavigator.TabIndex = 0;
            this.listaEstudiantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaEstudiantesBindingSource
            // 
            this.listaEstudiantesBindingSource.DataSource = typeof(BL.Escuela.Estudiante);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 32);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaEstudiantesBindingNavigatorSaveItem
            // 
            this.listaEstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEstudiantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEstudiantesBindingNavigatorSaveItem.Image")));
            this.listaEstudiantesBindingNavigatorSaveItem.Name = "listaEstudiantesBindingNavigatorSaveItem";
            this.listaEstudiantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 32);
            this.listaEstudiantesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaEstudiantesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaEstudiantesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(110, 36);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaEstudiantesBindingSource, "Activo", true));
            this.activoCheckBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.activoCheckBox.Location = new System.Drawing.Point(161, 424);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(27, 35);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Apellido", true));
            this.apellidoTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.apellidoTextBox.Location = new System.Drawing.Point(161, 176);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(303, 30);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Celular", true));
            this.celularTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.celularTextBox.Location = new System.Drawing.Point(161, 260);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(240, 30);
            this.celularTextBox.TabIndex = 6;
            // 
            // clasesTextBox
            // 
            this.clasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Clases", true));
            this.clasesTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.clasesTextBox.Location = new System.Drawing.Point(161, 344);
            this.clasesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.clasesTextBox.Name = "clasesTextBox";
            this.clasesTextBox.Size = new System.Drawing.Size(159, 30);
            this.clasesTextBox.TabIndex = 8;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Correo", true));
            this.correoTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.correoTextBox.Location = new System.Drawing.Point(161, 302);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(303, 30);
            this.correoTextBox.TabIndex = 10;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Edad", true));
            this.edadTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.edadTextBox.Location = new System.Drawing.Point(161, 218);
            this.edadTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(159, 30);
            this.edadTextBox.TabIndex = 12;
            // 
            // gradoTextBox
            // 
            this.gradoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Grado", true));
            this.gradoTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.gradoTextBox.Location = new System.Drawing.Point(161, 386);
            this.gradoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.gradoTextBox.Name = "gradoTextBox";
            this.gradoTextBox.Size = new System.Drawing.Size(303, 30);
            this.gradoTextBox.TabIndex = 14;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(161, 50);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(159, 30);
            this.idTextBox.TabIndex = 16;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Nombre", true));
            this.nombreTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.nombreTextBox.Location = new System.Drawing.Point(161, 134);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(303, 30);
            this.nombreTextBox.TabIndex = 18;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Cedula", true));
            this.cedulaTextBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.cedulaTextBox.Location = new System.Drawing.Point(161, 92);
            this.cedulaTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(303, 30);
            this.cedulaTextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cedulaLabel);
            this.groupBox1.Controls.Add(this.cedulaTextBox);
            this.groupBox1.Controls.Add(activoLabel);
            this.groupBox1.Controls.Add(this.activoCheckBox);
            this.groupBox1.Controls.Add(apellidoLabel);
            this.groupBox1.Controls.Add(this.apellidoTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(this.celularTextBox);
            this.groupBox1.Controls.Add(clasesLabel);
            this.groupBox1.Controls.Add(this.clasesTextBox);
            this.groupBox1.Controls.Add(correoLabel);
            this.groupBox1.Controls.Add(this.correoTextBox);
            this.groupBox1.Controls.Add(edadLabel);
            this.groupBox1.Controls.Add(this.edadTextBox);
            this.groupBox1.Controls.Add(gradoLabel);
            this.groupBox1.Controls.Add(this.gradoTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(28, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 485);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de alumnos";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(565, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaEstudiantesBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).EndInit();
            this.listaEstudiantesBindingNavigator.ResumeLayout(false);
            this.listaEstudiantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox clasesTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox gradoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}