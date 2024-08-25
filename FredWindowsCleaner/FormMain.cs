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
      // C:\Users\user1\AppData\Local\Microsoft\Windows\INetCache\IE\
      // C:\Users\user1\AppData\LocalLow\Microsoft\CryptnetUrlCache\Content\*.*
      // 12. Mozilla Firefox cache
      // 13. Chronium cache
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
