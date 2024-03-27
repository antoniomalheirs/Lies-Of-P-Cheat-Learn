namespace LiesOfPCheatLearn;

public partial class Form1 : Form
{
    static Player cplayer;

    public Form1()
    {
        InitializeComponent();
        
    }

    private void Infitelife_CheckedChanged(object sender, EventArgs e)
    {
        cplayer = new Player();

        if (Infitelife.Checked == true)
        {
            MessageBox.Show("O valor de ErgoCells é: " + cplayer.getErgoCells(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }

    private void Frezzyposition_CheckedChanged(object sender, EventArgs e)
    {

    }
}
