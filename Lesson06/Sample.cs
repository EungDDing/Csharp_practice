using System;
using System.Security.Policy;
using System.Windows.Forms;

class Sample : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample());
    }
    public Sample()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";

        lb.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);
        this.MouseLeave += new EventHandler(fm_MouseLeave);
    }
    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb.Text = "안녕하세요";
    }
    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb.Text = "안녕히 가세요";
    }
}

/* 키보드 입력 이벤트 처리
class Sample : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample());
    }
    public Sample()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb1 = new Label();
        lb1.Text = "방향키로 선택하세요";
        lb1.Width = this.Width;

        lb2 = new Label();
        lb2.Top = lb1.Bottom;

        lb1.Parent = this;
        lb2.Parent = this;

        this.KeyDown += new KeyEventHandler(fm_KeyDown);
    }
    public void fm_KeyDown(Object sender, KeyEventArgs e) // 키가 눌렸을 때에 이 이벤트 핸들러가 호출됨
    {
        String str;
        if (e.KeyCode == Keys.Up)
        {
            str = "위쪽";
        }
        else if (e.KeyCode == Keys.Down)
        {
            str = "아래쪽";
        }
        else if (e.KeyCode == Keys.Left)
        {
            str = "왼쪽";
        }
        else if (e.KeyCode == Keys.Right)
        {
            str = "오른쪽";
        }
        else
        {
            str = "다른 키";
        }
        lb2.Text = $"{str} 입니다";
    }
}
*/

/* 버튼 이벤트 처리
class Sample : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample());
    }
    public Sample()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Width = 150;

        bt = new Button();
        bt.Text = "구입";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "고맙습니다";
    }
}
*/

/* 이벤트 처리
class Sample : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample());        
    }
    public Sample()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";

        lb.Parent = this;

        this.Click += new EventHandler(fm_Click); // 이벤트 핸들러 등록
    }
    public void fm_Click(Object sender, EventArgs e) // 이벤트 핸들러 설계
    {
        lb.Text = "안녕하세요";
    }
}
*/