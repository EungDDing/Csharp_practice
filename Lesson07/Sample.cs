using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

// 모달리스(Modaless)
class Sample12 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample12());
    }
    public Sample12()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        ExtraForm sf = new ExtraForm();
        sf.Show(); // 새로운 폼을 모달리스로 표시
    }
}

// 새로운 폼 정의
class ExtraForm : Form
{
    public ExtraForm()
    {
        Label lb = new Label();
        Button bt = new Button();

        this.Text = "신규";
        this.Width = 250;
        this.Height = 200;

        lb.Text = "새로운 가게 시작했습니다";
        lb.Dock = DockStyle.Top;

        bt.Text = "OK";
        bt.DialogResult = DialogResult.OK;
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        this.Close();
    }
}

// 모달(Modal)
class Sample11 : Form
{
    private Label lb;
    private Button bt;

    public Sample11()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sf = new SampleForm();
        sf.ShowDialog(); // 새로운 폼을 모달로 표시
    }
}

// 새로운 폼 정의
class SampleForm : Form 
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();

        this.Text = "사례";
        this.Width = 250;
        this.Height = 200;

        lb.Text = "감사합니다";
        lb.Dock = DockStyle.Top;

        bt.Text = "OK";
        bt.DialogResult = DialogResult.OK;
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;
    }
}

// 다이얼로그(대화상자) 
class Sample10 : Form
{
    private Label lb;
    private Button bt;

    public Sample10()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("정말로 구입하시나요?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 메시지 박스 표시 (텍스트, 제목, 버튼 유형, 메시지 박스 아이콘)

        if (dr == DialogResult.Yes)
        {
            MessageBox.Show("구입해주셔서 감사합니다", "구입", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
// 메뉴
class Sample9 : Form
{
    private Label lb;
    private MenuStrip ms;
    private ToolStripMenuItem[] mi = new ToolStripMenuItem[10];

    public Sample9()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Bottom;

        ms = new MenuStrip(); // 메인 메뉴
        // 메뉴 항목 작성
        mi[0] = new ToolStripMenuItem("메인1");
        mi[1] = new ToolStripMenuItem("메인2");
        mi[2] = new ToolStripMenuItem("서브1");
        mi[3] = new ToolStripMenuItem("서브2");
        mi[4] = new ToolStripMenuItem("승용차");
        mi[5] = new ToolStripMenuItem("트럭");
        mi[6] = new ToolStripMenuItem("오픈카");
        mi[7] = new ToolStripMenuItem("택시");
        mi[8] = new ToolStripMenuItem("스포츠카");
        mi[9] = new ToolStripMenuItem("미니카");

        // 드롭다운 항목 설정
        mi[0].DropDownItems.Add(mi[4]);
        mi[0].DropDownItems.Add(mi[5]);

        mi[1].DropDownItems.Add(mi[2]);
        mi[1].DropDownItems.Add(new ToolStripSeparator()); // 세퍼레이터(칸막이)
        mi[1].DropDownItems.Add(mi[3]);
        mi[2].DropDownItems.Add(mi[6]);
        mi[2].DropDownItems.Add(mi[7]);
        mi[3].DropDownItems.Add(mi[8]);
        mi[3].DropDownItems.Add(mi[9]);

        // 가장 위의 메뉴 설정(보이는 메뉴 설정)
        ms.Items.Add(mi[0]);
        ms.Items.Add(mi[1]);

        this.MainMenuStrip = ms;

        ms.Parent = this;
        lb.Parent = this;

        for (int i = 4; i < mi.Length; i++)
        {
            mi[i].Click += new EventHandler(mi_Click);
        }
    }
    public void mi_Click(Object sender, EventArgs e)
    {
        ToolStripMenuItem mi = (ToolStripMenuItem)sender;
        lb.Text = mi.Text + "입니다";
    }
}
// 리스트 박스
class Sample8 : Form
{
    private Label lb;
    private ListBox lbx;

    public Sample8()
    {
        string[] str = {"승용차", "트럭", "오픈카",
                        "택시", "스포트카" , "미니카",
                        "자동차", "이륜차", "바이크",
                        "비행기", "헬리콥터", "로켓"
                        };

        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        lbx = new ListBox();

        for (int i = 0; i < str.Length; i++)
        {
            lbx.Items.Add(str[i]); // 리스트 박스에 아이템 추가 
        }
        lbx.Top = lb.Bottom;

        lb.Parent = this;
        lbx.Parent = this;

        lbx.SelectedIndexChanged += new EventHandler(lbx_SelectIndexChanged);
    }
    public void lbx_SelectIndexChanged(Object sender, EventArgs e)
    {
        ListBox tmp = (ListBox)sender;

        lb.Text = tmp.Text + "을(를) 선택했습니다";
    }
}

// 텍스트 박스
class Sample7 : Form
{
    private Label lb;
    private TextBox tb;

    public Sample7()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        tb = new TextBox();
        tb.Dock = DockStyle.Bottom;

        lb.Parent = this;
        tb.Parent = this;

        tb.KeyDown += new KeyEventHandler(tb_KeyDown);
    }
    public void tb_KeyDown(Object sender, KeyEventArgs e)
    {
        TextBox tmp = (TextBox)sender;
        if (e.KeyCode == Keys.Enter)
        {
            lb.Text = tmp.Text + "을(를) 선택했습니다";
        }
    }
}


// 라디오 버튼
class Sample6 : Form
{
    private Label lb;
    private RadioButton rb1;
    private RadioButton rb2;
    private GroupBox gb;

    public Sample6()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        rb1 = new RadioButton();
        rb2 = new RadioButton();

        rb1.Text = "자동차";
        rb2.Text = "트럭";
        rb1.Checked = true;

        rb1.Dock = DockStyle.Left;
        rb2.Dock = DockStyle.Right;

        gb = new GroupBox();
        gb.Text = "종류";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;

        lb.Parent = this;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
    }
    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;
        lb.Text = tmp.Text + "을(를) 선택했습니다";
    }
}

