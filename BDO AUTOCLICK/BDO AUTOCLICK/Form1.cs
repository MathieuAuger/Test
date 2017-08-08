using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_AUTOCLICK
{
    public partial class Form1 : Form
    {
        // LUL UN COMMENTAIRE

        public int xRes { get; set; }
        public int yRes { get; set; }

        public float modHighY { get; set; }
        public int highestY { get; set; }
        public float modLowY { get; set; }
        public int lowestY { get; set; }
        public float modHighX { get; set; }
        public int highestX { get; set; }
        public float modLowX { get; set; }
        public int lowestX { get; set; }

        public float modHighY2 { get; set; }
        public int highestY2 { get; set; }
        public float modLowY2 { get; set; }
        public int lowestY2 { get; set; }
        public float modHighX2 { get; set; }
        public int highestX2 { get; set; }
        public float modLowX2 { get; set; }
        public int lowestX2 { get; set; }

        public Random rand;
        public Point point;



        public Form1()
        {
            InitializeComponent();

            xRes = 2560;
            yRes = 1440;

            rand = new Random();
            point = new Point();
        }

        private void BTN_START_Click(object sender, EventArgs e)
        {
            Bot();
        }

        private void Bot()
        {
            TMR_Start.Stop();
            TMR_Start.Interval = rand.Next(50, 150);

            ////////////////////////////////////////////////////////
            //Refresh button

            modHighY = (float)1440 / (float)940;
            highestY = (int)(Math.Floor((float)yRes / modHighY + 0.5));
            modLowY = (float)1440 / (float)965;
            lowestY = (int)(Math.Floor((float)yRes / modLowY + 0.5));

            modHighX = (float)2560 / (float)1180;
            highestX = (int)(Math.Floor((float)xRes / modHighX + 0.5));
            modLowX = (float)2560 / (float)1052;
            lowestX = (int)(Math.Floor((float)xRes / modLowX + 0.5));

            point.X = rand.Next(lowestX, highestX);
            point.Y = rand.Next(highestY, lowestY);
            Cursor.Position = point;

            System.Threading.Thread.Sleep(rand.Next(25, 80));
            ////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////
            //Buy/Bid button

            modHighY2 = (float)1440 / (float)508;
            highestY2 = (int)(Math.Floor((float)yRes / modHighY2 + 0.5));
            modLowY2 = (float)1440 / (float)545;
            lowestY2 = (int)(Math.Floor((float)yRes / modLowY2 + 0.5));

            modHighX2 = (float)2560 / (float)1650;
            highestX2 = (int)(Math.Floor((float)xRes / modHighX2 + 0.5));
            modLowX2 = (float)2560 / (float)1595;
            lowestX2 = (int)(Math.Floor((float)xRes / modLowX2 + 0.5)); ;

            point.X = rand.Next(lowestX2, highestX2);
            point.Y = rand.Next(highestY2, lowestY2);
            Cursor.Position = point;

            System.Threading.Thread.Sleep(rand.Next(25, 80));
            ////////////////////////////////////////////////////////

        }

        private void TestRefresh()
        {

            TMR_Refresh.Stop();
            TMR_Refresh.Interval = rand.Next(50, 150);

            for (int i = 0; i < 20; ++i)
            {
                ////////////////////////////////////////////////////////
                //Refresh button

                modHighY = (float)1440 / (float)940;
                highestY = (int)(Math.Floor((float)yRes / modHighY + 0.5));
                modLowY = (float)1440 / (float)965;
                lowestY = (int)(Math.Floor((float)yRes / modLowY + 0.5));

                modHighX = (float)2560 / (float)1180;
                highestX = (int)(Math.Floor((float)xRes / modHighX + 0.5));
                modLowX = (float)2560 / (float)1052;
                lowestX = (int)(Math.Floor((float)xRes / modLowX + 0.5));

                point.X = rand.Next(lowestX, highestX);
                point.Y = rand.Next(highestY, lowestY);
                Cursor.Position = point;

                System.Threading.Thread.Sleep(rand.Next(25, 80));
                ////////////////////////////////////////////////////////
            }
        }

        private void TestBuy()
        {
            TMR_Buy.Stop();
            TMR_Buy.Interval = rand.Next(50, 150);


            for (int i = 0; i < 20; ++i)
            {
                ////////////////////////////////////////////////////////
                //Buy/Bid button

                modHighY2 = (float)1440 / (float)508;
                highestY2 = (int)(Math.Floor((float)yRes / modHighY2 + 0.5));
                modLowY2 = (float)1440 / (float)545;
                lowestY2 = (int)(Math.Floor((float)yRes / modLowY2 + 0.5));

                modHighX2 = (float)2560 / (float)1650;
                highestX2 = (int)(Math.Floor((float)xRes / modHighX2 + 0.5));
                modLowX2 = (float)2560 / (float)1595;
                lowestX2 = (int)(Math.Floor((float)xRes / modLowX2 + 0.5)); ;

                point.X = rand.Next(lowestX2, highestX2);
                point.Y = rand.Next(highestY2, lowestY2);
                Cursor.Position = point;

                System.Threading.Thread.Sleep(rand.Next(25, 80));
                ////////////////////////////////////////////////////////
            }
        }

        private void TMR_Start_Tick(object sender, EventArgs e)
        {
            Bot();

            TMR_Start.Start();
        }

        private void TMR_Refresh_Tick(object sender, EventArgs e)
        {
            TestRefresh();
        }

        private void TMR_Buy_Tick(object sender, EventArgs e)
        {
            TestBuy();
        }

        private void BTN_Go_Click(object sender, EventArgs e)
        {
            TMR_Start.Start();
        }

        private void BTN_TestRefresh_Click(object sender, EventArgs e)
        {
            TMR_Refresh.Start();
        }

        private void BTN_TestBuy_Click(object sender, EventArgs e)
        {
            TMR_Buy.Start();
        }

        private void BTN_StopAll_Click(object sender, EventArgs e)
        {
            TMR_Buy.Stop();
            TMR_Refresh.Stop();
            TMR_Start.Stop();
        }

        private void TB_ResX_TextChanged(object sender, EventArgs e)
        {
            xRes = Convert.ToInt32(TB_ResX.Text);
        }

        private void TB_ResY_TextChanged(object sender, EventArgs e)
        {
            yRes = Convert.ToInt32(TB_ResY.Text);
        }

    }
}
