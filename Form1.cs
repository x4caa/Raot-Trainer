using Swed64;
using System.Diagnostics;
using System.Runtime.InteropServices;


//posandvelobj offsets
//xyz = 0x20, 0x24, 0x28
//velo = 0x50, 0x54, 0x58

namespace Raot
{

    public partial class Raot_Trainer : Form
    {
        Swed swed = new Swed("raot");
        public bool toggleGas;
        public bool toggleStress;
        public bool toggleFly;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public Raot_Trainer()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            Debug.WriteLine("form loaded successfully");
            this.Location = new Point(0, 0);


            if (swed != null)
            {
                Thread gasThread = new Thread(infiniteGas) { IsBackground = true };
                Thread stressThread = new Thread(noStress) { IsBackground = true };
                Thread flyThread = new Thread(fly) { IsBackground = true };
                Thread OOBThread = new Thread(OOB) { IsBackground = true };
                Thread derpThread = new Thread(derp) { IsBackground = true };
                gasThread.Start();
                stressThread.Start();
                flyThread.Start();
                OOBThread.Start();
                derpThread.Start();
                Debug.WriteLine("threads started successfully");
            }
        }


        //check if infgas is toggled on
        private void checkbox_Gas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Gas.Checked) toggleGas = true;
            else toggleGas = false;
        }
        //check if noStress is toggled on
        private void checkbox_Stress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Stress.Checked) toggleStress = true;
            else toggleStress = false;
        }
        //check if fly is toggled on
        private void checkbox_Fly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Fly.Checked) toggleFly = true;
            else toggleFly = false;
        }

        //handle gas
        void infiniteGas()
        {
            while (true)
            {
                while (toggleGas == true)
                {
                    var GasModuleBase = swed.GetModuleBase("GameAssembly.dll");
                    var gasObj = swed.ReadPointer(GasModuleBase, 0x02592368, 0x50, 0xB8, 0x0, 0x38, 0x28);
                    swed.WriteFloat(gasObj, 0x58, 1.0f);
                    Thread.Sleep(100);
                }
            }
        }
        //handle stress
        void noStress()
        {
            while (true)
            {
                while (toggleStress == true)
                {
                    var GasModuleBase = swed.GetModuleBase("GameAssembly.dll");
                    var stressObj = swed.ReadPointer(GasModuleBase, 0x025A0E70, 0xB8, 0x0, 0x50, 0x30);
                    swed.WriteFloat(stressObj, 0x18, 0.0f);
                    Thread.Sleep(10);
                }

            }
        }
        //handle fly
        void fly()
        {
            while (true)
            {
                while (toggleFly == true)
                {
                    var ModuleBase = swed.GetModuleBase("UnityPlayer.dll");
                    var posAndVeloObj = swed.ReadPointer(ModuleBase, 0x017A7540, 0x30, 0x28, 0x30, 0x0);
                    swed.WriteFloat(posAndVeloObj, 0x54, 0.35f);
                    if (GetAsyncKeyState(Keys.Space) < 0)
                    {
                        swed.WriteFloat(posAndVeloObj, 0x54, 100.0f);
                        Thread.Sleep(100);
                    }
                    if (GetAsyncKeyState(Keys.LShiftKey) < 0)
                    {
                        swed.WriteFloat(posAndVeloObj, 0x54, -100.0f);
                        Thread.Sleep(100);
                    }
                    Thread.Sleep(5);
                }
            }
        }
        //clip through top of map
        void OOB()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.X) < 0)
                {
                    var ModuleBase = swed.GetModuleBase("UnityPlayer.dll");
                    var posAndVeloObj = swed.ReadPointer(ModuleBase, 0x017A7540, 0x30, 0x28, 0x30, 0x0);
                    float currentY = swed.ReadFloat(posAndVeloObj, 0x24);
                    swed.WriteFloat(posAndVeloObj, 0x24, currentY + 10.0f);
                    Thread.Sleep(100);
                }
                if (GetAsyncKeyState(Keys.Z) < 0)
                {
                    var ModuleBase = swed.GetModuleBase("UnityPlayer.dll");
                    var posAndVeloObj = swed.ReadPointer(ModuleBase, 0x017A7540, 0x30, 0x28, 0x30, 0x0);
                    float currentY = swed.ReadFloat(posAndVeloObj, 0x24);
                    swed.WriteFloat(posAndVeloObj, 0x24, currentY - 10.0f);
                    Thread.Sleep(100);
                }
            }
        }
        //handle velo
        void derp()
        {
            var randomVelo = new Random();
            while (true)
            {
                while (GetAsyncKeyState(Keys.D2) < 0)
                {
                    var ModuleBase = swed.GetModuleBase("UnityPlayer.dll");
                    var posAndVeloObj = swed.ReadPointer(ModuleBase, 0x017A7540, 0x30, 0x28, 0x30, 0x0);
                    if (randomVelo.Next(1, 3) == 1) swed.WriteFloat(posAndVeloObj, 0x50, randomVelo.Next(-5000, 5000));
                    else if (randomVelo.Next(1, 3) == 2) swed.WriteFloat(posAndVeloObj, 0x54, randomVelo.Next(-5000, -5000));
                    else if (randomVelo.Next(1, 3) == 3) swed.WriteFloat(posAndVeloObj, 0x58, randomVelo.Next(-5000, -5000));

                }

            }
        }


    }
}