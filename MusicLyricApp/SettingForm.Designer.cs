﻿using System;
using System.ComponentModel;
using System.Linq;
using MusicLyricApp.Bean;
using MusicLyricApp.Utils;

namespace MusicLyricApp
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        private void AfterInitializeComponent()
        {
            // 歌词时间戳
            Dot_ComboBox.Items.AddRange(GlobalUtils.GetEnumDescArray<DotTypeEnum>());
            Dot_ComboBox.SelectedIndex = (int)_settingBean.Config.DotType;
            LrcTimestampFormat_TextBox.Text = _settingBean.Config.LrcTimestampFormat;
            SrtTimestampFormat_TextBox.Text = _settingBean.Config.SrtTimestampFormat;
            
            // 原文歌词
            IgnoreEmptyLyric_CheckBox.Checked = _settingBean.Config.IgnoreEmptyLyric;
            VerbatimLyric_CheckBox.Checked = _settingBean.Config.EnableVerbatimLyric;
            
            // 译文歌词
            TransLostRule_ComboBox.Items.AddRange(GlobalUtils.GetEnumDescArray<TransLyricLostRuleEnum>());
            TransLostRule_ComboBox.SelectedIndex = (int)_settingBean.Config.TransConfig.LostRule;
            TranslateMatchPrecisionDeviation_TextBox.Text = _settingBean.Config.TransConfig.MatchPrecisionDeviation.ToString();
            BaiduTranslateAppId_TextBox.Text = _settingBean.Config.TransConfig.BaiduTranslateAppId;
            BaiduTranslateSecret_TextBox.Text = _settingBean.Config.TransConfig.BaiduTranslateSecret;
            CaiYunTranslateToken_TextBox.Text = _settingBean.Config.TransConfig.CaiYunToken;
            RomajiMode_ComboBox.Items.AddRange(GlobalUtils.GetEnumDescArray<RomajiModeEnum>());
            RomajiMode_ComboBox.SelectedIndex = (int)_settingBean.Config.TransConfig.RomajiModeEnum;
            RomajiSystem_ComboBox.Items.AddRange(GlobalUtils.GetEnumDescArray<RomajiSystemEnum>()); 
            RomajiSystem_ComboBox.SelectedIndex = (int)_settingBean.Config.TransConfig.RomajiSystemEnum;

            var allTransType = GlobalUtils.GetEnumList<LyricsTypeEnum>();
            foreach (var index in _settingBean.Config.DeserializationOutputLyricsTypes())
            {
                var one = (LyricsTypeEnum) index;
                allTransType.Remove(one);

                LyricShow_DataGridView.Rows.Add(true, one.ToDescription());
            }
            foreach (var one in allTransType)
            {
                LyricShow_DataGridView.Rows.Add(false, one.ToDescription());
            }

            // 输出设置
            IgnorePureMusicInSave_CheckBox.Checked = _settingBean.Config.IgnorePureMusicInSave;
            SeparateFileForIsolated_CheckBox.Checked = _settingBean.Config.SeparateFileForIsolated;
            OutputName_TextBox.Text = _settingBean.Config.OutputFileNameFormat;
            
            // 应用设置
            RememberParam_CheckBox.Checked = _settingBean.Config.RememberParam;
            AggregatedBlurSearchCheckBox.Checked = _settingBean.Config.AggregatedBlurSearch;
            AutoReadClipboard_CheckBox.Checked = _settingBean.Config.AutoReadClipboard;
            AutoCheckUpdate_CheckBox.Checked = _settingBean.Config.AutoCheckUpdate;
            QQMusic_Cookie_TextBox.Text = _settingBean.Config.QQMusicCookie;
            NetEase_Cookie_TextBox.Text = _settingBean.Config.NetEaseCookie;
            
            // 提示区
            SettingTips_TextBox.Text = Constants.HelpTips.Prefix;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.Save_Btn = new System.Windows.Forms.Button();
            this.RememberParam_CheckBox = new System.Windows.Forms.CheckBox();
            this.AutoReadClipboard_CheckBox = new System.Windows.Forms.CheckBox();
            this.AutoCheckUpdate_CheckBox = new System.Windows.Forms.CheckBox();
            this.RomajiMode_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RomajiSystem_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LrcTimestampFormat_TextBox = new System.Windows.Forms.TextBox();
            this.SrtTimestampFormat_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dot_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransLostRule_ComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TranslateMatchPrecisionDeviation_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IgnoreEmptyLyric_CheckBox = new System.Windows.Forms.CheckBox();
            this.VerbatimLyric_CheckBox = new System.Windows.Forms.CheckBox();
            this.NetEase_Cookie_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QQMusic_Cookie_TextBox = new System.Windows.Forms.TextBox();
            this.Timestamp_GroupBox = new System.Windows.Forms.GroupBox();
            this.TimestampHelp_Btn = new System.Windows.Forms.Button();
            this.SettingTips_TextBox = new System.Windows.Forms.TextBox();
            this.OutputHelp_Btn = new System.Windows.Forms.Button();
            this.AppConfig_GroupBox = new System.Windows.Forms.GroupBox();
            this.AggregatedBlurSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginLyric_GroupBox = new System.Windows.Forms.GroupBox();
            this.TransLyric_GroupBox = new System.Windows.Forms.GroupBox();
            this.TransConfig_TabControl = new System.Windows.Forms.TabControl();
            this.Romaji_TabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.TranslateApi_TabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BaiduTranslate_TabPage = new System.Windows.Forms.TabPage();
            this.BaiduTranslateSecret_TextBox = new System.Windows.Forms.TextBox();
            this.BaiduTranslateAppId_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CaiYunTranslate_TabPage = new System.Windows.Forms.TabPage();
            this.CaiYunTranslateToken_TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LyricShow_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output_GroupBox = new System.Windows.Forms.GroupBox();
            this.SeparateFileForIsolated_CheckBox = new System.Windows.Forms.CheckBox();
            this.OutputName_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IgnorePureMusicInSave_CheckBox = new System.Windows.Forms.CheckBox();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.Timestamp_GroupBox.SuspendLayout();
            this.AppConfig_GroupBox.SuspendLayout();
            this.OriginLyric_GroupBox.SuspendLayout();
            this.TransLyric_GroupBox.SuspendLayout();
            this.TransConfig_TabControl.SuspendLayout();
            this.Romaji_TabPage.SuspendLayout();
            this.TranslateApi_TabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BaiduTranslate_TabPage.SuspendLayout();
            this.CaiYunTranslate_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LyricShow_DataGridView)).BeginInit();
            this.Output_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.Color.Honeydew;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Location = new System.Drawing.Point(613, 639);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(97, 50);
            this.Save_Btn.TabIndex = 0;
            this.Save_Btn.Text = "保存";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // RememberParam_CheckBox
            // 
            this.RememberParam_CheckBox.Location = new System.Drawing.Point(6, 37);
            this.RememberParam_CheckBox.Name = "RememberParam_CheckBox";
            this.RememberParam_CheckBox.Size = new System.Drawing.Size(78, 17);
            this.RememberParam_CheckBox.TabIndex = 1;
            this.RememberParam_CheckBox.Text = "参数记忆";
            this.RememberParam_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoReadClipboard_CheckBox
            // 
            this.AutoReadClipboard_CheckBox.Location = new System.Drawing.Point(207, 37);
            this.AutoReadClipboard_CheckBox.Name = "AutoReadClipboard_CheckBox";
            this.AutoReadClipboard_CheckBox.Size = new System.Drawing.Size(112, 17);
            this.AutoReadClipboard_CheckBox.TabIndex = 2;
            this.AutoReadClipboard_CheckBox.Text = "自动读取剪贴板";
            this.AutoReadClipboard_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoCheckUpdate_CheckBox
            // 
            this.AutoCheckUpdate_CheckBox.Location = new System.Drawing.Point(336, 37);
            this.AutoCheckUpdate_CheckBox.Name = "AutoCheckUpdate_CheckBox";
            this.AutoCheckUpdate_CheckBox.Size = new System.Drawing.Size(98, 17);
            this.AutoCheckUpdate_CheckBox.TabIndex = 3;
            this.AutoCheckUpdate_CheckBox.Text = "自动检查更新";
            this.AutoCheckUpdate_CheckBox.UseVisualStyleBackColor = true;
            // 
            // RomajiMode_ComboBox
            // 
            this.RomajiMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RomajiMode_ComboBox.FormattingEnabled = true;
            this.RomajiMode_ComboBox.Location = new System.Drawing.Point(112, 58);
            this.RomajiMode_ComboBox.Name = "RomajiMode_ComboBox";
            this.RomajiMode_ComboBox.Size = new System.Drawing.Size(100, 20);
            this.RomajiMode_ComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "罗马音转换模式";
            // 
            // RomajiSystem_ComboBox
            // 
            this.RomajiSystem_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RomajiSystem_ComboBox.FormattingEnabled = true;
            this.RomajiSystem_ComboBox.Location = new System.Drawing.Point(112, 21);
            this.RomajiSystem_ComboBox.Name = "RomajiSystem_ComboBox";
            this.RomajiSystem_ComboBox.Size = new System.Drawing.Size(100, 20);
            this.RomajiSystem_ComboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "LRC 时间戳";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "SRT 时间戳";
            // 
            // LrcTimestampFormat_TextBox
            // 
            this.LrcTimestampFormat_TextBox.Location = new System.Drawing.Point(103, 33);
            this.LrcTimestampFormat_TextBox.Name = "LrcTimestampFormat_TextBox";
            this.LrcTimestampFormat_TextBox.Size = new System.Drawing.Size(100, 21);
            this.LrcTimestampFormat_TextBox.TabIndex = 15;
            // 
            // SrtTimestampFormat_TextBox
            // 
            this.SrtTimestampFormat_TextBox.Location = new System.Drawing.Point(103, 72);
            this.SrtTimestampFormat_TextBox.Name = "SrtTimestampFormat_TextBox";
            this.SrtTimestampFormat_TextBox.Size = new System.Drawing.Size(100, 21);
            this.SrtTimestampFormat_TextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "毫秒截位规则";
            // 
            // Dot_ComboBox
            // 
            this.Dot_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dot_ComboBox.FormattingEnabled = true;
            this.Dot_ComboBox.Location = new System.Drawing.Point(103, 112);
            this.Dot_ComboBox.Name = "Dot_ComboBox";
            this.Dot_ComboBox.Size = new System.Drawing.Size(100, 20);
            this.Dot_ComboBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "译文缺省规则";
            // 
            // TransLostRule_ComboBox
            // 
            this.TransLostRule_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransLostRule_ComboBox.FormattingEnabled = true;
            this.TransLostRule_ComboBox.Location = new System.Drawing.Point(115, 33);
            this.TransLostRule_ComboBox.Name = "TransLostRule_ComboBox";
            this.TransLostRule_ComboBox.Size = new System.Drawing.Size(98, 20);
            this.TransLostRule_ComboBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "译文匹配精度";
            // 
            // TranslateMatchPrecisionDeviation_TextBox
            // 
            this.TranslateMatchPrecisionDeviation_TextBox.Location = new System.Drawing.Point(115, 71);
            this.TranslateMatchPrecisionDeviation_TextBox.Name = "TranslateMatchPrecisionDeviation_TextBox";
            this.TranslateMatchPrecisionDeviation_TextBox.Size = new System.Drawing.Size(73, 21);
            this.TranslateMatchPrecisionDeviation_TextBox.TabIndex = 22;
            this.TranslateMatchPrecisionDeviation_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LrcMatchDigit_TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(194, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "MS";
            // 
            // IgnoreEmptyLyric_CheckBox
            // 
            this.IgnoreEmptyLyric_CheckBox.Location = new System.Drawing.Point(6, 35);
            this.IgnoreEmptyLyric_CheckBox.Name = "IgnoreEmptyLyric_CheckBox";
            this.IgnoreEmptyLyric_CheckBox.Size = new System.Drawing.Size(110, 17);
            this.IgnoreEmptyLyric_CheckBox.TabIndex = 24;
            this.IgnoreEmptyLyric_CheckBox.Text = "跳过空白歌词行";
            this.IgnoreEmptyLyric_CheckBox.UseVisualStyleBackColor = true;
            // 
            // VerbatimLyric_CheckBox
            // 
            this.VerbatimLyric_CheckBox.Location = new System.Drawing.Point(6, 73);
            this.VerbatimLyric_CheckBox.Name = "VerbatimLyric_CheckBox";
            this.VerbatimLyric_CheckBox.Size = new System.Drawing.Size(110, 17);
            this.VerbatimLyric_CheckBox.TabIndex = 25;
            this.VerbatimLyric_CheckBox.Text = "QQ音乐逐字歌词";
            this.VerbatimLyric_CheckBox.UseVisualStyleBackColor = true;
            this.VerbatimLyric_CheckBox.CheckedChanged += new System.EventHandler(this.VerbatimLyric_CheckBox_CheckedChanged);
            // 
            // NetEase_Cookie_TextBox
            // 
            this.NetEase_Cookie_TextBox.Location = new System.Drawing.Point(105, 75);
            this.NetEase_Cookie_TextBox.Name = "NetEase_Cookie_TextBox";
            this.NetEase_Cookie_TextBox.Size = new System.Drawing.Size(323, 21);
            this.NetEase_Cookie_TextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "网易云Cookie";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "QQ音乐Cookie";
            // 
            // QQMusic_Cookie_TextBox
            // 
            this.QQMusic_Cookie_TextBox.Location = new System.Drawing.Point(105, 122);
            this.QQMusic_Cookie_TextBox.Name = "QQMusic_Cookie_TextBox";
            this.QQMusic_Cookie_TextBox.Size = new System.Drawing.Size(323, 21);
            this.QQMusic_Cookie_TextBox.TabIndex = 29;
            // 
            // Timestamp_GroupBox
            // 
            this.Timestamp_GroupBox.Controls.Add(this.Dot_ComboBox);
            this.Timestamp_GroupBox.Controls.Add(this.LrcTimestampFormat_TextBox);
            this.Timestamp_GroupBox.Controls.Add(this.label8);
            this.Timestamp_GroupBox.Controls.Add(this.label6);
            this.Timestamp_GroupBox.Controls.Add(this.SrtTimestampFormat_TextBox);
            this.Timestamp_GroupBox.Controls.Add(this.label7);
            this.Timestamp_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Timestamp_GroupBox.Name = "Timestamp_GroupBox";
            this.Timestamp_GroupBox.Size = new System.Drawing.Size(227, 155);
            this.Timestamp_GroupBox.TabIndex = 30;
            this.Timestamp_GroupBox.TabStop = false;
            this.Timestamp_GroupBox.Text = "歌词时间戳";
            // 
            // TimestampHelp_Btn
            // 
            this.TimestampHelp_Btn.ForeColor = System.Drawing.Color.Red;
            this.TimestampHelp_Btn.Location = new System.Drawing.Point(212, 12);
            this.TimestampHelp_Btn.Name = "TimestampHelp_Btn";
            this.TimestampHelp_Btn.Size = new System.Drawing.Size(21, 21);
            this.TimestampHelp_Btn.TabIndex = 19;
            this.TimestampHelp_Btn.Text = "?";
            this.TimestampHelp_Btn.UseVisualStyleBackColor = true;
            this.TimestampHelp_Btn.Click += new System.EventHandler(this.Help_Btn_Click);
            // 
            // SettingTips_TextBox
            // 
            this.SettingTips_TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SettingTips_TextBox.Location = new System.Drawing.Point(483, 183);
            this.SettingTips_TextBox.Multiline = true;
            this.SettingTips_TextBox.Name = "SettingTips_TextBox";
            this.SettingTips_TextBox.ReadOnly = true;
            this.SettingTips_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SettingTips_TextBox.Size = new System.Drawing.Size(227, 437);
            this.SettingTips_TextBox.TabIndex = 31;
            // 
            // OutputHelp_Btn
            // 
            this.OutputHelp_Btn.ForeColor = System.Drawing.Color.Red;
            this.OutputHelp_Btn.Location = new System.Drawing.Point(425, 0);
            this.OutputHelp_Btn.Name = "OutputHelp_Btn";
            this.OutputHelp_Btn.Size = new System.Drawing.Size(21, 21);
            this.OutputHelp_Btn.TabIndex = 20;
            this.OutputHelp_Btn.Text = "?";
            this.OutputHelp_Btn.UseVisualStyleBackColor = true;
            this.OutputHelp_Btn.Click += new System.EventHandler(this.Help_Btn_Click);
            // 
            // AppConfig_GroupBox
            // 
            this.AppConfig_GroupBox.Controls.Add(this.AggregatedBlurSearchCheckBox);
            this.AppConfig_GroupBox.Controls.Add(this.AutoCheckUpdate_CheckBox);
            this.AppConfig_GroupBox.Controls.Add(this.AutoReadClipboard_CheckBox);
            this.AppConfig_GroupBox.Controls.Add(this.RememberParam_CheckBox);
            this.AppConfig_GroupBox.Controls.Add(this.NetEase_Cookie_TextBox);
            this.AppConfig_GroupBox.Controls.Add(this.label2);
            this.AppConfig_GroupBox.Controls.Add(this.QQMusic_Cookie_TextBox);
            this.AppConfig_GroupBox.Controls.Add(this.label4);
            this.AppConfig_GroupBox.Location = new System.Drawing.Point(12, 183);
            this.AppConfig_GroupBox.Name = "AppConfig_GroupBox";
            this.AppConfig_GroupBox.Size = new System.Drawing.Size(452, 164);
            this.AppConfig_GroupBox.TabIndex = 32;
            this.AppConfig_GroupBox.TabStop = false;
            this.AppConfig_GroupBox.Text = "应用设置";
            // 
            // AggregatedBlurSearchCheckBox
            // 
            this.AggregatedBlurSearchCheckBox.Location = new System.Drawing.Point(103, 37);
            this.AggregatedBlurSearchCheckBox.Name = "AggregatedBlurSearchCheckBox";
            this.AggregatedBlurSearchCheckBox.Size = new System.Drawing.Size(98, 17);
            this.AggregatedBlurSearchCheckBox.TabIndex = 30;
            this.AggregatedBlurSearchCheckBox.Text = "聚合模糊搜索";
            this.AggregatedBlurSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // OriginLyric_GroupBox
            // 
            this.OriginLyric_GroupBox.Controls.Add(this.IgnoreEmptyLyric_CheckBox);
            this.OriginLyric_GroupBox.Controls.Add(this.VerbatimLyric_CheckBox);
            this.OriginLyric_GroupBox.Location = new System.Drawing.Point(254, 12);
            this.OriginLyric_GroupBox.Name = "OriginLyric_GroupBox";
            this.OriginLyric_GroupBox.Size = new System.Drawing.Size(210, 155);
            this.OriginLyric_GroupBox.TabIndex = 33;
            this.OriginLyric_GroupBox.TabStop = false;
            this.OriginLyric_GroupBox.Text = "原文歌词";
            // 
            // TransLyric_GroupBox
            // 
            this.TransLyric_GroupBox.Controls.Add(this.TransLostRule_ComboBox);
            this.TransLyric_GroupBox.Controls.Add(this.label1);
            this.TransLyric_GroupBox.Controls.Add(this.TranslateMatchPrecisionDeviation_TextBox);
            this.TransLyric_GroupBox.Controls.Add(this.label9);
            this.TransLyric_GroupBox.Controls.Add(this.label5);
            this.TransLyric_GroupBox.Location = new System.Drawing.Point(483, 12);
            this.TransLyric_GroupBox.Name = "TransLyric_GroupBox";
            this.TransLyric_GroupBox.Size = new System.Drawing.Size(227, 155);
            this.TransLyric_GroupBox.TabIndex = 34;
            this.TransLyric_GroupBox.TabStop = false;
            this.TransLyric_GroupBox.Text = "译文歌词";
            // 
            // TransConfig_TabControl
            // 
            this.TransConfig_TabControl.Controls.Add(this.Romaji_TabPage);
            this.TransConfig_TabControl.Controls.Add(this.TranslateApi_TabPage);
            this.TransConfig_TabControl.Location = new System.Drawing.Point(12, 163);
            this.TransConfig_TabControl.Name = "TransConfig_TabControl";
            this.TransConfig_TabControl.SelectedIndex = 0;
            this.TransConfig_TabControl.Size = new System.Drawing.Size(422, 150);
            this.TransConfig_TabControl.TabIndex = 0;
            // 
            // Romaji_TabPage
            // 
            this.Romaji_TabPage.Controls.Add(this.RomajiSystem_ComboBox);
            this.Romaji_TabPage.Controls.Add(this.label3);
            this.Romaji_TabPage.Controls.Add(this.label11);
            this.Romaji_TabPage.Controls.Add(this.RomajiMode_ComboBox);
            this.Romaji_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Romaji_TabPage.Name = "Romaji_TabPage";
            this.Romaji_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Romaji_TabPage.Size = new System.Drawing.Size(414, 124);
            this.Romaji_TabPage.TabIndex = 0;
            this.Romaji_TabPage.Text = "罗马音";
            this.Romaji_TabPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "罗马音系统";
            // 
            // TranslateApi_TabPage
            // 
            this.TranslateApi_TabPage.Controls.Add(this.tabControl1);
            this.TranslateApi_TabPage.Location = new System.Drawing.Point(4, 22);
            this.TranslateApi_TabPage.Name = "TranslateApi_TabPage";
            this.TranslateApi_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TranslateApi_TabPage.Size = new System.Drawing.Size(414, 124);
            this.TranslateApi_TabPage.TabIndex = 1;
            this.TranslateApi_TabPage.Text = "翻译 API";
            this.TranslateApi_TabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BaiduTranslate_TabPage);
            this.tabControl1.Controls.Add(this.CaiYunTranslate_TabPage);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 110);
            this.tabControl1.TabIndex = 37;
            // 
            // BaiduTranslate_TabPage
            // 
            this.BaiduTranslate_TabPage.Controls.Add(this.BaiduTranslateSecret_TextBox);
            this.BaiduTranslate_TabPage.Controls.Add(this.BaiduTranslateAppId_TextBox);
            this.BaiduTranslate_TabPage.Controls.Add(this.label13);
            this.BaiduTranslate_TabPage.Controls.Add(this.label12);
            this.BaiduTranslate_TabPage.Location = new System.Drawing.Point(4, 22);
            this.BaiduTranslate_TabPage.Name = "BaiduTranslate_TabPage";
            this.BaiduTranslate_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BaiduTranslate_TabPage.Size = new System.Drawing.Size(386, 84);
            this.BaiduTranslate_TabPage.TabIndex = 0;
            this.BaiduTranslate_TabPage.Text = "百度翻译";
            this.BaiduTranslate_TabPage.UseVisualStyleBackColor = true;
            // 
            // BaiduTranslateSecret_TextBox
            // 
            this.BaiduTranslateSecret_TextBox.Location = new System.Drawing.Point(81, 52);
            this.BaiduTranslateSecret_TextBox.Name = "BaiduTranslateSecret_TextBox";
            this.BaiduTranslateSecret_TextBox.Size = new System.Drawing.Size(285, 21);
            this.BaiduTranslateSecret_TextBox.TabIndex = 40;
            // 
            // BaiduTranslateAppId_TextBox
            // 
            this.BaiduTranslateAppId_TextBox.Location = new System.Drawing.Point(81, 14);
            this.BaiduTranslateAppId_TextBox.Name = "BaiduTranslateAppId_TextBox";
            this.BaiduTranslateAppId_TextBox.Size = new System.Drawing.Size(285, 21);
            this.BaiduTranslateAppId_TextBox.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(18, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "密钥";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(18, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "APP ID";
            // 
            // CaiYunTranslate_TabPage
            // 
            this.CaiYunTranslate_TabPage.Controls.Add(this.CaiYunTranslateToken_TextBox);
            this.CaiYunTranslate_TabPage.Controls.Add(this.label14);
            this.CaiYunTranslate_TabPage.Location = new System.Drawing.Point(4, 22);
            this.CaiYunTranslate_TabPage.Name = "CaiYunTranslate_TabPage";
            this.CaiYunTranslate_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CaiYunTranslate_TabPage.Size = new System.Drawing.Size(386, 84);
            this.CaiYunTranslate_TabPage.TabIndex = 2;
            this.CaiYunTranslate_TabPage.Text = "彩云小译";
            this.CaiYunTranslate_TabPage.UseVisualStyleBackColor = true;
            // 
            // CaiYunTranslateToken_TextBox
            // 
            this.CaiYunTranslateToken_TextBox.Location = new System.Drawing.Point(75, 14);
            this.CaiYunTranslateToken_TextBox.Name = "CaiYunTranslateToken_TextBox";
            this.CaiYunTranslateToken_TextBox.Size = new System.Drawing.Size(285, 21);
            this.CaiYunTranslateToken_TextBox.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 12);
            this.label14.TabIndex = 41;
            this.label14.Text = "Token";
            // 
            // LyricShow_DataGridView
            // 
            this.LyricShow_DataGridView.AllowDrop = true;
            this.LyricShow_DataGridView.AllowUserToAddRows = false;
            this.LyricShow_DataGridView.AllowUserToDeleteRows = false;
            this.LyricShow_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LyricShow_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LyricShow_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2 });
            this.LyricShow_DataGridView.Location = new System.Drawing.Point(12, 23);
            this.LyricShow_DataGridView.Name = "LyricShow_DataGridView";
            this.LyricShow_DataGridView.RowTemplate.Height = 23;
            this.LyricShow_DataGridView.Size = new System.Drawing.Size(203, 123);
            this.LyricShow_DataGridView.TabIndex = 37;
            this.LyricShow_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransType_DataGridView_CellContentClick);
            this.LyricShow_DataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TransList_DataGridView_CellMouseMove);
            this.LyricShow_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransType_DataGridView_CellValueChanged);
            this.LyricShow_DataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TransList_DataGridView_RowsAdded);
            this.LyricShow_DataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TransList_DataGridView_DragDrop);
            this.LyricShow_DataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TransList_DataGridView_DragEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "是否启用";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "歌词类型";
            this.Column2.Name = "Column2";
            // 
            // Output_GroupBox
            // 
            this.Output_GroupBox.Controls.Add(this.SeparateFileForIsolated_CheckBox);
            this.Output_GroupBox.Controls.Add(this.OutputName_TextBox);
            this.Output_GroupBox.Controls.Add(this.label10);
            this.Output_GroupBox.Controls.Add(this.IgnorePureMusicInSave_CheckBox);
            this.Output_GroupBox.Controls.Add(this.OutputHelp_Btn);
            this.Output_GroupBox.Controls.Add(this.LyricShow_DataGridView);
            this.Output_GroupBox.Controls.Add(this.TransConfig_TabControl);
            this.Output_GroupBox.Location = new System.Drawing.Point(12, 362);
            this.Output_GroupBox.Name = "Output_GroupBox";
            this.Output_GroupBox.Size = new System.Drawing.Size(452, 327);
            this.Output_GroupBox.TabIndex = 35;
            this.Output_GroupBox.TabStop = false;
            this.Output_GroupBox.Text = "输出设置";
            // 
            // SeparateFileForIsolated_CheckBox
            // 
            this.SeparateFileForIsolated_CheckBox.Location = new System.Drawing.Point(226, 61);
            this.SeparateFileForIsolated_CheckBox.Name = "SeparateFileForIsolated_CheckBox";
            this.SeparateFileForIsolated_CheckBox.Size = new System.Drawing.Size(202, 17);
            this.SeparateFileForIsolated_CheckBox.TabIndex = 39;
            this.SeparateFileForIsolated_CheckBox.Text = "“独立”歌词格式分文件保存";
            this.SeparateFileForIsolated_CheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputName_TextBox
            // 
            this.OutputName_TextBox.Location = new System.Drawing.Point(222, 125);
            this.OutputName_TextBox.Name = "OutputName_TextBox";
            this.OutputName_TextBox.Size = new System.Drawing.Size(208, 21);
            this.OutputName_TextBox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(222, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "保存文件名";
            // 
            // IgnorePureMusicInSave_CheckBox
            // 
            this.IgnorePureMusicInSave_CheckBox.Location = new System.Drawing.Point(226, 23);
            this.IgnorePureMusicInSave_CheckBox.Name = "IgnorePureMusicInSave_CheckBox";
            this.IgnorePureMusicInSave_CheckBox.Size = new System.Drawing.Size(93, 17);
            this.IgnorePureMusicInSave_CheckBox.TabIndex = 36;
            this.IgnorePureMusicInSave_CheckBox.Text = "跳过纯音乐";
            this.IgnorePureMusicInSave_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.OldLace;
            this.Reset_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Btn.Location = new System.Drawing.Point(483, 639);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(97, 50);
            this.Reset_Btn.TabIndex = 36;
            this.Reset_Btn.Text = "重置";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 701);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.Output_GroupBox);
            this.Controls.Add(this.TransLyric_GroupBox);
            this.Controls.Add(this.OriginLyric_GroupBox);
            this.Controls.Add(this.AppConfig_GroupBox);
            this.Controls.Add(this.TimestampHelp_Btn);
            this.Controls.Add(this.SettingTips_TextBox);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Timestamp_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "设置";
            this.Timestamp_GroupBox.ResumeLayout(false);
            this.Timestamp_GroupBox.PerformLayout();
            this.AppConfig_GroupBox.ResumeLayout(false);
            this.AppConfig_GroupBox.PerformLayout();
            this.OriginLyric_GroupBox.ResumeLayout(false);
            this.TransLyric_GroupBox.ResumeLayout(false);
            this.TransLyric_GroupBox.PerformLayout();
            this.TransConfig_TabControl.ResumeLayout(false);
            this.Romaji_TabPage.ResumeLayout(false);
            this.TranslateApi_TabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.BaiduTranslate_TabPage.ResumeLayout(false);
            this.BaiduTranslate_TabPage.PerformLayout();
            this.CaiYunTranslate_TabPage.ResumeLayout(false);
            this.CaiYunTranslate_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LyricShow_DataGridView)).EndInit();
            this.Output_GroupBox.ResumeLayout(false);
            this.Output_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox SeparateFileForIsolated_CheckBox;

        private System.Windows.Forms.CheckBox AggregatedBlurSearchCheckBox;

        private System.Windows.Forms.TextBox BaiduTranslateAppId_TextBox;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.TextBox CaiYunTranslateToken_TextBox;
        private System.Windows.Forms.TextBox BaiduTranslateSecret_TextBox;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TabPage CaiYunTranslate_TabPage;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BaiduTranslate_TabPage;

        private System.Windows.Forms.TabControl TransConfig_TabControl;
        private System.Windows.Forms.TabPage Romaji_TabPage;
        private System.Windows.Forms.TabPage TranslateApi_TabPage;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

        private System.Windows.Forms.DataGridView LyricShow_DataGridView;

        private System.Windows.Forms.Button Reset_Btn;

        private System.Windows.Forms.TextBox OutputName_TextBox;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.GroupBox Output_GroupBox;
        private System.Windows.Forms.CheckBox IgnorePureMusicInSave_CheckBox;

        private System.Windows.Forms.GroupBox TransLyric_GroupBox;

        private System.Windows.Forms.GroupBox OriginLyric_GroupBox;

        private System.Windows.Forms.GroupBox AppConfig_GroupBox;

        private System.Windows.Forms.Button OutputHelp_Btn;

        private System.Windows.Forms.Button TimestampHelp_Btn;

        private System.Windows.Forms.GroupBox Timestamp_GroupBox;
        private System.Windows.Forms.TextBox SettingTips_TextBox;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QQMusic_Cookie_TextBox;

        private System.Windows.Forms.TextBox NetEase_Cookie_TextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox VerbatimLyric_CheckBox;

        private System.Windows.Forms.CheckBox IgnoreEmptyLyric_CheckBox;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TranslateMatchPrecisionDeviation_TextBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TransLostRule_ComboBox;

        private System.Windows.Forms.ComboBox RomajiSystem_ComboBox;

        private System.Windows.Forms.ComboBox RomajiMode_ComboBox;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.CheckBox AutoCheckUpdate_CheckBox;

        private System.Windows.Forms.CheckBox AutoReadClipboard_CheckBox;

        private System.Windows.Forms.CheckBox RememberParam_CheckBox;

        private System.Windows.Forms.Button Save_Btn;

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LrcTimestampFormat_TextBox;
        private System.Windows.Forms.TextBox SrtTimestampFormat_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Dot_ComboBox;
    }
}