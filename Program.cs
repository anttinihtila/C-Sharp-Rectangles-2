using System;
using System.Windows.Forms;
using System.Drawing;
public class Solidbru : Form
{
    public Solidbru()
    {
        this.Text = "Colors";
        this.Paint += new PaintEventHandler(Fill_Graph);
        this.Size = new Size(1200, 800);
    }
    public void Fill_Graph(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        //Creates a SolidBrush and fills the rectangle  
        SolidBrush sb = new SolidBrush(Color.Violet);
        SolidBrush sb2 = new SolidBrush(Color.Blue);
        SolidBrush sb3 = new SolidBrush(Color.Green);
        SolidBrush sb4 = new SolidBrush(Color.Yellow);
        SolidBrush sb5 = new SolidBrush(Color.Orange);
        SolidBrush sb6 = new SolidBrush(Color.Red);

        g.FillRectangle(sb, 50, 50, 150, 150);
        g.FillRectangle(sb2, 150, 150, 250, 250);
        g.FillRectangle(sb3, 250, 250, 350, 350);
        g.FillRectangle(sb4, 350, 350, 450, 450);
        g.FillRectangle(sb5, 450, 450, 550, 550);
        g.FillRectangle(sb6, 550, 550, 650, 650);

    }
    public static void Main()
    {
        Application.Run(new Solidbru());
    }
    // End of class  
}