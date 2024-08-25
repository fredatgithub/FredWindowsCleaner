using System;
using System.Windows.Forms;

namespace FredWindowsCleaner
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      // spec to be cleaned off
      // 1. éléments confidentiels à risque
      // 11. Internet Explorer cache
      // C:\Users\username\AppData\Local\Microsoft\Windows\INetCache\IE\
      // C:\Users\username\AppData\LocalLow\Microsoft\CryptnetUrlCache\Content\*.*
      // C:\Users\username\AppData\LocalLow\Microsoft\CryptnetUrlCache\MetaData\*.*

      // 12. Mozilla Firefox cache
      // try to get firefox profiles user path
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\cache2\entries\*.*
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\jumpListCache\*.*
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\thumbnails\*.*
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\cache2\index
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\cache2\index.log

      // 13. Chronium cache
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Cache\Cache_Data\*.*
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Extension State\CURRENT
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Extension State\LOG.old
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\GPUCache\*.*
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Session Storage\CURRENT
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Session Storage\LOG.old
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\GrShaderCache\data_*.*
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\GrShaderCache\index
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\ShaderCache\data_*.*
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\ShaderCache\index

      // 14. Mozilla Firefox historique
      // C:\Users\username\AppData\Roaming\Mozilla\Firefox\Profiles\e2pc575d.default-release\formhistory.sqlite
      // C:\Users\username\AppData\Roaming\Mozilla\Firefox\Profiles\e2pc575d.default-release\sessionstore.jsonlz4

      // 15. Google Chrome historique
      // prerequisite close Chrome before ?
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\history
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\history-journal
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Network Action Predictor
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Network Action Predictor-journal
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Top Sites
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Top Sites-journal
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Visited Links
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\Web Data-journal
      // C:\Users\username\AppData\Local\Microsoft\Edge\User Data\Default\first_party_sets.db-journal

      // 16. Internet Explorer cookies
      // C:\Users\username\AppData\Local\Microsoft\Windows\INetCookies\ESE\container.dat
      // C:\Users\username\AppData\Local\Microsoft\Windows\INetCookies\Low\ESE\container.dat

      // 17. Mozilla Firefox cookies
      // to be checked

      // 2. Nettoyage de l'espace disque
      // c:\temp\*.*
      // C:\WINDOWS\Temp\*.*
      // C:\Users\username\AppData\Local\temp\*.*

      // 3. Entrées résiduelles du registre
      // 31. Associations de fichiers
      // 32. Interfaces and types
      // 33. Liste des programmes de démarrage
      // 34. Valeurs temporaires du registre

      // C:\Users\All Users\Microsoft\Network\Downloader\edb00046.log
      // TO BE continued from here on out

      // 4. Racourcis non valides
      // C:\Users\username\AppData\Roaming\Microsoft\Windows\Recent\*.*

      // 5. Vider la corbeille
      // C:\$Recycle.Bin\*.*
    }
  }
}
