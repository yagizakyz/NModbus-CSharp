using Modbus.Device;
using Modbus.Utility;
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
    public partial class ReadHoldingRegisterForm : Form
    {
        /// <summary>
        /// TR: Modbus Slave'den veri alma.
        /// EN: Receiving data from Modbus Slave.
        /// </summary>

        private SerialPort serialPort = null;
        public ReadHoldingRegisterForm()
        {
            InitializeComponent();
        }

        private void ReadHoldingRegisterForm_Load(object sender, EventArgs e)
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
                ushort numberOfPoint = 8 * 4; // read 8 float.
                IModbusMaster masterRTU = ModbusSerialMaster.CreateRtu(serialPort);
                ushort[] ushortArray = masterRTU.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoint);

                // Convert ushort array to float array
                float[] result = ModbusUtility.ConvertUshortToFloatArray(ushortArray);
                textBox1.Text = string.Empty;
                foreach (float item in result)
                {
                    textBox1.Text += string.Format("{0}/", item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