// 체크 박스
class Sample5 : Form
{
    private Label lb;
    private CheckBox cb1;
    private CheckBox cb2;
    private FlowLayoutPanel flp;

    public Sample5()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        cb1 = new CheckBox();
        cb2 = new CheckBox();

        cb1.Text = "자동차";
        cb2.Text = "트럭";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;

        cb1.Parent = flp;
        cb2.Parent = flp;

        lb.Parent = this;
        flp.Parent = this;

        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);
        cb2.CheckedChanged += new EventHandler(cb_CheckedChanged);
    }
    public void cb_CheckedChanged(Object sender, EventArgs e)
    {
        CheckBox tmp = (CheckBox)sender; // Object 클래스의 오브젝트를 CheckBox 클래스로 형 변환
        if (tmp.Checked == true)
        {
            lb.Text = tmp.Text + "을(를) 선택했습니다"; 
        }
        else if (tmp.Checked == false)
        {
            lb.Text = tmp.Text + "을(를) 해제했습니다";
        }
    }
}


//
class Sample4 : Form
{
    private Label lb;
    private Button bt;

    public Sample4()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 100;

        lb = new Label();
        lb.Text = "어서오세요";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "구입";
        bt.Dock = DockStyle.Bottom;

        bt.Click += new EventHandler(bt_Click);

        lb.Parent = this;
        bt.Parent = this;
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "구입해주셔서 감사합니다";
        bt.Enabled = false; // 버튼 비활성화
    }
}

// 라벨
class Sample3 : Form
{
    private Label[] lb = new Label[3];
    private TableLayoutPanel tlp;

    public Sample3()
    {
        this.Text = "샘플";
        this.Width = 250;
        this.Height = 200;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;
        tlp.ColumnCount = 1;
        tlp.RowCount = 3;

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Text = $"This is Car";
            lb[i].Width = 200;
        }

        // 라벨의 전경색(글자색) 설정 
        lb[0].ForeColor = Color.Red;
        lb[1].ForeColor = Color.Black;
        lb[2].ForeColor = Color.Blue;

        // 라벨의 배경색 설정
        lb[0].BackColor = Color.White;
        lb[1].BackColor = Color.Gray;
        lb[2].BackColor = Color.Yellow;

        // 글자의 위치 정렬 설정
        lb[0].TextAlign = ContentAlignment.TopLeft;
        lb[1].TextAlign = ContentAlignment.MiddleCenter;
        lb[2].TextAlign = ContentAlignment.BottomRight;

        // 경계선 설정
        lb[0].BorderStyle = BorderStyle.None;
        lb[1].BorderStyle = BorderStyle.FixedSingle;
        lb[2].BorderStyle = BorderStyle.Fixed3D;

        // 폰트 설정
        lb[0].Font = new Font("Arial", 12, FontStyle.Bold);
        lb[1].Font = new Font("Times New Roman", 12, FontStyle.Underline);
        lb[2].Font = new Font("Courier New", 12, FontStyle.Strikeout);

        for (int i = 0; i < lb.Length; i++)
        {
            lb[i].Parent = tlp;
        }

        tlp.Parent = this;
    }
}


// 테이블 레이아웃 패널
class Sample2 : Form
{
    private Button[] bt = new Button[6];
    private TableLayoutPanel tlp;

    public Sample2()
    {
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        tlp = new TableLayoutPanel(); // 플로우 레이아웃 패널을 작성
        tlp.Dock = DockStyle.Fill;
        tlp.ColumnCount = 3; // 테이블 레이아웃 패널의 열 설정
        tlp.RowCount = 2; // 테이블 레이아웃 패널의 행 설정

        for (int i = 0; i < bt.Length; i++)
        {
            // 패널에 버튼 추가
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i); // 정수를 문자열로 반환
            bt[i].Parent = tlp;
        }

        tlp.Parent = this;
    }
}

// 플로우 레이아웃 패널
class Sample1 : Form
{
    private Button[] bt = new Button[6];
    private FlowLayoutPanel flp;

    public Sample1()
    {
        this.Text = "샘플";
        this.Width = 600;
        this.Height = 100;

        flp = new FlowLayoutPanel(); // 플로우 레이아웃 패널을 작성
        flp.Dock = DockStyle.Fill;

        for (int i = 0; i < bt.Length; i++) 
        {
            // 패널에 버튼 추가
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i); // 정수를 문자열로 반환
            bt[i].Parent = flp;
        }

        flp.Parent = this;
    }
}