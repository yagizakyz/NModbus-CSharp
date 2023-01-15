using Modbus.Device;
using Modbus.Utility;
using System.IO.Ports;

namespace NModbusExamples
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// TR: Modbus Slave veri gönderme.
        /// EN: Send data to Modbus Slave.
        /// </summary>

        private SerialPort serialPort = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void writeMultipleRegBTN_Click(object sender, EventArgs e)
        {
            try
            {
                IModbusMaster masterRTU =  ModbusSerialMaster.CreateRtu(serialPort);
                byte slaveAddress = 1;
                ushort startAddress = 40001;
                string[] strArray = textBox1.Text.Split(',');
                float[] floatArray = new float[strArray.Length];

                for (int i = 0; i < strArray.Length; i++)
                {
                    floatArray[i] = float.Parse(strArray[i]);
                }

                ushort[] registers = ModbusUtility.ConvertFloatArrayToUshortArray(floatArray);
                masterRTU.WriteMultipleRegisters(slaveAddress, startAddress, registers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}