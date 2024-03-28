namespace LiesOfPCheatLearn;

public partial class Form1 : Form
{
    static bool healthrun, ergorun, vitalrun, pbulletsrun, explosiverun;

    static CancellationTokenSource heatlhtask, ergotask, vitaltask, pbulletstask, explosivetask;
    private SynchronizationContext synchronizationContext;

    static Player cplayer;
    static Injetor cinjetor;

    public Form1()
    {
        InitializeComponent();
        cplayer = new Player();
        cinjetor = new Injetor();
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
            MessageBox.Show("O valor de VitalCells é: " + cplayer.getHealth(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Healthrun();
        }
        else
        {
            StopHealthrun();
        }
    }

    private void InfiniteStamina_CheckedChanged(object sender, EventArgs e)
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
}
