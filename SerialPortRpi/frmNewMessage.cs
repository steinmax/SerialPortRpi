using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortRpi
{
    public partial class frmNewMessage : Form
    {
	    private bool caps = false;
	    private bool shift = false;
	    public string text;
	    public bool vaild;
        public frmNewMessage()
        {
            InitializeComponent();
        }

        private void Write(string s)
		{
			this.textBox1.AppendText(s);
			if (!caps)
				shift = false;
		}
	    


		#region Keys
        private void keybackspace_Click(object sender, EventArgs e)
        {
	        this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
        }
		private void Shift(object sender, EventArgs e)
		{
			shift = !shift;
		}
		private void key1_Click(object sender, EventArgs e)
		{
			Write(shift ? "!" : "1");
		}

		private void key2_Click(object sender, EventArgs e)
		{
			Write(shift ? "\"" : "2");
		}

		private void key3_Click(object sender, EventArgs e)
		{
			Write(shift ? "§" : "3");
		}

		private void key4_Click(object sender, EventArgs e)
		{
			Write(shift ? "$" : "4");
		}

		private void key5_Click(object sender, EventArgs e)
		{
			Write(shift ? "%" : "5");
		}

		private void key6_Click(object sender, EventArgs e)
		{
			Write(shift ? "&" : "6");
		}

		private void key7_Click(object sender, EventArgs e)
		{
			Write(shift ? "/" : "7");
		}

		private void key8_Click(object sender, EventArgs e)
		{
			Write(shift ? "(" : "8");
		}

		private void key9_Click(object sender, EventArgs e)
		{
			Write(shift ? ")" : "9");
		}

		private void key0_Click(object sender, EventArgs e)
		{
			Write(shift ? "=" : "0");
		}

		private void keybackslash_Click(object sender, EventArgs e)
		{
			Write(shift ? "?" : "\\");
		}

		private void keyq_Click(object sender, EventArgs e)
		{
			Write(shift ? "Q" : "q");
		}

		private void keyw_Click(object sender, EventArgs e)
		{
			Write(shift ? "W" : "w");
		}

		private void keye_Click(object sender, EventArgs e)
		{
			Write(shift ? "E" : "e");
		}

		private void keyr_Click(object sender, EventArgs e)
		{
			Write(shift ? "R" : "r");
		}

		private void keyt_Click(object sender, EventArgs e)
		{
			Write(shift ? "T" : "t");
		}

		private void keyz_Click(object sender, EventArgs e)
		{
			Write(shift ? "Z" : "z");
		}

		private void keyu_Click(object sender, EventArgs e)
		{
			Write(shift ? "U" : "u");
		}

		private void keyi_Click(object sender, EventArgs e)
		{
			Write(shift ? "I" : "i");
		}

		private void keyo_Click(object sender, EventArgs e)
		{
			Write(shift ? "O" : "o");
		}

		private void keyp_Click(object sender, EventArgs e)
		{
			Write(shift ? "P" : "p");
		}

		private void keya_Click(object sender, EventArgs e)
		{
			Write(shift ? "A" : "a");
		}

		private void keys_Click(object sender, EventArgs e)
		{
			Write(shift ? "S" : "s");
		}

		private void keyd_Click(object sender, EventArgs e)
		{
			Write(shift ? "D" : "d");
		}

		private void keyf_Click(object sender, EventArgs e)
		{
			Write(shift ? "F" : "f");
		}

		private void keyg_Click(object sender, EventArgs e)
		{
			Write(shift ? "G" : "g");
		}

		private void keyh_Click(object sender, EventArgs e)
		{
			Write(shift ? "H" : "h");
		}

		private void keyj_Click(object sender, EventArgs e)
		{
			Write(shift ? "J" : "j");
		}

		private void keyk_Click(object sender, EventArgs e)
		{
			Write(shift ? "K" : "k");
		}

		private void keyl_Click(object sender, EventArgs e)
		{
			Write(shift ? "L" : "l");
		}

		private void keygreaterthan_Click(object sender, EventArgs e)
		{
			Write(shift ? ">" : "<");
		}

		private void keyy_Click(object sender, EventArgs e)
		{
			Write(shift ? "Y" : "y");
		}

		private void keyx_Click(object sender, EventArgs e)
		{
			Write(shift ? "X" : "x");
		}

		private void keyc_Click(object sender, EventArgs e)
		{
			Write(shift ? "C" : "c");
		}

		private void keyv_Click(object sender, EventArgs e)
		{
			Write(shift ? "V" : "v");
		}

		private void keyb_Click(object sender, EventArgs e)
		{
			Write(shift ? "B" : "b");
		}

		private void keyn_Click(object sender, EventArgs e)
		{
			Write(shift ? "N" : "n");
		}

		private void keym_Click(object sender, EventArgs e)
		{
			Write(shift ? "M" : "m");
		}

		private void keycomma_Click(object sender, EventArgs e)
		{
			Write(shift ? ";" : ",");
		}

		private void keydot_Click(object sender, EventArgs e)
		{
			Write(shift ? ":" : ".");
		}

		private void keydash_Click(object sender, EventArgs e)
		{
			Write(shift ? "_" : "-");
		}

		private void keyspace_Click(object sender, EventArgs e)
		{
			Write(" ");
		}

		private void keyplus_Click(object sender, EventArgs e)
		{
			Write(shift ? "*" : "+");
		}

		private void keysquarebracket_Click(object sender, EventArgs e)
		{
			Write(shift ? "]" : "[");
		}

		private void keycurvedbracket_Click(object sender, EventArgs e)
		{
			Write(shift ? "}" : "{");
		}

		private void keyhash_Click(object sender, EventArgs e)
		{
			Write(shift ? "'" : "#");
		}
		private void keytab_Click(object sender, EventArgs e)
		{
			Write("\t");
		}
		private void keytilde_Click(object sender, EventArgs e)
		{
			Write("~");
		}
		private void keyEsc_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		private void keyenter_Click(object sender, EventArgs e)
		{
			text = this.textBox1.Text;
			vaild = true;
			this.Close();
		}

		private void Caps(object sender, EventArgs e)
		{
			caps = !caps;
			shift = caps;
		}
	}
}
