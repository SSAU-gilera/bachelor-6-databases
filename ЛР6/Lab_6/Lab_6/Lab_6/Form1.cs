using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonIncident_Click(object sender, EventArgs e)
        {
            Incidents incidents = new Incidents();
            incidents.Show();
            SetVisibleCore(false);
        }
        private void buttonParticipant_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            participant.Show();
            SetVisibleCore(false);
        }
        private void buttonPI_Click(object sender, EventArgs e)
        {
            PI pI = new PI();
            pI.Show();
            SetVisibleCore(false);
        }
        private void buttonAttitude_Click(object sender, EventArgs e)
        {
            Attitude attitude = new Attitude();
            attitude.Show();
            SetVisibleCore(false);
        }
        private void buttonDecision_Click(object sender, EventArgs e)
        {
            Decision decision = new Decision();
            decision.Show();
            SetVisibleCore(false);
        }
        private void buttonType_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.Show();
            SetVisibleCore(false);
        }
    }
}
