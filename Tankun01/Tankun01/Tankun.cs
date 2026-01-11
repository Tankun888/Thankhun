using System;

namespace Tankun01
{
    internal class Tankun
    {
        // วัตถุดิบ (กรัม)
        private int water;
        private int coffee;
        private int milk;
        private int chocolate;

        // constructor
        public Tankun(int water, int coffee, int milk, int chocolate)
        {
            this.water = water;
            this.coffee = coffee;
            this.milk = milk;
            this.chocolate = chocolate;
        }

        // ชงเครื่องดื่ม
        public void MakeDrink(int w, int c, int m, int ch, string name)
        {
            if (water >= w && coffee >= c && milk >= m && chocolate >= ch)
            {
                water -= w;
                coffee -= c;
                milk -= m;
                chocolate -= ch;

                Console.WriteLine($"กำลังชง {name} ... เสร็จแล้ว ☕");
            }
            else
            {
                Console.WriteLine("วัตถุดิบไม่เพียงพอ ไม่สามารถชงได้");
            }
        }

        // แสดงสต็อก
        public void ShowStock()
        {
            Console.WriteLine("---- Stock ----");
            Console.WriteLine("Water      : " + water + " g");
            Console.WriteLine("Coffee     : " + coffee + " g");
            Console.WriteLine("Milk       : " + milk + " g");
            Console.WriteLine("Chocolate  : " + chocolate + " g");
        }

        // เติมวัตถุดิบ
        public void Refill(int w, int c, int m, int ch)
        {
            water += w;
            coffee += c;
            milk += m;
            chocolate += ch;

            Console.WriteLine("Refill completed");
            ShowStock();
        }
    }
}
