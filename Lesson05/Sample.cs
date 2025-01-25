using System;
using System.Windows.Forms;
using System.Drawing;

class Sample
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 300;

        PictureBox[] pb = new PictureBox[2]; // 객체 배열 선언
        Label lb = new Label();
        
        for (int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox(); // 객체 초기화
            pb[i].Parent = fm;
        }

        Car[] c = new Car[2];

        c[0] = new Car();
        c[1] = new RacingCar();

        for (int i = 0; i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].GetImage();
            // 프로퍼티를 통해서 필드에 접근
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }

        lb.Width = 170;
        lb.Top = 200;
        lb.Text = Car.CountCar();
        lb.Parent = fm;

        Application.Run(fm);
    }
}

class Car
{
    private Image img;
    protected int top;
    protected int left;
    public static int count = 0;
    public Car()
    {
        count++;
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    virtual public void Move() // 덮어 써지는 기본 클래스의 멤버의 virtual을 붙임
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
    }
    public int Top // 프로퍼티(property)
    {
        set { top = value; }
        get { return top; }
    }
    public int Left
    {
        set { left = value; }
        get { return left; }
    }
    public static string CountCar()
    {
        return $"자동차는 {count}대 있습니다.";
    }
}

class RacingCar : Car
{
    public override void Move()
    {
        top = top + 100;
        left = left + 100;
    }
}

/*
class Sample : Form // Form을 확장한 클래스
{
    public static void Main() 
    {
        Application.Run(new Sample()); // 클래스로부터 오브젝트를 작성해서 윈도우 프로그램을 실행
    }
    public Sample() // 생성자
    {
        this.Text = "샘플"
        this.Width = 400;
        this.Height = 200;
        this.BackgroundImage = Image.FromFile("c:\\car.bmp");
    }
}
*/


