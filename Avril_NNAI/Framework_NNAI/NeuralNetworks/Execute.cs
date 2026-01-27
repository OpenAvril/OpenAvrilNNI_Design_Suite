using System.Windows.Forms;

namespace Avril_NNAI
{
    public class Execute
    {
        public Execute()
        {

        }

        public void Create_And_Run_UI(Avril_NNAI.Framework_NNAI obj)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
