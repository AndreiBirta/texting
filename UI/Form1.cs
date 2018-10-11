using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using texting;

namespace UI
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();
        public Form1()
        {
            InitializeComponent();
            //hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hook_KeyPressed);
            //// register the control + alt + F12 combination as hot key.
            //hook.RegisterHotKey(UI.ModifierKeys.Control, Keys.C);
        }

        private void Copy_btn_Click(object sender, EventArgs e)
        {
            string text = paste_txtbox.Text;
            if (text != null && text != "")
                Clipboard.SetText(text);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            string text = copy_txtbox.Text;
            if (text != null && text != "")
                paste_txtbox.Text = Programsss.GetText(copy_txtbox.Text.Trim());
        }

        private void Paste_txtbox_MouseDown(object sender, MouseEventArgs e)
        {
            string text = paste_txtbox.Text;
            if (text != null && text != "")
            {
                Clipboard.SetText(text);
                Bot.LeftMouseClick(125, 375);
                Bot.LeftMouseClick(700, 700);
            }
        }

        private void Copy_txtbox_TextChanged(object sender, EventArgs e)
        {
            Next_btn_Click(sender, e);
            //Bot.LeftMouseClick(125,375);
            //Bot.LeftMouseClick(Bot.xPos, Bot.yPos + 50);
        }

        void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            //Bot.rememberMousePos();
            //Bot.LeftMouseClick(100,300);
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Dispose();
        }

        private void copy_txtbox_MouseDown(object sender, MouseEventArgs e)
        {
            //Task.Delay(500);
            //copy_txtbox.Text = Clipboard.GetText();
        }
        
    }
}
