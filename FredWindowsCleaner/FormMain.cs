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
      // C:\Users\user1\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\cache2\index
      // C:\Users\username\AppData\Local\Mozilla\Firefox\Profiles\e2pc575d.default-release\cache2\index.log
      // 13. Chronium cache
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\Cache\Cache_Data\*.*
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\Extension State\CURRENT
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\Extension State\LOG.old
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\GPUCache\*.*
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\Session Storage\CURRENT
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\Default\Session Storage\LOG.old
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\GrShaderCache\data_*.*
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\GrShaderCache\index
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\ShaderCache\data_*.*
      // C:\Users\user1\AppData\Local\Microsoft\Edge\User Data\ShaderCache\index
      // 14. Mozilla Firefox historique
      // 15. Google Chrome historique
      // 16. Internet Explorer cookies
      // 17. Mozilla Firefox cookies
      // 2. Nettoyage de l'espace disque
      // 3. Entrées résiduelles du registre
      // 4. Racourcis non valides
      // 5. Vider la corbeille

    }
  }
}
