using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsFile.Localization
{
    /// <summary>
    /// English language resource implementation
    /// </summary>
    public class EnglishLanguage : ILanguage
    {
        public string FormTitle => "Paste Into File";
        public string Filename => "Filename :";
        public string Extension => "Extension :";
        public string CurrentLocation => "Current Location :";
        public string SaveButton => "Save";
        public string TypeLabel => "Type";
        
        public string TextFile => "Text File";
        public string Image => "Image";
        public string UnknownFile => "Unknown File";
        
        public string FileSaved => " : File Saved :)";
        public string ImageSaved => " : Image Saved :)";
        
        public string FirstTimeMessage => 
            "Seems that you are running this application for the first time,\n" +
            "Do you want to Register it with your system Context Menu ?";
        public string FirstTimeTitle => "Paste Into File";
        
        public string RegisteredMessage => "Application has been registered with your system";
        public string RegisteredTitle => "Paste Into File";
        
        public string UnregisteredMessage => "Application has been Unregistered from your system";
        public string UnregisteredTitle => "Paste Into File";
        
        public string FilenameRegisteredMessage => "Filename has been registered with your system";
        public string FilenameRegisteredTitle => "Paste Into File";
        
        public string ErrorAdminRequired => "\nPlease run the application as Administrator !";
        public string ErrorTitle => "Paste Into File";
        
        public string FolderBrowserDescription => "Select a folder for saving this file ";
        
        public string HelpMessage => 
            "Paste Into File helps you paste any text or images in your system clipboard into a file directly instead of creating new file yourself" +
            "\n--------------------\n" +
            "To Register the application to your system Context Menu run the program as Administrator with this argument : /reg" +
            "\nto Unregister the application use this argument : /unreg\n" +
            "\nTo change the format of the default filename, use this argument: /filename yyyy-MM-dd_HHmm\n" +
            "\nTo change the language, use this argument: /language [en|zh]\n" +
            "\n--------------------\n" +
            "Send Feedback to : eslamx7@gmail.com\n\nThanks :)";
        public string HelpTitle => "Paste Into File Help";
        
        public string Copyright => "© Eslam Hamouda 2014";
        public string Website => "eslamx.com";
        
        // Settings form
        public string SettingsTitle => "Settings";
        public string LanguageGroup => "Language";
        public string SelectLanguage => "Select Language :";
        public string FilenameGroup => "Filename Format";
        public string FilenameFormat => "Format (yyyy-MM-dd HH.mm.ss) :";
        public string FilenamePreview => "Preview :";
        public string InvalidFormat => "Invalid format";
        public string ContextMenuGroup => "Context Menu";
        public string RegisterButton => "Register";
        public string UnregisterButton => "Unregister";
        public string RegistrationStatusRegistered => "✓ Registered to context menu";
        public string RegistrationStatusNotRegistered => "✗ Not registered";
        public string SettingsSaved => "Settings saved successfully!";
        public string CancelButton => "Cancel";
        public string SettingsMenuItem => "Settings...";
    }
}
