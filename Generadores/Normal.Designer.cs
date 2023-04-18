﻿using SIM_TP2.Util.NormalUtil;
using System.Collections.Generic;

namespace SIM_TP2.Generadores
{
    partial class Normal
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
            SIM_TP2.Util.NormalUtil.BoxMullerMethod boxMullerMethod1 = new SIM_TP2.Util.NormalUtil.BoxMullerMethod();
            SIM_TP2.Util.NormalUtil.ConvolutionMethod convolutionMethod1 = new SIM_TP2.Util.NormalUtil.ConvolutionMethod();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normal));
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.boxIntervalos = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvFrecuencias = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNormal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.NumericUpDown();
            this.txtA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(217, 116);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(135, 30);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // boxIntervalos
            // 
            this.boxIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxIntervalos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIntervalos.FormattingEnabled = true;
            this.boxIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.boxIntervalos.SelectedIndex = 0;
            this.boxIntervalos.Location = new System.Drawing.Point(217, 158);
            this.boxIntervalos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxIntervalos.Name = "boxIntervalos";
            this.boxIntervalos.Size = new System.Drawing.Size(134, 31);
            this.boxIntervalos.TabIndex = 29;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(217, 276);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(129, 39);
            this.btnGraficar.TabIndex = 30;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficarClick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(42, 276);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(129, 39);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(22, 117);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(169, 23);
            this.lblCantidad.TabIndex = 31;
            this.lblCantidad.Text = "Cantidad de Valores:";
            // 
            // dgvFrecuencias
            // 
            this.dgvFrecuencias.AllowUserToAddRows = false;
            this.dgvFrecuencias.AllowUserToDeleteRows = false;
            this.dgvFrecuencias.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencias.Location = new System.Drawing.Point(42, 339);
            this.dgvFrecuencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFrecuencias.Name = "dgvFrecuencias";
            this.dgvFrecuencias.ReadOnly = true;
            this.dgvFrecuencias.RowHeadersVisible = false;
            this.dgvFrecuencias.RowHeadersWidth = 51;
            this.dgvFrecuencias.RowTemplate.Height = 24;
            this.dgvFrecuencias.Size = new System.Drawing.Size(822, 182);
            this.dgvFrecuencias.TabIndex = 33;
            this.dgvFrecuencias.Visible = false;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 125;
            // 
            // nro
            // 
            this.nro.HeaderText = "Número";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            this.nro.Width = 125;
            // 
            // dgvNormal
            // 
            this.dgvNormal.AllowUserToAddRows = false;
            this.dgvNormal.AllowUserToDeleteRows = false;
            this.dgvNormal.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.valor});
            this.dgvNormal.GridColor = System.Drawing.Color.Bisque;
            this.dgvNormal.Location = new System.Drawing.Point(370, 42);
            this.dgvNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNormal.Name = "dgvNormal";
            this.dgvNormal.ReadOnly = true;
            this.dgvNormal.RowHeadersVisible = false;
            this.dgvNormal.RowHeadersWidth = 51;
            this.dgvNormal.RowTemplate.Height = 24;
            this.dgvNormal.Size = new System.Drawing.Size(494, 271);
            this.dgvNormal.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 34;
            this.label1.Tag = "";
            this.label1.Text = "Media(mu):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Desviación estándar(sigma)";
            // 
            // txtB
            // 
            this.txtB.DecimalPlaces = 2;
            this.txtB.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtB.Location = new System.Drawing.Point(217, 72);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtB.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(135, 30);
            this.txtB.TabIndex = 37;
            this.txtB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtA
            // 
            this.txtA.DecimalPlaces = 2;
            this.txtA.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtA.Location = new System.Drawing.Point(217, 32);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtA.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(135, 30);
            this.txtA.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Método:";
            // 
            // comboMetodo
            // 
            this.comboMetodo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Items.AddRange(new object[] {
            boxMullerMethod1,
            convolutionMethod1});
            this.comboMetodo.SelectedIndex = 0;
            this.comboMetodo.Location = new System.Drawing.Point(217, 221);
            this.comboMetodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(127, 31);
            this.comboMetodo.TabIndex = 39;
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIM_TP2.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFrecuencias);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvNormal);
            this.Controls.Add(this.boxIntervalos);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCantidad);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.ComboBox boxIntervalos;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridView dgvNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtB;
        private System.Windows.Forms.NumericUpDown txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMetodo;
    }
}