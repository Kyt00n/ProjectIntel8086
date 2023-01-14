using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public int SP = 0;
        public Stack myStack = new Stack();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Command_SelectedValueChanged(object sender, EventArgs e)
        {
            //string command = this.Command.SelectedItem.ToString();
            //return command;
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
  
            
            string command = this.Command.SelectedItem.ToString();
            string op1 = this.Operand1.SelectedItem.ToString();
            if(command =="MOV" || command == "XCHG")
            {
                
                
            }            
            
            
            






            switch (command)
            {
                case "MOV":
                    string op2 = this.Operand2.SelectedItem.ToString();
                    if (op1 == "AX" && op2 == "AX")
                    {
                        this.AXREG.Text = this.AXREG.Text;
                    }
                    if (op1 == "AX" && op2 == "BX")
                    {
                        this.BXREG.Text = this.AXREG.Text;
                    }
                    if (op1 == "AX" && op2 == "CX")
                    {
                        this.CXREG.Text = this.AXREG.Text;
                    }
                    if (op1 == "AX" && op2 == "DX")
                    {
                        this.DXREG.Text = this.AXREG.Text;
                    }
                    if (op1 == "BX" && op2 == "AX")
                    {
                        this.AXREG.Text = this.BXREG.Text;
                    }
                    if (op1 == "BX" && op2 == "BX")
                    {
                        this.BXREG.Text = this.BXREG.Text;
                    }
                    if (op1 == "BX" && op2 == "CX")
                    {
                        this.CXREG.Text = this.BXREG.Text;
                    }
                    if (op1 == "BX" && op2 == "DX")
                    {
                        this.DXREG.Text = this.BXREG.Text;
                    }
                    if (op1 == "CX" && op2 == "AX")
                    {
                        this.AXREG.Text = this.CXREG.Text;
                    }
                    if (op1 == "CX" && op2 == "BX")
                    {
                        this.BXREG.Text = this.CXREG.Text;
                    }
                    if (op1 == "CX" && op2 == "CX")
                    {
                        this.CXREG.Text = this.CXREG.Text;
                    }
                    if (op1 == "CX" && op2 == "DX")
                    {
                        this.DXREG.Text = this.CXREG.Text;
                    }
                    if (op1 == "DX" && op2 == "AX")
                    {
                        this.AXREG.Text = this.DXREG.Text;
                    }
                    if (op1 == "DX" && op2 == "BX")
                    {
                        this.BXREG.Text = this.DXREG.Text;
                    }
                    if (op1 == "DX" && op2 == "CX")
                    {
                        this.CXREG.Text = this.DXREG.Text;
                    }
                    if (op1 == "DX" && op2 == "DX")
                    {
                        this.DXREG.Text = this.DXREG.Text;
                    }
                    break;

                case "XCHG":
                    string temp = "";
                    op2 = this.Operand2.SelectedItem.ToString();

                    if (op1 == "AX" && op2 == "BX" || op1 == "BX" && op2 == "AX")
                    {
                        temp = this.BXREG.Text;
                        this.BXREG.Text = this.AXREG.Text;
                        this.AXREG.Text = temp;
                    }
                    if (op1 == "AX" && op2 == "CX" || op2 == "AX" && op1 == "CX")
                    {
                        temp = this.CXREG.Text;
                        this.CXREG.Text = this.AXREG.Text;
                        this.AXREG.Text = temp;
                    }
                    if (op1 == "AX" && op2 == "DX" || op2 == "AX" && op1 == "DX")
                    {
                        temp = this.DXREG.Text;
                        this.DXREG.Text = this.AXREG.Text;
                        this.AXREG.Text = temp;
                    }
                    if (op1 == "BX" && op2 == "CX" || op2 == "BX" && op1 == "CX")
                    {
                        temp = this.CXREG.Text;
                        this.CXREG.Text = this.BXREG.Text;
                        this.BXREG.Text = temp;
                    }
                    if (op1 == "BX" && op2 == "DX" || op2 == "BX" && op1 == "DX")
                    {
                        temp = this.DXREG.Text;
                        this.DXREG.Text = this.BXREG.Text;
                        this.BXREG.Text = temp;
                    }
                    if (op1 == "CX" && op2 == "DX" || op2 == "CX" && op1 == "DX")
                    {
                        temp = this.DXREG.Text;
                        this.DXREG.Text = this.CXREG.Text;
                        this.CXREG.Text = temp;
                    }



                    break;

                case "PUSH":
                    

                    if (op1 == "AX")
                    {

                        myStack.Push(this.AXREG.Text);
                        //stack[SP] = this.AXREG.Text;
                        //foreach(string s in stack)
                        //{
                        //    Debug.WriteLine(s);
                        //}
                        Debug.WriteLine(myStack.Count);
                        SP += 2;
                        this.SPREG.Text = SP.ToString();

                    }
                    if (op1 == "BX")
                    {

                        myStack.Push(this.BXREG.Text);
                        //stack[SP] = this.BXREG.Text;
                        SP += 2;
                        this.SPREG.Text = SP.ToString();


                    }
                    if (op1 == "CX")
                    {

                        myStack.Push(this.CXREG.Text);
                        //stack[SP] = this.CXREG.Text;
                        SP += 2;
                        this.SPREG.Text = SP.ToString();
                    }
                    if (op1 == "DX")
                    {

                        myStack.Push(this.DXREG.Text);
                        //stack[SP] = this.DXREG.Text;
                        SP += 2;
                        this.SPREG.Text = SP.ToString();
                    }
                    
                    break;

                case "POP":

                    if (op1 == "AX")
                    {
                        
                        SP -= 2;
                        this.AXREG.Text = myStack.Pop().ToString();

                    }
                    if (op1 == "BX")
                    {
                        
                        SP -= 2;
                        this.BXREG.Text = myStack.Pop().ToString();


                    }
                    if (op1 == "CX")
                    {

                        
                        SP -= 2;
                        this.CXREG.Text = myStack.Pop().ToString();
                    }
                    if (op1 == "DX")
                    {
                        
                        SP -= 2;
                        this.DXREG.Text = myStack.Pop().ToString();
                    }
                    this.SPREG.Text = SP.ToString();

                    break;
            }

            
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int lenght = 65535;
            int num = random.Next(lenght);

            this.AXREG.Text = num.ToString("X");            
            num = random.Next(lenght);
            this.BXREG.Text = num.ToString("X");
            num = random.Next(lenght);
            this.CXREG.Text = num.ToString("X");
            num = random.Next(lenght);
            this.DXREG.Text = num.ToString("X");
        }

       
    }
}
