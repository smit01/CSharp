using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_interface {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Car objCar = new Car();
            objCar.AddSpeed(1);

            button1.Text = objCar.GetSpeed().ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            Game objGame = new Game();
            objGame.AddSpeed(1);

            button2.Text = objGame.GetSpeed().ToString();

        }

        private void button3_Click(object sender, EventArgs e) {
            // Car objCar = new Car();
            Game objGame = new Game();
            Drive(objGame);
        }

        void Drive(IDrive i) {
            i.AddSpeed(1);
            button3.Text = i.GetSpeed().ToString();
        }

    }

    interface IDrive {
        int GetSpeed();
        void AddSpeed(int value);
    }
    class Car : Object, IDrive {
        private int _speed;
        public void AddSpeed(int value) {
            this._speed += value;
        }
        public int GetSpeed() {
            return this._speed;
        }
    }
    class Game : Object, IDrive {
        private int _speed;
        public void AddSpeed(int value) {
            this._speed += (value * 10);
        }
        public int GetSpeed() {
            return this._speed;
        }
    }


}
