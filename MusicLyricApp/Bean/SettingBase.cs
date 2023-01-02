﻿
namespace MusicLyricApp.Bean
{
    public class SettingBean
    {
        public ConfigBean Config = new ConfigBean();

        public PersistParamBean Param = new PersistParamBean();
    }

    public class ConfigBean
    {
        /// <summary>
        /// 参数记忆
        /// </summary>
        public bool RememberParam = false;

        /// <summary>
        /// 自读读取剪切板
        /// </summary>
        public bool AutoReadClipboard = false;

        /// <summary>
        /// 自动检查更新
        /// </summary>
        public bool AutoCheckUpdate = true;

        /// <summary>
        /// 保存时跳过纯音乐
        /// </summary>
        public bool IgnorePureMusicInSave = true;

        /// <summary>
        /// 输出文件名格式
        /// </summary>
        public string OutputFileNameFormat = "${name} - ${singer}";

        /// <summary>
        /// QQ 音乐 Cookie
        /// </summary>
        public string QQMusicCookie = "";

        /// <summary>
        /// 网易云音乐 Cookie
        /// </summary>
        public string NetEaseCookie = "";

        public TransConfigBean TransConfig = new TransConfigBean();
    }

    public class TransConfigBean
    {
        /// <summary>
        /// 译文缺省规则
        /// </summary>
        public TransLyricLostRuleEnum LostRule = TransLyricLostRuleEnum.IGNORE;
        
        /// <summary>
        /// 译文歌词匹配精度
        /// </summary>
        public int MatchPrecisionDeviation = 0;
        
        /// <summary>
        /// 译文类型
        /// </summary>
        public string TransType = "0";
        
        /// <summary>
        /// 罗马音转换模式
        /// </summary>
        public RomajiModeEnum RomajiModeEnum = RomajiModeEnum.SPACED;

        /// <summary>
        /// 罗马音字体系
        /// </summary>
        public RomajiSystemEnum RomajiSystemEnum = RomajiSystemEnum.HEPBURN;

        /// <summary>
        /// 百度翻译 APP ID
        /// </summary>
        public string BaiduTranslateAppId = "";
        
        /// <summary>
        /// 百度翻译密钥
        /// </summary>
        public string BaiduTranslateSecret = "";

        /// <summary>
        /// 彩云小译 Token
        /// </summary>
        public string CaiYunToken = "";
    }

    public class PersistParamBean
    {
        /// <summary>
        /// 搜索来源
        /// </summary>
        public SearchSourceEnum SearchSource = SearchSourceEnum.NET_EASE_MUSIC;

        /// <summary>
        /// 搜索类型
        /// </summary>
        public SearchTypeEnum SearchType = SearchTypeEnum.SONG_ID;

        /// <summary>
        /// 歌词展示格式
        /// </summary>
        public ShowLrcTypeEnum ShowLrcType = ShowLrcTypeEnum.ONLY_ORIGIN;
        
        /// <summary>
        /// 指定歌词合并的分隔符
        /// </summary>
        public string LrcMergeSeparator = string.Empty;
        
        /// <summary>
        /// LRC 歌词时间戳格式
        /// </summary>
        public string LrcTimestampFormat = "[mm:ss.SSS]";

        /// <summary>
        /// SRT 歌词时间戳格式
        /// </summary>
        public string SrtTimestampFormat = "HH:mm:ss,SSS";
        
        /// <summary>
        /// 启用逐字歌词模式
        /// </summary>
        public bool EnableVerbatimLyric = false;

        /// <summary>
        /// 忽略空的歌词行
        /// </summary>
        public bool IgnoreEmptyLyric = true;

        /// <summary>
        /// 小数位处理策略
        /// </summary>
        public DotTypeEnum DotType = DotTypeEnum.DOWN;

        /// <summary>
        /// 输出文件格式
        /// </summary>
        public OutputFormatEnum OutputFileFormat = OutputFormatEnum.LRC;

        /// <summary>
        /// 输出文件编码
        /// </summary>
        public OutputEncodingEnum Encoding = OutputEncodingEnum.UTF_8;
    }
}