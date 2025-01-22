using System;
using System.Windows.Forms;
using System.Drawing;

class Practice
{
    public static void Main()
    {
        Form fm;

        fm = new Form();

        fm.Text = "어서 오세요 C#으로";

        Label lb = new Label(); // 라벨 작성
        lb.Width = 150;         // 라벨의 가로 크기 설정

        lb.Text = "C#을 시작합니다."; // 라벨의 텍스트를 설정
        lb.Parent = fm;              // 지정한 라벨을 지정한 폼 위에 올림 (라벨과 폼 간의 관계 설정)

        PictureBox pb = new PictureBox();           // 이미지를 읽어 들이는 픽쳐박스 생성
        pb.Image = Image.FromFile("C:\\car.bmp");   // 이미지를 읽어 들임
        pb.Top = 25;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
