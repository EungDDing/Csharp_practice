using System;
using System.IO;
using System.Windows.Forms;

class Sample
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        fm.Width = 300;     // width는 오브젝트의 너비
        fm.Height = 200;    // height는 오브젝트의 높이

        Label lb = new Label();
        lb.Text = "안녕하세요";

        // form의 중앙에 label 배치
        lb.Top = (fm.Height - lb.Height) / 2;   // Top은 오브젝트의 위 공간의 길이
        lb.Left = (fm.Width - lb.Width) / 2;    // Left는 오브젝트의 왼쪽 공간의 길이 

        lb.Parent = fm;

        Label lb1 = new Label();
        Label lb2 = new Label();

        lb1.Text = "Hello";
        lb2.Text = "Good Bye";

        lb2.Left = lb2.Width + 100;

        lb1.Parent = fm;
        lb2.Parent = fm;

        Application.Run(fm);
    }    
}
