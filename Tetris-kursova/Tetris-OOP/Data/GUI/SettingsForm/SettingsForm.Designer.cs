﻿namespace Tetris.Data.GUI.SettingsForm
{
	partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btBack = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tltSettings = new System.Windows.Forms.ToolTip(this.components);
            this.cbFullScreen = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShadow = new System.Windows.Forms.CheckBox();
            this.cbNextShape = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGame = new System.Windows.Forms.TabPage();
            this.tbGraphics = new System.Windows.Forms.TabPage();
            this.pGraphicsMedium = new System.Windows.Forms.Panel();
            this.pbColorField = new System.Windows.Forms.PictureBox();
            this.pbColorBackground = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TabPage();
            this.btInputKeyRotate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtArrow = new System.Windows.Forms.RadioButton();
            this.rbtWASD = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpGame.SuspendLayout();
            this.tbGraphics.SuspendLayout();
            this.pGraphicsMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBackground)).BeginInit();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(215, 259);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 50);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.White;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Location = new System.Drawing.Point(109, 259);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(100, 50);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Скинути";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.BtReset_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(3, 259);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 50);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // tltSettings
            // 
            this.tltSettings.IsBalloon = true;
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.Checked = global::Tetris.Properties.Settings.Default.BorderScreen;
            this.cbFullScreen.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tetris.Properties.Settings.Default, "BorderScreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFullScreen.Location = new System.Drawing.Point(13, 13);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbFullScreen.Size = new System.Drawing.Size(184, 24);
            this.cbFullScreen.TabIndex = 2;
            this.cbFullScreen.Text = "На весь екран";
            this.cbFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tltSettings.SetToolTip(this.cbFullScreen, "Открывает приложение во весь экран без рамок.");
            this.cbFullScreen.UseVisualStyleBackColor = true;
            this.cbFullScreen.CheckedChanged += new System.EventHandler(this.CbFullScreen_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цвет поля";
            this.tltSettings.SetToolTip(this.label4, "Устанавливает цвет игрового поля, на котором происходит игра");
            // 
            // cbShadow
            // 
            this.cbShadow.Checked = global::Tetris.Properties.Settings.Default.ShadowShape;
            this.cbShadow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShadow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tetris.Properties.Settings.Default, "ShadowShape", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShadow.Location = new System.Drawing.Point(13, 13);
            this.cbShadow.Name = "cbShadow";
            this.cbShadow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbShadow.Size = new System.Drawing.Size(184, 24);
            this.cbShadow.TabIndex = 1;
            this.cbShadow.Text = "Тінь від фігури";
            this.cbShadow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tltSettings.SetToolTip(this.cbShadow, "Подсказка, показывающая, куда упадет фигура в настоящий момент времени.");
            this.cbShadow.UseVisualStyleBackColor = true;
            // 
            // cbNextShape
            // 
            this.cbNextShape.Checked = global::Tetris.Properties.Settings.Default.NextShape;
            this.cbNextShape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNextShape.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tetris.Properties.Settings.Default, "NextShape", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNextShape.Location = new System.Drawing.Point(13, 43);
            this.cbNextShape.Name = "cbNextShape";
            this.cbNextShape.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNextShape.Size = new System.Drawing.Size(184, 24);
            this.cbNextShape.TabIndex = 1;
            this.cbNextShape.Text = "Наступна фігура";
            this.cbNextShape.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tltSettings.SetToolTip(this.cbNextShape, "Показывает фигуру, которая появится, после падение текущей.");
            this.cbNextShape.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcSettings);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 314);
            this.panel1.TabIndex = 2;
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGame);
            this.tcSettings.Controls.Add(this.tbGraphics);
            this.tcSettings.Controls.Add(this.tpControl);
            this.tcSettings.Location = new System.Drawing.Point(48, 3);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(224, 250);
            this.tcSettings.TabIndex = 1;
            // 
            // tpGame
            // 
            this.tpGame.Controls.Add(this.cbNextShape);
            this.tpGame.Controls.Add(this.cbShadow);
            this.tpGame.Location = new System.Drawing.Point(4, 29);
            this.tpGame.Name = "tpGame";
            this.tpGame.Padding = new System.Windows.Forms.Padding(10);
            this.tpGame.Size = new System.Drawing.Size(216, 217);
            this.tpGame.TabIndex = 0;
            this.tpGame.Text = "Гра";
            this.tpGame.UseVisualStyleBackColor = true;
            // 
            // tbGraphics
            // 
            this.tbGraphics.Controls.Add(this.pGraphicsMedium);
            this.tbGraphics.Controls.Add(this.cbFullScreen);
            this.tbGraphics.Controls.Add(this.cbGraphics);
            this.tbGraphics.Controls.Add(this.label1);
            this.tbGraphics.Location = new System.Drawing.Point(4, 29);
            this.tbGraphics.Name = "tbGraphics";
            this.tbGraphics.Padding = new System.Windows.Forms.Padding(10);
            this.tbGraphics.Size = new System.Drawing.Size(216, 217);
            this.tbGraphics.TabIndex = 1;
            this.tbGraphics.Text = "Графіка";
            this.tbGraphics.UseVisualStyleBackColor = true;
            // 
            // pGraphicsMedium
            // 
            this.pGraphicsMedium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGraphicsMedium.Controls.Add(this.pbColorField);
            this.pGraphicsMedium.Controls.Add(this.pbColorBackground);
            this.pGraphicsMedium.Controls.Add(this.label4);
            this.pGraphicsMedium.Controls.Add(this.label3);
            this.pGraphicsMedium.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::Tetris.Properties.Settings.Default, "pnlGraphicsMedium", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pGraphicsMedium.Location = new System.Drawing.Point(19, 99);
            this.pGraphicsMedium.Name = "pGraphicsMedium";
            this.pGraphicsMedium.Size = new System.Drawing.Size(183, 74);
            this.pGraphicsMedium.TabIndex = 3;
            this.pGraphicsMedium.Visible = global::Tetris.Properties.Settings.Default.pnlGraphicsMedium;
            // 
            // pbColorField
            // 
            this.pbColorField.BackColor = global::Tetris.Properties.Settings.Default.BackColor;
            this.pbColorField.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbColorField.Location = new System.Drawing.Point(103, 42);
            this.pbColorField.Name = "pbColorField";
            this.pbColorField.Size = new System.Drawing.Size(20, 20);
            this.pbColorField.TabIndex = 3;
            this.pbColorField.TabStop = false;
            this.pbColorField.Click += new System.EventHandler(this.PbColorField_Click);
            // 
            // pbColorBackground
            // 
            this.pbColorBackground.BackColor = global::Tetris.Properties.Settings.Default.Background;
            this.pbColorBackground.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbColorBackground.Location = new System.Drawing.Point(103, 7);
            this.pbColorBackground.Name = "pbColorBackground";
            this.pbColorBackground.Size = new System.Drawing.Size(20, 20);
            this.pbColorBackground.TabIndex = 3;
            this.pbColorBackground.TabStop = false;
            this.pbColorBackground.Click += new System.EventHandler(this.PbColorBackground_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цвет фона";
            // 
            // cbGraphics
            // 
            this.cbGraphics.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", global::Tetris.Properties.Settings.Default, "SelectedGraphic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGraphics.DataBindings.Add(new System.Windows.Forms.Binding("TabIndex", global::Tetris.Properties.Settings.Default, "Quality", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Items.AddRange(new object[] {
            "Классика",
            "Стандарт"});
            this.cbGraphics.Location = new System.Drawing.Point(102, 43);
            this.cbGraphics.MaxDropDownItems = 3;
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(95, 28);
            this.cbGraphics.TabIndex = global::Tetris.Properties.Settings.Default.Quality;
            this.cbGraphics.SelectedIndexChanged += new System.EventHandler(this.CbGraphics_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стиль";
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.btInputKeyRotate);
            this.tpControl.Controls.Add(this.label6);
            this.tpControl.Controls.Add(this.label5);
            this.tpControl.Controls.Add(this.rbtArrow);
            this.tpControl.Controls.Add(this.rbtWASD);
            this.tpControl.Location = new System.Drawing.Point(4, 22);
            this.tpControl.Name = "tpControl";
            this.tpControl.Size = new System.Drawing.Size(216, 224);
            this.tpControl.TabIndex = 3;
            this.tpControl.Text = "Керування";
            this.tpControl.UseVisualStyleBackColor = true;
            // 
            // btInputKeyRotate
            // 
            this.btInputKeyRotate.Location = new System.Drawing.Point(18, 141);
            this.btInputKeyRotate.Name = "btInputKeyRotate";
            this.btInputKeyRotate.Size = new System.Drawing.Size(152, 33);
            this.btInputKeyRotate.TabIndex = 3;
            this.btInputKeyRotate.Text = "Обрати клавішу";
            this.btInputKeyRotate.UseVisualStyleBackColor = true;
            this.btInputKeyRotate.Click += new System.EventHandler(this.BtInputKeyRotate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Поворот фігури";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Переміщення фігур";
            // 
            // rbtArrow
            // 
            this.rbtArrow.AutoSize = true;
            this.rbtArrow.Checked = global::Tetris.Properties.Settings.Default.Arrow;
            this.rbtArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtArrow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tetris.Properties.Settings.Default, "Arrow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbtArrow.Location = new System.Drawing.Point(18, 47);
            this.rbtArrow.Name = "rbtArrow";
            this.rbtArrow.Size = new System.Drawing.Size(86, 24);
            this.rbtArrow.TabIndex = 0;
            this.rbtArrow.TabStop = true;
            this.rbtArrow.Text = "Стрілки";
            this.rbtArrow.UseVisualStyleBackColor = true;
            // 
            // rbtWASD
            // 
            this.rbtWASD.AutoSize = true;
            this.rbtWASD.Checked = global::Tetris.Properties.Settings.Default.WASD;
            this.rbtWASD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtWASD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tetris.Properties.Settings.Default, "WASD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbtWASD.Location = new System.Drawing.Point(18, 77);
            this.rbtWASD.Name = "rbtWASD";
            this.rbtWASD.Size = new System.Drawing.Size(76, 24);
            this.rbtWASD.TabIndex = 0;
            this.rbtWASD.TabStop = true;
            this.rbtWASD.Text = "WASD";
            this.rbtWASD.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::Tetris.Properties.Settings.Default.Background;
            this.CancelButton = this.btBack;
            this.ClientSize = new System.Drawing.Size(345, 338);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Tetris.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tetris | Налаштування";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpGame.ResumeLayout(false);
            this.tbGraphics.ResumeLayout(false);
            this.tbGraphics.PerformLayout();
            this.pGraphicsMedium.ResumeLayout(false);
            this.pGraphicsMedium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBackground)).EndInit();
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btReset;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ToolTip tltSettings;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGame;
        private System.Windows.Forms.CheckBox cbNextShape;
        private System.Windows.Forms.CheckBox cbShadow;
        private System.Windows.Forms.TabPage tbGraphics;
        private System.Windows.Forms.Panel pGraphicsMedium;
        private System.Windows.Forms.PictureBox pbColorField;
        private System.Windows.Forms.PictureBox pbColorBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbFullScreen;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpControl;
        private System.Windows.Forms.Button btInputKeyRotate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtArrow;
        private System.Windows.Forms.RadioButton rbtWASD;
    }
}