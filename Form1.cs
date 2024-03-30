namespace LiesOfPCheatLearn;

public partial class Form1 : Form
{
    static bool healthrun, ergorun, vitalrun, staminarun, explosiverun;

    private static CancellationTokenSource heatlhtask, ergotask, vitaltask, staminatask;
    private SynchronizationContext synchronizationContext;

    private static Player cplayer;
    private static Injetor cinjetor;

    public Form1()
    {
        InitializeComponent();

        cplayer = new Player();
        cinjetor = new Injetor();

        var valueS = cinjetor.getStamina(cplayer.getStamina(), cplayer.Stamina[5]);
        var valueH = cinjetor.getHealth(cplayer.getHealth(), cplayer.Health[6]);
        var valueE = cinjetor.getErgoCells(cplayer.getErgoCells(), cplayer.ErgoCells[3]);
        var valueV = cinjetor.getVitalCells(cplayer.getVitalCells(), cplayer.VitalCells[3]);
        var valueLA = cinjetor.getLegionArm(cplayer.getlegionArm(), cplayer.LegionArm[5]);
        var valueFA = cinjetor.getFabulosAttack(cplayer.getfabulosAttack(), cplayer.FabulosAttack[5]);


        viewS.Text = valueS.ToString();
        viewH.Text = valueH.ToString();
        viewE.Text = valueE.ToString();
        viewV.Text = valueV.ToString();
        viewLA.Text = valueLA.ToString();
        viewFA.Text = valueFA.ToString();
    }

    private void Infiteergos_CheckedChanged(object sender, EventArgs e)
    {
        if (Infiteergos.Checked == true)
        {
            //MessageBox.Show("O valor de ErgoCells é: " + cplayer.getErgoCells(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ergorun();
        }
        else
        {
            StopErgohrun();
        }
    }

    private void InfiniteVitalCells_CheckedChanged(object sender, EventArgs e)
    {
        if (InfiniteVitalCells.Checked == true)
        {
            //MessageBox.Show("O valor de VitalCells é: " + cplayer.getVitalCells(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Vitalrun();
        }
        else
        {
            StopVitalrun();
        }
    }

    private void Infinitehealth_CheckedChanged(object sender, EventArgs e)
    {
        if (Infinitehealth.Checked == true)
        {
            //MessageBox.Show("O valor de VitalCells é: " + cplayer.getHealth(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Healthrun();
        }
        else
        {
            StopHealthrun();
        }
    }

    private void InfiniteStamina_CheckedChanged(object sender, EventArgs e)
    {
        if (InfiniteStamina.Checked == true)
        {
            //MessageBox.Show("O valor de VitalCells é: " + cplayer.getStamina(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Staminarun();
        }
        else
        {
            StopStaminarun();
        }

    }

    private void InfiteArm_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void InfiniteFabulosAttack_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Frezzyposition_CheckedChanged(object sender, EventArgs e)
    {

    }

    private static void Ergorun()
    {
        ergotask = new CancellationTokenSource();
        CancellationToken Kcancel = ergotask.Token;
        ergorun = true;

        Task.Run(() =>
        {
            while (!Kcancel.IsCancellationRequested)
            {
                cinjetor.frezErgoCells(cplayer.getErgoCells(), cplayer.ErgoCells[3], 160000);
                Thread.Sleep(100);
            }

            ergorun = false;
        });
    }

    private static void Vitalrun()
    {
        vitaltask = new CancellationTokenSource();
        CancellationToken Kcancel = vitaltask.Token;
        vitalrun = true;

        Task.Run(() =>
        {
            while (!Kcancel.IsCancellationRequested)
            {
                cinjetor.frezVitalCells(cplayer.getVitalCells(), cplayer.VitalCells[3], 8);
                Thread.Sleep(100);
            }

            vitalrun = false;
        });
    }

    private static void StopErgohrun()
    {
        if (ergorun)
        {
            cinjetor.frezErgoCells(cplayer.getErgoCells(), cplayer.ErgoCells[3], 3);
            ergotask.Cancel();
            ergotask.Dispose();
            ergotask = null;
        }
    }

    private static void StopVitalrun()
    {
        if (vitalrun)
        {
            cinjetor.frezVitalCells(cplayer.getVitalCells(), cplayer.VitalCells[3], 3);
            vitaltask.Cancel();
            vitaltask.Dispose();
            vitaltask = null;
        }
    }

    private static void Healthrun()
    {
        heatlhtask = new CancellationTokenSource();
        CancellationToken Kcancel = heatlhtask.Token;
        healthrun = true;

        Task.Run(() =>
        {
            while (!Kcancel.IsCancellationRequested)
            {
                cinjetor.frezHealth(cplayer.getHealth(), cplayer.Health[6], 999);
                Thread.Sleep(100);
            }

            healthrun = false;
        });
    }

    private static void StopHealthrun()
    {
        if (healthrun)
        {
            cinjetor.frezHealth(cplayer.getHealth(), cplayer.Health[6], 601);
            heatlhtask.Cancel();
            heatlhtask.Dispose();
            heatlhtask = null;
        }
    }

    private static void Staminarun()
    {
        staminatask = new CancellationTokenSource();
        CancellationToken Kcancel = staminatask.Token;
        staminarun = true;

        Task.Run(() =>
        {
            while (!Kcancel.IsCancellationRequested)
            {
                cinjetor.frezStamina(cplayer.getStamina(), cplayer.Stamina[5], 250);
                Thread.Sleep(100);
            }

            staminarun = false;
        });
    }

    private static void StopStaminarun()
    {
        if (staminarun)
        {
            cinjetor.frezStamina(cplayer.getStamina(), cplayer.Stamina[5], 193);
            staminatask.Cancel();
            staminatask.Dispose();
            staminatask = null;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    
}
