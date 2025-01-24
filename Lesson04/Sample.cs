using System;
using System.Diagnostics;
using System.Windows.Forms;

class Sample
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250;
        fm.Height = 100;

        string[][] str = new string[4][]
        {
            new string[] { "서울", "Seoul", "한양" },
            new string[] { "대전", "Daejeon", "大田", "한밭" },
            new string[] { "대구", "Daegu", "大邱", "대구벌" },
            new string[] { "부산", "Busan", "釜山", "동래" }
        };

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        string tmp = "";

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                tmp += str[i][j];
                tmp += "  ";
            }
            tmp += "\n";
        }

        lb.Text = tmp;
        lb.Parent = fm;

        Application.Run(fm);
    }
}