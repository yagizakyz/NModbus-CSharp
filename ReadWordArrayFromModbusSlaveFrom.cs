using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NModbusExamples
{
    public partial class ReadWordArrayFromModbusSlaveFrom : Form
    {
        /// <summary>
        /// TR:
        /// EN:
        /// </summary>

        private SerialPort serialPort = null;
        public ReadWordArrayFromModbusSlaveFrom()
        {
            InitializeComponent();
        }

        private void ReadWordArrayFromModbusSlaveFrom_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readHoldRegBTN_Click(object sender, EventArgs e)
        {
            try
            {
                byte slaveAddress = 1;
                ushort startAddress = 40001;
                ushort numberOfPoints = 25;

                IModbusMaster masterRTU = ModbusSerialMaster.CreateRtu(serialPort);
                ushort[] result = masterRTU.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);

                // Display result.
                resultTXT.Text = string.Empty;
                foreach (ushort item in result)
                {
                    resultTXT.Text += string.Format("{0}/ ", item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
