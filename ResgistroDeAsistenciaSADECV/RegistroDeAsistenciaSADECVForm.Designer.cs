namespace ResgistroDeAsistenciaSADECV
{
    partial class RegistroDeAsistenciaSADECVForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hora_Lbl = new System.Windows.Forms.Label();
            this.fecha_Lbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.siete_Btn = new System.Windows.Forms.Button();
            this.nueve_Btn = new System.Windows.Forms.Button();
            this.ocho_Btn = new System.Windows.Forms.Button();
            this.uno_Btn = new System.Windows.Forms.Button();
            this.dos_Btn = new System.Windows.Forms.Button();
            this.tres_Btn = new System.Windows.Forms.Button();
            this.cuatro_Btn = new System.Windows.Forms.Button();
            this.cinco_Btn = new System.Windows.Forms.Button();
            this.seis_Btn = new System.Windows.Forms.Button();
            this.cero_Btn = new System.Windows.Forms.Button();
            this.dobleCero_Btn = new System.Windows.Forms.Button();
            this.borrar_Btn = new System.Windows.Forms.Button();
            this.administrador_Btn = new System.Windows.Forms.Button();
            this.usuario_Tbx = new System.Windows.Forms.TextBox();
            this.Administrador_Gbx = new System.Windows.Forms.GroupBox();
            this.codigoAdministrador_Tbx = new System.Windows.Forms.TextBox();
            this.contraseña_Lbl = new System.Windows.Forms.Label();
            this.datosPersonal_Gbx = new System.Windows.Forms.GroupBox();
            this.departamento_Cbx = new System.Windows.Forms.ComboBox();
            this.departamento_Lbl = new System.Windows.Forms.Label();
            this.generarReporte_Btn = new System.Windows.Forms.Button();
            this.registrarSalida_Btn = new System.Windows.Forms.Button();
            this.rFC_Tbx = new System.Windows.Forms.TextBox();
            this.rFC_Lbl = new System.Windows.Forms.Label();
            this.ingresarUsuario_Btn = new System.Windows.Forms.Button();
            this.validarUsuario_Btn = new System.Windows.Forms.Button();
            this.registrarEntrada_Btn = new System.Windows.Forms.Button();
            this.nombreCompleto_Tbx = new System.Windows.Forms.TextBox();
            this.nombreApellidoRegistro_Lbl = new System.Windows.Forms.Label();
            this.codigo_Lbl = new System.Windows.Forms.Label();
            this.validacion_Gbx = new System.Windows.Forms.GroupBox();
            this.persona_Gbx = new System.Windows.Forms.GroupBox();
            this.seleccionarImagen_Btn = new System.Windows.Forms.Button();
            this.bienvenida_Lbl = new System.Windows.Forms.Label();
            this.nombreApellido_Lbl = new System.Windows.Forms.Label();
            this.fotoPersonal_Picbox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Administrador_Gbx.SuspendLayout();
            this.datosPersonal_Gbx.SuspendLayout();
            this.validacion_Gbx.SuspendLayout();
            this.persona_Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPersonal_Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // hora_Lbl
            // 
            this.hora_Lbl.AutoSize = true;
            this.hora_Lbl.Font = new System.Drawing.Font("Consolas", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_Lbl.Location = new System.Drawing.Point(22, 16);
            this.hora_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hora_Lbl.Name = "hora_Lbl";
            this.hora_Lbl.Size = new System.Drawing.Size(104, 46);
            this.hora_Lbl.TabIndex = 0;
            this.hora_Lbl.Text = "Hora";
            // 
            // fecha_Lbl
            // 
            this.fecha_Lbl.AutoSize = true;
            this.fecha_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_Lbl.Location = new System.Drawing.Point(220, 33);
            this.fecha_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fecha_Lbl.Name = "fecha_Lbl";
            this.fecha_Lbl.Size = new System.Drawing.Size(77, 27);
            this.fecha_Lbl.TabIndex = 1;
            this.fecha_Lbl.Text = "Fecha";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Lbl_Tick);
            // 
            // siete_Btn
            // 
            this.siete_Btn.Location = new System.Drawing.Point(1067, 194);
            this.siete_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.siete_Btn.Name = "siete_Btn";
            this.siete_Btn.Size = new System.Drawing.Size(51, 62);
            this.siete_Btn.TabIndex = 2;
            this.siete_Btn.Text = "7";
            this.siete_Btn.UseVisualStyleBackColor = true;
            this.siete_Btn.Click += new System.EventHandler(this.siete_Btn_Click);
            // 
            // nueve_Btn
            // 
            this.nueve_Btn.Location = new System.Drawing.Point(1177, 194);
            this.nueve_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.nueve_Btn.Name = "nueve_Btn";
            this.nueve_Btn.Size = new System.Drawing.Size(51, 62);
            this.nueve_Btn.TabIndex = 3;
            this.nueve_Btn.Text = "9";
            this.nueve_Btn.UseVisualStyleBackColor = true;
            this.nueve_Btn.Click += new System.EventHandler(this.nueve_Btn_Click);
            // 
            // ocho_Btn
            // 
            this.ocho_Btn.Location = new System.Drawing.Point(1122, 194);
            this.ocho_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.ocho_Btn.Name = "ocho_Btn";
            this.ocho_Btn.Size = new System.Drawing.Size(51, 62);
            this.ocho_Btn.TabIndex = 4;
            this.ocho_Btn.Text = "8";
            this.ocho_Btn.UseVisualStyleBackColor = true;
            this.ocho_Btn.Click += new System.EventHandler(this.ocho_Btn_Click);
            // 
            // uno_Btn
            // 
            this.uno_Btn.Location = new System.Drawing.Point(1067, 326);
            this.uno_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.uno_Btn.Name = "uno_Btn";
            this.uno_Btn.Size = new System.Drawing.Size(51, 62);
            this.uno_Btn.TabIndex = 5;
            this.uno_Btn.Text = "1";
            this.uno_Btn.UseVisualStyleBackColor = true;
            this.uno_Btn.Click += new System.EventHandler(this.uno_Btn_Click);
            // 
            // dos_Btn
            // 
            this.dos_Btn.Location = new System.Drawing.Point(1122, 324);
            this.dos_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.dos_Btn.Name = "dos_Btn";
            this.dos_Btn.Size = new System.Drawing.Size(51, 62);
            this.dos_Btn.TabIndex = 6;
            this.dos_Btn.Text = "2";
            this.dos_Btn.UseVisualStyleBackColor = true;
            this.dos_Btn.Click += new System.EventHandler(this.dos_Btn_Click);
            // 
            // tres_Btn
            // 
            this.tres_Btn.Location = new System.Drawing.Point(1177, 326);
            this.tres_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.tres_Btn.Name = "tres_Btn";
            this.tres_Btn.Size = new System.Drawing.Size(51, 62);
            this.tres_Btn.TabIndex = 7;
            this.tres_Btn.Text = "3";
            this.tres_Btn.UseVisualStyleBackColor = true;
            this.tres_Btn.Click += new System.EventHandler(this.tres_Btn_Click);
            // 
            // cuatro_Btn
            // 
            this.cuatro_Btn.Location = new System.Drawing.Point(1067, 260);
            this.cuatro_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.cuatro_Btn.Name = "cuatro_Btn";
            this.cuatro_Btn.Size = new System.Drawing.Size(51, 62);
            this.cuatro_Btn.TabIndex = 8;
            this.cuatro_Btn.Text = "4";
            this.cuatro_Btn.UseVisualStyleBackColor = true;
            this.cuatro_Btn.Click += new System.EventHandler(this.cuatro_Btn_Click);
            // 
            // cinco_Btn
            // 
            this.cinco_Btn.Location = new System.Drawing.Point(1122, 260);
            this.cinco_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.cinco_Btn.Name = "cinco_Btn";
            this.cinco_Btn.Size = new System.Drawing.Size(51, 62);
            this.cinco_Btn.TabIndex = 9;
            this.cinco_Btn.Text = "5";
            this.cinco_Btn.UseVisualStyleBackColor = true;
            this.cinco_Btn.Click += new System.EventHandler(this.cinco_Btn_Click);
            // 
            // seis_Btn
            // 
            this.seis_Btn.Location = new System.Drawing.Point(1177, 260);
            this.seis_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.seis_Btn.Name = "seis_Btn";
            this.seis_Btn.Size = new System.Drawing.Size(51, 62);
            this.seis_Btn.TabIndex = 10;
            this.seis_Btn.Text = "6";
            this.seis_Btn.UseVisualStyleBackColor = true;
            this.seis_Btn.Click += new System.EventHandler(this.seis_Btn_Click);
            // 
            // cero_Btn
            // 
            this.cero_Btn.Location = new System.Drawing.Point(1067, 392);
            this.cero_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.cero_Btn.Name = "cero_Btn";
            this.cero_Btn.Size = new System.Drawing.Size(51, 62);
            this.cero_Btn.TabIndex = 13;
            this.cero_Btn.Text = "0";
            this.cero_Btn.UseVisualStyleBackColor = true;
            this.cero_Btn.Click += new System.EventHandler(this.cero_Btn_Click);
            // 
            // dobleCero_Btn
            // 
            this.dobleCero_Btn.Location = new System.Drawing.Point(1122, 392);
            this.dobleCero_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.dobleCero_Btn.Name = "dobleCero_Btn";
            this.dobleCero_Btn.Size = new System.Drawing.Size(51, 62);
            this.dobleCero_Btn.TabIndex = 14;
            this.dobleCero_Btn.Text = "00";
            this.dobleCero_Btn.UseVisualStyleBackColor = true;
            this.dobleCero_Btn.Click += new System.EventHandler(this.dobleCero_Btn_Click);
            // 
            // borrar_Btn
            // 
            this.borrar_Btn.Location = new System.Drawing.Point(1178, 392);
            this.borrar_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.borrar_Btn.Name = "borrar_Btn";
            this.borrar_Btn.Size = new System.Drawing.Size(51, 62);
            this.borrar_Btn.TabIndex = 16;
            this.borrar_Btn.Text = "<-";
            this.borrar_Btn.UseVisualStyleBackColor = true;
            this.borrar_Btn.Click += new System.EventHandler(this.borrar_Btn_Click);
            // 
            // administrador_Btn
            // 
            this.administrador_Btn.Location = new System.Drawing.Point(688, 22);
            this.administrador_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.administrador_Btn.Name = "administrador_Btn";
            this.administrador_Btn.Size = new System.Drawing.Size(88, 64);
            this.administrador_Btn.TabIndex = 21;
            this.administrador_Btn.Text = "Administrador";
            this.administrador_Btn.UseVisualStyleBackColor = true;
            this.administrador_Btn.Click += new System.EventHandler(this.administrador_Btn_Click);
            // 
            // usuario_Tbx
            // 
            this.usuario_Tbx.Location = new System.Drawing.Point(239, 34);
            this.usuario_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.usuario_Tbx.Name = "usuario_Tbx";
            this.usuario_Tbx.Size = new System.Drawing.Size(137, 20);
            this.usuario_Tbx.TabIndex = 22;
            this.usuario_Tbx.Click += new System.EventHandler(this.usuario_Tbx_Click);
            // 
            // Administrador_Gbx
            // 
            this.Administrador_Gbx.Controls.Add(this.codigoAdministrador_Tbx);
            this.Administrador_Gbx.Controls.Add(this.contraseña_Lbl);
            this.Administrador_Gbx.Controls.Add(this.administrador_Btn);
            this.Administrador_Gbx.Location = new System.Drawing.Point(12, 12);
            this.Administrador_Gbx.Name = "Administrador_Gbx";
            this.Administrador_Gbx.Size = new System.Drawing.Size(963, 96);
            this.Administrador_Gbx.TabIndex = 23;
            this.Administrador_Gbx.TabStop = false;
            this.Administrador_Gbx.Text = "Modo administrador";
            // 
            // codigoAdministrador_Tbx
            // 
            this.codigoAdministrador_Tbx.Location = new System.Drawing.Point(500, 45);
            this.codigoAdministrador_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.codigoAdministrador_Tbx.Name = "codigoAdministrador_Tbx";
            this.codigoAdministrador_Tbx.Size = new System.Drawing.Size(146, 20);
            this.codigoAdministrador_Tbx.TabIndex = 24;
            this.codigoAdministrador_Tbx.Click += new System.EventHandler(this.codigoAdministrador_Tbx_Click);
            // 
            // contraseña_Lbl
            // 
            this.contraseña_Lbl.AutoSize = true;
            this.contraseña_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_Lbl.Location = new System.Drawing.Point(5, 43);
            this.contraseña_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseña_Lbl.Name = "contraseña_Lbl";
            this.contraseña_Lbl.Size = new System.Drawing.Size(467, 27);
            this.contraseña_Lbl.TabIndex = 24;
            this.contraseña_Lbl.Text = "Ingrese el Codigo de administrador:";
            // 
            // datosPersonal_Gbx
            // 
            this.datosPersonal_Gbx.Controls.Add(this.departamento_Cbx);
            this.datosPersonal_Gbx.Controls.Add(this.departamento_Lbl);
            this.datosPersonal_Gbx.Controls.Add(this.generarReporte_Btn);
            this.datosPersonal_Gbx.Controls.Add(this.registrarSalida_Btn);
            this.datosPersonal_Gbx.Controls.Add(this.rFC_Tbx);
            this.datosPersonal_Gbx.Controls.Add(this.rFC_Lbl);
            this.datosPersonal_Gbx.Controls.Add(this.ingresarUsuario_Btn);
            this.datosPersonal_Gbx.Controls.Add(this.validarUsuario_Btn);
            this.datosPersonal_Gbx.Controls.Add(this.registrarEntrada_Btn);
            this.datosPersonal_Gbx.Controls.Add(this.nombreCompleto_Tbx);
            this.datosPersonal_Gbx.Controls.Add(this.nombreApellidoRegistro_Lbl);
            this.datosPersonal_Gbx.Controls.Add(this.usuario_Tbx);
            this.datosPersonal_Gbx.Controls.Add(this.codigo_Lbl);
            this.datosPersonal_Gbx.Location = new System.Drawing.Point(12, 114);
            this.datosPersonal_Gbx.Name = "datosPersonal_Gbx";
            this.datosPersonal_Gbx.Size = new System.Drawing.Size(637, 364);
            this.datosPersonal_Gbx.TabIndex = 24;
            this.datosPersonal_Gbx.TabStop = false;
            this.datosPersonal_Gbx.Text = "Datos del personal";
            // 
            // departamento_Cbx
            // 
            this.departamento_Cbx.FormattingEnabled = true;
            this.departamento_Cbx.Items.AddRange(new object[] {
            "RH",
            "TI",
            "R&D",
            "MKT",
            "Ops"});
            this.departamento_Cbx.Location = new System.Drawing.Point(383, 232);
            this.departamento_Cbx.Name = "departamento_Cbx";
            this.departamento_Cbx.Size = new System.Drawing.Size(137, 21);
            this.departamento_Cbx.TabIndex = 37;
            this.departamento_Cbx.Visible = false;
            // 
            // departamento_Lbl
            // 
            this.departamento_Lbl.AutoSize = true;
            this.departamento_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento_Lbl.Location = new System.Drawing.Point(5, 225);
            this.departamento_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departamento_Lbl.Name = "departamento_Lbl";
            this.departamento_Lbl.Size = new System.Drawing.Size(298, 27);
            this.departamento_Lbl.TabIndex = 35;
            this.departamento_Lbl.Text = "Ingresar Departamento:";
            this.departamento_Lbl.Visible = false;
            // 
            // generarReporte_Btn
            // 
            this.generarReporte_Btn.Location = new System.Drawing.Point(396, 312);
            this.generarReporte_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.generarReporte_Btn.Name = "generarReporte_Btn";
            this.generarReporte_Btn.Size = new System.Drawing.Size(80, 38);
            this.generarReporte_Btn.TabIndex = 34;
            this.generarReporte_Btn.Text = "Generar Reporte";
            this.generarReporte_Btn.UseVisualStyleBackColor = true;
            this.generarReporte_Btn.Visible = false;
            this.generarReporte_Btn.Click += new System.EventHandler(this.generarReporte_Btn_Click);
            // 
            // registrarSalida_Btn
            // 
            this.registrarSalida_Btn.Location = new System.Drawing.Point(106, 312);
            this.registrarSalida_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.registrarSalida_Btn.Name = "registrarSalida_Btn";
            this.registrarSalida_Btn.Size = new System.Drawing.Size(80, 38);
            this.registrarSalida_Btn.TabIndex = 33;
            this.registrarSalida_Btn.Text = "Registrar Salida";
            this.registrarSalida_Btn.UseVisualStyleBackColor = true;
            this.registrarSalida_Btn.Click += new System.EventHandler(this.registrarSalida_Btn_Click);
            // 
            // rFC_Tbx
            // 
            this.rFC_Tbx.Location = new System.Drawing.Point(383, 170);
            this.rFC_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.rFC_Tbx.Name = "rFC_Tbx";
            this.rFC_Tbx.Size = new System.Drawing.Size(137, 20);
            this.rFC_Tbx.TabIndex = 32;
            this.rFC_Tbx.Visible = false;
            // 
            // rFC_Lbl
            // 
            this.rFC_Lbl.AutoSize = true;
            this.rFC_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFC_Lbl.Location = new System.Drawing.Point(5, 163);
            this.rFC_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rFC_Lbl.Name = "rFC_Lbl";
            this.rFC_Lbl.Size = new System.Drawing.Size(181, 27);
            this.rFC_Lbl.TabIndex = 31;
            this.rFC_Lbl.Text = "Ingresar RFC:";
            this.rFC_Lbl.Visible = false;
            // 
            // ingresarUsuario_Btn
            // 
            this.ingresarUsuario_Btn.Location = new System.Drawing.Point(296, 312);
            this.ingresarUsuario_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.ingresarUsuario_Btn.Name = "ingresarUsuario_Btn";
            this.ingresarUsuario_Btn.Size = new System.Drawing.Size(80, 38);
            this.ingresarUsuario_Btn.TabIndex = 30;
            this.ingresarUsuario_Btn.Text = "Registrar Usuario";
            this.ingresarUsuario_Btn.UseVisualStyleBackColor = true;
            this.ingresarUsuario_Btn.Visible = false;
            this.ingresarUsuario_Btn.Click += new System.EventHandler(this.ingresarUsuario_Btn_Click);
            // 
            // validarUsuario_Btn
            // 
            this.validarUsuario_Btn.Location = new System.Drawing.Point(202, 312);
            this.validarUsuario_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.validarUsuario_Btn.Name = "validarUsuario_Btn";
            this.validarUsuario_Btn.Size = new System.Drawing.Size(80, 38);
            this.validarUsuario_Btn.TabIndex = 29;
            this.validarUsuario_Btn.Text = "Validar Usuario";
            this.validarUsuario_Btn.UseVisualStyleBackColor = true;
            this.validarUsuario_Btn.Click += new System.EventHandler(this.validarUsuario_Btn_Click);
            // 
            // registrarEntrada_Btn
            // 
            this.registrarEntrada_Btn.Location = new System.Drawing.Point(10, 312);
            this.registrarEntrada_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.registrarEntrada_Btn.Name = "registrarEntrada_Btn";
            this.registrarEntrada_Btn.Size = new System.Drawing.Size(80, 38);
            this.registrarEntrada_Btn.TabIndex = 25;
            this.registrarEntrada_Btn.Text = "Registrar Entrada";
            this.registrarEntrada_Btn.UseVisualStyleBackColor = true;
            this.registrarEntrada_Btn.Click += new System.EventHandler(this.registrarEntrada_Btn_Click);
            // 
            // nombreCompleto_Tbx
            // 
            this.nombreCompleto_Tbx.Location = new System.Drawing.Point(383, 100);
            this.nombreCompleto_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.nombreCompleto_Tbx.Name = "nombreCompleto_Tbx";
            this.nombreCompleto_Tbx.Size = new System.Drawing.Size(137, 20);
            this.nombreCompleto_Tbx.TabIndex = 28;
            this.nombreCompleto_Tbx.Visible = false;
            // 
            // nombreApellidoRegistro_Lbl
            // 
            this.nombreApellidoRegistro_Lbl.AutoSize = true;
            this.nombreApellidoRegistro_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreApellidoRegistro_Lbl.Location = new System.Drawing.Point(5, 95);
            this.nombreApellidoRegistro_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreApellidoRegistro_Lbl.Name = "nombreApellidoRegistro_Lbl";
            this.nombreApellidoRegistro_Lbl.Size = new System.Drawing.Size(363, 27);
            this.nombreApellidoRegistro_Lbl.TabIndex = 27;
            this.nombreApellidoRegistro_Lbl.Text = "Ingresar nombre y apellido:";
            this.nombreApellidoRegistro_Lbl.Visible = false;
            // 
            // codigo_Lbl
            // 
            this.codigo_Lbl.AutoSize = true;
            this.codigo_Lbl.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_Lbl.Location = new System.Drawing.Point(5, 31);
            this.codigo_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigo_Lbl.Name = "codigo_Lbl";
            this.codigo_Lbl.Size = new System.Drawing.Size(220, 27);
            this.codigo_Lbl.TabIndex = 26;
            this.codigo_Lbl.Text = "Ingresar codigo:";
            // 
            // validacion_Gbx
            // 
            this.validacion_Gbx.Controls.Add(this.fecha_Lbl);
            this.validacion_Gbx.Controls.Add(this.hora_Lbl);
            this.validacion_Gbx.Location = new System.Drawing.Point(12, 502);
            this.validacion_Gbx.Name = "validacion_Gbx";
            this.validacion_Gbx.Size = new System.Drawing.Size(963, 121);
            this.validacion_Gbx.TabIndex = 25;
            this.validacion_Gbx.TabStop = false;
            this.validacion_Gbx.Text = "Validación";
            // 
            // persona_Gbx
            // 
            this.persona_Gbx.Controls.Add(this.seleccionarImagen_Btn);
            this.persona_Gbx.Controls.Add(this.bienvenida_Lbl);
            this.persona_Gbx.Controls.Add(this.nombreApellido_Lbl);
            this.persona_Gbx.Controls.Add(this.fotoPersonal_Picbox);
            this.persona_Gbx.Location = new System.Drawing.Point(655, 114);
            this.persona_Gbx.Name = "persona_Gbx";
            this.persona_Gbx.Size = new System.Drawing.Size(320, 364);
            this.persona_Gbx.TabIndex = 26;
            this.persona_Gbx.TabStop = false;
            this.persona_Gbx.Text = "Datos del personal";
            // 
            // seleccionarImagen_Btn
            // 
            this.seleccionarImagen_Btn.Location = new System.Drawing.Point(119, 312);
            this.seleccionarImagen_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.seleccionarImagen_Btn.Name = "seleccionarImagen_Btn";
            this.seleccionarImagen_Btn.Size = new System.Drawing.Size(114, 38);
            this.seleccionarImagen_Btn.TabIndex = 38;
            this.seleccionarImagen_Btn.Text = "Ingresar Fotografia del Personal";
            this.seleccionarImagen_Btn.UseVisualStyleBackColor = true;
            this.seleccionarImagen_Btn.Visible = false;
            this.seleccionarImagen_Btn.Click += new System.EventHandler(this.seleccionarImagen_Btn_Click);
            // 
            // bienvenida_Lbl
            // 
            this.bienvenida_Lbl.AutoSize = true;
            this.bienvenida_Lbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.bienvenida_Lbl.Location = new System.Drawing.Point(5, 278);
            this.bienvenida_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bienvenida_Lbl.Name = "bienvenida_Lbl";
            this.bienvenida_Lbl.Size = new System.Drawing.Size(99, 19);
            this.bienvenida_Lbl.TabIndex = 30;
            this.bienvenida_Lbl.Text = "Bienvenido";
            this.bienvenida_Lbl.Visible = false;
            // 
            // nombreApellido_Lbl
            // 
            this.nombreApellido_Lbl.AutoSize = true;
            this.nombreApellido_Lbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.nombreApellido_Lbl.Location = new System.Drawing.Point(5, 210);
            this.nombreApellido_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreApellido_Lbl.Name = "nombreApellido_Lbl";
            this.nombreApellido_Lbl.Size = new System.Drawing.Size(162, 19);
            this.nombreApellido_Lbl.TabIndex = 29;
            this.nombreApellido_Lbl.Text = "nombre y apellido";
            this.nombreApellido_Lbl.Visible = false;
            // 
            // fotoPersonal_Picbox
            // 
            this.fotoPersonal_Picbox.Location = new System.Drawing.Point(32, 19);
            this.fotoPersonal_Picbox.Name = "fotoPersonal_Picbox";
            this.fotoPersonal_Picbox.Size = new System.Drawing.Size(263, 171);
            this.fotoPersonal_Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPersonal_Picbox.TabIndex = 0;
            this.fotoPersonal_Picbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(1078, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 83);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroDeAsistenciaSADECVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.persona_Gbx);
            this.Controls.Add(this.validacion_Gbx);
            this.Controls.Add(this.datosPersonal_Gbx);
            this.Controls.Add(this.Administrador_Gbx);
            this.Controls.Add(this.borrar_Btn);
            this.Controls.Add(this.dobleCero_Btn);
            this.Controls.Add(this.cero_Btn);
            this.Controls.Add(this.seis_Btn);
            this.Controls.Add(this.cinco_Btn);
            this.Controls.Add(this.cuatro_Btn);
            this.Controls.Add(this.tres_Btn);
            this.Controls.Add(this.dos_Btn);
            this.Controls.Add(this.uno_Btn);
            this.Controls.Add(this.ocho_Btn);
            this.Controls.Add(this.nueve_Btn);
            this.Controls.Add(this.siete_Btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroDeAsistenciaSADECVForm";
            this.Load += new System.EventHandler(this.RegistroDeAsistenciaSADECVForm_Load);
            this.Administrador_Gbx.ResumeLayout(false);
            this.Administrador_Gbx.PerformLayout();
            this.datosPersonal_Gbx.ResumeLayout(false);
            this.datosPersonal_Gbx.PerformLayout();
            this.validacion_Gbx.ResumeLayout(false);
            this.validacion_Gbx.PerformLayout();
            this.persona_Gbx.ResumeLayout(false);
            this.persona_Gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPersonal_Picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hora_Lbl;
        private System.Windows.Forms.Label fecha_Lbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button siete_Btn;
        private System.Windows.Forms.Button nueve_Btn;
        private System.Windows.Forms.Button ocho_Btn;
        private System.Windows.Forms.Button uno_Btn;
        private System.Windows.Forms.Button dos_Btn;
        private System.Windows.Forms.Button tres_Btn;
        private System.Windows.Forms.Button cuatro_Btn;
        private System.Windows.Forms.Button cinco_Btn;
        private System.Windows.Forms.Button seis_Btn;
        private System.Windows.Forms.Button cero_Btn;
        private System.Windows.Forms.Button dobleCero_Btn;
        private System.Windows.Forms.Button borrar_Btn;
        private System.Windows.Forms.Button administrador_Btn;
        private System.Windows.Forms.TextBox usuario_Tbx;
        private System.Windows.Forms.GroupBox Administrador_Gbx;
        private System.Windows.Forms.TextBox codigoAdministrador_Tbx;
        private System.Windows.Forms.Label contraseña_Lbl;
        private System.Windows.Forms.GroupBox datosPersonal_Gbx;
        private System.Windows.Forms.GroupBox validacion_Gbx;
        private System.Windows.Forms.GroupBox persona_Gbx;
        private System.Windows.Forms.PictureBox fotoPersonal_Picbox;
        private System.Windows.Forms.TextBox nombreCompleto_Tbx;
        private System.Windows.Forms.Label nombreApellidoRegistro_Lbl;
        private System.Windows.Forms.Label codigo_Lbl;
        private System.Windows.Forms.TextBox rFC_Tbx;
        private System.Windows.Forms.Label rFC_Lbl;
        private System.Windows.Forms.Button ingresarUsuario_Btn;
        private System.Windows.Forms.Button validarUsuario_Btn;
        private System.Windows.Forms.Button registrarEntrada_Btn;
        private System.Windows.Forms.Label bienvenida_Lbl;
        private System.Windows.Forms.Label nombreApellido_Lbl;
        private System.Windows.Forms.Button generarReporte_Btn;
        private System.Windows.Forms.Button registrarSalida_Btn;
        private System.Windows.Forms.Label departamento_Lbl;
        private System.Windows.Forms.ComboBox departamento_Cbx;
        private System.Windows.Forms.Button seleccionarImagen_Btn;
        private System.Windows.Forms.Button button1;
    }
}

