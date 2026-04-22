using System.Windows.Forms;
class Form1 : Form
{
    TextBox tb1 = new TextBox(), tb2 = new TextBox();
    Button add = new Button(), sub = new Button(), mul = new Button(), div = new Button();
    Label lbl = new Label();
    Form1()
    {
        tb1.Location = new System.Drawing.Point(20, 30);
        tb1.Size = new System.Drawing.Size(80, 20);
        tb2.Location = new System.Drawing.Point(110, 30);
        tb2.Size = new System.Drawing.Size(80, 20) 
        void Calc(string op)
        {
            double a = double.Parse(tb1.Text);
            double b = double.Parse(tb2.Text);
            double r = op == "+" ? a + b : op == "-" ? a - b : op == "*" ? a * b : a / b;
            lbl.Text = r.ToString();
        }   
        add.Text = "+"; add.Location = new System.Drawing.Point(20, 70);
        add.Click += (s, e) => Calc("+");
        sub.Text = "-"; sub.Location = new System.Drawing.Point(60, 70);
        sub.Click += (s, e) => Calc("-");
        mul.Text = "*"; mul.Location = new System.Drawing.Point(100, 70);
        mul.Click += (s, e) => Calc("*");
        div.Text = "/"; div.Location = new System.Drawing.Point(140, 70);
        div.Click += (s, e) => Calc("/"); 
        lbl.Location = new System.Drawing.Point(20, 110);
        lbl.Size = new System.Drawing.Size(150, 30);   
        Controls.Add(tb1);
        Controls.Add(tb2);
        Controls.Add(add);
        Controls.Add(sub);
        Controls.Add(mul);
        Controls.Add(div);
        Controls.Add(lbl);
    }
    static void Main() => Application.Run(new Form1());
}
