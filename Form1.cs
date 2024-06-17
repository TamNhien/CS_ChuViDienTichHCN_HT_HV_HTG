using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ChuViDienTichHCN_HT_HV_HTG
{
    public partial class Form1 : Form
    {
        int a, b, c, d, r;
        float x, y, z;
        double P, S, C;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCV.ResetText();
            txtChuViHT.ResetText();
            txtChuViHCN.ResetText();
            txtChiViHTG.ResetText();
            txtDT.ResetText();
            txtDienTichHT.ResetText();
            txtDienTichHCN.ResetText();
            txtDienTichHTG.ResetText();
            txtLoaiTG.ResetText();
            txtCanh.ResetText();
            txtR.ResetText();
            txtA.ResetText();
            txtB.ResetText();
            txt1.ResetText();
            txt2.ResetText();
            txt3.ResetText();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (rdoHV.Checked)
            {
                d = Convert.ToInt32(txtCanh.Text);
                txtCV.Text = Convert.ToString(d * 4);
                txtDT.Text = Convert.ToString(d * d);
            }
            if (rdoHT.Checked)
            {
                r = Convert.ToInt32(txtR.Text);
                txtChuViHT.Text = Convert.ToString(2 * Math.PI * r);
                txtDienTichHT.Text = Convert.ToString(Math.PI * r * r);
            }
            if (rdoHCN.Checked)
            {
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);
                txtChuViHCN.Text = Convert.ToString((a + b) * 2);
                txtDienTichHCN.Text = Convert.ToString(a * b);
            }
            if (rdoHTG.Checked)
            {
                float a = float.Parse(txt1.Text);
                float b = float.Parse(txt2.Text);
                float c = float.Parse(txt3.Text);

                x = a * a;
                y = b * b;
                z = c * c;

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (x == y && y == z && x == z)
                    {
                        if (x == y && y == z)
                            txtLoaiTG.Text = "Tam giác đều";
                        else
                        {
                            if (x == y + z || y == x + z || x == y + z)
                                txtLoaiTG.Text = "Tam giác vuông cân";
                            else
                                txtLoaiTG.Text = "Tam giác cân";
                        }
                    }
                    else
                    {
                        if (x == y + z || y == x + z || x == y + z)
                            txtLoaiTG.Text = "Tam giác vuông";
                        else
                            txtLoaiTG.Text = "Tam giác thường";
                    }
                    P = a + b + c;
                    C = P / 2;
                    S = Math.Sqrt(C * (C - a) * (C - b) * (C - c));

                    txtChiViHTG.Text = Convert.ToString(P);
                    txtDienTichHTG.Text = Convert.ToString(S);
                }
                else
                    txtLoaiTG.Text = ("Ba cạnh không tạo thành tam giác");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbHCN.Visible = false;
            gbHTG.Visible = false;
            gbHT.Visible = false;
            gbHV.Visible = false; ;
        }

        private void rdoHV_CheckedChanged(object sender, EventArgs e)
        {
            gbHCN.Visible = false;
            gbHTG.Visible = false;
            gbHT.Visible = false;
            gbHV.Visible = true;
        }

        private void rdoHT_CheckedChanged(object sender, EventArgs e)
        {
            gbHCN.Visible = false;
            gbHTG.Visible = false;
            gbHT.Visible = true;
            gbHV.Visible = false;
        }

        private void rdoHCN_CheckedChanged(object sender, EventArgs e)
        {
            gbHCN.Visible = true;
            gbHTG.Visible = false;
            gbHT.Visible = false;
            gbHV.Visible = false;
        }

        private void rdoHTG_CheckedChanged(object sender, EventArgs e)
        {
            gbHCN.Visible = false;
            gbHTG.Visible = true;
            gbHT.Visible = false;
            gbHV.Visible = false;
        }
    }
}
