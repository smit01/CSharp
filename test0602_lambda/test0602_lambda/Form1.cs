﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0602_lambda {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int Add(int x, int unit) {
            return x + unit;
        }

        private void button1_Click(object sender, EventArgs e) {
            int answer = Add(1000, 1);
            (sender as Button).Text = answer.ToString();
        }

        // ------------------------------------------------------------
        // 觀察 Add() 與 Add10() 有何共同點?
        // 都有兩個整數參數，都傳回整數
        // int Add(int x, int unit) {
        int Add10(int x, int unit) {
            return x + unit * 10;
        }

        // 定義 Delegate，將"副程式"視為"物件"
        delegate int AddDelegate(int x, int unit);

        private void button2_Click(object sender, EventArgs e) {
            // p 可以是 Add(); 也可以是 Add10
            AddDelegate p = new AddDelegate(Add);
            // AddDelegate p = new AddDelegate(Add10);
            int answer = p.Invoke(1000, 1);
            (sender as Button).Text = answer.ToString();

            // 為什麼要這麼麻煩?
            // 1. Button 有 Click 事件，
            // 2. 每個程式設計師寫的 Click 事件處理程式都不一樣
            // 3. 雖然都不一樣, 但外觀長得卻都一樣: void ... (object,  EventArgs)
        }

        // ------------------------------------------------------------
        // 匿名函式
        // 不另行定義函式，直接將函式的定義"嵌"(inline)進來
        // $.get("url", function (e) {...} );

        void TellMeHowToAdd(int x, int y, AddDelegate p) {
            this.Text = p(x, y).ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            TellMeHowToAdd(1000, 2, delegate (int x, int y) {
                return x + y * 100;
            });

            AddDelegate p = delegate (int x, int y) {
                return x + y * 100;
            };
            int answer = p(1000, 1);
            (sender as Button).Text = answer.ToString();
        }

        // ------------------------------------------------------------
        // Lambda
        // 類似"匿名函式"，但不一定要定義參數的型態
        //
        // 格式一: 
        // (參數) => { 程式 }
        private void button4_Click(object sender, EventArgs e) {
            AddDelegate p = (a, b) => {
                int result = 0;
                result = a + b;
                return result;
            };

            int answer = p(1000, 1);
            (sender as Button).Text = answer.ToString();
        }

        // ------------------------------------------------------------
        // Lambda
        // 類似"匿名函式"，但不一定要定義參數的型態
        //
        // 格式一: 
        // (參數, 參數) => { 程式 }  goes 代入
        // 格式二: 
        // (參數) => 運算式
        private void button5_Click(object sender, EventArgs e) {
            AddDelegate p = (x, y) => x + y * 10;

            int answer = p(1000, 1);
            (sender as Button).Text = answer.ToString();
        }

        // ------------------------------------------------------------
        // 將 Lambda 函式當成參數:
        //
        void TestLambda(Object sender, AddDelegate p) {
            int answer = p(1000, 2);
            (sender as Button).Text = answer.ToString();
        }

        private void button6_Click(object sender, EventArgs e) {
            TestLambda(sender, (x, y) => { return x + y * 10; });
        }

        // ------------------------------------------------------------
        // 不一定要寫 delegate 定義，因為有＂通用＂型可用。
        //
        // Func<...> 最多可定義四個參數加一個傳回值，
        // 大於符號的前一個型別是傳回值
        void TellMeHowToAdd2(int x, int y, Func<int, int, int> p) {
            this.Text = p(x, y).ToString();
        }

        private void button7_Click(object sender, EventArgs e) {
            // p = function (x, y) { .... };
            //
            TellMeHowToAdd2(
                1000,
                20, 
                (x, y) => {
                    return x + y;
                }
            );

        }
    }
}
