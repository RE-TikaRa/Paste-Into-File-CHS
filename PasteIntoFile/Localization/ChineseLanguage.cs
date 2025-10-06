using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsFile.Localization
{
    /// <summary>
    /// Chinese (Simplified) language resource implementation
    /// </summary>
    public class ChineseLanguage : ILanguage
    {
        public string FormTitle => "粘贴到文件";
        public string Filename => "文件名 :";
        public string Extension => "扩展名 :";
        public string CurrentLocation => "当前位置 :";
        public string SaveButton => "保存";
        public string TypeLabel => "类型";
        
        public string TextFile => "文本文件";
        public string Image => "图片";
        public string UnknownFile => "未知文件";
        
        public string FileSaved => " : 文件已保存 :)";
        public string ImageSaved => " : 图片已保存 :)";
        
        public string FirstTimeMessage => 
            "看起来您是第一次运行此应用程序,\n" +
            "是否要将其注册到系统右键菜单?";
        public string FirstTimeTitle => "粘贴到文件";
        
        public string RegisteredMessage => "应用程序已成功注册到系统";
        public string RegisteredTitle => "粘贴到文件";
        
        public string UnregisteredMessage => "应用程序已从系统中注销";
        public string UnregisteredTitle => "粘贴到文件";
        
        public string FilenameRegisteredMessage => "文件名格式已成功注册到系统";
        public string FilenameRegisteredTitle => "粘贴到文件";
        
        public string ErrorAdminRequired => "\n请以管理员身份运行应用程序!";
        public string ErrorTitle => "粘贴到文件";
        
        public string FolderBrowserDescription => "选择保存文件的文件夹 ";
        
        public string HelpMessage => 
            "粘贴到文件可以帮助您将系统剪贴板中的任何文本或图片直接粘贴到文件中,而无需手动创建新文件" +
            "\n--------------------\n" +
            "要将应用程序注册到系统右键菜单,请以管理员身份运行程序并使用此参数: /reg" +
            "\n要注销应用程序,请使用此参数: /unreg\n" +
            "\n要更改默认文件名格式,请使用此参数: /filename yyyy-MM-dd_HHmm\n" +
            "\n要更改语言,请使用此参数: /language [en|zh]\n" +
            "\n--------------------\n" +
            "发送反馈至: eslamx7@gmail.com\n\n谢谢 :)";
        public string HelpTitle => "粘贴到文件帮助";
        
        public string Copyright => "© Eslam Hamouda 2014";
        public string Website => "eslamx.com";
        
        // Settings form
        public string SettingsTitle => "设置";
        public string LanguageGroup => "语言";
        public string SelectLanguage => "选择语言 :";
        public string FilenameGroup => "文件名格式";
        public string FilenameFormat => "格式 (yyyy年MM月dd日) :";
        public string FilenamePreview => "预览效果 :";
        public string InvalidFormat => "格式无效";
        public string ContextMenuGroup => "右键菜单";
        public string RegisterButton => "注册";
        public string UnregisterButton => "注销";
        public string RegistrationStatusRegistered => "✓ 已注册到右键菜单";
        public string RegistrationStatusNotRegistered => "✗ 未注册";
        public string SettingsSaved => "设置保存成功!";
        public string CancelButton => "取消";
        public string SettingsMenuItem => "设置...";
    }
}
