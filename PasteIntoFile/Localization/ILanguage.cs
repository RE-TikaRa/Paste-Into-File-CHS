using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsFile.Localization
{
    /// <summary>
    /// Interface for language resource definitions
    /// </summary>
    public interface ILanguage
    {
        // Form labels
        string FormTitle { get; }
        string Filename { get; }
        string Extension { get; }
        string CurrentLocation { get; }
        string SaveButton { get; }
        string TypeLabel { get; }
        
        // File types
        string TextFile { get; }
        string Image { get; }
        string UnknownFile { get; }
        
        // Messages
        string FileSaved { get; }
        string ImageSaved { get; }
        string FirstTimeMessage { get; }
        string FirstTimeTitle { get; }
        string RegisteredMessage { get; }
        string RegisteredTitle { get; }
        string UnregisteredMessage { get; }
        string UnregisteredTitle { get; }
        string FilenameRegisteredMessage { get; }
        string FilenameRegisteredTitle { get; }
        string ErrorAdminRequired { get; }
        string ErrorTitle { get; }
        string FolderBrowserDescription { get; }
        
        // Help message
        string HelpMessage { get; }
        string HelpTitle { get; }
        
        // Copyright
        string Copyright { get; }
        string Website { get; }
        
        // Settings form
        string SettingsTitle { get; }
        string LanguageGroup { get; }
        string SelectLanguage { get; }
        string FilenameGroup { get; }
        string FilenameFormat { get; }
        string FilenamePreview { get; }
        string InvalidFormat { get; }
        string ContextMenuGroup { get; }
        string RegisterButton { get; }
        string UnregisterButton { get; }
        string RegistrationStatusRegistered { get; }
        string RegistrationStatusNotRegistered { get; }
        string SettingsSaved { get; }
        string CancelButton { get; }
        string SettingsMenuItem { get; }
    }
}
