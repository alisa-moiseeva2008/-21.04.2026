using System.Windows.Forms;
class Form1 : Form
{
    TextBox tb = new TextBox();
    Button toF = new Button(), toC = new Button();
    Label lbl = new Label();
    Form1()
    {
        tb.Location = new System.Drawing.Point(20, 30);
        toF.Text = "→ °F";
        toF.Location = new System.Drawing.Point(20, 70);
        toF.Click += (s, e) => {
            double c = double.Parse(tb.Text);
            lbl.Text = (c * 9 / 5 + 32) + " °F";
        };
        toC.Text = "→ °C";
        toC.Location = new System.Drawing.Point(100, 70);
        toC.Click += (s, e) => {
            double f = double.Parse(tb.Text);
            lbl.Text = ((f - 32) * 5 / 9) + " °C";
        };
        lbl.Location = new System.Drawing.Point(20, 110);
        lbl.Size = new System.Drawing.Size(150, 30);   
        Controls.Add(tb);
        Controls.Add(toF);
        Controls.Add(toC);
        Controls.Add(lbl);
    }
    static void Main() => Application.Run(new Form1());
}
