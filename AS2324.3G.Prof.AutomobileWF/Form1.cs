namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccellerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccellera_Click(object sender, EventArgs e)
        {
            velocita += stepAccellerazione;
            lstMonitor.Items.Clear();
            if (chkCinture.Checked == false && velocita > 0)
            {
                lstMonitor.Items.Add("Allaccia la cintura.");
            }
            lstMonitor.Items.Clear();
            if (velocita == 160)
            {
                lstMonitor.Items.Add("Sei già alla velocità massima.");
            }
            if (velocita > 160)
            {
                velocita = 160;
            }
            string scelta = cmbStrada.Text;
            switch (scelta)
            {
                case "urbana":
                    if (velocita > 50)
                    {
                        lstMonitor.Items.Clear();
                        lstMonitor.Items.Add("Rallenta! Stai superando il limite.");
                    }
                    break;
                case "extraurbana":
                    if (velocita > 90)
                    {
                        lstMonitor.Items.Clear();
                        lstMonitor.Items.Add("Rallenta! Stai superando il limite.");
                    }
                    break;
                case "autostrada":
                    if (velocita > 130)
                    {
                        lstMonitor.Items.Clear();
                        lstMonitor.Items.Add("Rallenta! Stai superando il limite.");
                    }
                    break;
                default:
                    break;
            }
            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;
            lstMonitor.Items.Clear();
            if (velocita == 0)
            {
                lstMonitor.Items.Add("Sei già fermo.");
            }
            if (velocita < 0)
            {
                velocita = 0;
            }
            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

        }

        private void btnClacson_Click(object sender, EventArgs e)
        {
            lstMonitor.Items.Clear();
            lstMonitor.Items.Add("BEEP!");
        }

        private void lblVelocita_Click(object sender, EventArgs e)
        {
     
        }
    }
}
