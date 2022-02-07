using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMQReadWriteDemo
{
    public partial class Form1 : Form
    {
        const string queueName = @".\private$\TestQueue";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageQueue msMq = null;
            if (!MessageQueue.Exists(queueName))
            {
                msMq = MessageQueue.Create(queueName);
            }
            msMq = new MessageQueue(queueName);

            try
            {
                // msMq.Send("Sending data to MSMQ at " + DateTime.Now.ToString());
                Person p = new Person()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text
                };
                msMq.Send(p);
            }
            catch (MessageQueueException ee)
            {
                Console.Write(ee.ToString());
            }
            Console.WriteLine("Message sent ......");
            MessageBox.Show("Message sent ......");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageQueue msMq = msMq = new MessageQueue(queueName);
            try
            {
                // msMq.Formatter = new XmlMessageFormatter(new Type[] {typeof(string)});
                msMq.Formatter = new XmlMessageFormatter(new Type[] { typeof(Person) });
                var message = (Person)msMq.Receive().Body;
                MessageBox.Show("FirstName: " + message.FirstName + ", LastName: " + message.LastName);
                // Console.WriteLine(message.Body.ToString());
            }
            catch (MessageQueueException ee)
            {
                Console.Write(ee.ToString());
            }
        }
    }
}
