using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace projektPWSW
{
    public partial class Form1 : Form
    {
        private string response = string.Empty;
        private static object PortLock = new object();
        private Queue<byte> rxBuffer = new Queue<byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 90;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnWyb.Enabled = false;
            btnN.Enabled = false;
            lbOK.Enabled = false;
            lbNOK.Enabled = false;
            String[] ports = SerialPort.GetPortNames();
            cboPort.Items.Clear();
            cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            progressBar1.Value = 70;

            zeruj();

            sendTestlbl.Text  = "";
            lbTbName.Text = "";
            

            progressBar1.Value = 60;
            try
            {

                serialPort1.Close();
                progressBar1.Value = 30;
                Console.WriteLine("Port został zamknięty");
                connect.Text = "Rozłączono z radarem";
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Nie można poprawnie zamknąć portu");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            btnClose.Enabled = false;
            serialPort1.RtsEnable = false;
            btnWyb.Enabled = false;
            btnN.Enabled = false;
            lbOK.Enabled = false;
            lbNOK.Enabled = false;
            lbTol.Text = "Tolerancja";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            btnWyb.Enabled = true;
            btnN.Enabled = true;
            try
            {
                progressBar1.Value = 30;
                serialPort1.PortName = cboPort.Text;
                progressBar1.Value = 60;
                serialPort1.Open();
                progressBar1.Value = 80;
                Console.WriteLine("Port został poprawnie otwarty");
                progressBar1.Value = 100;
                connect.Text = "Połączono z radarem";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Port nie został otwarty");
            }
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
       

        private void btnN_Click(object sender, EventArgs e)
        {
            string ramka = "";
            string testName = "";
            if (chN4.Checked)
            {
                 ramka = "FF30353030393932335609303030303030310081303030202020202020202020203033300300000105FDFA";
                testName = "Ustawiono nastawy na montaż MP-DP4";
            }
            else
            {
                 ramka = "FF30353030393932335609303030303030310681303030292929297D7B282828283033300300020406FDFA";
                 testName = "Ustawiono nastawy na montaż";
            }
            
            sendFrame(ramka, testName);
            zeruj();

        }

     


        private void zeruj()
        {

            lbTbName.Text = "";
            lbKBP.Text = "";
            lbCBP.Text = "";
            lbLBP.Text = "";
            lbNBP.Text = "";

            lbKPBP.Text = "";
            lbCPBP.Text = "";
            lbLPBP.Text = "";
            lbNPBP.Text = "";

            lbTol.Text = "Tolerancja";
            lbKPT.Text = "";
            lbCPT.Text = "";
            lbLPT.Text = "";
            lbNPT.Text = "";

            lbKPP.Text = "";
            lbCPP.Text = "";
            lbLPP.Text = "";
            lbNPP.Text = "";
        }
            private void Receive()
        {
            string HexOutPut = "";
            if (serialPort1.IsOpen)
            {
                //string odp = "FCB1B030FDFAFCB1B030FDFA";
                string odp2 = "3F3F3F303F3F3F3F3F303F3F";
                string A = serialPort1.ReadExisting();

                //Console.WriteLine(A);
                char[] charr = A.ToCharArray();
                //byte[] byte_odp = StringToByteArray(odp);
               

                foreach (char _eachChar in charr)
                {
                    int value = Convert.ToInt32(_eachChar);
                    HexOutPut +=  String.Format("{0:X}", value);
                }
                Console.WriteLine(odp2);
                Console.WriteLine(HexOutPut);
                if (String.Compare(HexOutPut,odp2)==0)
                {
                    Console.WriteLine("Radar odebrał nastawy");
                    lbOK.Enabled = true;
                    lbNOK.Enabled = false;
                }
                else
                {
                    Console.WriteLine("Radar nie odebrał nastaw");
                    lbOK.Enabled = false;
                    lbNOK.Enabled = true;
                    zeruj();
                }
               
            }
        }






        protected virtual void DataRecievedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Oczekiwanie na instrukcje");
            SerialPort sp = (SerialPort)sender;
            Receive();
            try
            {
                //txtReceive.Invoke(new Action(() => txtReceive.Text = response));
                // txtReceive.Text = response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Console.WriteLine("Zamknięcie okna aplikacji");
            }
        }

        private void btnWyb_Click(object sender, EventArgs e)
        {
            try
            {
                string test = cbtests.Text;
                SelectedTest(test);
                Console.WriteLine("Test został wybrany");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Port nie został otwarty");
            }
        }

        private void SelectedTest(string selected)
        {
            lbCPT.Font = new Font(lbCPT.Font.FontFamily, 10);
            lbCPP.Font = new Font(lbCPP.Font.FontFamily, 10);
            string testName = "";
            string ramka = "";
            switch (selected)
            {
                case ("Test świecenia"):
                    ramka = "FF303838313230323456013230303030303101C1303030292929297D7B282828283032300000010606FDFA";
                    testName = "Włączono test świecenia";
                    lbTbName.Text = "Test świecenia";
                    lbKBP.Text = "Ciągłe świecenie";
                    lbCBP.Text = "Ciągłe '88'";
                    lbLBP.Text = "☺";
                    lbNBP.Text = "Brak";

                    lbKPBP.Text = "Brak";
                    lbCPBP.Text = "Wartość pomiaru";
                    lbLPBP.Text = "☺";
                    lbNPBP.Text = "'Dziękuję'";

                    lbTol.Text = "Tolerancja";
                    lbKPT.Text = "-";
                    lbCPT.Text = "-";
                    lbLPT.Text = "-";
                    lbNPT.Text = "-";

                    lbKPP.Text = "Brak";
                    lbCPP.Text = "Wartość pomiaru";
                    lbLPP.Text = "Mandaty";
                    lbNPP.Text= "Ciągłe 'Zwolnij'";
                    break;

                case ("Test 1"):
                    ramka = "FF30353031323032345609323030303030310442303030292929297D7B282828283032300000010900FDFA";
                    testName = "Włączono test 1";
                    lbTbName.Text = "Test 1";
                    lbKBP.Text = "Brak";
                    lbCBP.Text = "Brak";
                    lbLBP.Text = "Temperatura";
                    lbNBP.Text = "Brak";

                    lbKPBP.Text = "Brak";
                    lbCPBP.Text = "Wartość pomiaru";
                    lbLPBP.Text = "☺";
                    lbNPBP.Text = "'Dziękuję'";

                    lbTol.Text = "Tolerancja";
                    lbKPT.Text = "-";
                    lbCPT.Text = "-";
                    lbLPT.Text = "-";
                    lbNPT.Text = "-";

                    lbKPP.Text = "Pulsujące";
                    lbCPP.Text = "Wartość pomiaru/Próg";
                    lbLPP.Text = "☺";
                    lbNPP.Text = "Pulsujące 'Zwolnij'";
                    break;

                case ("Test 2"):
                    ramka = "FF3035303132303234560D323030303030310450303030292929297D7B282828283032300000020204FDFA";
                    testName = "Włączono test 2";
                    lbTbName.Text = "Test 2";
                    lbKBP.Text = "Brak";
                    lbCBP.Text = "Brak";
                    lbLBP.Text = "Brak";
                    lbNBP.Text = "Brak";

                    lbKPBP.Text = "Brak";
                    lbCPBP.Text = "Brak";
                    lbLPBP.Text = "Brak";
                    lbNPBP.Text = "'Dziękuję'";

                    lbTol.Text = "Tolerancja";
                    lbKPT.Text = "-";
                    lbCPT.Text = "-";
                    lbLPT.Text = "-";
                    lbNPT.Text = "-";

                    lbKPP.Text = "Pulsujące";
                    lbCPP.Text = "Wartość pomiaru/Próg";
                    lbLPP.Text = "☺";
                    lbNPP.Text = "Pulsujące 'Zwolnij'";
                    break;

                case ("Test 3"):
                    ramka = "FF3035303132303234560B323030303030310281303030292929297D7B282828283032300500010108FDFA";
                    testName = "Włączono test 3";
                    lbTbName.Text = "Test 3";
                    lbKBP.Text = "Pulsujące";
                    lbCBP.Text = "Pulsujące '50'";
                    lbLBP.Text = "Brak";
                    lbNBP.Text = "Brak";

                    lbKPBP.Text = "Brak";
                    lbCPBP.Text = "Wartość pomiaru";
                    lbLPBP.Text = "Brak";
                    lbNPBP.Text = "'Dziękuję'";

                    lbTol.Text = "Tolerancja \n (5 km/h)";
                    lbKPT.Text = "Brak";
                    lbCPT.Font = new Font(lbCPT.Font.FontFamily, 9);
                    lbCPT.Text = "Pulsująca wartość pomiaru";
                    lbLPT.Text = "Brak";
                    lbNPT.Text = "'Dziękuję'";

                    lbKPP.Text = "Brak";
                    lbCPP.Font = new Font(lbCPP.Font.FontFamily, 9);
                    lbCPP.Text = "Pulsująca wartość pomiaru";
                    lbLPP.Text = "Mandaty";
                    lbNPP.Text = "Pulsujące 'Zwolnij'";
                    break;

                case ("Test końcowy"):
                    ramka = "FF30353030393932335609323030303030310681303030292929297D7B282828283033300300000305FDFA";
                    testName = "Włączono test końcowy";
                    lbTbName.Text = "Test końcowy";
                    lbKBP.Text = "Pulsujące";
                    lbCBP.Text = "Pulsujące '50'";
                    lbLBP.Text = "Brak";
                    lbNBP.Text = "Brak";

                    lbKPBP.Text = "Brak";
                    lbCPBP.Text = "Wartość pomiaru";
                    lbLPBP.Text = "Brak";
                    lbNPBP.Text = "'Dziękuję'";

                    lbTol.Text = "Tolerancja \n (3 km/h)";
                    lbKPT.Text = "Brak";
                    lbCPT.Text = "Wartość pomiaru/Próg";
                    lbLPT.Text = "Brak";
                    lbNPT.Text = "'Dziękuję'";

                    lbKPP.Text = "Brak";
                    lbCPP.Text = "Wartość pomiaru/Próg";
                    lbLPP.Text = "Mandaty";
                    lbNPP.Text = "Pulsujące 'Zwolnij'";
                    break;
            }

            sendFrame(ramka, testName);

        }
        private void sendFrame(string frame,string testName)
        {
            
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Console.WriteLine("Test");

                   
                    byte[] byte_ramka = StringToByteArray(frame);

                   // Console.WriteLine("Informacja została przekonwertowana na byte");

                    lock (PortLock)
                    {
                        serialPort1.RtsEnable = true;
                        Thread.Sleep(10);
                        serialPort1.Write(byte_ramka, 0, byte_ramka.Length);
                        serialPort1.RtsEnable = false;
                    }
                    Thread.Sleep(1000);
                    Receive();
                    Console.WriteLine("Pomyślnie wysłano komunikat");
                    sendTestlbl.Text = testName;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Błąd wysyłania komunikatu");
            }
        }

       
    }
}
