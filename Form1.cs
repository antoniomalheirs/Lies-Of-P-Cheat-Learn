namespace LiesOfPCheatLearn;

public partial class Form1 : Form
{
    static Player cplayer;
    static Injetor cinjetor;

    public Form1()
    {
        InitializeComponent();
        cplayer = new Player();
        cinjetor = new Injetor();
    }

    private void Infitelife_CheckedChanged(object sender, EventArgs e)
    {
        if (Infitelife.Checked == true)
        {
            MessageBox.Show("O valor de ErgoCells é: " + cplayer.getErgoCells(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cinjetor.frezErgoCells(cplayer.getErgoCells(),cplayer.ErgoCells[3], 160000);
        }
        else
        {

        }
    }

    private void InfiniteStamina_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void InfiniteVitalCells_CheckedChanged(object sender, EventArgs e)
    {
        if (InfiniteVitalCells.Checked == true)
        {
            MessageBox.Show("O valor de VitalCells é: " + cplayer.getVitalCells(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {

        }
    }

    private void Frezzyposition_CheckedChanged(object sender, EventArgs e)
    {
        if (Frezzyposition.Checked == true)
        {
            MessageBox.Show("O valor de VitalCells é: " + cplayer.getHealth(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {

        }
    }
}
