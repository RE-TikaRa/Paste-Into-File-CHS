using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsFile.Localization
{
    /// <summary>
    /// Manages language selection and loading
    /// </summary>
    public static class LanguageManager
    {
        private static ILanguage _currentLanguage;
        
        /// <summary>
        /// Gets the current language resource
        /// </summary>
        public static ILanguage Current
        {
            get
            {
                if (_currentLanguage == null)
                {
                    LoadLanguage();
                }
                return _currentLanguage;
            }
        }
        
        /// <summary>
        /// Available languages
        /// </summary>
        public enum LanguageCode
        {
            English,
            Chinese
        }
        
        /// <summary>
        /// Load language from registry or system culture
        /// </summary>
        private static void LoadLanguage()
        {
            // Try to get language from registry first
            string savedLanguage = (string)Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Classes\Directory\shell\Paste Into File\language", 
                "", 
                null);
            
            if (!string.IsNullOrEmpty(savedLanguage))
            {
                SetLanguage(savedLanguage);
                return;
            }
            
            // Fall back to system culture
            var culture = CultureInfo.CurrentUICulture;
            if (culture.TwoLetterISOLanguageName == "zh" || culture.Name.StartsWith("zh"))
            {
                _currentLanguage = new ChineseLanguage();
            }
            else
            {
                _currentLanguage = new EnglishLanguage();
            }
        }
        
        /// <summary>
        /// Set language by code
        /// </summary>
        /// <param name="languageCode">Language code (en, zh)</param>
        public static void SetLanguage(string languageCode)
        {
            switch (languageCode.ToLower())
            {
                case "zh":
                case "chinese":
                case "zh-cn":
                case "zh-tw":
                    _currentLanguage = new ChineseLanguage();
                    break;
                case "en":
                case "english":
                default:
                    _currentLanguage = new EnglishLanguage();
                    break;
            }
        }
        
        /// <summary>
        /// Set language by enum
        /// </summary>
        public static void SetLanguage(LanguageCode languageCode)
        {
            switch (languageCode)
            {
                case LanguageCode.Chinese:
                    _currentLanguage = new ChineseLanguage();
                    break;
                case LanguageCode.English:
                default:
                    _currentLanguage = new EnglishLanguage();
                    break;
            }
        }
        
        /// <summary>
        /// Save language preference to registry
        /// </summary>
        public static void SaveLanguagePreference(string languageCode)
        {
            try
            {
                var key = Registry.CurrentUser.CreateSubKey(@"Software\Classes\Directory");
                key = key.CreateSubKey("shell").CreateSubKey("Paste Into File");
                key = key.CreateSubKey("language");
                key.SetValue("", languageCode);
            }
            catch (Exception)
            {
                // Silently fail if we can't write to registry
            }
        }
    }
}
