using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void Form1_Load_1(object sender, EventArgs e)
        {






        }

        private void button2_Click(object sender, EventArgs e)
        {
            int szamlal = 0;
            int temp = 0;
            /*
            0 0 50 0
            50 0 50 50
            50 50 0 50
            0 50 0 0

            
             
            */

            float xtop = 0; //50
            float ytop = 0; //50
            float x2top = 50; //100
            float y2top = 0; //50

            float xright = 50; //100
            float yright = 0; //50
            float x2right = 50; //100
            float y2right = 50; //100

            float xbottom = 50; //100
            float ybottom = 50; //100
            float x2bottom = 0; // 50
            float y2bottom = 50; //100

            float xleft = 0;  //50
            float yleft = 50; //100
            float x2left = 0; //50
            float y2left = 0; //50
            Cell[] Cells = new Cell[64];

            int lefele = 6;
            int vizszint = 7;

            for (int c = 0; c <= lefele; c++)
            {
                for (int r = 0; r <= vizszint; r++)
                {


                    if (temp == 0)
                    {
                        Cells[szamlal] = new Cell(xtop, ytop, x2top, y2top, xright, yright,
                        x2right, y2right, xbottom, ybottom, x2bottom, y2bottom, xleft, yleft, x2left, y2left);
                        temp += 1;
                    };
                    xtop += 50;
                    ytop += 0;
                    x2top += 50;
                    y2top += 0;

                    xright += 50;
                    yright += 0;
                    x2right += 50;
                    y2right += 0;

                    xbottom += 50;
                    ybottom += 0;
                    x2bottom += 50;
                    y2bottom += 0;

                    xleft += 50;
                    yleft += 0;
                    x2left += 50;
                    y2left += 0;
                    Cells[szamlal] = new Cell(xtop, ytop, x2top, y2top, xright, yright,
                        x2right, y2right, xbottom, ybottom, x2bottom, y2bottom, xleft, yleft, x2left, y2left);
                    szamlal++;

                    textBox1.Text = Convert.ToString(szamlal);
                }
                xtop = 0;
                ytop += 50;
                x2top = 50;
                y2top += 50;

                xright = 50;
                yright += 50;
                x2right = 50;
                y2right += 50;

                xbottom = 50;
                ybottom += 50;
                x2bottom = 0;
                y2bottom += 50;

                xleft = 0;
                yleft += 50;
                x2left = 0;
                y2left += 50;
            }
            //Cells[0] = new Cell(false, false, false, false, false);
            textBox2.Text = Convert.ToString(Cells[0].Visited);

            Graphics gr = panel1.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            Pen DeletePen = new Pen(Brushes.White, 1);



            {
                Cells[0].Neighbour[0] = 70;
                Cells[0].Neighbour[1] = 1;
                Cells[0].Neighbour[2] = 8;
                Cells[0].Neighbour[3] = 70;

                Cells[1].Neighbour[0] = 70;
                Cells[1].Neighbour[1] = 2;
                Cells[1].Neighbour[2] = 9;
                Cells[1].Neighbour[3] = 0;

                Cells[2].Neighbour[0] = 70;
                Cells[2].Neighbour[1] = 3;
                Cells[2].Neighbour[2] = 10;
                Cells[2].Neighbour[3] = 1;

                Cells[3].Neighbour[0] = 70;
                Cells[3].Neighbour[1] = 4;
                Cells[3].Neighbour[2] = 11;
                Cells[3].Neighbour[3] = 2;

                Cells[4].Neighbour[0] = 70;
                Cells[4].Neighbour[1] = 5;
                Cells[4].Neighbour[2] = 12;
                Cells[4].Neighbour[3] = 3;

                Cells[5].Neighbour[0] = 70;
                Cells[5].Neighbour[1] = 6;
                Cells[5].Neighbour[2] = 13;
                Cells[5].Neighbour[3] = 4;

                Cells[6].Neighbour[0] = 70;
                Cells[6].Neighbour[1] = 7;
                Cells[6].Neighbour[2] = 14;
                Cells[6].Neighbour[3] = 5;

                Cells[7].Neighbour[0] = 70;
                Cells[7].Neighbour[1] = 70;
                Cells[7].Neighbour[2] = 15;
                Cells[7].Neighbour[3] = 6;

                Cells[8].Neighbour[0] = 0;
                Cells[8].Neighbour[1] = 9;
                Cells[8].Neighbour[2] = 16;
                Cells[8].Neighbour[3] = 70;

                Cells[9].Neighbour[0] = 1;
                Cells[9].Neighbour[1] = 10;
                Cells[9].Neighbour[2] = 17;
                Cells[9].Neighbour[3] = 8;

                Cells[10].Neighbour[0] = 2;
                Cells[10].Neighbour[1] = 11;
                Cells[10].Neighbour[2] = 18;
                Cells[10].Neighbour[3] = 9;

                Cells[11].Neighbour[0] = 3;
                Cells[11].Neighbour[1] = 12;
                Cells[11].Neighbour[2] = 19;
                Cells[11].Neighbour[3] = 10;

                Cells[12].Neighbour[0] = 4;
                Cells[12].Neighbour[1] = 13;
                Cells[12].Neighbour[2] = 20;
                Cells[12].Neighbour[3] = 11;

                Cells[13].Neighbour[0] = 5;
                Cells[13].Neighbour[1] = 14;
                Cells[13].Neighbour[2] = 21;
                Cells[13].Neighbour[3] = 12;

                Cells[14].Neighbour[0] = 6;
                Cells[14].Neighbour[1] = 15;
                Cells[14].Neighbour[2] = 22;
                Cells[14].Neighbour[3] = 13;

                Cells[15].Neighbour[0] = 7;
                Cells[15].Neighbour[1] = 70;
                Cells[15].Neighbour[2] = 23;
                Cells[15].Neighbour[3] = 14;

                Cells[16].Neighbour[0] = 8;
                Cells[16].Neighbour[1] = 17;
                Cells[16].Neighbour[2] = 24;
                Cells[16].Neighbour[3] = 70;

                Cells[17].Neighbour[0] = 9;
                Cells[17].Neighbour[1] = 18;
                Cells[17].Neighbour[2] = 25;
                Cells[17].Neighbour[3] = 16;

                Cells[18].Neighbour[0] = 10;
                Cells[18].Neighbour[1] = 19;
                Cells[18].Neighbour[2] = 26;
                Cells[18].Neighbour[3] = 17;

                Cells[19].Neighbour[0] = 11;
                Cells[19].Neighbour[1] = 20;
                Cells[19].Neighbour[2] = 27;
                Cells[19].Neighbour[3] = 18;

                Cells[20].Neighbour[0] = 12;
                Cells[20].Neighbour[1] = 21;
                Cells[20].Neighbour[2] = 28;
                Cells[20].Neighbour[3] = 19;

                Cells[21].Neighbour[0] = 13;
                Cells[21].Neighbour[1] = 22;
                Cells[21].Neighbour[2] = 29;
                Cells[21].Neighbour[3] = 20;

                Cells[22].Neighbour[0] = 14;
                Cells[22].Neighbour[1] = 23;
                Cells[22].Neighbour[2] = 30;
                Cells[22].Neighbour[3] = 21;

                Cells[23].Neighbour[0] = 15;
                Cells[23].Neighbour[1] = 70;
                Cells[23].Neighbour[2] = 31;
                Cells[23].Neighbour[3] = 22;

                Cells[24].Neighbour[0] = 16;
                Cells[24].Neighbour[1] = 25;
                Cells[24].Neighbour[2] = 32;
                Cells[24].Neighbour[3] = 70;

                Cells[25].Neighbour[0] = 17;
                Cells[25].Neighbour[1] = 26;
                Cells[25].Neighbour[2] = 33;
                Cells[25].Neighbour[3] = 24;


                Cells[26].Neighbour[0] = 18;
                Cells[26].Neighbour[1] = 27;
                Cells[26].Neighbour[2] = 34;
                Cells[26].Neighbour[3] = 25;

                Cells[27].Neighbour[0] = 19;
                Cells[27].Neighbour[1] = 28;
                Cells[27].Neighbour[2] = 35;
                Cells[27].Neighbour[3] = 26;

                Cells[28].Neighbour[0] = 20;
                Cells[28].Neighbour[1] = 29;
                Cells[28].Neighbour[2] = 36;
                Cells[28].Neighbour[3] = 27;

                Cells[29].Neighbour[0] = 21;
                Cells[29].Neighbour[1] = 30;
                Cells[29].Neighbour[2] = 37;
                Cells[29].Neighbour[3] = 28;

                Cells[30].Neighbour[0] = 22;
                Cells[30].Neighbour[1] = 31;
                Cells[30].Neighbour[2] = 38;
                Cells[30].Neighbour[3] = 29;

                Cells[31].Neighbour[0] = 23;
                Cells[31].Neighbour[1] = 70;
                Cells[31].Neighbour[2] = 39;
                Cells[31].Neighbour[3] = 30;

                Cells[32].Neighbour[0] = 24;
                Cells[32].Neighbour[1] = 33;
                Cells[32].Neighbour[2] = 40;
                Cells[32].Neighbour[3] = 70;

                Cells[33].Neighbour[0] = 25;
                Cells[33].Neighbour[1] = 34;
                Cells[33].Neighbour[2] = 41;
                Cells[33].Neighbour[3] = 32;

                Cells[34].Neighbour[0] = 26;
                Cells[34].Neighbour[1] = 35;
                Cells[34].Neighbour[2] = 42;
                Cells[34].Neighbour[3] = 33;

                Cells[35].Neighbour[0] = 27;
                Cells[35].Neighbour[1] = 36;
                Cells[35].Neighbour[2] = 43;
                Cells[35].Neighbour[3] = 34;

                Cells[36].Neighbour[0] = 28;
                Cells[36].Neighbour[1] = 37;
                Cells[36].Neighbour[2] = 44;
                Cells[36].Neighbour[3] = 35;

                Cells[37].Neighbour[0] = 29;
                Cells[37].Neighbour[1] = 38;
                Cells[37].Neighbour[2] = 45;
                Cells[37].Neighbour[3] = 36;

                Cells[38].Neighbour[0] = 30;
                Cells[38].Neighbour[1] = 39;
                Cells[38].Neighbour[2] = 46;
                Cells[38].Neighbour[3] = 37;

                Cells[39].Neighbour[0] = 31;
                Cells[39].Neighbour[1] = 70;
                Cells[39].Neighbour[2] = 47;
                Cells[39].Neighbour[3] = 38;

                Cells[40].Neighbour[0] = 32;
                Cells[40].Neighbour[1] = 41;
                Cells[40].Neighbour[2] = 48;
                Cells[40].Neighbour[3] = 70;

                Cells[41].Neighbour[0] = 33;
                Cells[41].Neighbour[1] = 42;
                Cells[41].Neighbour[2] = 49;
                Cells[41].Neighbour[3] = 40;

                Cells[42].Neighbour[0] = 34;
                Cells[42].Neighbour[1] = 43;
                Cells[42].Neighbour[2] = 50;
                Cells[42].Neighbour[3] = 41;

                Cells[43].Neighbour[0] = 35;
                Cells[43].Neighbour[1] = 44;
                Cells[43].Neighbour[2] = 51;
                Cells[43].Neighbour[3] = 42;

                Cells[44].Neighbour[0] = 36;
                Cells[44].Neighbour[1] = 45;
                Cells[44].Neighbour[2] = 52;
                Cells[44].Neighbour[3] = 43;

                Cells[45].Neighbour[0] = 37;
                Cells[45].Neighbour[1] = 46;
                Cells[45].Neighbour[2] = 53;
                Cells[45].Neighbour[3] = 44;

                Cells[46].Neighbour[0] = 38;
                Cells[46].Neighbour[1] = 47;
                Cells[46].Neighbour[2] = 54;
                Cells[46].Neighbour[3] = 45;

                Cells[47].Neighbour[0] = 39;
                Cells[47].Neighbour[1] = 70;
                Cells[47].Neighbour[2] = 55;
                Cells[47].Neighbour[3] = 46;

                Cells[48].Neighbour[0] = 40;
                Cells[48].Neighbour[1] = 49;
                Cells[48].Neighbour[2] = 70;
                Cells[48].Neighbour[3] = 70;

                Cells[49].Neighbour[0] = 41;
                Cells[49].Neighbour[1] = 50;
                Cells[49].Neighbour[2] = 70;
                Cells[49].Neighbour[3] = 48;

                Cells[50].Neighbour[0] = 42;
                Cells[50].Neighbour[1] = 51;
                Cells[50].Neighbour[2] = 70;
                Cells[50].Neighbour[3] = 49;

                Cells[51].Neighbour[0] = 43;
                Cells[51].Neighbour[1] = 52;
                Cells[51].Neighbour[2] = 70;
                Cells[51].Neighbour[3] = 50;

                Cells[52].Neighbour[0] = 44;
                Cells[52].Neighbour[1] = 53;
                Cells[52].Neighbour[2] = 70;
                Cells[52].Neighbour[3] = 51;

                Cells[53].Neighbour[0] = 45;
                Cells[53].Neighbour[1] = 54;
                Cells[53].Neighbour[2] = 70;
                Cells[53].Neighbour[3] = 52;

                Cells[54].Neighbour[0] = 46;
                Cells[54].Neighbour[1] = 55;
                Cells[54].Neighbour[2] = 70;
                Cells[54].Neighbour[3] = 53;

                Cells[55].Neighbour[0] = 47;
                Cells[55].Neighbour[1] = 70;
                Cells[55].Neighbour[2] = 70;
                Cells[55].Neighbour[3] = 54;

            }



            for (int r = 0; r <= 55; r++)
            {
                if (r == 1 || r == 2 || r == 3 || r == 4 || r == 5 || r == 6 || r == 8 || r == 15 || r == 16 || r == 23 || r == 24 || r == 31 || r == 32 || r == 39 || r == 40 || r == 47 || r == 49 || r == 50 || r == 51 || r == 52 || r == 53 || r == 54)
                {
                    Cells[r].Neighbours = 3;
                }
            }
            for (int r = 0; r <= 55; r++)
            {
                if (r == 0 || r == 7 || r == 48 || r == 55)
                {
                    Cells[r].Neighbours = 2;
                }
            }
            for (int r = 0; r <= 55; r++)
                if (r == 9 || r == 10 || r == 11 || r == 12 || r == 13 || r == 14 || r == 17 || r == 18 || r == 19 || r == 20 || r == 21 || r == 22 || r == 25 || r == 26 || r == 27 || r == 28 || r == 29 || r == 30 || r == 33 || r == 34 || r == 35 || r == 36 || r == 37 || r == 38 || r == 41 || r == 42 || r == 43 || r == 44 || r == 45 || r == 46)
                {
                    Cells[r].Neighbours = 4;
                }
            for (int r = 0; r <= 55; r++)
            {
                Cells[r].pos = r;
                gr.DrawLine(myPen, Cells[r].xtop, Cells[r].ytop, Cells[r].x2top, Cells[r].y2top);
                gr.DrawLine(myPen, Cells[r].xright, Cells[r].yright, Cells[r].x2right, Cells[r].y2right);
                gr.DrawLine(myPen, Cells[r].xbottom, Cells[r].ybottom, Cells[r].x2bottom, Cells[r].y2bottom);
                gr.DrawLine(myPen, Cells[r].xleft, Cells[r].yleft, Cells[r].x2left, Cells[r].y2left);


            }
            label1.Text = Convert.ToString(Cells[0].Neighbour[0]);
            label2.Text = Convert.ToString(Cells[20].ytop);
            label3.Text = Convert.ToString(Cells[20].x2top);
            label4.Text = Convert.ToString(Cells[20].y2top);


            textBox2.Text = Convert.ToString(Cells[2].GetNeighbour());
            //kiválasztjuk melyik algoritmust szeretnénk futtatni
            int SelectMode = 5;

            int temporary = 0;
            int up = 0;
            int right = 0;
            int down = 0;
            int left = 0;
            int VarElse = 0;
            int LastVisited = 0;
            Cells[0].Visited = true;
            int[] possibility = { };
            var random = new Random();
            int[] tempneighbor;
            bool Visited;
            int current = 0;
            int BinaryTree = 0;

            //for selectmode 5
            int elso = 0;
            int masodik = 0;
            int harmadik = 0;
            int negyedik = 0;
            //70,1,8,70
            //selectmode1 = aldous broder algorithm
            //selectmode2 = hunt and kill
            //selectmode3 = 

            if (SelectMode == 1)
            {
                while (temporary < 55)
                {
                    tempneighbor = Cells[current].Neighbour;
                    if (tempneighbor[0] < 70)
                    {
                        up = tempneighbor[0];
                    }
                    //checks right
                    if (tempneighbor[1] < 70)
                    {
                        right = tempneighbor[1];
                    }
                    //checks bottom
                    if (tempneighbor[2] < 70)
                    {
                        down = tempneighbor[2];
                    }
                    //checks left
                    if (tempneighbor[3] < 70)
                    {
                        left = tempneighbor[3];
                    }
                    //random kiválasztom hova megyünk következőnek
                    int[] selectableInts = new int[4] { up, right, down, left };
                    int randomValue = 0;
                    while (randomValue <= 0)
                    {
                        randomValue = selectableInts[random.Next(0, selectableInts.Length)];
                    }
                    //test
                    label1.Text = Convert.ToString(randomValue);

                    current = randomValue;
                    //rombol 
                    if (Cells[current].Visited == false)
                    {

                        if (Cells[current].pos - 1 == Cells[LastVisited].pos)
                        {
                            //rombol bal
                            gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);

                        }
                        if (Cells[current].pos + 1 == Cells[LastVisited].pos)
                        {
                            //rombol jobb
                            gr.DrawLine(DeletePen, Cells[current].xright, Cells[current].yright, Cells[current].x2right, Cells[current].y2right);

                        }
                        if (Cells[current].pos - 8 == Cells[LastVisited].pos)
                        {
                            //rombol fent
                            gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);

                        }
                        if (Cells[current].pos + 8 == Cells[LastVisited].pos)
                        {
                            //rombol alul

                            gr.DrawLine(DeletePen, Cells[current].xbottom, Cells[current].ybottom, Cells[current].x2bottom, Cells[current].y2bottom);

                        }

                        Cells[current].Visited = true;
                        temporary++;
                    }
                    LastVisited = Cells[current].pos;


                }
            }
            if (SelectMode == 2)
            {

                //algoritmus 2 (hunt and kill)

                Cells[0].Visited = true;
            StartPosition:



                while (temporary < 55)
                {
                    //Thread.Sleep(100);
                    VarElse = 0;
                    up = 0;
                    right = 0;
                    down = 0;
                    left = 0;

                    tempneighbor = Cells[current].Neighbour;

                    if (tempneighbor[0] < 70)
                    {

                        if (Cells[tempneighbor[0]].Visited == false)
                        {
                            up = tempneighbor[0];
                            VarElse++;
                        }
                    }
                    //checks right
                    if (tempneighbor[1] < 70)
                    {

                        if (Cells[tempneighbor[1]].Visited == false)
                        {
                            right = tempneighbor[1];
                            VarElse++;
                        }
                    }
                    //checks bottom
                    if (tempneighbor[2] < 70)
                    {

                        if (Cells[tempneighbor[2]].Visited == false)
                        {
                            down = tempneighbor[2];
                            VarElse++;
                        }
                    }
                    //checks left
                    if (tempneighbor[3] < 70)
                    {

                        if (Cells[tempneighbor[3]].Visited == false)
                        {
                            left = tempneighbor[3];
                            VarElse++;
                        }
                    }

                    if (VarElse == 0)
                    {


                        Console.Write("asd");
                        int HuntVar = 0;
                        int[] HuntSzomszed;


                        //hunt and kill///////////////////////// 



                        while (HuntVar < 55)
                        {
                            HuntSzomszed = Cells[HuntVar].Neighbour;
                            //valid-e
                            if (HuntSzomszed[0] < 70)
                            {
                                //nem visited + terget cell (ami adjascent) az már visited volt-->


                                if (Cells[HuntVar].Visited == false && Cells[HuntSzomszed[0]].Visited == true)
                                {
                                    current = HuntVar;
                                    gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);
                                    Cells[current].Visited = true;
                                    temporary++;
                                    LastVisited = Cells[current].pos;
                                    
                                    goto StartPosition;

                                }
                            }







                            //checks right
                            if (HuntSzomszed[1] < 70)
                            {

                                if (Cells[HuntVar].Visited == false && Cells[HuntSzomszed[1]].Visited == true)
                                {
                                    current = HuntVar;
                                    gr.DrawLine(DeletePen, Cells[current].xright, Cells[current].yright, Cells[current].x2right, Cells[current].y2right);
                                    Cells[current].Visited = true;
                                    temporary++;
                                    LastVisited = Cells[current].pos;
                                    label3.Text = Convert.ToString(69);
                                    goto StartPosition;

                                }
                            }
                            //checks bottom
                            if (HuntSzomszed[2] < 70)
                            {
                                if (Cells[HuntVar].Visited == false && Cells[HuntSzomszed[2]].Visited == true)
                                {
                                    current = HuntVar;
                                    gr.DrawLine(DeletePen, Cells[current].xbottom, Cells[current].ybottom, Cells[current].x2bottom, Cells[current].y2bottom);
                                    Cells[current].Visited = true;
                                    temporary++;
                                    LastVisited = Cells[current].pos;

                                    goto StartPosition;

                                }
                            }
                            //checks left
                            if (HuntSzomszed[3] < 70)
                            {
                                if (Cells[HuntVar].Visited == false && Cells[HuntSzomszed[3]].Visited == true)
                                {
                                    current = HuntVar;
                                    gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);
                                    Cells[current].Visited = true;
                                    temporary++;
                                    LastVisited = Cells[current].pos;

                                    goto StartPosition;

                                }
                            }
                            HuntVar++; //maybe something here?


                        }
                    }
                    else

                    {
                        VarElse = 0;
                    }
                    //random kiválasztom hova megyünk következőnek
                    int[] selectableInts = new int[4] { up, right, down, left };
                    int randomValue = 0;
                    while (randomValue <= 0)
                    {
                        randomValue = selectableInts[random.Next(0, selectableInts.Length)];
                    }
                    //test
                    label1.Text = Convert.ToString(Cells[current].pos);

                    current = randomValue;
                    //rombol 
                    if (Cells[current].Visited == false)
                    {


                        if (Cells[current].pos - 1 == Cells[LastVisited].pos)
                        {
                            //rombol bal
                            gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);

                        }
                        else if (Cells[current].pos + 1 == Cells[LastVisited].pos)
                        {
                            //rombol jobb
                            gr.DrawLine(DeletePen, Cells[current].xright, Cells[current].yright, Cells[current].x2right, Cells[current].y2right);

                        }
                        else if (Cells[current].pos - 8 == Cells[LastVisited].pos)
                        {
                            //rombol fent
                            gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);

                        }
                        else if (Cells[current].pos + 8 == Cells[LastVisited].pos)
                        {
                            //rombol alul

                            gr.DrawLine(DeletePen, Cells[current].xbottom, Cells[current].ybottom, Cells[current].x2bottom, Cells[current].y2bottom);

                        }

                        Cells[current].Visited = true;
                        temporary++;
                    }
                    LastVisited = Cells[current].pos;


                }



            }
            if (SelectMode == 3) //binary tree
            {
                while (temporary < 55)
                {
                    //Thread.Sleep(100);
                    right = 0;
                    down = 0;
                    VarElse = 0;
                    //bias : south, east
                    {
                        tempneighbor = Cells[BinaryTree].Neighbour;

                        //checks right
                        if (tempneighbor[1] < 70)
                        {
                            right = tempneighbor[1];
                            VarElse++;
                        }
                        //checks bottom
                        if (tempneighbor[2] < 70)
                        {
                            down = tempneighbor[2];
                            VarElse++;
                        }
                        if (VarElse == 0)
                        {
                            
                            break;
                        }
                        

                        //random kiválasztom hogy melyiket rombolom le
                        int[] selectableInts = new int[4] { up, right, down, left };
                        int randomValue = 0;
                        while (randomValue <= 0)
                        {
                            randomValue = selectableInts[random.Next(0, selectableInts.Length)];
                        }
                        //test
                        label1.Text = Convert.ToString(randomValue);

                        current = randomValue;
                        //rombol 




                        if (Cells[current].pos - 1 == Cells[BinaryTree].pos)
                        {
                            //rombol bal
                            gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);

                        }

                        if (Cells[current].pos - 8 == Cells[BinaryTree].pos)
                        {
                            //rombol fent
                            gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);

                        }


                        Cells[current].Visited = true;
                        temporary++;
                        label1.Text = Convert.ToString(temporary);

                        BinaryTree++;

                    }
                }
            }
            if (SelectMode == 4)
            {
                while (temporary < 55)
                {
                    tempneighbor = Cells[current].Neighbour;
                    if (tempneighbor[0] < 70)
                    {
                        up = tempneighbor[0];
                    }
                    //checks right
                    if (tempneighbor[1] < 70)
                    {
                        right = tempneighbor[1];
                    }
                    //checks bottom
                    if (tempneighbor[2] < 70)
                    {
                        down = tempneighbor[2];
                    }
                    //checks left
                    if (tempneighbor[3] < 70)
                    {
                        left = tempneighbor[3];
                    }
                    //random kiválasztom hova megyünk következőnek
                    int[] selectableInts = new int[4] { up, right, down, left };
                    int randomValue = 0;
                    while (randomValue <= 0)
                    {
                        randomValue = selectableInts[random.Next(0, selectableInts.Length)];
                    }
                    //test
                    label1.Text = Convert.ToString(randomValue);

                    current = randomValue;
                    //rombol 
                    if (Cells[current].Visited == false)
                    {

                        if (Cells[current].pos - 1 == Cells[LastVisited].pos)
                        {
                            //rombol bal
                            gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);

                        }
                        if (Cells[current].pos + 1 == Cells[LastVisited].pos)
                        {
                            //rombol jobb
                            gr.DrawLine(DeletePen, Cells[current].xright, Cells[current].yright, Cells[current].x2right, Cells[current].y2right);

                        }
                        if (Cells[current].pos - 8 == Cells[LastVisited].pos)
                        {
                            //rombol fent
                            gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);

                        }
                        if (Cells[current].pos + 8 == Cells[LastVisited].pos)
                        {
                            //rombol alul

                            gr.DrawLine(DeletePen, Cells[current].xbottom, Cells[current].ybottom, Cells[current].x2bottom, Cells[current].y2bottom);

                        }

                        Cells[current].Visited = true;
                        temporary++;
                    }
                    LastVisited = Cells[current].pos;


                }
            }
            if (SelectMode == 5)
            {
                while (temporary < 7)
                {
                    //Thread.Sleep(100);
                    right = 0;
                    up = 0;
                    VarElse = 0;
                    //bias : south, east
                    {
                        //binarytree is the pos where you are rn
                        tempneighbor = Cells[BinaryTree].Neighbour;
                        //checks up
                        if (tempneighbor[0] < 70)
                        {
                            up = tempneighbor[0];
                            VarElse++;
                        }
                        //checks right
                        if (tempneighbor[1] < 70)
                        {
                            right = tempneighbor[1];
                            VarElse++;
                        }

                        if (VarElse == 0)
                        {
                            label1.Text = Convert.ToString(69);
                            break;
                        }
                        //checks left

                        //random kiválasztom hova megyünk következőnek
                        int[] selectableInts = new int[4] { up, right, down, left };
                        int randomValue = 0;
                        while (randomValue <= 0)
                        {
                            randomValue = selectableInts[random.Next(0, selectableInts.Length)];
                        }
                        //test


                        current = randomValue;
                        //rombol 




                        if (Cells[current].pos - 1 == Cells[BinaryTree].pos)
                        {
                            //rombol bal
                            gr.DrawLine(DeletePen, Cells[current].xleft, Cells[current].yleft, Cells[current].x2left, Cells[current].y2left);

                        }

                        if (Cells[current].pos - 8 == Cells[BinaryTree].pos)
                        {
                            //rombol fent
                            gr.DrawLine(DeletePen, Cells[current].xtop, Cells[current].ytop, Cells[current].x2top, Cells[current].y2top);

                        }


                        Cells[current].Visited = true;
                        temporary++;
                        label1.Text = Convert.ToString(temporary);

                        BinaryTree++;

                    }
                }

                BinaryTree++;
                int randomchance;

                label3.Text = Convert.ToString(BinaryTree);


                temporary = 0;
                //47
                while (temporary < 46)
                {

                    right = 0;
                    up = 0;
                    VarElse = 0;
                    elso = 0;
                    masodik = 0;
                    harmadik = 0;
                    negyedik = 0;
                    //bias : south, east
                    {
                        //binarytree is the pos where you are rn
                        tempneighbor = Cells[BinaryTree].Neighbour;



                        /////////////////////1
                        if (tempneighbor[1] < 70)
                        {
                            elso = BinaryTree;



                            randomchance = random.Next(100);
                            if (randomchance <= 50)
                            {
                                BinaryTree++;
                                temporary++;
                                tempneighbor = Cells[BinaryTree].Neighbour;
                                goto RombolasPont;

                            }
                            else
                            {
                                gr.DrawLine(DeletePen, Cells[BinaryTree].xright, Cells[BinaryTree].yright, Cells[BinaryTree].x2right, Cells[BinaryTree].y2right);

                            }


                        }
                        else { elso = BinaryTree; }
                        BinaryTree++;
                        temporary++;
                        tempneighbor = Cells[BinaryTree].Neighbour;
                        /////////////////////2
                        if (tempneighbor[1] < 70)
                        {
                            masodik = BinaryTree;


                            randomchance = random.Next(100);
                            if (randomchance <= 50)
                            {
                                BinaryTree++;
                                temporary++;
                                tempneighbor = Cells[BinaryTree].Neighbour;
                                goto RombolasPont;

                            }
                            else
                            {
                                gr.DrawLine(DeletePen, Cells[BinaryTree].xright, Cells[BinaryTree].yright, Cells[BinaryTree].x2right, Cells[BinaryTree].y2right);

                            }
                        }
                        else { masodik = BinaryTree; }
                        BinaryTree++;
                        temporary++;
                        tempneighbor = Cells[BinaryTree].Neighbour;
                        /////////////////////3
                        ///

                        if (tempneighbor[1] < 70)
                        {
                            harmadik = BinaryTree;


                            randomchance = random.Next(100);
                            if (randomchance <= 50)
                            {
                                BinaryTree++;
                                temporary++;
                                tempneighbor = Cells[BinaryTree].Neighbour;
                                goto RombolasPont;

                            }
                            else
                            {
                                gr.DrawLine(DeletePen, Cells[BinaryTree].xright, Cells[BinaryTree].yright, Cells[BinaryTree].x2right, Cells[BinaryTree].y2right);

                            }
                        }
                        else { harmadik = BinaryTree; }
                        BinaryTree++;
                        temporary++;

                        tempneighbor = Cells[BinaryTree].Neighbour;
                        /////////////////////4
                        if (tempneighbor[1] < 70)
                        {
                            negyedik = BinaryTree;


                            randomchance = random.Next(100);
                            if (randomchance <= 50)
                            {
                                BinaryTree++;
                                temporary++;
                                tempneighbor = Cells[BinaryTree].Neighbour;
                                goto RombolasPont;

                            }
                            else
                            {
                                gr.DrawLine(DeletePen, Cells[BinaryTree].xright, Cells[BinaryTree].yright, Cells[BinaryTree].x2right, Cells[BinaryTree].y2right);

                            }
                        }
                        else { negyedik = BinaryTree; }
                        BinaryTree++;
                        temporary++;

                    //checks left
                    //random valasztok jeloltet

                    RombolasPont:
                        int randomMarked = 0;
                        int[] MarkedInt = new int[4] { elso, masodik, harmadik, negyedik };
                        while (randomMarked <= 0)
                        {
                            randomMarked = MarkedInt[random.Next(0, MarkedInt.Length)];
                        }
                        //rombol fent
                        gr.DrawLine(DeletePen, Cells[randomMarked].xtop, Cells[randomMarked].ytop, Cells[randomMarked].x2top, Cells[randomMarked].y2top);










                    }

                }
                label1.Text = Convert.ToString(BinaryTree);
            }
            //test
            //label1.Text = Convert.ToString(up);
            //label2.Text = Convert.ToString(right);
            //label3.Text = Convert.ToString(down);
            //label4.Text = Convert.ToString(left);

        }

        void visit(int[] p)
        {

        }
        void button1_Click_1(object sender, EventArgs e)
        {




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

