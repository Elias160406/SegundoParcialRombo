using SegundoParcialRombo.Entidades;

namespace SegundoParcialRombo.Windows
{
    public partial class frmRombos : Form
    {
        public frmRombos()
        {
            InitializeComponent();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            {
                frmRomboAE frm = new frmRomboAE() { Text = "Agregar Elipse" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) return;
      
                {
                    
                    {
                        

                    }
                    
                    {

                        

                    }
                }
               
                {

                   

                }
            }
        }


        private void tsbBorrar_Click(object sender, EventArgs e)
        {
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
        }


        private void CargarComboContornos(ref ToolStripComboBox tsCboBordes)
        {
            var listaBordes = Enum.GetValues(typeof(Rombo));
            foreach (var item in listaBordes)
            {
                tsCboBordes.Items.Add(item);
            }
            tsCboBordes.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboBordes.SelectedIndex = 0;

        }


        private void lado09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lado90ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
        }

        private void frmElipses_Load(object sender, EventArgs e)
        {
            CargarComboContornos(ref tsCboContornos);

        }

    }
}
