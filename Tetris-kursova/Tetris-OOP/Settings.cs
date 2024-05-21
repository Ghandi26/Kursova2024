namespace Tetris_OOP.Properties {
    
    
    // Этот класс позволяет обрабатывать определенные события в классе параметров:
    //  Событие SettingChanging возникает перед изменением значения параметра.
    //  Событие PropertyChanged возникает после изменения значения параметра.
    //  Событие SettingsLoaded возникает после загрузки значений параметров.
    //  Событие SettingsSaving возникает перед сохранением значений параметров.
    public sealed partial class Settings {
        
        public Settings() {
            
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
           
        }
    }
}
