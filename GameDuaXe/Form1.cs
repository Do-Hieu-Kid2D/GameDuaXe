using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GameDuaXe
{
    public partial class Form1 : Form
    {
        ChaoMung mung;
        List<Car> dataCar = new List<Car>();
        List<PictureBox> listCar = new List<PictureBox>();
        Boolean veDichRoi= false;
        Boolean nutLoad = false;
        public Form1()
        {
            InitializeComponent();
            // Form1.StartPosition = FormStartPosition.CenterScreen;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void kiemTraVeDich(PictureBox pc)
        {
            int vitriDauXe = pc.Location.X + pc.Size.Width;
            if ( vitriDauXe >= 1078)
            {
                veDichRoi = true;
            }

        }
        void kiemTraTop1()
        {
            int max = 0;
            PictureBox pc = new PictureBox();
            foreach (PictureBox item in listCar)
            {
               int data = item.Location.X + item.Size.Width;
               if ( data > max)
                {
                    max = data;
                    pc = item;
                }
                foreach (PictureBox p in listCar)
                {
                    if (p.Name != pc.Name)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (Car c in dataCar)
                        {
                            if (c.getName().Equals("Xe Ô tô") && p.Name.Equals("car1"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("Cậu Vàng") && p.Name.Equals("car2"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("Máy Bay") && p.Name.Equals("car3"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("Con Trâu đi cày") && p.Name.Equals("car4"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("5 Anh em Siu Nhân") && p.Name.Equals("car5"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("Tắc kè") && p.Name.Equals("car6"))
                            {
                                txtTop1.Text = c.getName().ToUpper();
                            }
                            if (c.getName().Equals("Du thuyền Hạ Long") && p.Name.Equals("car7"))
                            {
                                txtTop1.Text = c.getName();
                            }
                        }
                    }
                }

            }

        }
        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        string layTen()
        {
            string ten = "";
            foreach (PictureBox p in listCar)
            {
                int vitriDauXe = p.Location.X + p.Size.Width;
                
                if (vitriDauXe >= 1078)
                {
                    String name = p.Name.ToString();
                    if(name == "car1")
                    {
                        ten = "Xe Ô tô";
                    }
                    if (name == "car2")
                    {
                        ten = "Cậu Vàng ";
                    }
                    if (name == "car3")
                    {
                        ten = "Máy Bay ";
                    }
                    if (name == "car4")
                    {
                        ten = "Con Trâu đi cày ";
                    }
                    if (name == "car5")
                    {
                        ten = "5 Anh em Siu Nhân";
                    }
                    if (name == "car6")
                    {
                        ten = "Tắc kè";
                    }
                    if (name == "car7")
                    {
                        ten = "Du thuyền Hạ Long";
                    }
                   
                }
            }
            return ten;
            
        }
        void showKetqua(string ten)
        {
            ten = ten.ToUpper();
            string tb = $"Chúc mừng {ten} đã giành CHIẾN THẮNG!!!!";
            MessageBox.Show(tb, "NGƯỜI CHƠI LÀ NGƯỜI THẮNG :>", MessageBoxButtons.OK);
            
        }
        void carChay(PictureBox pc)
        {
         
                Random rnd = new Random();
                int speed = rnd.Next(30, 40);
                pc.Location = new Point(pc.Location.X + speed, pc.Location.Y);
                kiemTraVeDich(pc);
                kiemTraTop1(); 
            if (veDichRoi)
            {
                timer1.Stop();
                showKetqua(layTen());
            }
 
        }

        private void btnDua_Click(object sender, EventArgs e)
        {
            if (veDichRoi)
            {
                return;
            }
            nutLoad = true;
            khoiTaoXe("Xe Ô tô", car1);
            listCar.Add(car1);
            khoiTaoXe("Cậu Vàng", car2);
            listCar.Add(car2);
            khoiTaoXe("Máy Bay", car3);
            listCar.Add(car3);
            khoiTaoXe("Con Trâu đi cày", car4);
            listCar.Add(car4);
            khoiTaoXe("5 Anh em Siu Nhân", car5);
            listCar.Add(car5);
            khoiTaoXe("Tắc kè", car6);
            listCar.Add(car6);
            khoiTaoXe("Du thuyền Hạ Long", car7);
            listCar.Add(car7);
            txtTop1.Visible = true;
            timer1.Start();
            // playSound("D:\WorkSpace\c#\Hoc\GameDuaXe\GameDuaXe\Resources\mv.mp3");


        }


        void khoiTaoXe(string name , PictureBox pc)
        {
            
            String nameCar = name;
            int doDaiXe = pc.Size.Width; // Chiều dài của PictureBox 
            int viTriX = pc.Location.X;  // Cách theo trục hoành 
            int viTriY = pc.Location.Y; // Cách trên bao nhiêu
                
            Car car = new Car(nameCar, doDaiXe, viTriX, viTriY);
            dataCar.Add(car);




        }
        void anNutLoad()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                for(int i = 0; i < 17; i++) {
                    btnLoad.Left = btnLoad.Left -5;
                    int width = btnLoad.Size.Width - 7;
                    int  height = btnLoad.Size.Height -7;
                    btnLoad.Size = new Size(width, height);
                    Thread.Sleep(15);
                    btnLoad.Text = "TOP 1:>";
                }
                

            }).Start();
            
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (nutLoad)
            {
                return;
            }
            car1.Visible = !car1.Visible;
            car2.Visible = !car2.Visible;
            car3.Visible = !car3.Visible;
            car4.Visible = !car4.Visible;
            car5.Visible = !car5.Visible;
            car6.Visible = !car6.Visible;
            car7.Visible = !car7.Visible;
            btnDua.Enabled = true;
            btnReset.Enabled = true;
            anNutLoad();
           
  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            foreach (PictureBox p in listCar)
            {
                carChay(p);
                if (veDichRoi)
                {
                    break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            foreach (PictureBox p in listCar)
            {
               foreach(Car c in dataCar)
                {
                    if (c.getName().Equals("Xe Ô tô") && p.Name.Equals("car1"))
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("Cậu Vàng") && p.Name.Equals("car2"))
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("Máy Bay") && p.Name.Equals("car3") )
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("Con Trâu đi cày") && p.Name.Equals("car4") )
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("5 Anh em Siu Nhân") && p.Name.Equals("car5"))
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("Tắc kè") && p.Name.Equals("car6") )
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                    if (c.getName().Equals("Du thuyền Hạ Long") && p.Name.Equals("car7"))
                    {
                        p.Location = new Point(c.getViTriX(), c.getViTriY());
                    }
                }
            }

            listCar.Clear();
            veDichRoi = false;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 b = new AboutBox1();
            b.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.papa.Show();
        }
    }
}
