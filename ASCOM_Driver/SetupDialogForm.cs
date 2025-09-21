using ASCOM.Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ASCOM.DarkSkyGeek
{
    // Form not registered for COM!
    [ComVisible(false)]

    public partial class SetupDialogForm : Form
    {
        // Holder for a reference to the driver's trace logger
        TraceLogger tl;

        public SetupDialogForm(TraceLogger tlDriver)
        {
            InitializeComponent();

            // Save the provided trace logger for use within the setup dialogue
            tl = tlDriver;

            // Initialise current values of user settings from the ASCOM Profile
            InitUI();
        }

        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            // Place any validation constraint checks here
            // Update the state variables with results from the dialogue
            Switch.autoDetectComPort = chkAutoDetect.Checked;
            Switch.comPortOverride = (string)comboBoxComPort.SelectedItem;
            Switch.comPort2Override = (string)comboBoxComPort2.SelectedItem;
            Switch.comPort3Override = (string)comboBoxComPort3.SelectedItem;
            Switch.comPortName = textBoxComPortName.Text;
            Switch.comPort2Name = textBoxComPort2Name.Text;
            Switch.comPort3Name = textBoxComPort3Name.Text;
            tl.Enabled = chkTrace.Checked;
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            Close();
        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("https://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void InitUI()
        {
            chkAutoDetect.Checked = Switch.autoDetectComPort;
            chkTrace.Checked = tl.Enabled;
            comboBoxComPort.Enabled = !chkAutoDetect.Checked;
            textBoxComPortName.Text = Switch.comPortName;
            textBoxComPort2Name.Text = Switch.comPort2Name;
            textBoxComPort3Name.Text = Switch.comPort3Name;

            // Set the list of COM ports to those that are currently available
            comboBoxComPort.Items.Clear();
            // Use System.IO because it's static
            comboBoxComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            // Select the current port if possible
            if (comboBoxComPort.Items.Contains(Switch.comPortOverride))
            {
                comboBoxComPort.SelectedItem = Switch.comPortOverride;
            }

            
            // Use System.IO because it's static
            comboBoxComPort2.Items.Clear();
            comboBoxComPort2.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBoxComPort2.Items.Insert(0, "");
            if (comboBoxComPort2.Items.Contains(Switch.comPort2Override))
            {
                comboBoxComPort2.SelectedItem = Switch.comPort2Override;
            }

            comboBoxComPort3.Items.Clear();
            comboBoxComPort3.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBoxComPort3.Items.Insert(0, "");
            if (comboBoxComPort3.Items.Contains(Switch.comPort3Override))
            {
                comboBoxComPort3.SelectedItem = Switch.comPort3Override;
            }


        }

        private void chkAutoDetect_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxComPort.Enabled = !((CheckBox)sender).Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetupDialogForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}