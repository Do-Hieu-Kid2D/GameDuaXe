using System;
using System.Collections.Generic;
using System.Text;

namespace GameDuaXe
{   
    // Điểm đầu xuất phát tọa độ x = 130;
    // 
    internal class Car
    {
        string name;
        int doDaiXe;
        int viTRiX, viTRiY, viTriDauXe;
        int xepHang;

        public Car(string name, int doDaiXe, int viTriX, int viTriY) {
            this.name = name;
            this.viTRiX = viTriX;
            this.viTRiY = viTriY;
            this.doDaiXe = doDaiXe;
        }
        public string getName()
        {
            return this.name;
        }
        public int getViTriX()
        {
            return this.viTRiX;
        }
        public int getViTriY()
        {
            return this.viTRiY;
        }

    }
}
